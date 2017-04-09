using System;
using System.Collections;
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
        public List<ShowFood> items = new List<ShowFood>();

        public Window5()
        {
            InitializeComponent();
            //add all drink items
            foreach (MainWindow.DrinkItem i in MainWindow.orderedDrinks)
            {
                if (i.issmall)
                {
                    this.items.Add(new ShowFood(i.Name, i.price12));
                }
                else
                {
                    this.items.Add(new ShowFood(i.Name, i.price16));
                }
            }

            List<MainWindow.ingredient> tempuse;
            for(int numfood = 0; numfood < MainWindow.orderedFood.Count; numfood++)
            {
                this.items.Add(new ShowFood(MainWindow.orderedFood[numfood].name, MainWindow.orderedFood[numfood].price));
                tempuse = MainWindow.orderedFood[numfood].remove;
                foreach(MainWindow.ingredient i in tempuse)
                {
                    this.items.Add(new ShowFood("\tNo " + i.name, i.price));
                }
                tempuse = MainWindow.orderedFood[numfood].add;
                foreach (MainWindow.ingredient i in tempuse)
                {
                    this.items.Add(new ShowFood("\tAdd " + i.name, i.price));
                }
                this.items.Add(new ShowFood("\t" + MainWindow.orderedSides[numfood].name, MainWindow.orderedSides[numfood].price));
            }

            double tempprice = 0;
            double temptax;
            double tempfinal;

            foreach(ShowFood i in items)
            {
                if(i.Price != null)
                {
                    tempprice = tempprice + Double.Parse(i.Price);
                }
            }
            temptax = Math.Round(tempprice * 0.05, 2);
            tempfinal = temptax + tempprice;

            lbxPriceBox.ItemsSource = this.items;

            view_subtotal.Text = tempprice.ToString();
            view_tax.Text = temptax.ToString();
            view_finaltotal.Text = tempfinal.ToString();
        }

		private void btnBillBack_Click(object sender, RoutedEventArgs e)
		{
			this.Close();
		}

        private void btnCash_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("A Waiter is on the way with.");
        }

        private void btnCard_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("A Waiter is on the way with a payment machine. Please wait");
        }
    }

    public class ShowFood
    {
        public ShowFood(string a, string b)
        {
            this.Name = a;
            this.Price = b;
        }

        public string Name { get; set; }
        public string Price { get; set; }
    }
}
