﻿using Gorbachev_Vinyl.AdminUserFolder;
using Gorbachev_Vinyl.ClassFolder;
using Gorbachev_Vinyl.ClassicFolder;
using Gorbachev_Vinyl.DataFolder;
using Gorbachev_Vinyl.WindowFolder;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
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
  

namespace Gorbachev_Vinyl.PageArtist        
{
    /// <summary>      
    /// Логика взаимодействия для Abba.xaml     
    /// </summary>
    public partial class Abba : Window
    {
        
        public DataGrid BasketGrid { get; private set; }

        public Abba()
        {
            InitializeComponent();
            BasketGrid = new DataGrid();
        }
        ConnectionStringClass connectionStringClass;

        public class ConnectionStringClass
        {
            public string ConnectionString { get; } = "Data Source=DESKTOP-KI0QVLM\\HOME;Initial Catalog=Vinyl;Integrated Security=True";
        }


        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            new ClassicWindow().Show();
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
                    Format = LP.Text,
                    Quantity = 1,
                    TotalPrice = Convert.ToDecimal(SUMP.Text),
                    
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

