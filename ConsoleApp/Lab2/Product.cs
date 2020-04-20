using System;
using System.Collections.Generic;
using System.Data;

namespace ConsoleApp.Lab2
{
    public class Product
    {
        public int iD;
        public string name;
        public int price;
        public int qty;
        public string image;
        public string desc;
        public List<String> gallery = new List<String>();
        public List<Product> productList = new List<Product>();

        public Product()
        {
        }

        public Product(int iD, string name, int price, int qty, string image, string desc)
        {
            this.iD = iD;
            this.name = name;
            this.price = price;
            this.qty = qty;
            this.image = image;
            this.desc = desc;
        }
        public void addProduct(Product product)
        {
            productList.Add(product);
        }
        public void getInfo()
        {
            Console.WriteLine("Product List:");
            foreach (Product p in productList)
            {    
                Console.WriteLine("ID:"+p.iD+"Name:"+p.name+" price:"+p.price+" QTY:"+p.qty+" Image:"+p.image+" Desc:"+p.desc);
                Console.WriteLine();
            }
            
        }

        public void checkStock()
        {
            string name;
            Console.WriteLine("Nhap ten sp muon check:");
            name = Convert.ToString(Console.ReadLine());
            foreach (Product p in productList)
            {
                if (name.Equals(p.name))
                {
                    if (p.qty > 0)
                    {
                        Console.WriteLine("SP Con hang");
                    }
                    else
                    {
                        Console.WriteLine("SP Het hang");
                    }
                }
            }
        }

        public void addGallery()
        {
            /*(if (gallery.Count < 2) //*/
            if(gallery.Count <10)
            {
                foreach (Product p in productList)
                {
                    gallery.Add(p.image);
                }
                Console.WriteLine("Them thanh cong vao gallery");
                Console.WriteLine("Gallery List:");
                for (int i = 0; i < gallery.Count; i++)
                {
                    Console.WriteLine("STT:"+(i+1)+"\tImage Name: "+gallery[i]);
                }
            }
            else
            {
                Console.WriteLine("Vuot qua so luong them can xoa bot anh");
            }
        }
        public void removeGallery()
        {
            Console.WriteLine("Gallery List:");
            for(int i=0;i<gallery.Count;i++)
            {
                Console.WriteLine("STT:"+(i+1)+"\tImage Name: "+gallery[i]);
            }
            int index;
            Console.WriteLine("Nhap vi tri anh muon xoa");
            index = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < gallery.Count; i++)
            {
                if (i == index)
                {
                    gallery.RemoveAt(index-1);
                    Console.WriteLine("Xoa thanh cong");
                }
            }
        }
        }
    }