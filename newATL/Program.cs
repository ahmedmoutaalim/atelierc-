using System;

namespace newATL
{
    class Program
    {
        static void Main(string[] args)
        {
            const double tva = 0.196;

            Console.WriteLine("write product :");
            string product = Console.ReadLine();
            Console.WriteLine("write price : ");
            string price = Console.ReadLine();



            int i = 0;
            if (int.TryParse(price, out i))
            {
                int pr = Convert.ToInt32(price);
                double x = pr + (pr * tva);
                Console.WriteLine("the price of the " + product + " is " + price + "DH and with tva " + x);
            }
            else
            {
                Console.WriteLine("sorry that's not a number");

            }



        }
    }
}
