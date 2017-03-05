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

namespace Drink_Menu
{
    /// <summary>
    /// Interaction logic for Window4.xaml
    /// </summary>
    public partial class Window4 : Window
    {
        public Window4()
        {
            InitializeComponent();
            List<Sides> items = new List<Sides>();
            items.Add(new Sides { Image = null, price = null, Name = "potato1", Image_1 = null, Name_1 = "sasasa", price_1 = "$1.50" });
            items.Add(new Sides { Image = null, price = null, Name = "potato2", Image_1 = null, Name_1 = "cupa", price_1 = "$1.50" });
            items.Add(new Sides { Image = null, price = null, Name = "potato3", Image_1 = null, Name_1 = "sasasa", price_1 = "$1.50" });
            items.Add(new Sides { Image = null, price = "$0.50", Name = "potato4", Image_1 = null, Name_1 = "sasasa", price_1 = "$1.50" });
            items.Add(new Sides { Image = null, price = null, Name = "potato5", Image_1 = null, Name_1 = "sasasa", price_1 = "$1.50" });
        }
    }

    public class Sides
    {
        public string Image { get; set; }
        public string price { get; set; }
        public string Name { get; set; }
        public string Image_1 { get; set; }
        public string price_1 { get; set; }
        public string Name_1 { get; set; }
    }
}
