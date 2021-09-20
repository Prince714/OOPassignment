using System;

namespace ConsoleApp11
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Deck1 deck1 = new Deck1();
            deck1.Shuffle();

            Console.WriteLine(value: "Enter Number of  Times you want to Shuffle cards?");
            int numbers = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= numbers; i++)
            {
                Console.WriteLine(deck1.DealCard());
            }
        }
    }
}
