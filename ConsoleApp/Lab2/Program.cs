using System;
using System.Collections.Generic;

namespace ConsoleApp.Lab2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Cart c1 = new Cart(1,"thang",0,new List<Product>(),"Hanoi","vietnam" ); 
            Product p1 = new Product(1,"sp1",3000,5,"anh1","anhso1",new List<string>());
            Fashion f1 = new Fashion(1, "fs1", 3000, 5, "image1", "fashion1", new List<string>(), "do", "M");
           // f1.checkStock();
          // Diamond d1 = new Diamond(1,"18K",50000,10,"image1","kimcuongmau",new List<string>(),5);
           // d1.CheckDiamond();
           // p1.getInfo();
           // p1.removeGallery();
           // c1.AddProduct(p1);
           // c1.AddProduct(f1);
           // c1.AddProduct(d1);
        //   p1.addGallery("anh1.jpg");
        //   p1.addGallery("anh2.jpg");
        //   p1.addGallery("anh3.jpg");
        //   p1[1] = "anh26.jpg"; // thay vao vi tri so 1
           // foreach (string x in p1.Gallery)
           // {
           //     Console.WriteLine(x);
           // }
        //   for (int i = 0; i < p1.Gallery.Count; i++)
        //   {
         //      Console.WriteLine(p1[i]);
          // }
          if (c1.AddProduct(p1)) ;
        }
    }
}