using System;
using System.Collections.Generic;

namespace HeadTailSample
{
    public static class SampleDataSource
    {
        public static IEnumerable<string> EnumRecords()
        {
            Console.WriteLine("---- START ENUMERATION ----", ConsoleColor.Yellow);
            yield return "Header";

            yield return "Data 1";
            yield return "Data 2";
            yield return "Data 3";
        }
    }
}
