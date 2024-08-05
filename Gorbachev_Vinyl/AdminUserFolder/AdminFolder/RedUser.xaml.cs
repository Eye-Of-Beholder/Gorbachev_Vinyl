using Gorbachev_Vinyl.ClassFolder;
using Gorbachev_Vinyl.DataFolder;
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

namespace Gorbachev_Vinyl.AdminUserFolder.AdminFolder
{
    /// <summary>
    /// Логика взаимодействия для RedUser.xaml
    /// </summary>
    public partial class RedUser : Window
    {
        public RedUser()
        {
            InitializeComponent();
            LoadUserData();
        }

        private const string ConnectionString = "Data Source=DESKTOP-KI0QVLM\\HOME;Initial Catalog=Vinyl;Integrated Security=True";


        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            new NewUser().Show();
            Close();
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            new AdminWindow().Show();
            Close();
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            if (UserGrid.SelectedItem != null && UserGrid.SelectedItem is User selectedUser)
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(ConnectionString))
                    {
                        connection.Open();
                        string deleteQuery = "DELETE FROM [dbo].[User] WHERE Login = @Login";
                        using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                        {
                            command.Parameters.AddWithValue("@Login", selectedUser.Login);

                            int rowsAffected = command.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Пользователь удален успешно.");
                                LoadUserData(); 
                            }
                            else
                            {
                                MessageBox.Show("Пользователь не найден.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при удалении пользователя: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите пользователя для удаления.");
            }
        }

        private void LoadUserData()
        {
            try
            {
             UserGrid.ItemsSource = DBEntities.getContex().User.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке данных: " + ex.Message);
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
