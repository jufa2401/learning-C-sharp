using System;
using System.Linq;
using System.Collections.Generic;
using C_sharp;
using System.Collections.Immutable;

namespace learningC_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> array = new List<int> {2, 3, 4, 5, 6, 7, 8, 9, 10};

            // reduce
            int sum = array.Aggregate((x, y) => x + y);
            Console.WriteLine(sum);
            // map
            List<int> squaredArray = array.Select(x => x * x).ToList();
            squaredArray.ForEach(Console.WriteLine);
            // filter
            List<int> wholeNumbers = array.Where(number => number % 2 == 0).ToList();
            wholeNumbers.ForEach(Console.WriteLine);


            Rectangle rectangle1 = new Rectangle {Length = 200, Height = 10};
            Console.WriteLine("Area of rect: {0}", rectangle1.Area());

            Rectangle rectangle2 = new Rectangle(5, 8);
            Console.WriteLine("Area of rect: {0}", rectangle2.Area());

            // GetResultFunctional1();

            MoreFunctionalStuff main2 = new MoreFunctionalStuff();
            main2.Main2();

            List<Entry> entries = new List<Entry>(
                new Entry[] {
                new Entry(6,25),
                new Entry(10,28),
                new Entry(12,32),
                new Entry(16,30),
                new Entry(18,26)
                }
            );

           ImmutableList<Entry> entries2 = ImmutableList.Create(
                new Entry(6,25),
                new Entry(10,28),
                new Entry(12,32),
                new Entry(16,30),
                new Entry(18,26)
           );



            entries.Add(new Entry(18,200));
            EntryTest test = new EntryTest();
            var s = test.ImmutableLogProcessor(entries2);
            s.ForEach(Console.WriteLine);
        }

        private static string GetResult()
        {
            MyStopWatch watch = new MyStopWatch();
            watch.Start();

            DoExpensiveOperation();
            DoExpensiveOperation2();

            string result = DoExpensiveOperation3();

            watch.Stop();
            watch.LogMs("Sleep lasted {0} ms.");
            return result;
        }



        private static string GetResultFunctional1()
        {
            MyStopWatchFunctional.LogMs("First Operation took {0} ms", (() =>
            {
                DoExpensiveOperation2();
                MyStopWatchFunctional.LogMs("First Operation took {0} ms", () => { DoExpensiveOperation(); });
            }));
            return MyStopWatchFunctional.LogMs("Last operation took {0} ms", (() => DoExpensiveOperation3()));
        }




private static string DoExpensiveOperation3()
        {
            throw new NotImplementedException();
        }

        private static void DoExpensiveOperation2()
        {
            throw new NotImplementedException();
        }

        private static void DoExpensiveOperation()
        {
            throw new NotImplementedException();
        }

    }
}