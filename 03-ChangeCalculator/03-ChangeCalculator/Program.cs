using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ChangeCalculator
{
    class Program
    {

        static double ItemCost(string prompt)
        {

            //Message for user
            Console.WriteLine(prompt);
            while (true)
            {
                try
                {
                    string userInput = Console.ReadLine();
                    double x = double.Parse(userInput);
                    if (x > 0)
                    {
                        return x;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Please enter the correct amount of money that the item costs.");
                }

            }
        }


        static double CustomerMoney(string prompt)
        {

            //Message for user
            Console.WriteLine(prompt);
            while (true)
            {
                try
                {
                    string userInput = Console.ReadLine();
                    double x = double.Parse(userInput);
                    if (x > 0)
                    {
                        return x;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Please enter the correct amount of money you have received from the customer.");
                }

            }
        }



        static void Main(string[] args)
        {

            double itemCost = ItemCost("How much does the item cost?");
            double customerMoney = CustomerMoney("How much has the customer given you?");
      //    double customerChange = 0;
            double x = customerMoney;

            while (itemCost > customerMoney)
            {
                Console.WriteLine("Please ask the customer for additional funds.");


            }


            if (customerMoney >= itemCost)
            {
                double customerChange = Math.Round(customerMoney - itemCost, 2);
                double quarters = Math.Floor(customerChange / 0.25);
                double quartersRemainder = (customerChange % 0.25);
                double dimes = Math.Floor(quartersRemainder / 0.10);
                double dimesRemainder = (quartersRemainder % 0.10);
                double nickels = Math.Floor(dimesRemainder / 0.05);
                double nickelsRemainder = (dimesRemainder % 0.05);
                double pennies = (nickelsRemainder / 0.01);


                Console.WriteLine("======");
                Console.WriteLine("The customer's change is " + customerChange);
                Console.WriteLine("Quarters: " + quarters);
                Console.WriteLine("Dimes: " + dimes);
                Console.WriteLine("Nickels: " + nickels);
                Console.WriteLine("Pennies: " + pennies);
                Console.ReadLine();

            }
       }
    }
}
