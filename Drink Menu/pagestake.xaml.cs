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

            List<Drinkdisplay> meals = new List<Drinkdisplay>();
            meals.Add(new Drinkdisplay { Image = null, Name = "Steak", price12 = "25.00", Name_1 = "other food", Image_1 = null, price12_1 = "15.00" });
            meals.Add(new Drinkdisplay { Image = null, Name = "food", price12 = "25.00", Name_1 = "other food", Image_1 = null, price12_1 = "15.00" });
            meals.Add(new Drinkdisplay { Image = null, Name = "food", price12 = "25.00", Name_1 = "other food", Image_1 = null, price12_1 = "15.00" });
            meals.Add(new Drinkdisplay { Image = null, Name = "food", price12 = "25.00", Name_1 = "other food", Image_1 = null, price12_1 = "15.00" });
            FoodBox.ItemsSource = meals;
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

        private void FoodBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Window1 tempWindow = new Drink_Menu.Window1();
            tempWindow.Show();
        }
    }
}
