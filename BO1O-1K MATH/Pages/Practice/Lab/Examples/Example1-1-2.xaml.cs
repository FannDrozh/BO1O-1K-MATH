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

namespace BO1O_1K_MATH.Pages.Practice.Lab.Examples
{
    /// <summary>
    /// Логика взаимодействия для Example1_1_2.xaml
    /// </summary>
    public partial class Example1_1_2 : Page
    {
        public Frame frame1;
        public Example1_1_2(Frame frame)
        {
            InitializeComponent();
            frame1 = frame;
        }
        private void Back_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            frame1.Navigate(new Lab1_1(frame1, null));
        }
        private void CheckT1_Click(object sender, RoutedEventArgs e)
        {
            if (Ex1.Text == "35")
            {
                RecEx1T.Visibility = Visibility.Visible;
            }
            else
            {
                RecEx1F.Visibility = Visibility.Visible;
            }
            if (Ex2.Text == "39")
            {
                RecEx2T.Visibility = Visibility.Visible;
            }
            else
            {
                RecEx2F.Visibility = Visibility.Visible;
            }
            if (Ex3_1.Text == "11" && Ex3_2.Text == "5")
            {
                RecEx3T.Visibility = Visibility.Visible;
            }
            else
            {
                RecEx3F.Visibility = Visibility.Visible;
            }
        }
    }
}
