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
        public static void Yellow(object input)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(input);
            Console.ResetColor();
        }
        
        public static void CautionColor(object input)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(input);
            Console.ResetColor();

        }
        public static void WarmReminderColor(object input)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(input);
            Console.ResetColor();

        }
    }
}
