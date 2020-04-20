using System;
using System.Net;

namespace ConsoleApp.Sesson3
{
    public class Woman: Human
    {
        public override void AddFriend()
        {
            
        }

        public override void Running() // ham duoc ghi de se phai ghi la override vao lop con
        {
            Console.WriteLine("Vua chay vua hat....");
        }
        // su dung tu khoa new de tao moi phuong thuc vao lop con thay cho ghi de 
        public new void Eat()
        {
            Console.WriteLine("Eating and Sing...");
        }
    }
}