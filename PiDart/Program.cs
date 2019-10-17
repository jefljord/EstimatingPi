using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace PiDart
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number of darts to throw?");

            
            int darts = Convert.ToInt32(Console.ReadLine());
            

            Console.WriteLine("Number of threads?");

            
            int fourThread = Convert.ToInt32(Console.ReadLine());

            List<Thread> multiThread = new List<Thread>();
            List<FindPiThread> findPi = new List<FindPiThread>();

            int tot = 0;
            for (int i = 0; i < fourThread; i++)
            {
                FindPiThread threadDart = new FindPiThread(darts);

                findPi.Add(threadDart);

                Thread newthread = new Thread(new ThreadStart(threadDart.throwDarts));

                multiThread.Add(newthread);

                newthread.Start();

                Thread.Sleep(16);
            }

            for (int i = 0; i < fourThread; i++)
            {
                multiThread[i].Join();
            }
            for (int i = 0; i < fourThread; i++)
            {
                Console.WriteLine(findPi[i].printHits);
                tot += findPi[i].printHits;
            }

            Console.WriteLine(4 * ((double) tot / ((double)darts * (double)fourThread)));
            Console.ReadLine();
        }
    }
}
