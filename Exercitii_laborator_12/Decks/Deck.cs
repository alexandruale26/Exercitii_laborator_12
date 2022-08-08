using System;
using System.Collections.Generic;
using Exercitii_laborator_12.Cards;


namespace Exercitii_laborator_12.Decks
{
    class Deck
    {
        public List<Card> Cards { get; set; }


        public Deck()
        {
            this.Cards = GenerateDeck();
        }


        private List<Card> GenerateDeck()
        {
            List<Card> newDeck = new List<Card>();

            for (int i = 0; i < Enum.GetNames(typeof(Symbol)).Length; i++)
            {
                for (int j = 0; j < 13; j++)
                {
                    newDeck.Add(new Card(j + 1, (Symbol)i));
                }
            }
            return newDeck;
        }
    }
}
