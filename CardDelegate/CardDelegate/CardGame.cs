using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardDelegate
{
    class CardGame
    {
        List<Card> cards = new List<Card>();

        public void AddCard(ColorType color, CardType cardType)
        {
            cards.Add(new Card(color, cardType));
        }

        public List<Card> filterCardGame(FilterCardDelegate filter)
        {
            List<Card> result = new List<Card>();
            foreach (Card card in cards)
            {
                if (filter(card))
                    result.Add(card);
            }

            return result;

        }
    }
}
