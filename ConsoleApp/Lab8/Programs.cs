using System;
using System.Threading;

namespace ConsoleApp.Lab8
{
    public class Programs
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("10:00");
            Thread t1 = new Thread(ThreadRun);
            t1.Start();
        }

        public static void ThreadRun()
        {
            for (int i = 9; i>=0;i--) {
                for(int j=59;j>0;j--){
                    if(j<=9) {
                        Console.WriteLine("0"+i+":"+"0"+j);
                    }else{
                        Console.WriteLine("0"+i+":"+j);
                    }
                    Thread.Sleep(100);
                }
            }
            Console.WriteLine("Bùm Toang");
        }
    }
}