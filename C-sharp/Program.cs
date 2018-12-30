using System;
using System.Linq;
using System.Collections.Generic;
namespace learningC_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> array = new List<int> { 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // reduce
            int sum = array.Aggregate((x, y) => x + y);
            Console.WriteLine(sum);
            // map
            List<int> squaredArray = array.Select(x => x * x).ToList();
            squaredArray.ForEach(Console.WriteLine);
            // filter
            List<int> wholeNumbers = array.Where(number => number % 2 == 0).ToList();
            wholeNumbers.ForEach(Console.WriteLine);

        }
    }
}