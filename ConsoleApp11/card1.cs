using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp11
{
    public class card1
    {
        private string face;
        private string suit;

        public card1(string cardFace, string cardSuit)
        {
            face = cardFace;
            suit = cardSuit;
        }
        public override string ToString()
        {
            return face + " of " + suit;
        }
    }
}

