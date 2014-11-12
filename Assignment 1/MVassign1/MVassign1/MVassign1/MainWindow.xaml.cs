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

namespace MVassign1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void okMathShow(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Robert " + "Stevens " + ": " + "rstevens@conestogac.on.ca");
        }

        private void okP1Show(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("David " + "Allison " + ": " + "dallison@conestogac.on.ca");
        }

        private void okP2show(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Steven " + "McKenna " + ": " + "smckenna@conestogac.on.ca");
        }

        private void okCshow(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Tracy " + "Finn " + ": " + "tfinn@conestogac.on.ca");
        }

 
    }
}
