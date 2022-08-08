using System;
using Exercitii_laborator_12.Interfaces;
using Exercitii_laborator_12.Players;
using System.Collections.Generic;


namespace Exercitii_laborator_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
               Scrieti un program care va modela finalul unui joc de carti blackjack.

               Un jucator de blackjack va fi caracterizat prin:
                  • un id de tip guid
                  • un nume
                  • o lista de carti de joc
                  • o functie care va returna descrierea acestuia (id, nume, lista cartilor) sub forma unui string.

               Cărțile vor avea valori de la 1 la 13 și vor putea fi de mai multe tipuri
                  • Inimă roșie
                  • Inimă neagră
                  • Romb
                  • Trifoi

               Clasa Joc va avea o metoda Evalueaza care va primi ca parametru o lista de jucatori si va returna 
               guid-ul jucatorilor castigator sau null in cazul in care nu exista niciun castigator.

               Evaluarea va fi urmatoarea:
                  • Daca suma cartilor unui jucator depaseste 21 atunci el este pierzator
                  • Jucatorul a carui valoare a sumei cartilor este cea mai apropiata de 21 va fi desemnat castigator.
                  • In cazul in care exista mai multi jucatori castigatori, va fi desemnat ca si castigator primul din lista.

               1. Creati clasele, creati cativa jucatori, evaluati-le cartile, afisati castigatorul in cazul in care exista.
               2. Testati unitar functia „evalueaza”
               a. Testati mai multe cazuri pentru functie
               b. Definiti o interfata pentru clasa „Jucator”, si folositi mock-uri pentru a facilita testele unitare.
            */

            Console.WriteLine("If a player's hand value is less than 10, a card with a value of 1 will value 11");
            Console.WriteLine("If a player's hand value is greater than 10, a card with a value of 1 will value 1");
            Console.WriteLine("Any card with a value above 10 will value 10");
            Console.WriteLine("A player will draw cards until his hand's value will be at least 17\n\n");


            List<IPlayer> players = new List<IPlayer>
            {
                new Player("Mitica"),
                new Player("George"),
                new Player("Valeriu"),
                new Player("Stelian"),
                new Player("Carmen")
            };

            Blackjack newGameOfBlackjack = new Blackjack();
            newGameOfBlackjack.Play(players);

            IPlayer winner = newGameOfBlackjack.Evaluate(players);
            //ShowAllPlayers(players);

            if (winner != null)
            {
                Console.WriteLine(winner.Description());
            }
            else
            {
                Console.WriteLine("<<No winner!>>");
            }


        }

        static void ShowAllPlayers(List<IPlayer> players)
        {
            foreach (IPlayer player in players)
            {
                Console.WriteLine(player.Description());
            }
        }
    }
}
