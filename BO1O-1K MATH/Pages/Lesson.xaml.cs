using BO1O_1K_MATH.BD;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
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

namespace BO1O_1K_MATH.Pages
{
    /// <summary>
    /// Логика взаимодействия для Lesson.xaml
    /// </summary>
    public partial class Lesson : Page
    {
        public int pagenum = 1;
        public int total = 0;
        public char zero = '0';
        public string path;
        public Frame frame1;
        Chapters thisChapters;
        Themes thisThemes;
        List<Chapters> chapters = new List<Chapters>();
        List<Themes> themes = new List<Themes>();
        public Lesson(Frame frame, Chapters chapter, Themes theme)
        {
            InitializeComponent();
            frame1 = frame;
            thisChapters = chapter;
            thisThemes = theme;
            Vved.Text = thisChapters.Chapter;
            chapters = KTP_Matematika_BarashenkovEntities.GetContext().Chapters.ToList();
            for(int i = 1; File.Exists(@"../../Lectures/" + thisThemes.Numeration + "/" + thisChapters.Numeration + "/" + thisChapters.Numeration + "-" + zero + i + ".jpg"); i++)
            {
                if (total < 10)
                {
                    zero = '0';
                }
                else
                {
                    zero = '\0';
                }
                total++;

            }
            pagenum = 1;
            for (int i = 0; i < chapters.Count; i++)
            {
                if (chapters[i].ID_Chapter == thisChapters.ID_Chapter)
                {

                    path = @"pack://application:,,,/BO1O-1K MATH;component/Lectures/" + thisThemes.Numeration + "/" + thisChapters.Numeration + "/" + thisChapters.Numeration + "-" + zero + pagenum + ".jpg";
                    LecturesPicture.Source = new BitmapImage(new Uri(path));
                    break;
                }
            }
        }
        private void Back_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            frame1.Navigate(new MainMenu(frame1));
        }
        private void Pagenext_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            try
            {
                pagenum++;
                if (pagenum < 10)
                {
                    zero = '0';
                }
                else
                {
                    zero = '\0';
                }
                path = @"pack://application:,,,/BO1O-1K MATH;component/Lectures/" + thisThemes.Numeration + "/" + thisChapters.Numeration + "/" + thisChapters.Numeration + "-" + zero + pagenum + ".jpg";
                LecturesPicture.Source = new BitmapImage(new Uri(path));
            }
            catch
            {
                pagenum = 1;
                zero = '0';
                path = @"pack://application:,,,/BO1O-1K MATH;component/Lectures/" + thisThemes.Numeration + "/" + thisChapters.Numeration + "/" + thisChapters.Numeration + "-" + zero + pagenum + ".jpg";
                LecturesPicture.Source = new BitmapImage(new Uri(path));
            }
        }
        private void Pageback_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (pagenum > 1)
            {
                pagenum--;
            }
            else
            {
                pagenum = total;
            }
            if (pagenum < 10)
            {
                zero = '0';
            }
            else
            {
                zero = '\0';
            }
            path = @"pack://application:,,,/BO1O-1K MATH;component/Lectures/" + thisThemes.Numeration + "/" + thisChapters.Numeration + "/" + thisChapters.Numeration + "-" + zero + pagenum + ".jpg";
            LecturesPicture.Source = new BitmapImage(new Uri(path));
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
