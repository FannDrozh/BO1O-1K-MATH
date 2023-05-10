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
    /// Логика взаимодействия для Example1_1_3.xaml
    /// </summary>
    public partial class Example1_1_3 : Page
    {
        public Frame frame1;
        public Example1_1_3(Frame frame)
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
            if ((Ex1_1.IsChecked.Equals(true) && Ex1_2.IsChecked.Equals(true) && Ex1_5.IsChecked.Equals(true)) && (Ex1_3.IsChecked.Equals(false) && Ex1_4.IsChecked.Equals(false) && Ex1_6.IsChecked.Equals(false)))
            {

            }
            else
            {
                MessageBox.Show("У тебя ошибка в первом задании");
            }
            if (Ex2.Text == "60")
            {

            }
            else
            {
                MessageBox.Show("У тебя ошибка во втором задании!");
            }
            if (Ex3_1.Text == "6" && Ex3_2.Text == "43")
            {

            }
            else
            {
                MessageBox.Show("У тебя ошибка в третьем задании задании!");
            }
            if ((Ex4_1.Text == "31" && Ex4_2.Text == "25") && (Ex4_3.Text == "3" && Ex4_4.Text == "100") && (Ex4_5.Text == "9" && Ex4_6.Text == "5") && (Ex4_7.Text == "31" && Ex4_8.Text == "10"))
            {

            }
            else
            {
                MessageBox.Show("У тебя ошибка в четвёртом задании задании задании!");
            }
        }
    }
}
