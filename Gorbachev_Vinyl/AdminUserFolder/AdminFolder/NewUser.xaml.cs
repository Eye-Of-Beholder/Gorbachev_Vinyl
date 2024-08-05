using Gorbachev_Vinyl.ClassFolder;
using Gorbachev_Vinyl.DataFolder;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
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
using System.Xml.Linq;

namespace Gorbachev_Vinyl.AdminUserFolder.AdminFolder
{
    /// <summary>
    /// Логика взаимодействия для NewUser.xaml
    /// </summary>
    public partial class NewUser : Window
    {
        public NewUser()
        {
            InitializeComponent();

            CmbRole.ItemsSource = DBEntities.getContex().Role.ToList();
        }

        private string connectionString = ConnectionStringClass.ConnectionLine;

        private const string ConnectionString = "Data Source=DESKTOP-KI0QVLM\\HOME;Initial Catalog=Vinyl;Integrated Security=True";

        private void save_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                DBEntities.getContex().User.Add(new User()
                {

                    Login = LoginTxb.Text,
                    Password = PassTxb.Text,
                    RoleID = Convert.ToInt32(CmbRole.SelectedValue),

                });
                DBEntities.getContex().SaveChanges();
                MBClass.InfoMB("Сотрудник добавлен");
                
            }
            catch (Exception ex)
            {
                MBClass.ErrorMB(ex);
            }
            //string login = LoginTxb.Text;
            //string password = PassTxb.Text;
            //string role = (CmbRole.SelectedItem as ComboBoxItem)?.Content.ToString();

            //if (!string.IsNullOrEmpty(login) && !string.IsNullOrEmpty(password) && !string.IsNullOrEmpty(role))
            //{
            //    using (SqlConnection connection = new SqlConnection(ConnectionString))
            //    {
            //        connection.Open();
            //        string insertQuery = "INSERT INTO [dbo].[User] (Login, Password, RoleID) VALUES (@Login, @Password, @RoleID)";
            //        using (SqlCommand command = new SqlCommand(insertQuery, connection))
            //        {
            //            command.Parameters.AddWithValue("@Login", login);
            //            command.Parameters.AddWithValue("@Password", password);
            //            command.Parameters.AddWithValue("@RoleID", role == "пользователь" ? 1 : 2); 
            //            command.ExecuteNonQuery();
            //        }
            //        MessageBox.Show("Пользователь добавлен.");
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Пожалуйста, заполните все поля.");
            //}
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            new AdminWindow().Show();
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
