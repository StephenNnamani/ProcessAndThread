using System.Diagnostics;

namespace ProcessAndThread.ListDisplays
{
    internal class ThreadAliveOrBackground
    {
        public static void ThreadStatus()
        {

            Process procces = System.Diagnostics.Process.GetCurrentProcess();
            ProcessThreadCollection threadCollection = procces.Threads;

            string threads = string.Empty;

            foreach (ProcessThread proccessThread in threadCollection)
            {
                threads += string.Format("Thread Id: {0} \t\tThreadState: {1}\r\n",
                    proccessThread.Id, proccessThread.ThreadState);
            }

            Console.WriteLine(threads);
        }

        public static void CheckThread()
        {

        }

    }
}
