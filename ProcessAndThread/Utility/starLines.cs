using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessAndThread.Utility
{
    internal class starLines
    {
        public static void LinesWithWords(string input)
        {
            Console.WriteLine($"*************************** {input} ***************************");
        }
        public static void Lines()
        {
            Console.WriteLine("***************************************************************");
        }
        public static void Yellow()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
        }
        public static void DefaultColor()
        {
            Console.ResetColor();
        }
    }
}
