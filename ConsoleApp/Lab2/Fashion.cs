using System;
using System.Collections.Generic;

namespace ConsoleApp.Lab2
{
    public class Fashion: Product
    {
        private string color;
        private string size;

        public Fashion(int iD, string name, int price, int qty, string image, string desc, List<string> gallery, string color, string size) : base(iD, name, price, qty, image, desc, gallery)
        {
            this.color = color;
            this.size = size;
        }
        // getter setter
        public string Color
        {
            get => color; // ham tra ve gia tri la ham read
            set => color = value; // ham set gia tri ham write
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
                    return;
                }

                Console.WriteLine("Het hang");
            }
            else
            {
                Console.WriteLine("khong tim thay san pham");
            }
        }
    }
}