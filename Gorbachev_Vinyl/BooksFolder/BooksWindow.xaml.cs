using Gorbachev_Vinyl.BooksFolder.BookPage;
using Gorbachev_Vinyl.ClassFolder;
using Gorbachev_Vinyl.WindowFolder;
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
using System.Windows.Shapes;

namespace Gorbachev_Vinyl.BooksFolder
{
    /// <summary>
    /// Логика взаимодействия для BooksWindow.xaml
    /// </summary>
    public partial class BooksWindow : Window
    {
        public BooksWindow()
        {
            InitializeComponent();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            new Catalog().Show();
            Close();
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            new RockCovers().Show();
            Close() ;
        }

        private void Image_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            new QueenBook().Show();
                Close();
        }

        private void Image_MouseDown_2(object sender, MouseButtonEventArgs e)
        {
            new Lenon().Show();
            Close();
        }

        private void Image_MouseDown_3(object sender, MouseButtonEventArgs e)
        {
            new Yanka().Show();
            Close();
        }

        private void Image_MouseDown_4(object sender, MouseButtonEventArgs e)
        {
            new Kish().Show();
            Close();
        }

        private void Image_MouseDown_5(object sender, MouseButtonEventArgs e)
        {
            new Nirvana().Show();
            Close();
        }

        private void Image_MouseDown_6(object sender, MouseButtonEventArgs e)
        {
            new Letov().Show();
            Close();
        }

        private void Image_MouseDown_7(object sender, MouseButtonEventArgs e)
        {
            new Korn().Show();
            Close();
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            new AboutUs().Show();
            Close();
        }

        private void RadioButton_Checked_2(object sender, RoutedEventArgs e)
        {
            new Catalog().Show();
            Close();
        }

        private void Image_MouseDown_8(object sender, MouseButtonEventArgs e)
        {
            MBClass.ExitMB();

        }

        private void Image_MouseDown_9(object sender, MouseButtonEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }
    }
}
