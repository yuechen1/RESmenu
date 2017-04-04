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
    /// Interaction logic for Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        public Window3()
        {
            InitializeComponent();
            List<MainWindow.ingredient> recipe = new List<MainWindow.ingredient>();
            recipe.Add(new MainWindow.ingredient("Salt", "$0.00"));
            recipe.Add(new MainWindow.ingredient("Pepper", "$0.00"));
            recipe.Add(new MainWindow.ingredient("BBQ Sauce", "$0.00"));
            lbxIngredientList.ItemsSource = recipe;
        }

		private void btnFoodAddBack_Click(object sender, RoutedEventArgs e)
		{
			this.Close();
		}
	}
}
