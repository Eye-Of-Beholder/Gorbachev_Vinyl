using Gorbachev_Vinyl.ClassFolder;
using Gorbachev_Vinyl.PageArtist;
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

namespace Gorbachev_Vinyl.VinylFolder
{
    /// <summary>
    /// Логика взаимодействия для TopVinyl.xaml
    /// </summary>
    public partial class TopVinyl : Window
    {
        public TopVinyl()
        {
            InitializeComponent();
        }



        private void RadioButton_Click(object sender, RoutedEventArgs e)
        {
            new Catalog().Show();
            Close();
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            new PageQueen().Show();
            Close();
        }

        private void RadioButton_Click_1(object sender, RoutedEventArgs e)
        {
            new Catalog().Show();
            Close();
        }

        private void Image_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            new PageAbba().Show();
            Close();
        }

        private void Image_MouseDown_2(object sender, MouseButtonEventArgs e)
        {
            new PageGuns().Show();
            Close();
        }

        private void Image_MouseDown_3(object sender, MouseButtonEventArgs e)
        {
            new PageNirvana().Show();
            Close();
        }

        private void Image_MouseDown_4(object sender, MouseButtonEventArgs e)
        {
            new PageMetallica().Show();
            Close();
        }

        private void Image_MouseDown_5(object sender, MouseButtonEventArgs e)
        {
            new PageBlackSabbath().Show();
            Close();
        }

        private void Image_MouseDown_6(object sender, MouseButtonEventArgs e)
        {
            new PageLed().Show();
            Close();
        }

        private void Image_MouseDown_7(object sender, MouseButtonEventArgs e)
        {
            new PagePinkFloyd().Show();
            Close();
        }

        private void Image_MouseDown_10(object sender, MouseButtonEventArgs e)
        {
            MBClass.ExitMB();
        }

        private void Image_MouseDown_11(object sender, MouseButtonEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }
    }
}
