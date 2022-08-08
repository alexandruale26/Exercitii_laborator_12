using System;


namespace Exercitii_laborator_12.Cards
{
    public class Card
    {
        public int Value { get; private set; }
        public Symbol Symbol { get; private set; }

        
        public Card(int value, Symbol symbol)
        {
            this.Value = value;
            this.Symbol = symbol;
        }


        public override string ToString()
        {
            return $"{Value}  of  {Symbol}";
        }
    }
}


public enum Symbol
{
    Hearts, // inima rosie
    Spades, // inima neagra
    Diamonds, // romb
    Clubs // trifoi
}
