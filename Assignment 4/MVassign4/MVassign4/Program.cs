/* Program.cs
 * This program lets a user enter car details and store them in a record, the user can then
 * view the details or edit the details.
 * 
 * Matthew Van Boxtel, 2014.11.10: completed
 */ 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVassign4
{
    class Program
    {
        // declare empty car object C1
        public static Car C1;
        static void Main(string[] args)
        {
            // program begins calling the menu method, this will be used frequently
            Menu();
        }

        // The Menu method displays the options available to the user and takes an input,
        // once the user has entered thier input the decision method is called.
        static void Menu()
        {
            Console.WriteLine("Please select one of the following 4 options:");
            Console.WriteLine("a) Display current car information");
            Console.WriteLine("b) Add a new car");
            Console.WriteLine("c) Edit the existing car");
            Console.WriteLine("d) Exit program");
            string placeholder = Console.ReadLine();
            Decision(placeholder);
        }
   
        // the Decision method takes the users choice as an arguement and redirects
        // the user using a switch statement.
        static void Decision(string option)
        {
            switch (option)
            {
                case "a":
                case "A":
                    if (C1 != null)
                    {
                        Console.WriteLine("Here is the current car information:");
                        // Call the DisplayCar method on the object C1
                        C1.DisplayCar();
                        Menu();
                    }
                    else
                    {
                        Console.WriteLine("No car exists!");
                        Menu();
                    }
                    break;
                case "b":
                case "B":
                    if (C1 == null)
                    {
                        Console.WriteLine("Enter the Car's color:");
                        string color = Console.ReadLine();
                        Console.WriteLine("Enter the Car's make:");
                        string make = Console.ReadLine();
                        Console.WriteLine("Enter the price of the Car:");
                        // call the Validate method on the user's input
                        int price = Car.Validate(Console.ReadLine());
                        // assign empty car object C1 the user input values
                        C1 = new Car(color, make, price);
                        Console.WriteLine("Car added!");
                        Menu();
                    }
                    else
                    {
                        Console.WriteLine("Cannot add more than one car");
                        Menu();
                    }
                    break;
                case "c":
                case "C":
                    if (C1 != null)
                    {
                        C1.DisplayCar();
                        Console.WriteLine("Enter new car values");
                        // Call EditCar method on car object C1
                        C1.EditCar();
                        Menu();
                    }
                    else
                    {
                        Console.WriteLine("No car exists!");
                        Menu();
                    }
                    break;
                case "d":
                case "D":
                    Console.WriteLine("Goodbye!");
                    break;
                default:
                    Console.WriteLine("That is not an option, enter an option");
                    Menu();
                    break;
            }
        }
    }

    class Car
    {
        private string color;
        private string make;
        private int price;

        // Car constructor with 3 fields
        public Car(string color1, string make1, int price1)
        {
            color = color1;
            make = make1;
            price = price1;
        }

        // DisplayCar method prints car details of the object to the console
        public void DisplayCar()
        {
            Console.WriteLine(color);
            Console.WriteLine(make);
            Console.WriteLine(price.ToString());
        }

        // EditCar method allows user to reenter the car details to the car object
        public void EditCar()
        {
            Console.WriteLine("Enter the Car's new color:");
            color = Console.ReadLine();
            Console.WriteLine("Enter the Car's new make:");
            make = Console.ReadLine();
            Console.WriteLine("Enter the new price of the Car:");
            price = Validate(Console.ReadLine());
            Console.WriteLine("Car edited!");
        }

        // Validate method handles integer input errors for the program, in particular
        // the price which must be reentered if a non int is entered by the user.
        public static int Validate(string snumber)
        {
            try
            {
                int inumber = int.Parse(snumber);
                if (inumber > 0)
                {
                    return inumber;
                }
                else
                {
                    Console.WriteLine("That is not a valid price, enter a valid price");
                    int inumber2 = Validate(Console.ReadLine());
                    return inumber2;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("That is not a valid price, enter a valid price");
                int inumber = Validate(Console.ReadLine());
                return inumber;
            }
        }
    }
}
