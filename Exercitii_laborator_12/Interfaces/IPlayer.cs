using System;
using System.Text;
using System.Collections.Generic;
using Exercitii_laborator_12.Cards;


namespace Exercitii_laborator_12.Interfaces
{
    public interface IPlayer
    {
        string Name { get; }
        int CurrentHandValue { get; set; }
        Guid ID { get; }
        List<Card> Cards { get; }

        StringBuilder Description();
    }
}
