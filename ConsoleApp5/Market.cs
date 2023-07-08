using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace MarketProject
{
    internal class Market
    {
        public int ID { get; set; }
        public double Price { get; set; }
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public DateTime ExpireDate { get; set; }
        public int QTY { get; set; }

       


       
        public static List<Market> soldProducts { get; set; } = new List<Market>();


        


       
        public  void QuantityQount()
        {
            if (QTY < 100)
            {
                Console.WriteLine($"Product >>>{Name}<<< quantity is low quantity >>>{QTY}<<< feel it ! ");
            }
        }

        public static void Sell(List<Market> mark, int id, int sellCount)
        {
           
            foreach (var item in mark)
            {
                if (item.ID == id)
                {
                    item.QTY -= sellCount;
                    soldProducts.Add(item);
                }
            }
          
        }

     

        public void Discount(List<Market> mark)
        {


            DateTime expire = ExpireDate;
            DateTime now = DateTime.Now;

            int res = (now - expire).Days;

        
            foreach (var item in mark)
            {
                if (res < 15)
                {
                    double newPrice = item.Price - item.Price * 0.20;
                   

                    item.Price = newPrice;
                    
                }
            }

           

        }

        public static void SoldProductsTotalPrice()
        {
            double total = 0;
            foreach (var item in soldProducts)
                total += item.Price;



            Console.WriteLine(total);
        }



        public void  Print()
        {



            List<Market> market = new List<Market>()
            {
                new Water()
                {
                    ID = 1,
                    Manufacturer = "CocaCola corp.",
                    Name ="BonAqua",
                    IsMineralWater = false,
                    ExpireDate = new DateTime(2023,5,30),
                    Size = 0.5,
                    Price = 0.80,
                    QTY = 150
                },
                new Water()
                {
                    ID = 2,
                    Manufacturer = "kartuli wylebi",
                    Name ="Zvare",
                    IsMineralWater = true,
                    ExpireDate = new DateTime(2023,5,28),
                    Size = 0.5,
                    Price = 1.20,
                    QTY = 300
                },
                new Beer()
                {
                    ID = 3,
                    Manufacturer = "Zedazeni",
                    Name= "Heineken",
                    BeerType ="Lager",
                    Size = 0.5,
                    ExpireDate = new DateTime(2023,5,28),
                    Price=4.90,
                    QTY = 120
                },
                new Beer()
                {
                    ID = 4,
                    Manufacturer = "Czech br",
                    Name= "Old Prague",
                    BeerType ="Lager",
                    Size = 0.5,
                    ExpireDate = new DateTime(2023,5,28),
                    Price=5.10,
                    QTY = 500
                }
            };





            foreach (var item in market)
            {
                Console.WriteLine(item);
                item.QuantityQount();
                item.Discount(market);

            }



            Market.Sell(market, 4, 450);
            Market.Sell(market, 1, 50);
            Market.Sell(market, 3, 50);

            Console.WriteLine("------------");
            Console.WriteLine("------------");

            Console.WriteLine("Sold products ");
            foreach (var item in soldProducts)
            {

                Console.WriteLine(item);
               
             

            }

            Console.Write("Day sold total price : $");
            Market.SoldProductsTotalPrice();
            
            

        }




        public override string ToString()
        {
            return $"Manufacturer {Manufacturer} Product name {Name} Price {Price} ExpireDate {ExpireDate.ToShortDateString()} QTY {QTY}";
        }




    }
}
