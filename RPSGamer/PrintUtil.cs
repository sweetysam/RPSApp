using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSGamer
{
    public class PrintUtil
    {
        /// <summary>
        /// Gets the user name.
        /// </summary>
        /// <returns></returns>
        public string GreetOpponent()
        {
            Console.WriteLine("\nWelcome to Rock, Paper, Scissors Game! It's you against the Computer Player.");
            Console.WriteLine("\nPlease enter your name.");
            string name = Console.ReadLine();
            return name;
        }

        /// <summary>
        /// Displays the welcome message.
        /// </summary>
        /// <param name="player"></param>
        public void StartGameMessage(Player player)
        {
            Console.WriteLine("\nHai {0}, let's Play!\n", player.Name);
        }

        /// <summary>
        /// Gets the user Hand Sign
        /// </summary>
        /// <returns></returns>
        public HandSign ChooseHandSign()
        {
            //Accept the user input
            Console.WriteLine("R-Rock\n" +
                              "P-Paper\n" +
                              "S-Scissors\n" +
                              "Make your selection:");
            string input = Console.ReadLine();
            var handSign = HandSign.MapStringToMove(input);
            if (handSign == null)
            {
                Console.WriteLine("Sorry Invalid. Please choose again");
                return ChooseHandSign();
            }
            return handSign;
        }
    }
}
