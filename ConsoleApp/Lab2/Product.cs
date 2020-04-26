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
        public List<String> gallery;
        public Product()
        {
        }

        public Product(int iD, string name, int price, int qty, string image, string desc, List<string> gallery)
        {
            this.iD = iD;
            this.name = name;
            this.price = price;
            this.qty = qty;
            this.image = image;
            this.desc = desc;
            this.gallery = gallery;
        }

        public int ID
        {
            get => iD;
            set => iD = value;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public int Price
        {
            get => price;
            set => price = value;
        }

        public int Qty
        {
            get => qty;
            set => qty = value;
        }

        public string Image
        {
            get => image;
            set => image = value;
        }

        public string Desc
        {
            get => desc;
            set => desc = value;
        }

        public List<string> Gallery
        {
            get => gallery;
            // set => gallery = value;
        }

        public string this[int index]
        {
            get { return gallery[index]; }
            set { gallery[index] = value; }

        }

        public void getInfo()
        {
            Console.WriteLine("ID:"+iD+"Name:"+name+" price:"+price+" QTY:"+qty+" Image:"+image+" Desc:"+desc);

        }

        public void checkStock()
        {
            if (qty > 0)
            {
                Console.WriteLine("SP Con hang");
                return;
            }
            Console.WriteLine("Het hang");
        }

        public void addGallery(string newimage)
        {
            if (gallery.Count >= 10)
            {
                Console.WriteLine("khong the them anh");
                return;
            }
            gallery.Add(newimage);
        }
        public void removeGallery()
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
        }
    }