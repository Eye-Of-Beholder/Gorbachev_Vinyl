using Gorbachev_Vinyl.ClassFolder;
using Gorbachev_Vinyl.DataFolder;
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

namespace Gorbachev_Vinyl.AdminUserFolder.AdminFolder
{
    /// <summary>
    /// Логика взаимодействия для OrdersAdmin.xaml
    /// </summary>
    public partial class OrdersAdmin : Window
    {
        public OrdersAdmin()
        {
            InitializeComponent();

            adminOrder.ItemsSource = DBEntities.getContex().Orders
            .ToList().OrderBy(u => u.Artist);

            TBPrice.Text = adminOrder.Items.OfType<Orders>().Sum(u => u.TotalPrice).ToString();
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            new AdminWindow().Show();
            Close();
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            Orders orders = adminOrder.SelectedItem as Orders;

            if (adminOrder.SelectedItem == null)
            {
                MBClass.ErrorMB("Выберите товар" +
                    " для удаления");
            }
            else
            {
                if (MBClass.QuestionMB("Удалить " +
                    $"товар?"))
                {
                    DBEntities.getContex().Orders
                        .Remove(adminOrder.SelectedItem as Orders);
                    DBEntities.getContex().SaveChanges();
                    MBClass.InfoMB("Товар удален");
                    adminOrder.ItemsSource = DBEntities.getContex()
                        .Orders.ToList().OrderBy(u => u.OrdersID);
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
