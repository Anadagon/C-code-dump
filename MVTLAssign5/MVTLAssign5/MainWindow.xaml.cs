/*
 * MainWindow.xaml.cs
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MVTLAssign5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow : Window
    {
        // declare private string and button arrays, as well as a string waiting list.
        string[,] nameArray = new string[5, 3];
        Button[,] buttonArray = new Button[5, 3];
        string[,] seatArray = new string[5, 3];
        List<string> waitingList = new List<string>();

        // populate components and button and seat arrays
        public MainWindow()
        {
            InitializeComponent();
            InitializeButtonArray();
            InitializeSeatArray();
        }

        /*
         * This method is called when each seat button is clicked, its purpose is to
         * loop through each button in the button array and check to see if it is enabled
         * if all buttons are disabled, enable the waiting list.
         */ 
        public void EnableWaitList()
        {
            bool allReserverved = true;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if(buttonArray[i,j].IsEnabled)
                    {
                        allReserverved = false;
                    }
                }
            }
            if (allReserverved == true)
            {
                btnWaitingList.IsEnabled = true;                
            }
        }


        //Create points for each button
        public void InitializeButtonArray()
        {
            buttonArray[0, 0] = btn1A;
            buttonArray[0, 1] = btn1B;
            buttonArray[0, 2] = btn1C;

            buttonArray[1, 0] = btn2A;
            buttonArray[1, 1] = btn2B;
            buttonArray[1, 2] = btn2C;

            buttonArray[2, 0] = btn3A;
            buttonArray[2, 1] = btn3B;
            buttonArray[2, 2] = btn3C;

            buttonArray[3, 0] = btn4A;
            buttonArray[3, 1] = btn4B;
            buttonArray[3, 2] = btn4C;

            buttonArray[4, 0] = btn5A;
            buttonArray[4, 1] = btn5B;
            buttonArray[4, 2] = btn5C;
        }

        //Create points for each seat number
        public void InitializeSeatArray()
        {
            seatArray[0, 0] = "1A";
            seatArray[0, 1] = "1B";
            seatArray[0, 2] = "1C";

            seatArray[1, 0] = "2A";
            seatArray[1, 1] = "2B";
            seatArray[1, 2] = "2C";

            seatArray[2, 0] = "3A";
            seatArray[2, 1] = "3B";
            seatArray[2, 2] = "3C";

            seatArray[3, 0] = "4A";
            seatArray[3, 1] = "4B";
            seatArray[3, 2] = "4C";

            seatArray[4, 0] = "5A";
            seatArray[4, 1] = "5B";
            seatArray[4, 2] = "5C";
        }


        /*
         * The following 15 methods handle logic for each seat, clicking a seat
         * button brings up a popup window where a client is able to enter his/her
         * name, the name is then stored at the respective seat number in namearray, 
         * also the respective button is disabled in buttonarray
         */
        private void Btn1AClick(object sender, RoutedEventArgs e)
        {
            Window2 popUp = new Window2();
            popUp.ShowDialog();
            if (popUp.Name != null)
            {
                btn1A.IsEnabled = false;
                nameArray[0, 0] = popUp.Name;
                EnableWaitList();
            }
        }

        private void Btn1BClick(object sender, RoutedEventArgs e)
        {
            Window2 popUp = new Window2();
            popUp.ShowDialog();
            if (popUp.Name != null)
            {
                btn1B.IsEnabled = false;
                nameArray[0, 1] = popUp.Name;
                EnableWaitList();
            }
        }

        private void Btn1CClick(object sender, RoutedEventArgs e)
        {
            Window2 popUp = new Window2();
            popUp.ShowDialog();
            if (popUp.Name != null)
            {
                btn1C.IsEnabled = false;
                nameArray[0, 2] = popUp.Name;
                EnableWaitList();
            }
        }

        private void Btn2AClick(object sender, RoutedEventArgs e)
        {
            Window2 popUp = new Window2();
            popUp.ShowDialog();
            if (popUp.Name != null)
            {
                btn2A.IsEnabled = false;
                nameArray[1, 0] = popUp.Name;
                EnableWaitList();
            }
        }

        private void Btn2BClick(object sender, RoutedEventArgs e)
        {
            Window2 popUp = new Window2();
            popUp.ShowDialog();
            if (popUp.Name != null)
            {
                btn2B.IsEnabled = false;
                nameArray[1, 1] = popUp.Name;
                EnableWaitList();
            }
        }

        private void Btn2CClick(object sender, RoutedEventArgs e)
        {
            Window2 popUp = new Window2();
            popUp.ShowDialog();
            if (popUp.Name != null)
            {
                btn2C.IsEnabled = false;
                nameArray[1, 2] = popUp.Name;
                EnableWaitList();
            }
        }

        private void Btn3AClick(object sender, RoutedEventArgs e)
        {
            Window2 popUp = new Window2();
            popUp.ShowDialog();
            if (popUp.Name != null)
            {
                btn3A.IsEnabled = false;
                nameArray[2, 0] = popUp.Name;
                EnableWaitList();
            }
        }

        private void Btn3BClick(object sender, RoutedEventArgs e)
        {
            Window2 popUp = new Window2();
            popUp.ShowDialog();
            if (popUp.Name != null)
            {
                btn3B.IsEnabled = false;
                nameArray[2, 1] = popUp.Name;
                EnableWaitList();
            }
        }

        private void Btn3CClick(object sender, RoutedEventArgs e)
        {
            Window2 popUp = new Window2();
            popUp.ShowDialog();
            if (popUp.Name != null)
            {
                btn3C.IsEnabled = false;
                nameArray[2, 2] = popUp.Name;
                EnableWaitList();
            }
        }

        private void Btn4AClick(object sender, RoutedEventArgs e)
        {
            Window2 popUp = new Window2();
            popUp.ShowDialog();
            if (popUp.Name != null)
            {
                btn4A.IsEnabled = false;
                nameArray[3, 0] = popUp.Name;
                EnableWaitList();
            }
        }

        private void Btn4BClick(object sender, RoutedEventArgs e)
        {
            Window2 popUp = new Window2();
            popUp.ShowDialog();
            if (popUp.Name != null)
            {
                btn4B.IsEnabled = false;
                nameArray[3, 1] = popUp.Name;
                EnableWaitList();
            }
        }

        private void Btn4CClick(object sender, RoutedEventArgs e)
        {
            Window2 popUp = new Window2();
            popUp.ShowDialog();
            if (popUp.Name != null)
            {
                btn4C.IsEnabled = false;
                nameArray[3, 2] = popUp.Name;
                EnableWaitList();
            }
        }

        private void Btn5AClick(object sender, RoutedEventArgs e)
        {
            Window2 popUp = new Window2();
            popUp.ShowDialog();
            if (popUp.Name != null)
            {
                btn5A.IsEnabled = false;
                nameArray[4, 0] = popUp.Name;
                EnableWaitList();
            }
        }

        private void Btn5BClick(object sender, RoutedEventArgs e)
        {
            Window2 popUp = new Window2();
            popUp.ShowDialog();
            if (popUp.Name != null)
            {
                btn5B.IsEnabled = false;
                nameArray[4, 1] = popUp.Name;
                EnableWaitList();
            }
        }


        private void Btn5CClick(object sender, RoutedEventArgs e)
        {
            Window2 popUp = new Window2();
            popUp.ShowDialog();
            if (popUp.Name != null)
            {
                btn5C.IsEnabled = false;
                nameArray[4, 2] = popUp.Name;
                EnableWaitList();
            }
        }

        /*
         * this method handles waiting list button logic, clicking the waiting 
         * list button creates a popup window where a client can enter his/her
         * name in order to be added to the waiting list. The name is listed on 
         * the waiting list text box on the right.
         */ 
        private void BtnWaitingListClick(object sender, RoutedEventArgs e)
        {
            Window2 popUp = new Window2();
            popUp.ShowDialog();
            waitingList.Add(popUp.Name);
            waitListTextBox.Text += popUp.Name + "\n";
        }

        /*
         * This method handles logic for the cancel reservation button as well as
         * waiting list updates. Upon click a popup window emerges where a client
         * can enter his/her name or seat number that they have reserved in order
         * to cancel their reservation. Once the cancel button has been selected 
         * the first person on the waiting list is entered into the seat that has
         * been cancelled. 
         */
        private void BtnCancelClick(object sender, RoutedEventArgs e)
        {
            Window3 popUp = new Window3();
            popUp.ShowDialog();
            string cancelName = popUp.Name;
            string cancelSeat = popUp.Seat;

            if(cancelName !="")
            {
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 3; j++){
                        if (nameArray[i,j] == cancelName)
                        {
                            if (waitingList.Count > 0)
                            {

                                nameArray[i, j] = waitingList[0];
                                waitingList.RemoveAt(0);
                                buttonArray[i, j].IsEnabled = false;
                                if (waitingList.Count == 0)
                                {
                                    waitListTextBox.Text = "";
                                }
                                waitListTextBox.Text = "";
                                foreach (string name in waitingList)
                                {
                                    waitListTextBox.Text += name + "\n";
                                }
                            }
                            else
                            {
                                nameArray[i, j] = "";
                                buttonArray[i, j].IsEnabled = true;
                                btnWaitingList.IsEnabled = false;
                            }
                        }
                    }
                }
            }
            else if(cancelSeat != "")
            {
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 3; j++) 
                    {
                        if (seatArray[i, j] == cancelSeat)
                        {

                            if (waitingList.Count > 0) 
                            {

                                nameArray[i, j] = waitingList[0];
                                waitingList.RemoveAt(0);
                                buttonArray[i, j].IsEnabled = false;
                                if (waitingList.Count == 0)
                                {
                                    waitListTextBox.Text = "";
                                }
                                waitListTextBox.Text = "";
                                foreach (string name in waitingList)
                                {
                                    waitListTextBox.Text += name + "\n";
                                }
                            }
                            else
                            {
                                nameArray[i, j] = "";
                                buttonArray[i, j].IsEnabled = true;
                                btnWaitingList.IsEnabled = false;
                            }
                            
                        }
                        
                    }
                } 
            }
        }
    }
}
