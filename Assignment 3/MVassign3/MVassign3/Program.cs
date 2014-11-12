/* program.cs
 * this program gives a user 3 options to choose from... 1: view perfect squares, 2. view fibonacci sequence, 3 exit program
 * 
 * Matthew VanBoxtel, 2014.10.23: completed
 */ 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVassign3
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
             * This do loop shows the user a menu from which the user can select 3 options, if the try cannot parse the user
             * input, the option variable is assigned to 4 which will result in a true value for the while loop which means
             * the do statement is printed to console again.
             */
            int option;
            do 
            {
                Console.WriteLine("Which option would you like to view?");
                Console.WriteLine("Option 1: sequence of perfect squares");
                Console.WriteLine("Option 2: Fibonacci Sequence");
                Console.WriteLine("Option 3: Exit");
                string entry = Console.ReadLine();
                try
                {
                    option = int.Parse(entry);
                }
                catch (Exception)
                {
                    option =  4;
                }
            } while(!(option == 1 || option == 2 || option == 3));
            /* 
             * If the while loop evaluates to false as a result of selecting a valid option this if statement will
             * take the user to his/her requested option. As you can see the first two go to functions and the 3rd 
             * option exits the program.
             */
            if (option == 1)
            {
                Console.WriteLine("You have selected option 1...");
                Console.WriteLine("How many perfect squares would you like the console to display?");
                string input = Console.ReadLine();
                int squares = int.Parse(input);
                PerfectSquares(squares);
            }
            else if (option == 2)
            {
                Console.WriteLine("You have selected option 2...");
                Console.WriteLine("Starting Fibonacci sequence...");
                FibonacciSeq();
            }
            else
            {
                return;
            }
        }
        /*
         * The PerfectSquares method takes the number of squares the user entered as an arguement and uses a for loop
         * to loop through every perfect square up to the number of squares the user requested.
         */ 
        static void PerfectSquares(int numberofsquares)
        {
            for (int i = 1; i <= numberofsquares; i++)
            {
                int product = i * i;
                Console.WriteLine(i + " x " + i + " = " + product);
            }
            Console.WriteLine("Thank you for using this program...");
        }
        /*
         * The FibonacciSeq method uses a while loop to show users the fibonacci numbers, after each number is printed
         * the user is asked if they would like to see the next value. the holder string acts as control of the while loop
         * if user enters anything but y, the loop stops.
         */ 
        static void FibonacciSeq()
        {
            string holder = "y";
            int fnumber = 0;
            int snumber = 1;
            int pnumber = 0;
            while (holder == "y")
            {
                pnumber = fnumber + snumber;
                Console.WriteLine(pnumber.ToString());
                snumber = fnumber;
                fnumber = pnumber;
                Console.WriteLine("Would you like to see the next number in the sequence? y/n");
                holder = Console.ReadLine();
            }
        }
    }
}
