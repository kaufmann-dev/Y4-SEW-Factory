using System;
using System.Threading;

namespace Factory
{
    public class MachineB
    {
        public static Semaphore smb = new Semaphore(0, 1);
        
        public static void Run()
        {
            while (true)
            {
                smb.WaitOne();
                Process();
                Crane.sc.Release();
            }
        }

        public static void Process()
        {
            Thread.Sleep(300);
        
            Console.WriteLine("MachineB: finished process");
        }
    }
}