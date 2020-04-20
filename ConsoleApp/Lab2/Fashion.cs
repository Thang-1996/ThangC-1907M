using System;

namespace ConsoleApp.Lab2
{
    public class Fashion: Product
    {
        protected string color;
        protected string size;

        public Fashion(int iD, string name, int price, int qty, string image, string desc, string color, string size) : base(iD, name, price, qty, image, desc)
        {
            this.color = color;
            this.size = size;
        }
        
        public new void checkStock()
        {
            string colorCheck, sizeCheck;
            Console.WriteLine("Nhap ten mau muon kt:");
            colorCheck = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Nhap size muon kt:");
            sizeCheck = Convert.ToString(Console.ReadLine());
            if (colorCheck.Equals(color) && sizeCheck.Equals(size))
            {
                if (qty > 0)
                {
                    Console.WriteLine("Con hang");
                }
                else
                {
                    Console.WriteLine("Het hang");
                }
            }
            else
            {
                Console.WriteLine("khong tim thay san pham");
            }
        }
    }
}