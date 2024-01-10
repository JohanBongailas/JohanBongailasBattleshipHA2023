using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public class Data
    {
        // Variable decleration
        battleshipDataContext _battleshipDataContext;
        public Data()
        {
            // Initalize the battleship data context to a new battleshipDataContext()
            _battleshipDataContext = new battleshipDataContext();
        }

        // Function to return player details
        public IEnumerable<Player> FetchPlayerDetails()
        {
            return _battleshipDataContext.Players;
        }

        // Function to return ship details
        public IEnumerable<Ship> FetchShipDetails()
        {
            return _battleshipDataContext.Ships;
        }

        // Function to check if user exist in the database
        public bool DoesUserExist(string username)
        {
            return _battleshipDataContext.Players.Any(p => p.Username == username);
        }

        public bool DoesUsernamePasswordCombinationExist(string username, string password)
        {
            return _battleshipDataContext.Players.Any(p => p.Username == username && p.Password == password);
        }

        public Player AddPlayer(string username, string password)
        {
            Player newPlayer = new Player()
            {
                Username = username,
                Password = password
            };

            try
            {
                _battleshipDataContext.Players.InsertOnSubmit(newPlayer);
                _battleshipDataContext.SubmitChanges();
                Console.WriteLine($"Player {newPlayer.Username} added successfully to the database");
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Exception Occurred: {ex.Message}");
            }

            return newPlayer;
        }


        /* 
         * // Fetch or create another player for the opponent
                Player opponentPlayer = _battleshipDataContext.Players.FirstOrDefault(p => p.ID != creatorId) ?? new Player();
                int opponentId = opponentPlayer.ID;

                AddGame(creatorId, opponentId);
         */
        public Game AddGame(string creatorUsername, string opponentUsername)
        {
            try
            {
                // Retrieve Players based on usernames
                Player creator = _battleshipDataContext.Players.FirstOrDefault(p => p.Username == creatorUsername);
                Player opponent = _battleshipDataContext.Players.FirstOrDefault(p => p.Username == opponentUsername);

                if (creator != null && opponent != null)
                {
                    Game newGame = new Game()
                    {
                        Title = "Battleship",
                        CreatorFK = creator.ID,
                        OpponentFK = opponent.ID,
                        Complete = false
                    };

                    _battleshipDataContext.Games.InsertOnSubmit(newGame);
                    _battleshipDataContext.SubmitChanges();

                    Console.WriteLine($"Game added successfully to the database");
                    return newGame;
                }
                else
                {
                    Console.WriteLine("Invalid creator or opponent usernames. Unable to create the game.");
                    return null;
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Exception Occurred: {ex.Message}");
                return null;
            }
        }


    }
}
