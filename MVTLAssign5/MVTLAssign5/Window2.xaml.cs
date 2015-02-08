/*
 * Window2.xaml.cs
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
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        // declare private name variable assigned later
        private string name;

        //Name property used to transport name values to main window
        //using get and set parameters
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        
        //window Construtor
        public Window2()
        {
            InitializeComponent();
            infoNameTextbox.Focus();
        }

        /*
        * This method handles logic for the reserve button, it takes the entry texts 
        * for name and assigns it to its respective variable, the window
        * closes if the name is not empty, otherwise an error message is thrown.
        */ 
        private void infoBtnClick(object sender, RoutedEventArgs e)
        {
            name = infoNameTextbox.Text;
            if (name != "")
            {
                this.Close();
            }
            else
            {
                errorLabel.Content = "please enter a name or seat";
            }

            
        }
    }
}
