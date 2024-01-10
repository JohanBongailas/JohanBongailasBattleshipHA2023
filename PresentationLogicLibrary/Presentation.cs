using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BusinessLogicLibrary;
namespace PresentationLogicLibrary
{
    public class Presentation
    {
        // variable decleration
        private Business _business;

        public Presentation()
        {
            /* Instantiate _business attribute everything the presentation
               constructor is created*/
            _business = new Business();        
        }
        
        // Function to present menu to the user
        public void PresentMenu()
        {
            Console.WriteLine("1. Add Player Details");
            Console.WriteLine("2. Configure Ships");
            Console.WriteLine("3. Launch Attack");
            Console.WriteLine("4. Quit");
        }

        public void HandleMenuOption()
        {
            try
            {
                // Prompt the user to select a choice
                Console.Write("Kindly select a choice: ");

                // Store the choice in menuChoice variable and convert it to byte
                byte menuChoice = Convert.ToByte(Console.ReadLine());

                // Switch statement to handle all valid choices except when it is out of bounds
                switch (menuChoice)
                {
                    case 1:
                        // But I can only access the player class from the data layer
                        // so how can I pass it from the presentation
                        _business.AddPlayerDetails();
                        break;
                    case 2:
                        _business.ConfigureShips();
                        break;
                    case 3:
                        // Help I am not quite sure
                        // Call business logic to handle attacks
                        break;
                    case 4:
                        _business.QuitApplication();
                        break;
                    default:
                        throw new Exception("Number is higher than possible options");
                }
            }
            catch (FormatException fe)
            {
                // Catch the error when input is not in byte format
                Console.WriteLine($"Exception occured: {fe.Message}");
            } catch (Exception ex)
            {
                // Throw a general except
                Console.WriteLine($"Exception occured: {ex.Message}");
            }
            finally
            {
                // Buy the user some time by waiting for a key press
                Console.ReadKey();
            }
        }
    }
}
