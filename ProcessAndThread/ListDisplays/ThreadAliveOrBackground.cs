using ProcessAndThread.Utility;
using System.Collections;
using System.Diagnostics;

namespace ProcessAndThread.ListDisplays
{
    internal class ThreadAliveOrBackground
    {
        public static void ThreadStatus()
        {

            Process procces = Process.GetCurrentProcess();
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
            Process process = Process.GetCurrentProcess();
            ProcessThreadCollection threadCollection = process.Threads;

        restart:
            Console.Clear();
            foreach (ProcessThread i in threadCollection)
            {
                starLines.Yellow($"Thread ID: {i.Id}");

            }
            starLines.LinesWithWords("Check Thread Status");

            int input = 0;
            int quit = 0;
            while (input == 0 || quit == 3)
            {
                Console.Write("Kindly type in here the ID of the thread (numbers only): ");

                if (int.TryParse(Console.ReadLine(), out input))
                {
                    quit=3;
                }


                quit++;
                if (quit == 2)
                {
                    starLines.WarmReminderColor("This is your last opportunity to insert only numbers");
                }
                else if (quit == 3)
                {
                    starLines.CautionColor("Sorry you can't continue this operations, kindly try again when you are ready");
                    Environment.Exit(0);
                }
            }
            bool found = false;
            foreach(ProcessThread thread in threadCollection)
            {
                Thread threaded = Thread.CurrentThread;
                if(input == thread.Id)
                {
                    starLines.Lines();
                    starLines.Yellow($"\nThe Thread {thread.Id} is currntly: \nIsAlive\n{thread}\nIsBackground\n{threaded.IsBackground}");
                    starLines.Lines();
                    found = true;
                }
            }
            if(found == false)
            {
                starLines.CautionColor("OOPS!!! The THREAD was not found check back and try again. This time be very observant to the IDs of threads\n\nPress any button to try again");
                Console.ReadKey();
                goto restart;
            }
            
            
                
            
        }

    }
}
