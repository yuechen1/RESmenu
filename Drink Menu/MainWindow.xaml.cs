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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Drink_Menu
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public class Drinkdisplay
        {
            public string Image { get; set; }
            public string Name { get; set; }
            public string price12 { get; set; }
            public string price16 { get; set; }
            public string Image_1 { get; set; }
            public string Name_1 { get; set; }
            public string price12_1 { get; set; }
            public string price16_1 { get; set; }
        }

        public class DrinkItem
        {
            public string Image { get; set; }
            public string Name { get; set; }
            public string price12 { get; set; }
            public string price16 { get; set; }
        }

        private void btnCall_Click(object sender, RoutedEventArgs e)
        {
			MessageBox.Show("Waitstaff has been notified.", "Please wait");
        }

        private void btnBill_Click(object sender, RoutedEventArgs e)
        {
            Window5 tempwindow = new Window5();
            tempwindow.Show();
        }

        private void menuSelector_Click(object sender, RoutedEventArgs e)
        {
            Menushow.Width = 470;
        }

        private void quitmenu_Click(object sender, RoutedEventArgs e)
        {
            Menushow.Width = 0;
        }

        private void DrinkMain_Click(object sender, RoutedEventArgs e)
        {
            DrinkMain.IsEnabled = false;
            DrinkMain_text.Opacity = 70;
            DinnerMain.IsEnabled = true;
            DinnerMain_text.Opacity = 100;
            BurgerMain.IsEnabled = true;
            BurgerMain_text.Opacity = 100;
            pagename_drinkpage.Height = 670;
            pagename_stackpage.Height = 0;
        }

        private void DinnerMain_Click(object sender, RoutedEventArgs e)
        {
            DrinkMain.IsEnabled = true;
            DrinkMain_text.Opacity = 100;
            DinnerMain.IsEnabled = false;
            DinnerMain_text.Opacity = 70;
            BurgerMain.IsEnabled = true;
            BurgerMain_text.Opacity = 100;
            pagename_stackpage.Height = 670;
            pagename_drinkpage.Height = 0;
        }

        private void BurgerMain_Click(object sender, RoutedEventArgs e)
        {
            DrinkMain.IsEnabled = true;
            DrinkMain_text.Opacity = 100;
            DinnerMain.IsEnabled = true;
            DinnerMain_text.Opacity = 100;
            BurgerMain.IsEnabled = false;
            BurgerMain_text.Opacity = 70;
        }

        private void pagename_SourceUpdated(object sender, DataTransferEventArgs e)
        {

        }
    }
}
