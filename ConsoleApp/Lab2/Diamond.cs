using System;

namespace ConsoleApp.Lab2
{
    public class Diamond: Product
    {
        protected int cara;

        public Diamond(int iD, string name, int price, int qty, string image, string desc, int cara) : base(iD, name, price, qty, image, desc)
        {
            this.cara = cara;
       
        }
        public void CheckDiamond()
        {
            if (cara > 10)
            {
                Console.WriteLine("Kim cuong that");
            }
            else
            {
                Console.WriteLine("Kim cuong gia");
            }
        }

    }
}