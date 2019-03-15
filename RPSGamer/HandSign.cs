using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSGamer
{
    public class HandSign
    {
        private Move move;

        public enum Move
        {
            Rock,
            Paper,
            Scissors
        }

        public HandSign(Move move)
        {
            this.move = move;
        }

        /// <summary>
        /// Method returns the user choice to actual Game Move.
        /// </summary>
        /// <param name="userChoice">input details of user choice</param>
        /// <returns></returns>
        public static HandSign MapStringToMove(string userChoice)
        {
            switch (userChoice.ToUpper())
            {
                case "P":
                    return new HandSign(Move.Paper);
                case "S":
                    return new HandSign(Move.Scissors);
                case "R":
                    return new HandSign(Move.Rock);
            }
            return null;
        }

        /// <summary>
        /// Method returns the user move as a string.
        /// </summary>
        /// <param name="userChoice">input details of the move</param>
        /// <returns></returns>
        public static string MapMoveToString(HandSign actualMove)
        {
            switch (actualMove.move)
            {
                case HandSign.Move.Paper:
                    return "Paper";
                case HandSign.Move.Scissors:
                    return "Scissor";
                case HandSign.Move.Rock:
                    return "Rock";
            }
            return null;
        }

        /// <summary>
        /// Returns the computer player move.
        /// </summary>
        /// <returns></returns>
        public static HandSign MapRandomToMove()
        {
            Random random = new Random();
            int cpuChoice = random.Next(0, 2);

            switch (cpuChoice)
            {
                case 0:
                    return new HandSign(Move.Rock);
                case 1:
                    return new HandSign(Move.Paper);
                case 2:
                    return new HandSign(Move.Scissors);
            }
            return null;
        }

        /// <summary>
        /// Gets the winning move.
        /// </summary>
        /// <returns>The winning move.</returns>
        /// <param name="move">Handsign.</param>
        public static Move GetWinningMove(Move move)
        {
            switch (move)
            {
                case Move.Rock:
                    return Move.Paper;
                case Move.Paper:
                    return Move.Scissors;
                default:
                    return Move.Rock;
            }
        }


        /// <summary>
        /// Gets the winner.
        /// </summary>
        /// <returns>The winner.</returns>
        /// <param name="player1">Handsign player1.</param>
        /// <param name="player2">Handsign player2.</param>
        public static string GetWinner(Player player1, Player player2)
        {
            if (GetWinningMove(player1.HandSign.move).Equals(player2.HandSign.move))
            {
                //return player2.HandSign.move; //player 1 loses to player 2
                Console.WriteLine("\n" + player2.Name + " is the winner\n");
                return player2.Name;
            }
            else if (GetWinningMove(player2.HandSign.move).Equals(player1.HandSign.move))
            {
                //return player1.HandSign.move; //player 2 loses to player 1
                Console.WriteLine("\n" + player1.Name + " is the winner\n");
                return player1.Name;
            }
            else
            {
                Console.WriteLine("\nIt's a Draw!\n");
                return "Draw";
            }
        }
    }
}
