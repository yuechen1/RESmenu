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
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();

            List<MainWindow.Drinkdisplay> drinkshowcase = new List<MainWindow.Drinkdisplay>();
            int i = 0;
            int tempmax = MainWindow.drinks.Count;
            while( i < tempmax)
            {
                if((i+1) <= tempmax)
                {
                    drinkshowcase.Add(new MainWindow.Drinkdisplay
                    {
                        Image = MainWindow.drinks[i].Image,
                        Name = MainWindow.drinks[i].Name,
                        price12 = MainWindow.drinks[i].price12,
                        price16 = MainWindow.drinks[i].price16,
                        Image_1 = MainWindow.drinks[i + 1].Image,
                        Name_1 = MainWindow.drinks[i + 1].Name,
                        price12_1 = MainWindow.drinks[i + 1].price12,
                        price16_1 = MainWindow.drinks[i + 1].price16
                    });
                }
                else
                {
                    drinkshowcase.Add(new MainWindow.Drinkdisplay
                    {
                        Image = MainWindow.drinks[i].Image,
                        Name = MainWindow.drinks[i].Name,
                        price12 = MainWindow.drinks[i].price12,
                        price16 = MainWindow.drinks[i].price16,
                        Image_1 = null,
                        Name_1 = null,
                        price12_1 = null,
                        price16_1 = null
                    });
                }
                i++;
                i++;
            }
            DrinkBox.ItemsSource = drinkshowcase;
            
        }

        private void DrinkBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button k = (Button)sender;
            MainWindow.Drinkdisplay drink = k.DataContext as MainWindow.Drinkdisplay;

            Window2 tempWindow = new Drink_Menu.Window2(drink.Name);
            tempWindow.Show();
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            Button k = (Button)sender;
            MainWindow.Drinkdisplay drink = k.DataContext as MainWindow.Drinkdisplay;

            Window2 tempWindow = new Drink_Menu.Window2(drink.Name_1);
            tempWindow.Show();
        }
    }
}
