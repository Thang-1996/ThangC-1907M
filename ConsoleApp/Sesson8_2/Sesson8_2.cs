using System;
using System.Threading;

namespace ConsoleApp.Sesson8_2
{
    public class Sesson8_2
    {
        public static void Main(string[] args)
        {
            Thread t1 = new Thread(Runcounter);
            t1.Start();
        }
        public static void Runcounter(Object o)
        {
            NumberCounter nc = (NumberCounter) o;
            for (int i = 0; i < 100; i++)
            {
                lock (nc)
                {
                    nc.Change();
                    nc.Show();
                }
                Thread.Sleep(100);
            }
        }
    }
}