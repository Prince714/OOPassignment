using System;
using System.Collections.Generic;

namespace Assignment2
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter the number of cards to pick: ");
			string line = Console.ReadLine();
			if (int.TryParse(line, out int numCards))
			{
				foreach (var card in CardPicker.PickSomeCards(numCards))
				{
					Console.WriteLine(card);
				}
			}
			else
			{
				Console.WriteLine("Please enter a valid number.");
			}


			ParticleMovement particleMover = new ParticleMovement();
			while (true)
			{
				Console.Write("0 for base movement only\n1 if a magnetic field is present\n" +
							  "2 if a gravitational field is present\n3 for both fields\n");
				char key = Console.ReadKey().KeyChar;
				if (key != '0' && key != '1' && key != '2' && key != '3') return;

				Console.WriteLine($"\nParticle with a movement range of {particleMover.MovementRange} units" +
								  $" moved a total distance of {particleMover.DistanceMoved} units.\n");
			}
		}
		class ParticleMovement
		{
			static Random random = new Random(1);

			public const int BASE_MOVEMENT = 3;
			public const int GRAVITY_MOVEMENT = 2;

			private int movementRange;
			public int MovementRange
			{
				get { return movementRange; }
				set { movementRange = value; CalculateDistance(); }
			}

			private bool magneticField;
			public bool MagneticField
			{
				get { return magneticField; }
				set { magneticField = value; CalculateDistance(); }
			}

			private bool gravitationalField;
			public bool GravitationalField
			{
				get { return gravitationalField; }
				set { gravitationalField = value; CalculateDistance(); }
			}

			public double Distance
			{ get; private set; }

			public int DistanceMoved;

			private int movement_range;
			public ParticleMovement()
			{
				movementRange = movement_range;
				CalculateDistance();
				GetMovementRange();
			}

			public void CalculateDistance()
			{
					DistanceMoved = MovementRange + BASE_MOVEMENT + GRAVITY_MOVEMENT;
			}

			public void GetMovementRange()
			{
				movementRange = random.Next(1, 7) + random.Next(1, 7) + random.Next(1, 7);
			}

			
		}
		public static class SubsequenceFinder // The static here means this class CANNOT be instantiated 
		{
			/// <summary>
			/// Determines whether a list of integers is a subsequence of another list of integers
			/// </summary>
			/// <param name="seq">The main sequence of integers.</param>
			/// <param name="subseq">The potential subsequence.</param>
			/// <returns>
			/// True if subseq is a subsequence of seq and false otherwise.
			/// </returns>
			public static bool IsValidSubsequeuce(List<int> seq, List<int> subseq)
			{
				int seqIdx = 0;
				int subseqIdx = 0;
				while (seqIdx < seq.Count && subseqIdx < subseq.Count)
				{
					if (seq[seqIdx] == subseq[subseqIdx])
					{
						++subseqIdx;
					}
					++seqIdx;
				}
				return subseqIdx == subseq.Count;
			}
		}

		class CardPicker
		{
			static Random random = new Random(1);
			/// <summary>
			/// Picks a random (with replacement) number of cards.
			/// </summary>
			/// <param name="numCards">The number of cards to choose at random.</param>
			/// <returns>An array of strings where each string represents a card.</returns>
			public static string[] PickSomeCards(int numCards)
			{
				string[] pickedCards = new string[numCards];
				for (int i = 0; i < numCards; ++i)
				{
					pickedCards[i] = RandomValue() + " of " + RandomSuit();
				}
				return pickedCards;
			}


			enum cards
			{
				Ace,
				Jack,
				Queen,
				King
			}

			enum Card_1
			{
				Clubs,
				Diamonds,
				Hearts,
				Spades
			}
			private static string RandomValue()
			{
				int value = random.Next(1, 14);
				switch (value)
				{
					case 1:
						cards ace = cards.Ace;
						return ace.ToString();
					case 11:
						cards Jack = cards.Jack;
						return Jack.ToString();

					case 12:
						cards Queen = cards.Queen;
						return Queen.ToString();

					case 13:
						cards King = cards.King;
						return King.ToString();

					default:
						// The integers 2 -> 10 can just be converted to a string
						return value.ToString();
				}
			}
			private static string RandomSuit()
			{
				int value = random.Next(1, 5);
				switch (value)
				{
					case 1:
						Card_1 Clubs = Card_1.Clubs;
						return Clubs.ToString();

					case 2:
						Card_1 Diamonds = Card_1.Diamonds;
						return Diamonds.ToString();

					case 3:
						Card_1 Hearts = Card_1.Hearts;
						return Hearts.ToString();

					default:
						Card_1 Spades = Card_1.Spades;
						return Spades.ToString();

				}
			}
		}
	}
}
