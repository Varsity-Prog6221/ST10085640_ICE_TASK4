using System;
using System.Collections;
using System.Collections.Generic;

namespace ST10085640_ICE_TASK4
{
    class Program
    {
        public static ArrayList items = new ArrayList();
        public static List<double> prices = new List<double>();
        public static List<double> grocery = new List<double>();
        public static List<double> bigbox = new List<double>();

        static void Main(string[] args)
        {
            UserInput();
            CartClass.CalcTOT(prices, bigbox);
            CartClass.categoryAmount(grocery, bigbox);
            ItemClass.CalcVAT(items, prices);
        }
        public static void UserInput()
        {
            Console.WriteLine("WELCOME TO TAKE 5. \nTAKE 5 now allows grocery or big box items.\n"
                            + "Enter 'y' to continue (Type 'exit' once you have added your items.)");
            var input = Console.ReadLine();
            try
            {
                while (input.Equals("y"))
                {
                    Console.Write("Enter the product name >> ");
                    string item = Console.ReadLine();
                    items.Add(item);
                    if (item.Equals("exit"))
                    {
                        items.Remove(item);
                        break;
                    }
                    Console.Write("Enter " + item + " price >> ");
                    double price = double.Parse(Console.ReadLine());
                    prices.Add(price);

                    Console.WriteLine("Please specify which type " + item + " is ('1' GROCERY / '2' BIG BOX)");
                    double type = double.Parse(Console.ReadLine());
                    if (type == 1)
                    {
                        grocery.Add(price);
                    }
                    else if (type == 2)
                    {
                        Console.WriteLine("Please specify the price of delivery");
                        double delPrice = double.Parse(Console.ReadLine());
                        bigbox.Add(delPrice);
                    }
                }

                Console.WriteLine();
                Console.WriteLine("----------------------------");
                for (int i = 0; i < items.Count; i++)
                {
                    Console.WriteLine(items[i] + " R " + prices[i]);
                }
                Console.WriteLine("----------------------------");

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
