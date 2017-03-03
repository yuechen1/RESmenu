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
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }
    }

    public class Food
    {
        public string Image1 { set; get; }
        public string Image2 { set; get; }
        public List<ingredient> ingredients = new List<ingredient>();
    }

    public class ingredient
    {
        public string name { set; get; }
        public string price { set; get; }
    }
}
