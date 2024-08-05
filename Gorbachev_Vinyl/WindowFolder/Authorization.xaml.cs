using Gorbachev_Vinyl.AdminUserFolder;
using Gorbachev_Vinyl.AdminUserFolder.AdminFolder;
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

namespace Gorbachev_Vinyl.WindowFolder
{
    /// <summary>
    /// Логика взаимодействия для Authorization.xaml
    /// </summary>
    public partial class Authorization : Window
    {
        public Authorization()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            new Registration().Show();
            Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            new Registration().Show();
            Close();
        }


        private void Enter_Click_1(object sender, RoutedEventArgs e)
        {
            try 
            { var user = DBEntities.getContex().User.FirstOrDefault(u => u.Login == ButLog.Text);
                if(user ==  null || user.Password != ButPas.Password)
                {
                    MessageBox.Show("Неверный логин или пароль", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
                switch (user.RoleID)
                {
                    case 1: new AdminWindow().Show();
                            Close(); ;
                        break;

                    case 2 : new Catalog().Show();
                        VerybleClass.UserId = user.UserID;
                        Close();
                        break;
                }
                

            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void ButLog_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MBClass.ExitMB();
        }

        private void Image_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void Image_MouseDown_2(object sender, MouseButtonEventArgs e)
        {

        }

        private void Image_MouseDown_3(object sender, MouseButtonEventArgs e)
        {

        }
    }
}
