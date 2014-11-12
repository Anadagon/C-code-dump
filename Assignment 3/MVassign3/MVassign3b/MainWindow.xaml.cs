/*
 * MainWindow.xaml.cs
 * this program is a simple calculator which takes 2 user integer inputs and calculates a value for the operation the 
 * user wishes to perform.
 * 
 * Matthew VanBoxtel, 2014.10.23: completed
 */ 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MVassign3b
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            /// prevent user from editing output by making it read only
            outputBox.IsReadOnly = true;
        }
        /* 
         * the following buttons call the Calculate method with 3 arguments; the function placeholder, 
         * the first integer and the second integer that the user entered. The function placeholder 
         * will be explained below above the Calculate method.
         */
        private void BtnPlus(object sender, RoutedEventArgs e)
        {
            int function = 1;
            string firstInteger = firstInput.Text;
            string secondInteger = secondInput.Text;
            Calculate(function, firstInteger, secondInteger);
        }

        private void BtnMinus(object sender, RoutedEventArgs e)
        {
            int function = 2;
            string firstInteger = firstInput.Text;
            string secondInteger = secondInput.Text;
            Calculate(function, firstInteger, secondInteger);
        }

        private void BtnMultiply(object sender, RoutedEventArgs e)
        {
            int function = 3;
            string firstInteger = firstInput.Text;
            string secondInteger = secondInput.Text;
            Calculate(function, firstInteger, secondInteger);
        }

        private void BtnDivide(object sender, RoutedEventArgs e)
        {
            int function = 4;
            string firstInteger = firstInput.Text;
            string secondInteger = secondInput.Text;
            Calculate(function, firstInteger, secondInteger);
        }
        /*
         * The Calculate method takes three arguments and utilizes a switch statement which takes the function
         * variable as an arguement in each respective button which allows the switch to handle each case for 
         * each button. the entire switch is encapsulated with one try statement for error handling.
         */ 
        public void Calculate(int function, string firstInteger, string secondInteger)
        {
            try 
            {
                errorBox.Text = "";
            switch (function)
            {
                case 1:
                    int sum = int.Parse(firstInteger) + int.Parse(secondInteger);
                    outputBox.Text = sum.ToString();
                    break;
                case 2:
                    int difference = int.Parse(firstInteger) - int.Parse(secondInteger);
                    outputBox.Text = difference.ToString();
                    break;
                case 3:
                    int product = int.Parse(firstInteger) * int.Parse(secondInteger);
                    outputBox.Text = product.ToString();
                    break;
                case 4:
                    int quotient = int.Parse(firstInteger) / int.Parse(secondInteger);
                    outputBox.Text = quotient.ToString();
                    break;
            }
            }
            catch (FormatException) 
            {
                errorBox.Text = "At least one of your entries is not a valid integer...";
                outputBox.Text = "";
            }
            catch (DivideByZeroException)
            {
                errorBox.Text = "You cannot divide by zero...";
                outputBox.Text = "";
            }
            catch (Exception)
            {
                errorBox.Text = "That operation is invalid, check your inputs...";
                outputBox.Text = "";
            }
        }
    }
}
