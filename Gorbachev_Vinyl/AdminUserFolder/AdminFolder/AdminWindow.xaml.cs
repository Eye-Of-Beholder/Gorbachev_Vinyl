using Gorbachev_Vinyl.ClassFolder;
using Gorbachev_Vinyl.DataFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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
    /// Логика взаимодействия для AdminWindow.xaml
    /// </summary>
    public partial class AdminWindow : Window
    {
        public AdminWindow()
        {
            InitializeComponent();
        }

        private void Orders_Click(object sender, RoutedEventArgs e)
        {
            new OrdersAdmin().Show();
            Close();
        }

        private void New_User_Click(object sender, RoutedEventArgs e)
        {
            new NewUser().Show();
            Close();
        }

        private void AddWindow_Click(object sender, RoutedEventArgs e)
        {
            new RedUser().Show();
            Close();
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            new WindowFolder.Authorization().Show();
            Close();
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
