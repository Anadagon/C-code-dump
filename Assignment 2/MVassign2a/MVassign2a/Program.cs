/* $MainWindow$.xaml.cs
 * 
 * $This shirt order program asks a user to enter a shirt type(color), the quantity of shirts and what shipping type a customer would like to order,
 * the program then calculates the total cost and displays it to the customer $
 * 
 * $Matthew VanBoxtel$, 2014-10-11
 * 
 * 
 */ 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVassign2a
{
    class Program
    {
        
        
        static void Main(string[] args)
        {
            Console.WriteLine("*****Welcome to the shirt order program!*****");
            Console.WriteLine("*****To order shirts please specify the shirt type, shirt quantity and shipping type using the information below.*****");
            Console.WriteLine("*****Shirt types and costs*****");
            Console.WriteLine("*****Blue shirts: $20***Green shirts: $20***Yellow shirts: $10***Brown shirts: $5***Other shirts: $15*****");
            Console.WriteLine("*****Shipping types and costs*****");
            Console.WriteLine("*****None: $0***Standard: $5***Expedited: $10*****");
            Console.WriteLine("What type of shirt would you like to order?");
            string shirtType = Console.ReadLine();
            Console.WriteLine("How many shirts would you like to order?");
            /* this try statement gets the quantity of shirts a user requests, if the value is too large or not an int an exception occurs, ending the program
             * while informing the user that they have requested an invalid quantity.
             */ 
            try
            {
                string shirtQuantitys = Console.ReadLine();
                int shirtQuantityi = int.Parse(shirtQuantitys);
                Console.WriteLine("What shipping type would you like to use?");
                string shippingType = Console.ReadLine();
                CalculateCost(shirtType, shirtQuantityi, shippingType);
                Console.WriteLine("Your order has been processed.");
                Console.ReadLine();
            }
            catch (Exception)
            {
                Console.WriteLine("That is not a valid quantity...");
            }
        }

        /* the CalculateCost method takes 3 arguements shirtType, shirtQuantityi, and shippingType, an if statement is used to change user's shipping
         * type into the cost associated with the shipping type, invalid shipping types end the program. 
         */ 
        static void CalculateCost(string shirtType, int shirtQuantityi, string shippingType)
        {
            int shippingTypei = 0;
            if (shippingType == "Standard" || shippingType == "standard")
            {
                shippingTypei = 5;
            }
            else if (shippingType == "Expedited" || shippingType == "expedited")
            {
                shippingTypei = 10;
            }
            else if (shippingType == "None" || shippingType == "none")
            {
                shippingTypei = 0;
            }
            else
            {
                Console.WriteLine("That is not a valid shipping type...");
                return;
            }
            /* this switch statement handles user input of shirt type... because different shirts have different costs, the cases will calculate the total
             * cost depending on the arguements given to the method and then displays them to the user. 
             */
            switch (shirtType)
            {
                case "Blue":
                    Console.WriteLine("Here is your total for your blue shirts:");
                    double totalb = (((20 * shirtQuantityi) + shippingTypei) * 1.13);
                    String.Format("{0:0.00}", totalb);
                    Console.WriteLine("$" + totalb);
                    break;
                case "Green":
                    Console.WriteLine("Here is your total for your green shirts:");
                    double totalg = (((20 * shirtQuantityi) + shippingTypei) * 1.13);
                    String.Format("{0:0.00}", totalg);
                    Console.WriteLine("$" + totalg);
                    break;
                case "Yellow":
                    Console.WriteLine("Here is your total for your yellow shirts:");
                    double totaly = (((10 * shirtQuantityi) + shippingTypei) * 1.13);
                    String.Format("{0:0.00}", totaly);
                    Console.WriteLine("$" + totaly);
                    break;
                case "Brown":
                    Console.WriteLine("Here is your total for your brown shirts:");
                    double totalr = (((5 * shirtQuantityi) + shippingTypei) * 1.13);
                    String.Format("{0:0.00}", totalr);
                    Console.WriteLine("$" + totalr);
                    break;
                case "Other":
                    Console.WriteLine("Here is your total for your other shirts:");
                    double totalo = (((15 * shirtQuantityi) + shippingTypei) * 1.13);
                    String.Format("{0:0.00}", totalo);
                    Console.WriteLine("$" + totalo);
                    break;
                default:
                    Console.WriteLine("That is not a valid shirt type...");
                    break;
            }

        }
    }
}
