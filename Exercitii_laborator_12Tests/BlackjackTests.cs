using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Exercitii_laborator_12.Interfaces;
using Exercitii_laborator_12.Players;
using System.Collections.Generic;
using Exercitii_laborator_12.Cards;
using Moq;

namespace Exercitii_laborator_12.Tests
{
    [TestClass()]
    public class BlackjackTests
    {
        [TestMethod()]
        public void EvaluateTest()
        {
            IPlayer player1 = new Player("Mitica");
            player1.Cards.Add(new Card(7, Symbol.Hearts));
            player1.Cards.Add(new Card(10, Symbol.Clubs));
            player1.Cards.Add(new Card(7, Symbol.Diamonds));
            player1.CurrentHandValue = 24;

            IPlayer player2 = new Player("George");
            player2.Cards.Add(new Card(7, Symbol.Hearts));
            player2.Cards.Add(new Card(10, Symbol.Spades));
            player2.Cards.Add(new Card(1, Symbol.Diamonds));
            player2.CurrentHandValue = 18;


            IPlayer player3 = new Player("Valeriu");
            player3.Cards.Add(new Card(9, Symbol.Spades));
            player3.Cards.Add(new Card(5, Symbol.Clubs));
            player3.Cards.Add(new Card(8, Symbol.Diamonds));
            player3.CurrentHandValue = 22;


            IPlayer player4 = new Player("Stelian");
            player4.Cards.Add(new Card(1, Symbol.Spades));
            player4.Cards.Add(new Card(3, Symbol.Clubs));
            player4.Cards.Add(new Card(9, Symbol.Diamonds));
            player3.CurrentHandValue = 23;


            List<IPlayer> players = new List<IPlayer>
            {
                player1,
                player2,
                player3,
                player4
            };

            Blackjack newGame = new Blackjack();

            Guid expectedResult = player2.ID;
            Guid actualResult = newGame.Evaluate(players).ID;


            Assert.AreEqual(expectedResult, actualResult);
        }


        [TestMethod()]
        public void EvaluateTest1111()
        {
            IPlayer player1 = new Player("Mitica");
            player1.Cards.Add(new Card(4, Symbol.Hearts));
            player1.Cards.Add(new Card(10, Symbol.Clubs));
            player1.Cards.Add(new Card(8, Symbol.Diamonds));
            player1.CurrentHandValue = 22;

            IPlayer player2 = new Player("George");
            player2.Cards.Add(new Card(7, Symbol.Hearts));
            player2.Cards.Add(new Card(10, Symbol.Spades));
            player2.Cards.Add(new Card(1, Symbol.Diamonds));
            player2.CurrentHandValue = 18;


            IPlayer player3 = new Player("Valeriu");
            player3.Cards.Add(new Card(4, Symbol.Spades));
            player3.Cards.Add(new Card(5, Symbol.Clubs));
            player3.Cards.Add(new Card(8, Symbol.Diamonds));
            player3.CurrentHandValue = 17;


            IPlayer player4 = new Player("Stelian");
            player4.Cards.Add(new Card(2, Symbol.Spades));
            player4.Cards.Add(new Card(3, Symbol.Clubs));
            player4.Cards.Add(new Card(9, Symbol.Diamonds));
            player4.Cards.Add(new Card(7, Symbol.Hearts));
            player3.CurrentHandValue = 21;



            List<IPlayer> players = new List<IPlayer>
            {
                player1,
                player2,
                player3,
                player4
            };

            Blackjack newGame = new Blackjack();

            int expectedResult = 21;
            int actualResult = newGame.Evaluate(players).CurrentHandValue;


            Assert.AreEqual(expectedResult, actualResult);
        }


        [TestMethod()]
        public void IPlayerTest()
        {
            IPlayer player = GetMock("Mitica");

            string expectedResult = "Stelian";

            Assert.AreEqual(expectedResult, player.Name);
        }


        private IPlayer GetMock(string name)
        {
            Mock<IPlayer> playerMock = new Mock<IPlayer>();

            playerMock.Setup(p => p.Name).Returns(name);

            return playerMock.Object;
        }


        [TestMethod()]
        public void IPlayerTest222()
        {
            IPlayer player = GetMock222(19);

            int expectedResult = 19;

            Assert.AreEqual(expectedResult, player.CurrentHandValue);
        }


        private IPlayer GetMock222(int value)
        {
            Mock<IPlayer> playerMock = new Mock<IPlayer>();

            playerMock.Setup(p => p.CurrentHandValue).Returns(value);

            return playerMock.Object;
        }
    }
}