using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ST10085640_ICE_TASK4
{
    class CartClass
    {
        public static double CalcTOT(List<double> prices, List<double> bigbox)
        {
            double total = prices.Sum();
            double VAT = total * 14 / 100;
            double grnTOT = total + VAT;
            double delPriceTot = bigbox.Sum();

            Console.WriteLine("----------------------------\n"
                            + "Total: R " + total + "\n"
                            + "+ VAT: R " + VAT + "\n"
                            + "----------------------------\n"
                            + "Grand Total: R " + grnTOT + "\n"
                            + "----------------------------\n"
                            + "Total delivery price for BigBox items: R " + delPriceTot + "\n"
                            + "----------------------------\n");

            return total;
        }
        
        public static void categoryAmount(List<double> grocery, List<double> bigbox)
        {
            Console.WriteLine("Total groceries: " + grocery.Count + "\n"
                            + "Total BigBox items: " + bigbox.Count);

        }
    }
}
