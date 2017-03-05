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
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
			List<DrinkData> liquids = new List<DrinkData>();
			liquids.Add(new Drink_Menu.DrinkData { drinkImage = null, drinkName = "Water", drinkDescription = "H2O." });

			//			txtDrinkName.Text = liquids. .drinkName.get();
			txtDrinkName.Text = "Water";
			txtDrinkInfo.Text = "H2O.";
        }

		private void btnDrinkBack_Click(object sender, RoutedEventArgs e)
		{
			this.Close();
		}
	}

	public class DrinkData
	{
		public string drinkImage { get; set; }
		public string drinkName { get; set; }
		public string drinkDescription { get; set; }
	}
}
