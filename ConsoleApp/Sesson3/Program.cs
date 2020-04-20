namespace ConsoleApp.Sesson3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Man m = new Man();
            m.Running();
            m.SayHello();
            Woman wm = new Woman();
            wm.Running(); //  tai su dung dc cac phuong thuc cua Human neu muon ke thua se de protected khong de private 
        }
    }
}