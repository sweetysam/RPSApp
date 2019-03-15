using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RPSGamer;

namespace RPSTests
{
    [TestClass]
    public class HandSignTest
    {
        [TestMethod]
        public void MapStringToMove_Paper_Choice()
        {
            //Assign
            var expectedResult = new HandSign(HandSign.Move.Paper);
            //Act
            var result = HandSign.MapStringToMove("p");
            //Assert
            Assert.AreEqual(expectedResult.ToString(), result.ToString());

        }

        [TestMethod]
        public void MapStringToMove_Rock_Choice()
        {
            //Assign
            var expectedResult = new HandSign(HandSign.Move.Rock);
            //Act             
            var result = HandSign.MapStringToMove("r");
            //Assert
            Assert.AreEqual(expectedResult.ToString(), result.ToString());
        }

        [TestMethod]
        public void MapStringToMove_Scissor_Choice()
        {
            //Assign
            var expectedResult = new HandSign(HandSign.Move.Scissors);
            //Act
            var result = HandSign.MapStringToMove("S");
            //Assert
            Assert.AreEqual(expectedResult.ToString(), result.ToString());

        }

        [TestMethod]
        public void MapStringToMove_Wrong_Choice()
        {
            //Act
            var result = HandSign.MapStringToMove("k");
            //Assert
            Assert.IsNull(result);
        }

        [TestMethod]
        public void GetWinnerTest_Player1_Pass()
        {
            //Assign
            Player player1 = new Player("Player1") { HandSign = new HandSign(HandSign.Move.Scissors) };
            Player player2 = new Player("Player2") { HandSign = new HandSign(HandSign.Move.Paper) };
            var expectedResult = "Player1";

            //Act
            var result = HandSign.GetWinner(player1, player2);
            //Assert
            Assert.AreSame(expectedResult, result);

        }

        [TestMethod]
        public void GetWinnerTest_Player2_Pass()
        {
            //Assign
            Player player1 = new Player("Player1") { HandSign = new HandSign(HandSign.Move.Rock) };
            Player player2 = new Player("Player2") { HandSign = new HandSign(HandSign.Move.Paper) };
            var expectedResult = "Player2";

            //Act
            var result = HandSign.GetWinner(player1, player2);
            //Assert
            Assert.AreSame(expectedResult, result);

        }
        [TestMethod]
        public void GetWinnerTest_Draw_Pass()
        {
            //Assign
            Player player1 = new Player("Player1") { HandSign = new HandSign(HandSign.Move.Rock) };
            Player player2 = new Player("Player2") { HandSign = new HandSign(HandSign.Move.Rock) };
            var expectedResult = "Draw";

            //Act
            var result = HandSign.GetWinner(player1, player2);
            //Assert
            Assert.AreSame(expectedResult, result);

        }

        [TestMethod]
        public void MapRandomToMove_Pass()
        {
            //Assert
            Assert.IsNotNull(HandSign.MapRandomToMove());
        }
    }
}
