using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardDelegate
{
    class Program
    {

        static public bool FilterByKlør(Card card)
        {
            if (card.Color == ColorType.Klør)
                return true;
            else
                return false;
        }

        static public bool FilterByBilledKort(Card card)
        {
            if (card.Number == CardType.Dame || card.Number==CardType.Konge ||
                card.Number == CardType.Knægt)
                return true;
            else
                return false;
        }

        static void Main(string[] args)
        {
            var game = new CardGame();
            game.AddCard(ColorType.Klør, CardType.Es);
            game.AddCard(ColorType.Hjerter, CardType.Dame);
            game.AddCard(ColorType.Klør, CardType.Ni);

            var billedKort = game.filterCardGame(FilterByBilledKort);
            foreach (Card card in billedKort)
            {
                Console.WriteLine(card.ToString());

            }



            var klør = game.filterCardGame(FilterByKlør);
            klør.ForEach(delegate (Card card)
            {
                Console.WriteLine(card.ToString());

            });

            Console.ReadLine();





        }
    }
}
