using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)


        {

            Console.WriteLine("Please enter first amount, then press enter");
            double amount1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter second amount, then press enter");
            double amount2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter third amount, then press enter");
            double amount3 = double.Parse(Console.ReadLine());

            double average1 = (amount1 + amount2 + amount3) / 3;
            double total = amount3 + amount2 + amount1;

            double[] amountAll = { amount1, amount2, amount3 };
            double maxAmount = amountAll.Max();
            double minAmount = amountAll.Min();
             

            



            double totalR = Math.Round(total, 2);
            double averageR = Math.Round(average1, 2);
            double maxAmountR = Math.Round(maxAmount, 2);
            double minAmountR = Math.Round(minAmount, 2);



            Console.WriteLine(" - The average is {0}", averageR);
            Console.WriteLine(" - The total is {0}", totalR);

            Console.WriteLine(" - The highest amount is {0}", maxAmountR);
            Console.WriteLine(" - The lowest amount is {0}", minAmountR);
            Console.WriteLine(total.ToString("C", CultureInfo.CurrentCulture));
            Console.WriteLine(total.ToString("C", CultureInfo.CreateSpecificCulture("ja-JP")));
            Console.WriteLine(total.ToString("C", CultureInfo.CreateSpecificCulture("sv-SE")));
            Console.WriteLine(total.ToString("C", CultureInfo.CreateSpecificCulture("th-TH")));















        }
    }
}
