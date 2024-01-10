using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using DataAccessLibrary;
using System.Text.RegularExpressions;
using System.Runtime.Remoting.Lifetime;
using System.Threading;

namespace BusinessLogicLibrary
{
    public class Business
    {
		private Data _data;
        Player newPlayer;

		public Data PData
		{
			get {return _data;}
			set {_data = value;}
		}

        public Business()
        {
            // Initialize the PData property with a new instance of the Data class
            PData = new Data();
        }

        

        public void AddPlayerDetails()
        {
            List<string> usernames = new List<string>();
            string password;

            for (byte playerIndex = 0; playerIndex < 2; playerIndex++)
			{
                Console.Write($"Player {playerIndex + 1} kindly enter your username: ");
                usernames.Add(Console.ReadLine());

                if (PData.DoesUserExist(usernames[playerIndex]))
                {
                    Console.WriteLine($"Username {usernames[playerIndex]} already exists.");
                    Console.Write("Please enter password for confirmation: ");
                    
                    if (PData.DoesUsernamePasswordCombinationExist(usernames[playerIndex], MaskPassword()))
                    {
                        
                    } else
                    {
                        Console.WriteLine("Terminating application ...");
                        Thread.Sleep(1500);
                        Environment.Exit(0);
                    }
                    Console.WriteLine("\n");
                } else
                {
                    Console.WriteLine($"Username {usernames[playerIndex]} does not exist.");
                    Console.Write("Please enter password: ");
                    password = MaskPassword();

                    PData.AddPlayer(usernames[playerIndex], password);
                    newPlayer = PData.AddPlayer(usernames[playerIndex], password);
                }
            }

            PData.AddGame(usernames[0], usernames[1]);
        }

        public string MaskPassword()
        {
            ConsoleKeyInfo cki;
            StringBuilder passwordBuilder = new StringBuilder();

            do
            {
                cki = Console.ReadKey(true);

                if (cki.Key != ConsoleKey.Backspace && cki.Key != ConsoleKey.Enter)
                {
                    Console.Write("*");
                    passwordBuilder.Append(cki.KeyChar);
                }
                else if (cki.Key == ConsoleKey.Backspace && passwordBuilder.Length > 0)
                {
                    Console.Write("\b \b");
                    passwordBuilder.Remove(passwordBuilder.Length - 1, 1);
                }

            } while (cki.Key != ConsoleKey.Enter);

            Console.WriteLine(); // Move to the next line after entering password
            return passwordBuilder.ToString();
        }

        public void PrintGrid()
        {
            // Print column numbers
            Console.Write("   ");
            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"{i,2} ");
            }
            Console.WriteLine();

            // Print grid
            for (int i = 0; i < 10; i++)
            {
                char rowChar = (char)('A' + i);
                Console.Write($"{rowChar,2} "); // Print row letter

                for (int j = 1; j <= 10; j++)
                {
                    Console.Write(" 〇 ");
                }
                Console.WriteLine();
            }
        }

        public void ConfigureShips()
        {
            PrintGrid();

            for (int p = 0; p < 2; p++)
            {
                for (int j = 0; j < 5; j++)
                {
                    foreach (var ship in PData.FetchShipDetails())
                    {
                        Console.WriteLine($"Ship ID: {ship.ID}, Ship Title: {ship.Title}, Ship Size: {ship.Size}");
                    }
                    Console.Write($"Player {p + 1} please select a ship: ");
                    int ShipChoice = Convert.ToInt32(Console.ReadLine());
                    switch ( ShipChoice )
                    {

                    }
                }
            }
        }

        public void QuitApplication()
        {
            Console.WriteLine("Terminating application ...");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("Terminating application ..");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("Terminating application .");
            Thread.Sleep(1000);
            Console.Clear();
            Environment.Exit(0);
        } 

        public void Execute()
        {
        }

    }
}
