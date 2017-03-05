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
    /// Interaction logic for Window5.xaml
    /// </summary>
    public partial class Window5 : Window
    {
        public string subtotal = "n//a";
        public string tax = "n//a";

        public Window5()
        {
            InitializeComponent();
            List<Food1> items = new List<Food1>();
            items.Add(new Drink_Menu.Food1 { Name = "Steak", Price = "$25.00" });
            lbxPriceBox.ItemsSource = items;
            view_subtotal.Text = "$25.00";
            view_tax.Text = "$1.25";
            view_finaltotal.Text = "$26.25";
        }

		private void btnBillBack_Click(object sender, RoutedEventArgs e)
		{
			this.Close();
		}
	}

	public class Food1
    {
        public string Name { get; set; }
        public string Price { get; set; }
    }
}
