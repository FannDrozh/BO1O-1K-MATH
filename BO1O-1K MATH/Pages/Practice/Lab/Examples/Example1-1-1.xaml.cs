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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BO1O_1K_MATH.Pages.Practice.Lab.Tasks
{
    /// <summary>
    /// Логика взаимодействия для Example1_1_1.xaml
    /// </summary>
    public partial class Example1_1_1 : Page
    {
        public Frame frame1;
        public Example1_1_1(Frame frame)
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
            if ((Ex1_1.IsChecked.Equals(true) && Ex1_4.IsChecked.Equals(true) && Ex1_5.IsChecked.Equals(true)) && (Ex1_2.IsChecked.Equals(false) && Ex1_3.IsChecked.Equals(false) && Ex1_6.IsChecked.Equals(false)))
            {
                RecEx1T.Visibility = Visibility.Visible;
            }
            else
            {
                RecEx1F.Visibility = Visibility.Visible;
            }

            if (Ex2.Text == "36")
            {
                RecEx2T.Visibility = Visibility.Visible;
            }
            else
            {
                RecEx2F.Visibility = Visibility.Visible;
            }

            if ((Ex3_1.IsChecked.Equals(true) && Ex3_3.IsChecked.Equals(true)) && (Ex3_2.IsChecked.Equals(false) && Ex3_4.IsChecked.Equals(false)))
            {
                RecEx3T.Visibility = Visibility.Visible;
            }
            else
            {
                RecEx3F.Visibility = Visibility.Visible;
            }

            if (Ex4_1.Text == "51" && Ex4_2.Text == "19")
            {
                RecEx4T.Visibility = Visibility.Visible;
            }
            else
            {
                RecEx4F.Visibility = Visibility.Visible;
            }
        }
    }
}
