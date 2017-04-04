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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Drink_Menu
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Boolean menuopen = false;

        public static List<DrinkItem> drinks =  new List<DrinkItem>();
        public static List<FoodItem> food = new List<FoodItem>();
        public static List<DrinkItem> orderedDrinks = new List<DrinkItem>();
        public static List<FoodItem> orderedFood = new List<FoodItem>();

        public MainWindow()
        {
            InitializeComponent();
            //add drink items
            drinks.Add(new DrinkItem(null, "Water", "0.00", "0.00", "The best tap water you can find" ));
            drinks.Add(new DrinkItem(null, "Light Beer", "6.50", "8.00", "Genaric light beer" ));
            drinks.Add(new DrinkItem(null, "Beer", "6.50", "8.00", "Some Beer" ));
            drinks.Add(new DrinkItem(null, "Bear", "8.00", "12.00", "Real Bear? I don't know"));
            drinks.Add(new DrinkItem(null, "Red Wine", "12.00", "35.00", "WHY ARE YOU READING THIS?"));
            drinks.Add(new DrinkItem(null, "White Wine", "12.00", "35.00", "DO YOU LOOK AT EVERY SINGLE ONE?"));
            drinks.Add(new DrinkItem(null, "Drink 1", "7.00", "9.00", "WHY AM I EVEN WRITING THESE"));
            drinks.Add(new DrinkItem(null, "Moonshine", "6.50", "8.50", "NO HOPE IN HERE"));
            drinks.Add(new DrinkItem(null, "Banana Flush", "5.50", "10.00", "I DON\'T EVEN KNOW WHAT TO WRITE"));
            drinks.Add(new DrinkItem(null, "Drink 2", "3.00", "5.00", "ARE THERE EVEN MORE THAN 10 DRINKS?"));
            drinks.Add(new DrinkItem(null, "Almost Out of Ideas", "30.00", "50.00", "WHAT DO PEOPLE THINK ABOUT WHEN DRINKING?"));
            drinks.Add(new DrinkItem(null, "Out of Ideas", "60.00", "120.00", "THIS IS THE LAST ONE"));



        }

        public class Drinkdisplay
        {

            public ImageSource Image { get; set; }
            public string Name { get; set; }
            public string price12 { get; set; }
            public string price16 { get; set; }
            public ImageSource Image_1 { get; set; }
            public string Name_1 { get; set; }
            public string price12_1 { get; set; }
            public string price16_1 { get; set; }
        }

        public class DrinkItem
        {
            public DrinkItem(ImageSource a, string b, string c, string d, string e)
            {
                this.Image = a;
                this.Name = b;
                this.price12 = c;
                this.price16 = d;
                this.description = e;
                this.issmall = true;
            }

            public ImageSource Image { get; set; }
            public string Name { get; set; }
            public string price12 { get; set; }
            public string price16 { get; set; }
            public string description { get; set; }
            public Boolean issmall { get; set; }

            public DrinkItem copy()
            {
                return (new DrinkItem(this.Image, this.Name, this.price12, this.price16, this.description));
            }
        }

        public class FoodItem
        {
            public FoodItem(ImageSource a, ImageSource b, List<ingredient> c, string d, string e, List<string> f, string g)
            {
                this.Image1 = a;
                this.Image2 = b;
                this.ingredients = c;
                this.remove = new List<ingredient>();
                this.add = new List<ingredient>();
                this.description = d;
                this.name = e;
                this.allergy = f;
                this.price = g;
            }

            public ImageSource Image1 { set; get; }
            public ImageSource Image2 { set; get; }
            public List<ingredient> ingredients { set; get; }
            public List<ingredient> remove { set; get; }
            public List<ingredient> add { set; get; }
            public string description { set; get; }
            public string name { set; get; }
            public List<string> allergy { set; get; }
            public string price { set; get; }

            public void addingredient(ingredient x)
            {
                Double tprice = Double.Parse(this.price) + Double.Parse(x.price);
                this.price = tprice.ToString();
                this.add.Add(x);
            }

            public void removeingredient(ingredient x)
            {
                if (this.ingredients.Contains(x))
                {
                    this.ingredients.Remove(x);
                }
                else
                { 
                    Double tprice = Double.Parse(this.price) - Double.Parse(x.price);
                    this.price = tprice.ToString();
                    this.add.Remove(x);
                }
            }

            public FoodItem copy()
            {
                return (new FoodItem(this.Image1, this.Image2, this.ingredients, this.description, this.name, this.allergy, this.price));
            }

        }

        public class ingredient : IEquatable<ingredient>
        {
            public ingredient(string a, string b)
            {
                this.name = a;
                this.price = b;
            }

            public string name { set; get; }
            public string price { set; get; }

            public bool Equals(ingredient other)
            {
                if(other.name.Equals(other.name, StringComparison.Ordinal))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        private void btnCall_Click(object sender, RoutedEventArgs e)
        {
			MessageBox.Show("Waitstaff has been notified.", "Please wait");
        }

        private void btnBill_Click(object sender, RoutedEventArgs e)
        {
            Window5 tempwindow = new Window5();
            tempwindow.Show();
        }

        private void menuSelector_Click(object sender, RoutedEventArgs e)
        {
            if (this.menuopen)
            {
                this.menuopen = false;
                Menushow.Width = 0;
            }
            else
            {
                this.menuopen = true;
                Menushow.Width = 470;
            }
        }

        private void quitmenu_Click(object sender, RoutedEventArgs e)
        {
            Menushow.Width = 0;
            this.menuopen = false;
        }

        private void DrinkMain_Click(object sender, RoutedEventArgs e)
        {
            DrinkMain.IsEnabled = false;
            DrinkMain.Opacity = 0.5;
            DinnerMain.IsEnabled = true;
            DinnerMain.Opacity = 1;
            BurgerMain.IsEnabled = true;
            BurgerMain.Opacity = 1;
            pagename_drinkpage.Height = 670;
            pagename_stackpage.Height = 0;
            Menushow.Width = 0;
            this.menuopen = false;
        }

        private void DinnerMain_Click(object sender, RoutedEventArgs e)
        {
            DrinkMain.IsEnabled = true;
            DrinkMain.Opacity = 1;
            DinnerMain.IsEnabled = false;
            DinnerMain.Opacity = 0.5;
            BurgerMain.IsEnabled = true;
            BurgerMain.Opacity = 1;
            pagename_stackpage.Height = 670;
            pagename_drinkpage.Height = 0;
            Menushow.Width = 0;
            this.menuopen = false;
        }

        private void BurgerMain_Click(object sender, RoutedEventArgs e)
        {
            DrinkMain.IsEnabled = true;
            DrinkMain.Opacity = 1;
            DinnerMain.IsEnabled = true;
            DinnerMain.Opacity = 1;
            BurgerMain.IsEnabled = false;
            BurgerMain.Opacity = 0.5;
            Menushow.Width = 0;
            this.menuopen = false;
        }

        private void pagename_SourceUpdated(object sender, DataTransferEventArgs e)
        {

        }
    }
}
