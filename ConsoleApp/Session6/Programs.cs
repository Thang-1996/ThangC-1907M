using System;

namespace ConsoleApp.Session6
{
    public class Programs
    {
        
    }
}

namespace ConsoleApp.Session6.Demo
{
    public class Program
    {
        public void showInfo()
        {
            try
            {
                int x = 10;
                int y = 0;
                Console.WriteLine(x/y);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}