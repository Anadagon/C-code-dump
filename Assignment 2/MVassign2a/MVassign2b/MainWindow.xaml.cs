/* $MainWindow$.xaml.cs
 * 
 * $This program asks a user to enter three integers then provides the largest value and the mean of the three integers entered$
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
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MVassign2b
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            btnCalculate.IsEnabled = false;            
        }

        public static class GlobalInts
        {
            public static int firstInteger = 0;
            public static int secondInteger = 0;
            public static int thirdInteger = 0;
        }

        /* use switch statement with button text cases... each case changes button content in order for next case to be triggered, 
         * integer validation in try statements ... the final case diables the integer input button and enables the calculate button.
         */
        private void FirstClick(object sender, RoutedEventArgs e)
        {     
            switch (btnIntegerInput.Content.ToString())
            {
                case "Enter First Integer":
                    try
                    {
                        GlobalInts.firstInteger = int.Parse(integerTextBox.Text);
                        btnIntegerInput.Content = "Enter Second Integer";
                        integerTextBox.Text = "";
                        errorTextBlock.Text = "";
                    }
                    catch (Exception)
                    {
                        errorTextBlock.Text = "That is not a valid integer...";
                    }
                    break;
                case "Enter Second Integer":
                    try
                    {
                        GlobalInts.secondInteger = int.Parse(integerTextBox.Text);
                        btnIntegerInput.Content = "Enter Third Integer";
                        integerTextBox.Text = "";
                        errorTextBlock.Text = "";
                    }
                    catch (Exception)
                    {
                        errorTextBlock.Text = "That is not a valid integer...";
                    }
                    break;
                default:
                    try
                    {
                        GlobalInts.thirdInteger = int.Parse(integerTextBox.Text);
                        btnIntegerInput.Content = "Enter First Integer";
                        btnIntegerInput.IsEnabled = false;
                        btnCalculate.IsEnabled = true;
                        integerTextBox.Text = "";
                        errorTextBlock.Text = "";
                    }
                    catch (Exception)
                    {
                        errorTextBlock.Text = "That is not a valid integer...";
                    }
                    break;
            }
            
        }

        /* second click represents second button click... 
         * this button calls methods CalculateMean and LargestValue, which do what thier names say...
         * after storing mean as a double in the result variable, the variable is formatted into a string and displayed in the text box
         * the largest value remains an integer after its method is called, the calculate button is then disabled and the integer
         * input button is enabled in order for a new set of numbers to be evaluated
         */ 
        private void SecondClick(object sender, RoutedEventArgs e)
        {
            double result = CalculateMean(GlobalInts.firstInteger, GlobalInts.secondInteger, GlobalInts.thirdInteger);
            meanTextBox.Text = String.Format("{0:0.00}", result);
            largestTextBox.Text = LargestValue(GlobalInts.firstInteger, GlobalInts.secondInteger, GlobalInts.thirdInteger).ToString();
            btnCalculate.IsEnabled = false;
            btnIntegerInput.IsEnabled = true;
        }

        public double CalculateMean(double firstInteger, double secondInteger, double thirdInteger)
        {
            double mean = ((firstInteger + secondInteger + thirdInteger) / 3.00);
            return mean;
        }

        public int LargestValue(int firstInteger, int secondInteger, int thirdInteger)
        {
            int[] intarray = { firstInteger, secondInteger, thirdInteger };
            int largestValue = intarray.Max();
            return largestValue;
        }
    }
}
