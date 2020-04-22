using System;
using System.Collections.Generic;

namespace ConsoleApp.LAB_2_3
{
    public class Product
    {
        protected int id;
        protected string name;
        protected double price;
        protected uint qty; // kieu khong am
        protected string image;
        protected string desc;
        protected List<string> gallery;

        public Product()
        {
            this.gallery = new List<string>();
        }
        public Product(int id, string name, uint qty, string image,double price, string desc, List<string> gallery)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.qty = qty;
            this.image = image;
            this.desc = desc;
            this.gallery = gallery;
        }

        public void GetInfo()
        {
            Console.WriteLine("ID:"+this.id+"Name:"+this.name+"Price:"+this.price+"QTY:"+this.name+"Desc:"+desc+"Image:"+image);
        }

        public bool CheckStock()
        {
            if (qty > 0) return true;
            return false;
        }

        public bool AddGallery(string image)
        {
            if (gallery.Count >= 10)
            {
                Console.WriteLine("Anh da vuot qua so luong can xoa bot di truoc khi them");
                return false;
            }
            gallery.Add(image);
            return true;
        }

        public void DeleteGallery()
        {
            Console.WriteLine("Danh sach link anh");
            for(int i=0;i<gallery.Count;i++)
            {
                Console.WriteLine(i+"."+gallery[i]);
            }

            Console.WriteLine("Chon anh de xoa: ");
            int stt;
            stt = Convert.ToInt32(Console.ReadLine());
            gallery.RemoveAt(stt);
        }

        public bool DeleteImage(string image)
        {
            return gallery.Remove(image);
        }

        public bool DeleteAt(int number)
        {
            if (number < gallery.Count && number > 0)
            {
                gallery.RemoveAt(number);
                return true;
            }
            return false;
        }
    }
}