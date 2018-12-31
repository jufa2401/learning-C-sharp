using System;
using System.Linq;
using System.Text;

namespace C_sharp
{
    class MoreFunctionalStuff
    {
        Func<int, int> addOne = n => n + 1;
        Func<int, int, int> addNums = (x, y) => x + y;
        Func<int, bool> isZero = n => n == 0;

        void Main2(string[] args)
        {
            Console.WriteLine(addOne(5)); // 6
            Console.WriteLine(isZero(addNums(-5,5))); // True

            int[] a = {0, 1, 0, 3, 4, 0};
            Console.WriteLine(a.Count(isZero)); // 3



            bool[] bools = {false, true, false, false, false, true};
            bools.Count(boolean => boolean == false); // 4
            bools.Count(boolean => boolean == true); // 2
        }
        // Expressions are better than statements - No mutables :)
        public static string GetSalutation (int hour) => hour < 12 ? "Good Morning" : "Good Afternoon";


        public string Greeting() => new StringBuilder()
            .Append("Hello ")
            .Append("World ")
            .ToString()
            .TrimEnd()
            .ToUpper(); //HELLO WORLD
    }

}
