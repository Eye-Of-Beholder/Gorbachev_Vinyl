using Gorbachev_Vinyl.AdminUserFolder;
using Gorbachev_Vinyl.ClassFolder;
using Gorbachev_Vinyl.DataFolder;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Gorbachev_Vinyl.BooksFolder.BookPage
{
    /// <summary>
    /// Логика взаимодействия для Lenon.xaml
    /// </summary>
    public partial class Lenon : Window
    {
        public Lenon()
        {
            InitializeComponent();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            new BooksWindow().Show();
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DBEntities.getContex().Basket.Add(new Basket()
                {
                    IdBasket = 2,
                    IdUser = VerybleClass.UserId,
                    Artist = Artist.Text,
                    Album = Album.Text,
                    Format = Format.Text,
                    Quantity = 1,
                    TotalPrice = Convert.ToDecimal(Sum.Text),

                });
                DBEntities.getContex().SaveChanges();
                MessageBox.Show("Товар добавлен");
                NavigationService.GetNavigationService(new BasketWindow());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MBClass.ExitMB();

        }

        private void Image_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }
    }
}
