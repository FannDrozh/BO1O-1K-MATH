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
        public Les1(Frame frame)
        {
            InitializeComponent();
            frame1 = frame;
            System.Windows.Xps.Packaging.XpsDocument doc
            = new System.Windows.Xps.Packaging.XpsDocument(
            "..\\..\\Documents\\Математика-в-науке_-технике_-экономике_-информационных-технологиях-и-практической-деятельности.xps", System.IO.FileAccess.Read);
            docContent.Document = doc.GetFixedDocumentSequence();

        }
    }
}
