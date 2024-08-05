using Gorbachev_Vinyl.ClassFolder;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
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
using Gorbachev_Vinyl.DataFolder;
using Gorbachev_Vinyl.WindowFolder;

namespace Gorbachev_Vinyl.AdminUserFolder
{
    /// <summary>
    /// Логика взаимодействия для BasketWindow.xaml
    /// </summary>
    public partial class BasketWindow : Window
    {


        public BasketWindow()
        {
            InitializeComponent();
            BasketGrid.ItemsSource = DBEntities.getContex().Basket.Where(u => u.IdUser == VerybleClass.UserId)
            .ToList().OrderBy(u => u.Artist);

            TBPrice.Text = BasketGrid.Items.OfType<Basket>().Sum(u => u.TotalPrice).ToString();
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            new OrderWindow().Show();
            Close();
        }

        

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            new Catalog().Show();
            Close();
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            new AboutUs().Show();
            Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var items = BasketGrid.Items.OfType<Basket>().ToArray();

            foreach (var item in items)
            {
                DBEntities.getContex().Orders.Add(new Orders()
                {
                    UserID = item.IdUser,
                    Album = item.Album,
                    Artist = item.Artist,
                    Format = item.Format,
                    Quantity = item.Quantity,
                    TotalPrice = item.TotalPrice,

                });
                DBEntities.getContex().Basket.Remove(item);
            }


            DBEntities.getContex().SaveChanges();

           
            MessageBox.Show("Заказ оформлен!", "Успешно");
            BasketGrid.ItemsSource = DBEntities.getContex().Basket
            .ToList().OrderBy(u => u.Artist);
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Basket basket = BasketGrid.SelectedItem as Basket;

            if (BasketGrid.SelectedItem == null)
            {
                MBClass.ErrorMB("Выберите товар" +
                    " для удаления");
            }
            else
            {
                if (MBClass.QuestionMB("Удалить " +
                    $"товар?"))
                {
                    DBEntities.getContex().Basket
                        .Remove(BasketGrid.SelectedItem as Basket);
                    DBEntities.getContex().SaveChanges();
                    MBClass.InfoMB("Товар удален");
                    BasketGrid.ItemsSource = DBEntities.getContex()
                        .Basket.ToList().OrderBy(u => u.IdBasket);
                }
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




 