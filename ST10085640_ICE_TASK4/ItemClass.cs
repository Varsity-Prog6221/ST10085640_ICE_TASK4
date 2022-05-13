using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ST10085640_ICE_TASK4
{
    class ItemClass : CartClass
    {
        public static double CalcVAT(ArrayList items, List<double> prices)
        {
            double VAT = 0;

            Console.WriteLine("Do you wish to view the included VAT on each item? 'y' yes || 'n' no.");
            string inp = Console.ReadLine();
            Console.WriteLine();

            if (inp.Equals("y"))
            {
                Console.WriteLine("INCLUDED VAT\n"
                                + "-----------------");
                for (int i = 0; i < prices.Count; i++)
                {
                    VAT = prices[i] * 14 / 100;
                    Console.WriteLine(items[i] + ": R " + prices[i] + " (+" + VAT + ")");
                }
            }
            else
            {
                Environment.Exit(0);
            }
            return VAT;
        }
    }
}
