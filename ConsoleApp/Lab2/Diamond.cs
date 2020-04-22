using System;
using System.Collections.Generic;

namespace ConsoleApp.Lab2
{
    public class Diamond: Product
    {
        private int cara;

        public Diamond(int iD, string name, int price, int qty, string image, string desc, List<string> gallery, int cara) : base(iD, name, price, qty, image, desc, gallery)
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