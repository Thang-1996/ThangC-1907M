namespace ConsoleApp.Lab2
{
    public class Program2
    {
        public static void Main(string[] args)
        {
            Fashion f1 = new Fashion(1,"ao1",3000,5,"image1","ao khoac","xanh","M");
            f1.checkStock();
            Diamond d1 = new Diamond(1,"18K",50000,10,"image1","kimcuongmau",5);
            d1.CheckDiamond();
        }
    }
}