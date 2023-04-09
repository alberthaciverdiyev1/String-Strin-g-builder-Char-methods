using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deneme
{
    internal class NoteBook : Product
    {
        public string OpSystem;
        public string Processor;
        public bool HasGraphicCard;
        public NoteBook(string brandName, string model, double price, double cost, int count, string processor,string opsystem) : base(brandName, model, price, cost, count)

        {
            OpSystem = opsystem;
            Processor = processor;
        }
        public NoteBook(string brandName, string model, double price, double cost, int count, string processor, bool hasGraphicCard, string opsystem) : base(brandName, model, price, cost, count)

        {
            OpSystem = opsystem;
            Processor = processor;
            HasGraphicCard = hasGraphicCard;
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
            Console.WriteLine($"Processor: {Processor}");
            Console.WriteLine($"OS: {OpSystem}");
            Console.WriteLine($"Has Graphic Card {HasGraphicCard}");
        }
    }
}
