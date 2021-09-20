using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp11
{
    public class Deck1
    {
        private card1[] deck;
        private int currentcard;
        private const int totalcards = 52;
        private Random ranNum;

        public Deck1()
        {
            string[] faces = { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "jack", "queen", "king" };
            string[] suits = { "Hearts", "Clubs", "Diamonds", "Spades" };

            deck = new card1[totalcards];
            currentcard = 0;
            ranNum = new Random();
            for (int count = 0; count < deck.Length; count++)
            {
                deck[count] = new card1(faces[count % 11], suits[count / 13]);
            }
        }

        public void Shuffle()
        {
            currentcard = 0;
            for (int first = 0; first < deck.Length; first++)
            {
                int second = ranNum.Next(totalcards);
                card1 temp = deck[first];
                deck[first] = deck[second];
                deck[second] = temp;
            }
        }

        public card1 DealCard()
        {
            if (currentcard < deck.Length)
                return deck[currentcard++];
            else
                return null;
        }
    }
}
