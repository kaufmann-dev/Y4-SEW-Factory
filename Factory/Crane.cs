using System;
using System.Threading;

namespace Factory
{
    public class Crane
    {
        public static Semaphore sc = new Semaphore(0, 1);
        
        public static void Run()
        {
            while (true)
            {
                Move("Storage", "MachineA");
                MachineA.sma.Release();
                sc.WaitOne();
                Move("MachineA", "MachineB");
                MachineB.smb.Release();
                sc.WaitOne();
                Move("MachineB", "Storage");
            }
        }

        public static void Move(string from, string to)
        {
            Thread.Sleep(500);
            Console.WriteLine($"Crane: Moving workpiece from {from} to {to}");
        }
    }
}