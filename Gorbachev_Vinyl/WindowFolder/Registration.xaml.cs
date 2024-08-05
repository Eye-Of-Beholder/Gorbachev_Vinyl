using Gorbachev_Vinyl.ClassFolder;
using System;
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
using System.Windows.Shapes;

namespace Gorbachev_Vinyl.WindowFolder
{
    /// <summary>
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Window
    {
        public Registration()
        {
            InitializeComponent();
        }

        private string connectionString = ConnectionStringClass.ConnectionLine;


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            new Authorization().Show();
            Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            
        }

        private void Enter_Click(object sender, RoutedEventArgs e)
        {
            string username = ButLog.Text;
            string password = ButPas.Password;
            string confirmPassword = DobButPas.Password;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Пожалуйста, заполните все поля.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Пароли не совпадают.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

              
                string checkUserQuery = "SELECT COUNT(*) FROM [User] WHERE [Login] = @Username";
                using (SqlCommand checkUserCmd = new SqlCommand(checkUserQuery, connection))
                {
                    checkUserCmd.Parameters.AddWithValue("@Username", username);
                    int existingUsersCount = (int)checkUserCmd.ExecuteScalar();

                    if (existingUsersCount > 0)
                    {
                        MessageBox.Show("Пользователь с таким логином уже существует.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                        return;
                    }
                }

                
                string registerUserQuery = "INSERT INTO [User] ([Login], [Password], [RoleID]) VALUES (@Username, @Password, @RoleID)";
                using (SqlCommand registerUserCmd = new SqlCommand(registerUserQuery, connection))
                {
                    registerUserCmd.Parameters.AddWithValue("@Username", username);
                    registerUserCmd.Parameters.AddWithValue("@Password", password);
                    registerUserCmd.Parameters.AddWithValue("@RoleID", 2); 

                    int rowsAffected = registerUserCmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Пользователь зарегистрирован успешно.", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                    else
                    {
                        MessageBox.Show("Ошибка при регистрации пользователя.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
            }
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void Image_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            MBClass.ExitMB();
        }
    }
}
