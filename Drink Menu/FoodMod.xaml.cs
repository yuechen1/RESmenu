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
			List<ingredient> recipe = new List<ingredient>();
			recipe.Add(new ingredient { name = "Steak", price = "$25.00" });
			recipe.Add(new ingredient { name = "Salt", price = "$0.00" });
			recipe.Add(new ingredient { name = "Pepper", price = "$0.00" });
			recipe.Add(new ingredient { name = "BBQ Sauce", price = "$0.00" });

			Food info = new Drink_Menu.Food { Image1 = null, Image2 = null, ingredients = recipe };
			lbxIngredientList.ItemsSource = recipe;

			string foodDesc = "Cooked medium rare, a staple of the Dancing Shamrock.";
			txtFoodInfo.Text = foodDesc;
			string foodName = "Steak";
			txtFoodName.Text = foodName;
			string allergy = "Non-vegetarian";
			txtAllergies.Text = allergy;
        }

		private void btnModAdd_Click(object sender, RoutedEventArgs e)
		{
			Window4 sidesWindow = new Window4();
			sidesWindow.Show();
		}

		private void btnModBack_Click(object sender, RoutedEventArgs e)
		{
			this.Close();
		}
	}

	public class Food
    {
        public string Image1 { set; get; }
        public string Image2 { set; get; }
        public List<ingredient> ingredients { set; get; }
    }

    public class ingredient
    {
        public string name { set; get; }
        public string price { set; get; }
    }
}
