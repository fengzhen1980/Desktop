<<<<<<< HEAD
﻿using System;
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

namespace Desktop
{
    /// <summary>
    /// Interaction logic for BankChargeWin.xaml
    /// </summary>
    public partial class BankChargeWin : Window
    {
        public BankChargeWin()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            this.Close();
            mainWindow.Show();
        }

        private void calculateButton_Click(object sender, RoutedEventArgs e)
        {
            double serviceFee = 10;
            double checkNumber = Convert.ToDouble(checksTextBox.Text);
            double balance = Convert.ToDouble(balanceTextBox.Text);

            if (checkNumber < 20)
            {
                serviceFee = serviceFee + 0.1 * checkNumber;
            }
            else if (checkNumber >= 20 && checkNumber <= 39)
            {
                serviceFee = serviceFee + 0.08 * checkNumber;
            }
            else if (checkNumber >= 40 && checkNumber <= 59)
            {
                serviceFee = serviceFee + 0.06 * checkNumber;
            }
            else if (checkNumber >= 60)
            {
                serviceFee = serviceFee + 0.04 * checkNumber;
            }

            if (balance < 400)
            {
                serviceFee = serviceFee + 15;
            }

            serviceFeeLabel.Content = serviceFee;
        }
    }
}
=======
﻿using System;
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

namespace Desktop
{
    /// <summary>
    /// Interaction logic for BankChargeWin.xaml
    /// </summary>
    public partial class BankChargeWin : Window
    {
        public BankChargeWin()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            this.Close();
            mainWindow.Show();
        }

        private void calculateButton_Click(object sender, RoutedEventArgs e)
        {
            double serviceFee = 10;
            double checkNumber = Convert.ToDouble(checksTextBox.Text);
            double balance = Convert.ToDouble(balanceTextBox.Text);

            if (checkNumber < 20)
            {
                serviceFee = serviceFee + 0.1 * checkNumber;
            }
            else if (checkNumber >= 20 && checkNumber <= 39)
            {
                serviceFee = serviceFee + 0.08 * checkNumber;
            }
            else if (checkNumber >= 40 && checkNumber <= 59)
            {
                serviceFee = serviceFee + 0.06 * checkNumber;
            }
            else if (checkNumber >= 60)
            {
                serviceFee = serviceFee + 0.04 * checkNumber;
            }

            if (balance < 400)
            {
                serviceFee = serviceFee + 15;
            }

            serviceFeeLabel.Content = serviceFee;
        }
    }
}
>>>>>>> aeef6d10cd2828941777353c4f3f8550f8620ea5
