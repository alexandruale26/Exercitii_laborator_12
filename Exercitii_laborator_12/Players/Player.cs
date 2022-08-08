using System;
using System.Collections.Generic;
using System.Text;
using Exercitii_laborator_12.Cards;
using Exercitii_laborator_12.Interfaces;

namespace Exercitii_laborator_12.Players
{
    public class Player : IPlayer
    {
        public string Name { get; private set; }
        public int CurrentHandValue { get; set; }
        public Guid ID { get; private set; }
        public List<Card> Cards {get; set; }


        public Player(string name)
        {
            this.Name = name;
            this.CurrentHandValue = 0;
            this.ID = Guid.NewGuid();
            this.Cards = new List<Card>();
        }


        public StringBuilder Description()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Player:  {this.Name}");
            sb.AppendLine($"ID:  {this.ID}");
            sb.AppendLine($"CurrentHandValue:  {this.CurrentHandValue}");
            sb.AppendLine("Cards:");

            foreach(Card card in this.Cards)
            {
                sb.AppendLine($"\t{card}");
            }
            return sb;
        }
    }
}
