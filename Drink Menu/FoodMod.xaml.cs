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
using System.ComponentModel;

namespace Drink_Menu
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        MainWindow.FoodItem k;
        BindingList<MainWindow.ingredient> currentrecipe = new BindingList<MainWindow.ingredient>();
        BindingList<MainWindow.ingredient> addrecipe = new BindingList<MainWindow.ingredient>();

        public Window1(string name)
        {
            InitializeComponent();


            //pull the food item from MainWindow based on name
            foreach (MainWindow.FoodItem i in MainWindow.food)
            {
                if (String.Compare(i.name, name) == 0)
                {
                    this.k = i.copy();
                    break;
                }
            }

            //get a copy of the full ingredent list
            foreach(MainWindow.ingredient i in MainWindow.fulllist)
            {
                this.addrecipe.Add(i);
            }

            IngredientList.ItemsSource = this.addrecipe;
            
            //pull the new ingredent list

            foreach(MainWindow.ingredient i in k.ingredients)
            {
                this.currentrecipe.Add(i);
            }
            lbxIngredientList.ItemsSource = this.currentrecipe;

            image1.Source = k.Image1;
            image2.Source = k.Image2;
			string foodDesc = "Cooked medium rare, a staple of the Dancing Shamrock.";
			txtFoodInfo.Text = foodDesc;
			txtFoodName.Text = k.name;
			txtAllergies.Text = String.Join(", ", k.ingrendientlist());
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

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Window3 sideWindow = new Drink_Menu.Window3();
            sideWindow.Show();
        }

        private void something_Click(object sender, RoutedEventArgs e)
        {
            Button k = (Button)sender;
            MainWindow.ingredient food = k.DataContext as MainWindow.ingredient;

            foreach (MainWindow.ingredient i in this.currentrecipe)
            {
                if (i.Equals(food))
                {
                    this.currentrecipe.Remove(i);
                    this.k.removeingredient(i);
                    break;
                }
            }
        }

        private void btnFoodAddAccept_Click(object sender, RoutedEventArgs e)
        {
            Addmenu.Height = 0;
        }

        private void btnFoodAddBack_Click(object sender, RoutedEventArgs e)
        {

            foreach (MainWindow.ingredient i in this.addrecipe)
            {

                if(i.check)
                {
                    i.check = false;
                    this.addrecipe.Remove(i);
                    this.currentrecipe.Add(i);
                    this.k.addingredient(i);
                }
            }
            Addmenu.Height = 0;
        }

        private void button_Click_1(object sender, RoutedEventArgs e)
        {
            Addmenu.Height = 637;
        }
    }

}
