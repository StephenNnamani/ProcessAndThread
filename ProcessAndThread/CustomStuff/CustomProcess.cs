using ProcessAndThread.StartOrKill;
using ProcessAndThread.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessAndThread.CustomStuff
{
    internal class CustomProcess
    {
        public static void StartProcessesMethod()
        {
            starLines.LinesWithWords("Creating custom process\n");
            Console.WriteLine(@"Kindly paste the local address of the new process you wish to start and it should look like this\nC:\\Program Files\\BraveSoftware\\Brave-Browser\\Application\brave.exe");
            string? localAddress = Console.ReadLine();

        }
    }

}
