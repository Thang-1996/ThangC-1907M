using System;
using System.Net.Sockets;

namespace ConsoleApp.Sesson3
{
    public abstract class Human
    {
        protected string name;
        protected int age;
        public abstract void AddFriend();
        public virtual void Running() // ham ghi de se phai co virtual vao lop cha
        {
            Console.WriteLine("Run....");
        }

        public void Eat()
        {
            Console.WriteLine("Eating...");
        }
    }
}