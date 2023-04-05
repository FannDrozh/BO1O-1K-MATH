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
            for(int i = 0; i < chapters.Count; i++)
            {
                if (chapters[i].ID_Chapter == thisChapters.ID_Chapter)
                {
                    if (chapters[i].ID_Chapter == 1)
                    {
                        System.Windows.Xps.Packaging.XpsDocument doc
                        = new System.Windows.Xps.Packaging.XpsDocument(
                        "..\\..\\Documents\\Математика-в-науке_-технике_-экономике_-информационных-технологиях-и-практической-деятельности.xps", System.IO.FileAccess.Read);
                        docContent.Document = doc.GetFixedDocumentSequence();
                    }
                    else if (chapters[i].ID_Chapter == 2)
                    {
                        System.Windows.Xps.Packaging.XpsDocument doc
                        = new System.Windows.Xps.Packaging.XpsDocument(
                        "..\\..\\Documents\\Theme 1-1\\Натуральные, целые, рациональные и иррациональные числа.xps", System.IO.FileAccess.Read);
                        docContent.Document = doc.GetFixedDocumentSequence();
                    }
                    else if (chapters[i].ID_Chapter == 3)
                    {
                        System.Windows.Xps.Packaging.XpsDocument doc
                        = new System.Windows.Xps.Packaging.XpsDocument(
                        "..\\..\\Documents\\Theme 1-1\\Понятие-предела.-Бесконечно-убывающая-геометрическая-прогрессия.xps", System.IO.FileAccess.Read);
                        docContent.Document = doc.GetFixedDocumentSequence();
                    }
                    else if (chapters[i].ID_Chapter == 4)
                    {
                        System.Windows.Xps.Packaging.XpsDocument doc
                        = new System.Windows.Xps.Packaging.XpsDocument(
                        "..\\..\\Documents\\Theme 1-2\\Арифметический-корень-натуральной-степени.xps", System.IO.FileAccess.Read);
                        docContent.Document = doc.GetFixedDocumentSequence();
                    }
                    else if (chapters[i].ID_Chapter == 6)
                    {
                        System.Windows.Xps.Packaging.XpsDocument doc
                        = new System.Windows.Xps.Packaging.XpsDocument(
                        "..\\..\\Documents\\Theme 1-2\\Степенная-функция_-ее-свойства-и-график.xps", System.IO.FileAccess.Read);
                        docContent.Document = doc.GetFixedDocumentSequence();
                    }
                    else
                    {
                        MessageBoxResult messageBoxResult = MessageBox.Show("Тема в разработке! Ждите следующего обновления!","Внимание!", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
            }
            

        }

        private void Back_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            frame1.Navigate(new MainMenu(frame1));
        }
    }
}
