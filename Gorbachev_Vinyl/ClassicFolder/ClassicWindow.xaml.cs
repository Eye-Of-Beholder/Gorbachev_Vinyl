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

namespace Gorbachev_Vinyl.ClassicFolder
{
    /// <summary>
    /// Логика взаимодействия для ClassicWindow.xaml
    /// </summary>
    public partial class ClassicWindow : Window
    {
        public ClassicWindow()
        {
            InitializeComponent();
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            new Beatles1().Show();
            Close();
        }

        private void Image_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            new Beatles().Show();
            Close();
        }

        private void Image_MouseDown_2(object sender, MouseButtonEventArgs e)
        {
            new BeeGees().Show();
            Close();
        }

        private void Image_MouseDown_3(object sender, MouseButtonEventArgs e)
        {
            new ACDC().Show();
            Close();
        }

        private void Image_MouseDown_4(object sender, MouseButtonEventArgs e)
        {
            new Abba().Show();
            Close();
        }

        private void Image_MouseDown_5(object sender, MouseButtonEventArgs e)
        {
            new Madonna().Show();
            Close();
        }

        private void Image_MouseDown_6(object sender, MouseButtonEventArgs e)
        {
            new Enigma().Show();
            Close();
        }

        private void Image_MouseDown_7(object sender, MouseButtonEventArgs e)
        {
            new Queen().Show();
            Close();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            new Catalog().Show();
            Close ();
        }

        private void Image_MouseDown_8(object sender, MouseButtonEventArgs e)
        {
            MBClass.ExitMB();
        }

        private void Image_MouseDown_9(object sender, MouseButtonEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }
    }
}
