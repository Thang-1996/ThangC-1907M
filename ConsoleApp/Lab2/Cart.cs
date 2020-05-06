using System;
using System.Collections.Generic;
using ConsoleApp.Lab2;

namespace ConsoleApp.Lab2
{
    public delegate void CartAlert(string msg);
    public class Cart
    {
        private int id;
        private string customer;
        private double grandTotal;
        private List<Product> listProduct;
        private string city;
        private string country;
        private event CartAlert AddToCart;

        public Cart(int id, string customer, double grandTotal, List<Product> listProduct, string city, string country)
        {
            this.id = id;
            this.customer = customer;
            this.grandTotal = grandTotal;
            this.listProduct = listProduct;
            this.city = city;
            this.country = country;
            if (AddToCart == null)
            {
                AddToCart += AlertMessage;
            }
        }

        public bool AddProduct(Product product)
        {
            listProduct.Add(product);
            Console.WriteLine("them thanh cong");
            AlertMessage("Da them san pham"+product.name);
            return true;
        }

        public bool RemoveProduct(Product product)
        {
            return listProduct.Remove(product);
        }

        public double FinalTotal()
        {
            double grand = 0;
            foreach (Product p in listProduct)
            {
                grand += p.price;
            }

            grand += ShippingFee(grand);
            this.grandTotal = grand;
            return grandTotal;
        }

        public double ShippingFee(double grand)
        {
            if (country.Equals("VN") && (city.Equals("HN") || city.Equals("HCM")))
            {
                return grand * 0.01;
            }

            if (country.Equals("VN"))
            {
                return grand * 0.02;
            }

            return grand * 0.05;
        }
        public static void AlertMessage(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}