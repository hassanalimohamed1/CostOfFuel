using System;
using static System.Console;
namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            double price1;
            double litres1;
            double total_cost;
            User_input(out litres1, out price1);
            total_cost = Calculate(litres1, price1);
            Output(litres1, price1, total_cost);

        }

        private static void User_input(out double litres, out double price) {
            Write("Enter the number of litres: ");
            litres = double.Parse(ReadLine());

            Write("Enter the number of price: ");
            price = double.Parse(ReadLine());
        }

        private static double Calculate(double litres, double price)
        {
            double total_cost;
            total_cost = litres * price;
            return total_cost;
       
        }

        private static void Output(double total_cost, double litres, double price)
        {
          
            WriteLine($"Number of litres of fuel: {litres}");
            WriteLine($"Cost of fuel: {price.ToString("C")}");
            WriteLine($"Total cost of fuel: {total_cost.ToString("C")}");
        }

    }
}
