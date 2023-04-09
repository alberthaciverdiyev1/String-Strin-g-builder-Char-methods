using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace deneme
{
    internal class Phone : Product
    {
        public int RAM;
        public string Color;
        public double Balance;
        public Phone(string brandName, string model, double price, double cost, int count, int ram = 0, string color = "Black", int balance = 0) : base(brandName, model, price, cost, count)
        {
            RAM = ram;
            Color = color;
            Balance = balance;

        }

        public void Call(int seconds)
        {
            double cost = seconds * 0.1;
            if (Balance > cost)
            {
                Balance -= cost;
                Console.WriteLine($"Balansinizdan {cost} cixildi. Balansiniz {Balance} manat Teskil Edir");
            }
            if (Balance < cost)
            {
                Console.WriteLine("Balansinizda Kifayet Qeder Mebleg Yoxdur");
            }

        }
        public void Pay(double money)
        {
            double Money = money;
            Balance += Money;
            Console.WriteLine($"Balansiniz {Money} Manat Artirildi. Hal-Hazirda Balansiniz {Balance} manatdir");
        }
        public void GetInfo()
        {

            Console.WriteLine($"Id: {Id}");
            Console.WriteLine($"Brand: {BrandName}");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Price: {Price}");
            Console.WriteLine($"Cost: {Cost}");
            Console.WriteLine($"Income: {Income}");
            Console.WriteLine($"Count: {Count}");
            Console.WriteLine($"RAM: {RAM}");
            Console.WriteLine($"Balance: {Balance}");
            Console.WriteLine($"Color: {Color}");


        }
    }
}
