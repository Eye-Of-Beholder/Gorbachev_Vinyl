
using Gorbachev_Vinyl.AdminUserFolder;
using Gorbachev_Vinyl.BooksFolder;
using Gorbachev_Vinyl.ClassFolder;
using Gorbachev_Vinyl.ClassicFolder;
using Gorbachev_Vinyl.VinylFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace Gorbachev_Vinyl.WindowFolder
{
    /// <summary>
    /// Логика взаимодействия для Catalog.xaml
    /// </summary>
    public partial class Catalog : Window
    {
        public Catalog()
        {
            InitializeComponent();

        }
        


        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            new TopVinyl().Show();
            Close();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Вы действительно желаете выйти?", "Подтверждение выхода", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (result == MessageBoxResult.Yes)
            {
                
               Close();
            }
        }

        private void RadioButton_Click(object sender, RoutedEventArgs e)
        {
            new AboutUs().Show();
            Close();
        }

        private void RadioButton_Click_1(object sender, RoutedEventArgs e)
        {
            new Registration().Show();
            Close();
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            new Registration().Show();
            Close();
        }

        private void Border_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            new ClassicWindow().Show();
            Close();
        }

        private void Border_MouseDown_2(object sender, MouseButtonEventArgs e)
        {
            new BooksWindow().Show();
            Close();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            new CabUser().Show();
            Close();
        }

        private void Image_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void Image_MouseDown_2(object sender, MouseButtonEventArgs e)
        {
            MBClass.ExitMB();
        }
    }
}
