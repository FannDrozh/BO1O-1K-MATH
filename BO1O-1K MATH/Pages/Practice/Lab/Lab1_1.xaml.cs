using BO1O_1K_MATH.BD;
using BO1O_1K_MATH.Pages.Practice.Lab.Examples;
using BO1O_1K_MATH.Pages.Practice.Lab.Tasks;
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

namespace BO1O_1K_MATH.Pages.Practice.Lab
{
    /// <summary>
    /// Логика взаимодействия для Lab1_1.xaml
    /// </summary>
    public partial class Lab1_1 : Page
    {
        public Frame frame1;
        Themes thisThemes;

        public Lab1_1(Frame frame, Themes theme)
        {
            InitializeComponent();
            frame1 = frame;
            thisThemes = theme;
        }

        private void Task1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            frame1.Navigate(new Example1_1_1(frame1));
        }

        private void Task2_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            frame1.Navigate(new Example1_1_2(frame1));
        }

        private void Task3_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            frame1.Navigate(new Example1_1_3(frame1));
        }

        private void BackMain_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            frame1.Navigate(new MainMenu(frame1));
        }

        private void Close_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MessageBoxButton btnMessageBox = MessageBoxButton.YesNo;
            MessageBoxImage imgMessageBox = MessageBoxImage.Question;
            MessageBoxResult boxResult = MessageBox.Show("Вы действительно хотите выйти?", "Выход", btnMessageBox, imgMessageBox);
            switch (boxResult)
            {
                case MessageBoxResult.Yes:
                    System.Windows.Application.Current.Shutdown();
                    break;
                case MessageBoxResult.No:
                    break;
            }
        }

    }
}
