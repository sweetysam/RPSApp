using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSGamer
{
    public class Game
    {
        private Player humanPlayer;
        private Player cpuPlayer;
        private static PrintUtil printUtil = new PrintUtil();

        public void startGame()
        {
            var name = printUtil.GreetOpponent();
            //create players
            this.humanPlayer = new Player(name);
            this.cpuPlayer = new Player("Computer Player");
            //start game message
            printUtil.StartGameMessage(humanPlayer);

            while (true)
            {
                int attempt = 0;
                int humanWin = 0;
                int cpWin = 0;
                while (attempt < 3)
                {
                    //Get users hand, checks for valid entry
                    var humanHandSign = printUtil.ChooseHandSign();
                    this.humanPlayer.HandSign = humanHandSign;

                    //Generate a random hand for computer
                    this.cpuPlayer.HandSign = HandSign.MapRandomToMove();
                    Console.WriteLine("Computer Player : " + HandSign.MapMoveToString(this.cpuPlayer.HandSign));

                    //compares the choices and declare the winner
                    string winner = HandSign.GetWinner(this.humanPlayer, this.cpuPlayer);

                    if (winner.Equals(this.cpuPlayer.Name))
                    {
                        cpWin++;
                    }
                    else if (winner.Equals(this.humanPlayer.Name))
                    {
                        humanWin++;
                    }
                    attempt++;
                }

                //Declare the overall winner
                if (cpWin == humanWin)
                {
                    Console.WriteLine("Sorry, It's a Draw!");
                }
                else if (cpWin > humanWin)
                {
                    Console.WriteLine("Congrats " + cpuPlayer.Name + " is the overall winner!");
                }
                else
                {
                    Console.WriteLine("Congrats " + humanPlayer.Name + " is the overall winner!");
                }

                //Check if user wishes to play again.
                Console.WriteLine("Play again? Yes|No");
                if (!Console.ReadLine().StartsWith("Y", StringComparison.OrdinalIgnoreCase)) break;
            }
        }
    }
}
