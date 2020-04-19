﻿using System;
using System.Collections.Generic;

// tương đương với import lớp system

namespace ConsoleApp // tương đương với package 
{
    class Program
    {
        static void Main(string[] args)
        {
            findFibonaci();
        }

        static void findFibonaci()
        {
            int n;
            int fb = 0;
            int fb1 = 1;
            int fb2 = 1;
            Console.WriteLine("Nhap vao n:");
            n = Convert.ToInt32(Console.ReadLine());
            while (fb1+fb2<n)
            {
                fb = fb1 + fb2;
                fb1 = fb2;
                fb2 = fb;
            }
            Console.WriteLine("So fibonaci < n = "+fb);
        }
    }
    
}