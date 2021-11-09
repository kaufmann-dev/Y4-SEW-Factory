using System;
using System.Threading;

namespace Factory
{
    public class MachineA
    {
        public static Semaphore sma = new Semaphore(0, 1);
        
        public static void Run()
        {
            while (true)
            {
                sma.WaitOne();
                Process();
                Crane.sc.Release();
            }
        }

        public static void Process()
        {
            Thread.Sleep(400);
        
            Console.WriteLine("MachineA: finished process");
        }
    }
}