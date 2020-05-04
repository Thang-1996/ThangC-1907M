using System;
using System.Collections.Generic;

namespace ConsoleApp.Session8
{
    // khai bao delegate trả về 2 tham số là int a và int b
    public delegate int IntergerToInterger(int a, int b);
    // đại diện cho hàm có 2 tham số là 2 số nguyên vả trả về 2 số nguyên
    public class Program
    {
        public static void Main(string[] args)
        {
            // goi tạo đối tượng delegate // tham chiếu đến hàm có tham số là 2 số nguyên và trả về số nguyên vào trong ngoặc
            IntergerToInterger ii = new IntergerToInterger(Calculator.Add);
            // ii += Calculator.Subtract; // nạp thêm hàm subtract vào chuỗi thực hiện của delagate
            // // nạp vào hàm không có static
            // ii += new Calculator().division; //  cần tạo đối tượng mới để lấy được ô nhớ là hàm division
            // cách sử dụng hàm thông thường 
            // Program.Add(2, 4);
            // sử dụng qua delagate
            // ii(2, 5); // thực thi hàm được nạp vào delegate
            // Calculator.Add(2, 5);
            // Calculator.Subtract(2, 5);
            // Calculator.Add(7, 3);
            // Calculator.Subtract(7, 3);
            // cách chạy bình thường phải chạy từng dóng và truyền vào tham số khác nhau
            // ii(5, 2); //  sẽ chạy 1 lúc 2 hàm là add và subtract
            TaxMoney tm = TaxCalc.GetTax("VN");
            float tax = tm(100000000);
            Console.WriteLine("Thue phai nop:"+tax);
            // hàm ẩn danh bằng delagate
            TaxMoney tm2 = delegate(float salary) { return salary * 40 / 100; };
            float frTax = tm2(10000);
            Console.WriteLine("Thue tai phap"+frTax);
        }
    }
}