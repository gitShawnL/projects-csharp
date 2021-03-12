using System;

namespace PickSomeCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number of cards to pick: ");
             string line = Console.ReadLine();
            
            if (int.TryParse(line, out int numberOfCards))
            {
                /*This foreach loop executes Console.WriteLine(card) for each
                 element in the array returned by PickSomeCards. */
                foreach (string card in CardPicker.PickSomeCards(numberOfCards))
                {
                    Console.WriteLine(card);
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid number.");
            }
        }
    }
}
