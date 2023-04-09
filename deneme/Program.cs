using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Runtime.Intrinsics.Arm;

namespace deneme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Phone NewPhone = new Phone(brand  ,model,  price,cost, count, ram, color, balance) ;
            //Phone NewPhone = new Phone("Apple", "IPhone", 1400, 600, 0, 4, "Red", 2);
            //NewPhone.GetInfo();
            //NewPhone.Pay(5);
            //NewPhone.Call(10);
            NoteBook NewBook = new NoteBook("Apple", "Tuf Gaming", 1700, 20, -7, "Intel", true, "Windows");
            NewBook.GetInfo();
            NewBook.Sale(5);

            //brandName, model, price, cost, count, ram, color ,  balance ,  processor , hasGraphicCard,  opsystem )


        }


        public static string CorrectSentence(string sentence)
        {
            string correctSentence = sentence;

            string[] word = correctSentence.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < word.Length; i++)
            {
                word[i] = word[i].ToLower();
                word[i] = char.ToUpper(word[i][0]) + word[i].Substring(1);
            }
            return string.Join(" ", word);
        }
    }

}