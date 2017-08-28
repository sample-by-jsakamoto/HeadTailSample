using System;

namespace HeadTailSample
{
    public static class Console
    {
        public static void WriteLine(string value)
        {
            global::System.Console.WriteLine(value);
        }

        public static void WriteLine(string value, ConsoleColor color)
        {
            var orgColor = global::System.Console.ForegroundColor;
            global::System.Console.ForegroundColor = color;
            global::System.Console.WriteLine(value);
            global::System.Console.ForegroundColor = orgColor;
        }
    }
}
