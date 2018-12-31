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

        public void Main2()
        {
            Console.WriteLine(addOne(5)); // 6
            Console.WriteLine(isZero(addNums(-5,5))); // True

            int[] a = {0, 1, 0, 3, 4, 0};
            Console.WriteLine(a.Count(isZero)); // 3



            bool[] bools = {false, true, false, false, false, true};
            System.Console.WriteLine(bools.Count(boolean => boolean == false)); // 4
            System.Console.WriteLine(bools.Count(boolean => boolean == true));  // 2

            System.Console.WriteLine(GetSalutation(13));            
            System.Console.WriteLine(Greeting());
        }
        // Expressions are better than statements - No mutables :)
        public string GetSalutation (int hour) => hour < 12 ? "Good Morning" : "Good Afternoon";


        public string Greeting() => new StringBuilder()
            .Append("Hello ")
            .Append("World ")
            .ToString()
            .TrimEnd()
            .ToUpper(); //HELLO WORLD
    }

}
