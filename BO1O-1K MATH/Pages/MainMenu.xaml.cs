using BO1O_1K_MATH.BD;
using BO1O_1K_MATH.Pages;
using Path = System.IO.Path;
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
using System.IO;
using BO1O_1K_MATH.Pages.Practice.Lab;

namespace BO1O_1K_MATH.Pages
{
    /// <summary>
    /// Логика взаимодействия для MainMenu.xaml
    /// </summary>
    public partial class MainMenu : Page
    {
        public Frame frame1;
        List<Themes> themes = new List<Themes>();
        public BO1O_1K_MATH.BD.Chapters trackC;
        public BO1O_1K_MATH.BD.Themes trackT;


        public MainMenu(Frame frame)
        {
            InitializeComponent();
            frame1 = frame;
            themes = KTP_Matematika_BarashenkovEntities.GetContext().Themes.ToList();
            LViewThemes.Items.Clear(); 
            LViewThemes.ItemsSource = themes;
        }
        private void LViewThemes_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var currentChapter = KTP_Matematika_BarashenkovEntities.GetContext().Chapters.ToList();
            trackT = ((ListView)sender).SelectedValue as Themes;
            LViewThemes.Visibility = Visibility.Hidden;
            LViewChapter.Visibility = Visibility.Visible;
            Back.Visibility = Visibility.Visible;
            Pract.Visibility = Visibility.Visible;
            for (int i = 0; i < currentChapter.Count; i++)
            {
                if (currentChapter[i].ID_theme != trackT.ID_Theme)
                {
                    currentChapter.RemoveAt(i);
                    i--;
                }
            }
            LViewChapter.ItemsSource = currentChapter.ToList();
        }

        public void LViewChapter_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            trackC = ((ListView)sender).SelectedValue as Chapters;
            if (File.Exists(@"../../Lectures/" + trackT.Numeration + "/" + trackC.Numeration + "/" + trackC.Numeration + "-01.jpg"))
            {
                frame1.Navigate(new Lesson(frame1, trackC, trackT));
            }
            else
            {
                MessageBoxResult messageBoxResult = MessageBox.Show("Тема в разработке! Ждите следующего обновления!", "Внимание!", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void Back_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Back.Visibility = Visibility.Hidden;
            Pract.Visibility = Visibility.Hidden;
            LViewChapter.Visibility = Visibility.Hidden;
            LViewThemes.Visibility = Visibility.Visible;
        }

        private void Close_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MessageBoxButton btnMessageBox = MessageBoxButton.YesNo;
            MessageBoxImage imgMessageBox = MessageBoxImage.Question;
            MessageBoxResult boxResult = MessageBox.Show("Вы действительно хотите выйти?","Выход", btnMessageBox, imgMessageBox);
            switch (boxResult)
            {
                case MessageBoxResult.Yes:
                    System.Windows.Application.Current.Shutdown();
                    break; 
                case MessageBoxResult.No:
                    break;
            }
        }
        private void Pract_Click(object sender, RoutedEventArgs e)
        {
            string path = trackT.Numeration;
            switch (path)
            {
                case "1-1":
                    frame1.Navigate(new Lab1_1(frame1, trackT));
                    break;
                default:
                    MessageBox.Show("Практики по данному разделу пока нет!");
                    break;
            }
        }
    }
}
