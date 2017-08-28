using System;
using System.Linq;
using System.Collections.Generic;

namespace HeadTailSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var records = SampleDataSource.EnumRecords();

            Console.WriteLine("\n==== Sample 1. using \"First()\" and \"Skip()\" LINQ methods. ====", ConsoleColor.Cyan);
            Sample1_Firast_and_Skip(records);

            Console.WriteLine("\n==== Sample 2. using raw enumerator directly. ====", ConsoleColor.Cyan);
            Sample2_Use_Raw_Enumerator(records);

            Console.WriteLine("\n==== Sample 3. using \"HeadTail\" extension. ====", ConsoleColor.Cyan);
            Sample3_Use_HeadTail_Extension(records);
        }

        /// <summary>
        /// Example by using "First()" and "Skip()" LINQ methods.
        /// </summary>
        public static void Sample1_Firast_and_Skip(IEnumerable<string> records)
        {
            var header = records.First();
            Console.WriteLine($"Header is \"{header}\"");

            Console.WriteLine("Rows are...");
            var rows = records.Skip(1);
            foreach (var row in rows)
            {
                Console.WriteLine(row);
            }
        }

        /// <summary>
        /// Example by using raw enumerator directly.
        /// </summary>
        public static void Sample2_Use_Raw_Enumerator(IEnumerable<string> records)
        {
            var enumerator = records.GetEnumerator();
            enumerator.MoveNext();
            var header = enumerator.Current;
            Console.WriteLine($"Header is \"{header}\"");

            Console.WriteLine("Rows are...");
            while (enumerator.MoveNext())
            {
                var row = enumerator.Current;
                Console.WriteLine(row);
            }
        }

        /// <summary>
        /// Example by using "HeadTail" extension.
        /// </summary>
        public static void Sample3_Use_HeadTail_Extension(IEnumerable<string> records)
        {
            var header = records.HeadTail(out var tail);
            Console.WriteLine($"Header is \"{header}\"");

            Console.WriteLine("Rows are...");
            foreach (var row in tail)
            {
                Console.WriteLine(row);
            }
        }
    }
}
