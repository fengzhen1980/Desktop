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

namespace Desktop
{
    /// <summary>
    /// Interaction logic for ShippingChargesWin.xaml
    /// </summary>
    public partial class ShippingChargesWin : Window
    {
        public ShippingChargesWin()
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
            double weight = Convert.ToDouble(weightTextBox.Text);
            double miles = Convert.ToDouble(milesTextBox.Text);

            double charge = 0;
            double countMile = 0;

            countMile = Math.Ceiling(miles / 500);
            if (weight <= 2)
            {
                charge = 1.10 * countMile;
            }
            else if (weight > 2 && weight <= 6)
            {
                charge = 2.20 * countMile;
            }
            else if (weight > 6 && weight <= 10)
            {
                charge = 3.70 * countMile;
            }
            else
            {
                charge = 4.80 * countMile;
            }

            chargeLabel.Content = charge;
        }
    }
}
