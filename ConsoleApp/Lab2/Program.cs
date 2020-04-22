using System;

namespace ConsoleApp.Lab2
{
    public class Program
    {
        public static void Main(string[] args)
        {
           Product p1 = new Product(1,"sp1",20,5,"anhnen","sanpham1");
           p1.getInfo();
           p1.addGallery();
           p1.removeGallery();
        }
    }
}