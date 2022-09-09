using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardDelegate
{
    enum ColorType {Spar, Klør, Ruder, Hjerter}
    enum CardType {Es, Et, To, Tre, Fire, Fem, Seks, Syv, Otte, Ni, Ti, Knægt, Dame, Konge}

    delegate bool FilterCardDelegate(Card card);

 

    class Card
    {
        public ColorType Color {get; set; }
        public CardType Number { get; set; }

        public Card(ColorType color, CardType number)
        {
            Color = color;
            Number = number;
        }

        public override string ToString()
        {
            return Color + " " + Number;
        }
    }
}
