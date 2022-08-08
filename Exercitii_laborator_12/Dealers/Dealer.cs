using System;
using System.Collections.Generic;
using Exercitii_laborator_12.Decks;
using Exercitii_laborator_12.Cards;


namespace Exercitii_laborator_12.Dealers
{
    class Dealer
    {
        public Deck Deck { get; private set; }


        public Dealer()
        {
            Deck = new Deck();
            Deck.Cards = ShuffleDeck();
        }


        private List<Card> ShuffleDeck()
        {
            List<Card> shuffledDeck = new List<Card>();

            shuffledDeck.AddRange(Deck.Cards);

            Random random = new Random();

            for (int i = 0; i < shuffledDeck.Count; i++)
            {
                int randomResult = random.Next(i, shuffledDeck.Count);
                (shuffledDeck[randomResult], shuffledDeck[i]) = (shuffledDeck[i], shuffledDeck[randomResult]);
            }

            return shuffledDeck;
        }
    }
}
