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
            List<DrinkItem> items = new List<DrinkItem>();
            items.Add(new DrinkItem { Image = null, DrinkName = "suger water", price12 = "8.00", price16 = "10.00"});
            items.Add(new DrinkItem { Image = null, DrinkName = "Water", price12 = "8.00", price16 = "10.00" });
            DrinkBox.ItemsSource = items;
        }

        public class DrinkItem
        {
            public string Image { get; set; }
            public string DrinkName { get; set; }
            public string price12 { get; set; }
            public string price16 { get; set; }
        }
    }
}
