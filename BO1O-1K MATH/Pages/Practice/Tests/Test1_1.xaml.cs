using BO1O_1K_MATH.BD;
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

namespace BO1O_1K_MATH.Pages.Practice.Tests
{
    /// <summary>
    /// Логика взаимодействия для Test1_1.xaml
    /// </summary>
    public partial class Test1_1 : Page
    {
        public Frame frame1;
        Chapters thisChapters;
        Themes thisThemes;
        public Test1_1(Frame frame, Chapters chapter, Themes theme)
        {
            InitializeComponent();
            frame1 = frame;
            thisChapters = chapter;
            thisThemes = theme;
            LabelChapter.Content = "Тест по теме: " + thisChapters.Chapter;
        }
        private void Back_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            frame1.Navigate(new Lesson(frame1, thisChapters, thisThemes));
        }

        private void TestChapter_Click(object sender, RoutedEventArgs e)
        {
            if (Q1.IsChecked.Equals(true) && Q2.Text == "делится нацело" || Q2.Text == "Делится нацело" && Q3.IsChecked.Equals(true) && Q4.IsChecked.Equals(true))
            {
                MessageBox.Show("Ты решил всё верно!", "Проверка", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Ты допустил ошибки!", "Проверка", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

    }
}
