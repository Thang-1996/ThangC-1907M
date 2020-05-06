using System;

namespace ConsoleApp.Session7
{
    // khai báo trước 1 delegate
    public delegate void ButtonHander(string msg);
    public class EventDemo
    {
        // khỏi tạo sự kiện
        public event ButtonHander OnClick;

        public void ClickButton()
        {
            Console.WriteLine("Button Click");
            // lấy thời điểm sử dụng
            DateTime now = DateTime.Now;
            if (OnClick == null)
            {
                OnClick += ShowAlert; //  Cộng vào theo delegate
            }

            OnClick("User clicked at : " + now);
        }

        public static void ShowAlert(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}