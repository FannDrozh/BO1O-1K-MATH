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

namespace BO1O_1K_MATH.Pages
{
    /// <summary>
    /// Логика взаимодействия для MainMenu.xaml
    /// </summary>
    public partial class MainMenu : Page
    {
        public Frame frame1;
        List<Themes> themes = new List<Themes>();
        public MainMenu(Frame frame)
        {
            InitializeComponent();
            frame = frame1;
            themes = KTP_Matematika_BarashenkovEntities.GetContext().Themes.ToList();
            LViewThemes.Items.Clear(); 
            LViewThemes.ItemsSource = themes;
        }

        private void LViewThemes_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var currentChapter = KTP_Matematika_BarashenkovEntities.GetContext().Chapters.ToList();
            var track = ((ListView)sender).SelectedValue as Themes;
            LViewThemes.Visibility = Visibility.Hidden;
            LViewChapter.Visibility = Visibility.Visible;
            for (int i = 0; i < currentChapter.Count; i++)
            {
                if (currentChapter[i].ID_theme != track.ID_Theme)
                {
                    currentChapter.RemoveAt(i);
                    i--;
                }
            }
            LViewChapter.ItemsSource = currentChapter.ToList();
        }

        private void LViewChapter_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

        }
    }
}
