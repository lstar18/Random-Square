using System;
using System.Collections.Generic;

namespace Random_Square
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            var randomNumbers = new List<int>();

            for (int i = 0; i < 20; i++)
            {
                var randomNum = random.Next(1, 51);
                randomNumbers.Add(randomNum);
            }
            Console.WriteLine($"Random Number List: {string.Join(",", randomNumbers)}");

            var squaredNumbers = new List<int>();
            for (int i = 0; i < randomNumbers.Count; i++)
            {
                var squaredNumber = randomNumbers[i] * randomNumbers[i];
                squaredNumbers.Add(squaredNumber);
            }
            Console.WriteLine($"Squared Number List: {string.Join(",", squaredNumbers)}");

            var evenNumberSquared = new List<int>();

            foreach (var number in squaredNumbers)
            {
                if (number %2 == 0)
                {
                    evenNumberSquared.Add(number);
                }
            }
            Console.WriteLine($"Even Number Squared: {string.Join(",", evenNumberSquared)}");
        }

    }
}
