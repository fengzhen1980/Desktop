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
    /// Interaction logic for TestScoresWin.xaml
    /// </summary>
    public partial class TestScoresWin : Window
    {
        public TestScoresWin()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            this.Close();
            mainWindow.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            double s1 = Convert.ToDouble(score1.Text);
            double s2 = Convert.ToDouble(score2.Text);
            double s3 = Convert.ToDouble(score3.Text);

            double average = (s1 + s2 + s3) / 3;

            string letterGrade;
            if (average >= 90 && average <= 100)
            {
                letterGrade = "A";
            }
            else if (average >= 80 && average <= 89)
            {
                letterGrade = "B";
            }
            else if (average >= 70 && average <= 79)
            {
                letterGrade = "C";
            }
            else if (average >= 60 && average <= 69)
            {
                letterGrade = "D";
            }
            else
            {
                letterGrade = "E";
            }

            averageLabel.Content = average.ToString();
            gradeLabel.Content = letterGrade;
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
    /// Interaction logic for TestScoresWin.xaml
    /// </summary>
    public partial class TestScoresWin : Window
    {
        public TestScoresWin()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            this.Close();
            mainWindow.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            double s1 = Convert.ToDouble(score1.Text);
            double s2 = Convert.ToDouble(score2.Text);
            double s3 = Convert.ToDouble(score3.Text);

            double average = (s1 + s2 + s3) / 3;

            string letterGrade;
            if (average >= 90 && average <= 100)
            {
                letterGrade = "A";
            }
            else if (average >= 80 && average <= 89)
            {
                letterGrade = "B";
            }
            else if (average >= 70 && average <= 79)
            {
                letterGrade = "C";
            }
            else if (average >= 60 && average <= 69)
            {
                letterGrade = "D";
            }
            else
            {
                letterGrade = "E";
            }

            averageLabel.Content = average.ToString();
            gradeLabel.Content = letterGrade;
        }
    }
}
>>>>>>> aeef6d10cd2828941777353c4f3f8550f8620ea5
