
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

namespace Gorbachev_Vinyl.AdminUserFolder
{
    /// <summary>
    /// Логика взаимодействия для CabUser.xaml
    /// </summary>
    public partial class CabUser : Window
    {
        public CabUser()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            new OrderWindow().Show();
            Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            new BasketWindow().Show();
            Close();
        }

        private void RadioButton_Click(object sender, RoutedEventArgs e)
        {
            new WindowFolder.Catalog().Show();
            Close();
        }

        private void RadioButton_Click_1(object sender, RoutedEventArgs e)
        {
            new AboutUs().Show();
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
