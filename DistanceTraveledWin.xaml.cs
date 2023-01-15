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
    /// Interaction logic for DistanceTraveledWin.xaml
    /// </summary>
    public partial class DistanceTraveledWin : Window
    {
        public DistanceTraveledWin()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            this.Close();
            mainWindow.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            double speed = Convert.ToDouble(speedTextBox.Text);
            double hours = Convert.ToDouble(hoursTextBox.Text);
            double distance = 0;
            string resultString = "Hour\tDistance Traveled\n";

            for (int i = 1; i <= hours; i++)
            {
                distance = distance + speed;
                resultString = resultString + i.ToString() + "\t" + distance + "\n";
                
            }
            resultTextBox.Text = resultString;
            resultTextBox.IsReadOnly = true;
        }
    }
}
