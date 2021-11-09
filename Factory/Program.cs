using System;
using System.Threading;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t1 = new Thread(() => Crane.Run());
            Thread t2 = new Thread(() => MachineA.Run());
            Thread t3 = new Thread(() => MachineB.Run());
            
            t1.Start();
            t2.Start();
            t3.Start();
        }
    }
}