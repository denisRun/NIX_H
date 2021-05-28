using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Philosophers
{
    class Philosopher
    {
        public int id;

        public Philosopher(int id)
        {
            this.id = id;
        }

        static Mutex mutex = new Mutex(false, "Forks");

        public void FindForks(List<Fork> forks)
        {
            lock (mutex)
            {
                int ind1 = id;
                int ind2;
                if (id != forks.Count-1)
                    ind2 = id + 1;
                else
                    ind2 = 0;

                if (forks[ind1].isFree)
                {
                    forks[ind1].isFree = false;
                    Console.WriteLine($"Philosopher {id+1} took fork in LEFT hand");
                    Thread.Sleep(100);
                    if (forks[ind2].isFree)
                    {
                        forks[ind2].isFree = false;
                        Console.WriteLine($"Philosopher {id+1} took fork in RIGHT hand");
                        Thread.Sleep(100);
                        Console.WriteLine($"Philosopher {id+1} is eating");
                        forks[ind1].isFree = true;
                        Console.WriteLine($"Philosopher {id+1} put LEFT fork");
                        Thread.Sleep(100);
                        forks[ind2].isFree = true;
                        Console.WriteLine($"Philosopher {id+1} put RIGHT fork");
                        Console.WriteLine($"Philosopher {id+1} is thinking");
                    }
                    else
                    {
                        forks[ind1].isFree = false;
                        Console.WriteLine($"Philosopher {id+1} put LEFT fork");
                    }
                }
            }
        }

        public void Start(object forks)
        {
            for(int i = 0; i < 5; i++) { 
                Console.WriteLine($"Philosopher {id+1} is looking for forks");
                FindForks((List<Fork>)forks);
                Random rnd = new Random();
                Thread.Sleep(rnd.Next(1, 2000));                
            }
        }
    }
}
