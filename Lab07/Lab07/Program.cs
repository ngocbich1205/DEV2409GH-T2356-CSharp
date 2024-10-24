using Store;
namespace Lab07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //tao moi nha phan phoi cung cap day du namespace
            Supply.Manufacturer dealer= new Supply.Manufacturer();
            //gan gia tri
            dealer.Name = "Coca cola";
            dealer.Email = "coacolap@gmail.com";
            dealer.Phone = "(111)791-8074";
            //in thong tin
            Console.WriteLine("Dealer information");
            Console.WriteLine("\t Name:" + dealer.Name);
            Console.WriteLine("\t Email:"+dealer.Email);
            Console.WriteLine("\t Phone:"+dealer.Phone);
            //tao moi san pham nam trong namespace Store
            StoreItem si = new StoreItem();
            //gan gia tri
            si.ItemNo = 613508;
            si.ItemName = "Fanta";
            si.Price = 80.00M;
            //in thong tin
            Console.WriteLine("Store Inventory");
            Console.Write("\t Item #:     ");
            Console.WriteLine(si.ItemNo);
            Console.Write("\t Item Name:   ");
            Console.WriteLine(si.ItemName);
            Console.Write("\t Unit Price: ");
            Console.WriteLine(si.Price);
            Console.Read();
        }
    }
}
