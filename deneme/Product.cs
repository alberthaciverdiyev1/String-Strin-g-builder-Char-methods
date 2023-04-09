using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace deneme
{
    internal class Product
    {
        public string Id;
        public string BrandName;
        public string Model;
        public double Price;
        public double Cost;    
        public double Income;  
        public int Count = 0;
       



        public Product(string brandName, string model, double price, double cost, int count)
        {
            BrandName = brandName;
            Model = model;
            Price = price;
            Cost = cost;
            Count = count;

            if (count < 0) {
                Count = 0;
            }


            Id = brandName.Substring(0, 2) + model.Substring(0, 2);

        }
              public void Sale( int productCount)
        {
            if (Count-productCount > 0)
            {
                Income =  Price -productCount*Cost;
                Count-=productCount;
                Console.WriteLine($"Sizin Umumi Geliriniz {Income} manatdir ve Magazamizda Eyni Mehsuldan {Count} eded Qalib");
            }
            else
            {
                Console.WriteLine("Kifayet Qeder Mehsulumuz Yoxdur");
            }
        }




        


    }
}
