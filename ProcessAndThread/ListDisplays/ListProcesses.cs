using ProcessAndThread.Utility;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessAndThread.ListDisplays
{
    internal class ListProcesses
    {
        public static void ListOfProcesses()
        {
            starLines.LinesWithWords(" Stephen's Task Manager ");
            Process[] processCollection = Process.GetProcesses();
            Console.WriteLine("\nPROCESS NAME \t\t\tBASE PRIORITY \t\tPROCESS ID\tPrivate Memory Size");
            foreach (var p in processCollection)
            {
                starLines.Yellow($">>> {p.ProcessName} \t\t\t{p.BasePriority} \t\t\t{p.Id}\t\t{p.PrivateMemorySize}");
            }
            starLines.Lines();
        }
    }
}
