/*
 * Window3.xaml.cs
 * this program is a reservation system for an airplane, clients can add 
 * and cancel reservations
 * 
 * Matthew VanBoxtel and Ting Ting Lin, 2014.12.03: Completed
 * 
 * Disclaimer:
 * The faculty is free to use this program for teaching purposes.
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
using System.Windows.Shapes;

namespace MVTLAssign5
{
    /// <summary>
    /// Interaction logic for Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        // declare private seat and name variables assigned later
        private string name;
        private string seat;

        //Name property used to transport name values to main window
        //using get and set parameters
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        // Seat property used to transport seat values to main window
        // using get and set parameters
        public string Seat 
        {
            get { return seat; }
            set { seat = value; }
        }

        // window constructor
        public Window3()
        {
            InitializeComponent();
        }

        /*
         * This method handles logic for the cancel button, it takes the entry texts 
         * for seat or name and assigns them to thier respective variables, the window
         * closes if the name or seat is not empty, otherwise an error message is thrown.
         */ 
        private void infoCancelClick(object sender, RoutedEventArgs e)
        {
            seat = infoCancelSeatTextbox.Text;
            name = infoCancelNameTextbox.Text;
            if (name != "" || seat != "")
            {
                this.Close();
            }
            else
            {
                errorCancelLabel.Content = "please enter your name";
            }
        }
    }
}
