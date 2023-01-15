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
using static System.Net.Mime.MediaTypeNames;

namespace Desktop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string[] operations { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            operations = new string[] { "Test Scores", "Bank Charges", "Shipping Charges", "Distance Traveled" };
            DataContext = this;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if ((string)comboBox.SelectedItem == "Test Scores")
            {
                TestScoresWin testScoresWin = new TestScoresWin(); 
                this.Close();
                testScoresWin.Show();
            }
            else if ((string)comboBox.SelectedItem == "Bank Charges")
            {
                BankChargeWin bankChargeWin = new BankChargeWin();
                this.Close();
                bankChargeWin.Show();
            }
            else if ((string)comboBox.SelectedItem == "Shipping Charges")
            {
                ShippingChargesWin shippingChargesWin = new ShippingChargesWin();
                this.Close();
                shippingChargesWin.Show();
            }
            else if ((string)comboBox.SelectedItem == "Distance Traveled")
            {
                DistanceTraveledWin distanceTraveledWin = new DistanceTraveledWin();
                this.Close();
                distanceTraveledWin.Show();
            }
        }
    }
}
