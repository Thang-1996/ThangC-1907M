using System;

namespace ConsoleApp.Sesson3
{ //  ke thua trong c# dung dau : 
    public class Man: Human,IHuman // them interface vao sau ke thua băng dau ,
    {
        public override void AddFriend()
        {
            
        }

        public void Alo()
        {
            
        }

        public void SayHello()
        {
            Console.WriteLine("Hello everybody!");
        }

        public void SayHello(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}