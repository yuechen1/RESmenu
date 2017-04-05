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
    /// Interaction logic for Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        public Page2()
        {
            InitializeComponent();

            List<Fooddisplay> meals = new List<Fooddisplay>();
            int i = 0;
            int tempmax = MainWindow.food.Count;
            while (i < tempmax)
            {
                if ((i + 1) <= tempmax)
                {
                    meals.Add(new Fooddisplay(
                        MainWindow.food[i].Image1,
                        MainWindow.food[i].name,
                        MainWindow.food[i].price,
                        String.Join(", ", MainWindow.food[i].ingrendientlist()),
                        MainWindow.food[i+1].Image1,
                        MainWindow.food[i+1].name,
                        MainWindow.food[i+1].price,
                        String.Join(", ", MainWindow.food[i+1].ingrendientlist())
                        ));
                }
                else
                {

                    meals.Add(new Fooddisplay(
                        MainWindow.food[i].Image1,
                        MainWindow.food[i].name,
                        MainWindow.food[i].price,
                        String.Join(", ", MainWindow.food[i].ingrendientlist()),
                        null,
                        null,
                        null,
                        null
                        ));
                }
                i++;
                i++;
            }


            FoodBox.ItemsSource = meals;
        }



        public class Fooddisplay
        {
            public Fooddisplay(ImageSource a, string b, string c, string d, ImageSource e, string f, string g, string h)
            {
                this.Image = a;
                this.Name = b;
                this.price = c;
                this.ingredentlist = d;
                this.Image_1 = e;
                this.Name_1 = f;
                this.price_1 = g;
                this.ingredentlist_1 = h;
            }

            public ImageSource Image { get; set; }
            public string Name { get; set; }
            public string price { get; set; }
            public string ingredentlist { get; set; }
            public ImageSource Image_1 { get; set; }
            public string Name_1 { get; set; }
            public string price_1 { get; set; }
            public string ingredentlist_1 { get; set; }
        }


        private void item_Click(object sender, RoutedEventArgs e)
        {
            Button k = (Button)sender;
            Fooddisplay food = k.DataContext as Fooddisplay;

            Window1 tempWindow = new Drink_Menu.Window1(food.Name);
            tempWindow.Show();
        }

        private void item1_Click(object sender, RoutedEventArgs e)
        {
            Button k = (Button)sender;
            Fooddisplay food = k.DataContext as Fooddisplay;

            Window1 tempWindow = new Drink_Menu.Window1(food.Name_1);
            tempWindow.Show();
        }
    }
}
