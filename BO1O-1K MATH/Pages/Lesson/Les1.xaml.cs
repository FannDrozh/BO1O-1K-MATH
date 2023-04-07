using BO1O_1K_MATH.BD;
using System;
using System.Collections.Generic;
using System.IO.Packaging;
using System.Linq;
using System.Security.Policy;
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
using System.Windows.Xps.Packaging;

namespace BO1O_1K_MATH.Pages.Lesson
{
    /// <summary>
    /// Логика взаимодействия для Les1.xaml
    /// </summary>
    public partial class Les1 : Page
    {
        public Frame frame1;
        Chapters thisChapters;
        List<Chapters> chapters = new List<Chapters>();
        public Les1(Frame frame, Chapters chapter)
        {
            InitializeComponent();
            frame1 = frame;
            thisChapters = chapter;
            chapters = KTP_Matematika_BarashenkovEntities.GetContext().Chapters.ToList();
            //try
            //{
                for (int i = 0; i < chapters.Count; i++)
                {
                    if (chapters[i].ID_Chapter == thisChapters.ID_Chapter)
                    {
                    //xps file
                    //var uri = new Uri("pack://application:,,,/..\\..\\documents\\" + chapters[i].Chapter + ".xps");
                    //var stream = Application.GetResourceStream(uri).Stream;
                    //Package package = Package.Open(stream);
                    //PackageStore.AddPackage(uri, package);
                    //var xpsDoc = new XpsDocument(package, CompressionOption.Maximum, uri.AbsoluteUri);
                    //var fixedDocumentSequence = xpsDoc.GetFixedDocumentSequence();
                    //docContent.Document = fixedDocumentSequence; // displaying document in viewer
                    //xpsDoc.Close();
                    //pdf file
                        string filePatch = @"file:///" + @"BO1O-1K MATH/Documents/" + chapters[i].Chapter + @".pdf";
                        Uri url = new Uri(filePatch);
                        webBrowser1.Navigate(url);
                        //System.Windows.Xps.Packaging.XpsDocument doc
                        //   = new System.Windows.Xps.Packaging.XpsDocument(
                        //   "..\\..\\Documents\\" + chapters[i].Chapter + ".xps", System.IO.FileAccess.Read);
                        //docContent.Document = doc.GetFixedDocumentSequence();
                        break;
                    }
                }
            //}
            //catch 
            //{
            //    MessageBoxResult messageBoxResult = MessageBox.Show("Тема в разработке! Ждите следующего обновления!", "Внимание!", MessageBoxButton.OK, MessageBoxImage.Information);
            //}
        }

        private void Back_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            frame1.Navigate(new MainMenu(frame1));
        }
    }
}
