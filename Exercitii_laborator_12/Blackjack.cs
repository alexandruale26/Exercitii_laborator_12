using System.Collections.Generic;
using Exercitii_laborator_12.Decks;
using Exercitii_laborator_12.Interfaces;
using Exercitii_laborator_12.Dealers;

namespace Exercitii_laborator_12
{
    public class Blackjack
    {
        public IPlayer Evaluate(List<IPlayer> players)
        {
            IPlayer winner = null;

            if (players.Count < 2) return winner;

            foreach (IPlayer player in players)
            {
                if (player.CurrentHandValue < 22)
                {
                    winner = player;
                    break;
                }
            }
            if (winner == null) return winner;

            foreach (IPlayer player in players)
            {
                if (player.CurrentHandValue < 22 && player.CurrentHandValue > winner.CurrentHandValue)
                {
                    winner = player;
                }
            }
            return winner;
        }


        public void Play(List<IPlayer> players)
        {
            Deck deck = new Dealer().Deck;

            foreach(IPlayer player in players)
            {
                while (player.CurrentHandValue <= 17) // only a crazy person (or a very lucky one) will not stop at 17+. very small chances to hit below 21 or exactly 21 after 17+.
                {
                    player.Cards.Add(deck.Cards[0]);

                    if (deck.Cards[0].Value == 11 || deck.Cards[0].Value == 12 || deck.Cards[0].Value == 13) // every card after 10 has a value of 10
                    {
                        player.CurrentHandValue += 10;
                    }
                    else if (deck.Cards[0].Value == 1 && player.CurrentHandValue < 11)
                    {
                        player.CurrentHandValue += 11; // Ace is either 1 or 11
                    }
                    else if (deck.Cards[0].Value == 1 && player.CurrentHandValue > 10)
                    {
                        player.CurrentHandValue += 1;
                    }
                    else
                    {
                        player.CurrentHandValue += deck.Cards[0].Value;
                    }

                    deck.Cards.RemoveAt(0);
                }
            }
        }
    }
}
