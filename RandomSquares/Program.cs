using System;
using System.Collections.Generic;
using System.Linq;

namespace RandomSquares
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Random numbers n squarin em n stuff");

            var random = new Random();
            var randomNumbers = new List<int>();

            for (int i = 0; i < 20; i++)
            {
                var currentNumber = random.Next(1, 51);
                randomNumbers.Add(currentNumber);
            }

            var squaredRandos = new List<int>();

            foreach (int rando in randomNumbers)
            {
                squaredRandos.Add(rando * rando);
            }

            foreach (int number in randomNumbers)
            {
                Console.Write(number.ToString() + "  ");
            }

            Console.WriteLine();

            foreach (int number in squaredRandos)
            {
                Console.Write(number.ToString() + "  ");
            }

            Console.WriteLine();

            var onlyEvens = squaredRandos.Where(rando => rando % 2 == 0);

            foreach (int number in onlyEvens)
            {
                Console.Write(number.ToString() + "  ");
            }
        }
    }
}
