using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Threading.Tasks;

namespace Philosophers
{
    class Program
    {

        static void Main(string[] args)
        {
            List<Fork> forks = new List<Fork>();
            List<Philosopher> philosophers = new List<Philosopher>();

            for(int i = 0; i < 5; i++)
            {
                Fork fork = new Fork();
                Philosopher philosopher = new Philosopher(i);
                forks.Add(fork);
                philosophers.Add(philosopher);
            }

            Thread t1 = new Thread(philosophers[0].Start);
            Thread t2 = new Thread(philosophers[1].Start);
            Thread t3 = new Thread(philosophers[2].Start);
            Thread t4 = new Thread(philosophers[3].Start);
            Thread t5 = new Thread(philosophers[4].Start);

            t1.Start(forks);
            t2.Start(forks);
            t3.Start(forks);
            t4.Start(forks);
            t5.Start(forks);

        }

    }
}