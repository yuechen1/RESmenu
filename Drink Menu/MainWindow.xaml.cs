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
        public static List<Sides> orderedSides = new List<Sides>();
        public static List<ingredient> fulllist = new List<ingredient>();
        public static List<Sides> sides = new List<Sides>();

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

            //add food items
            fulllist.Add(new ingredient("Salt"));                   //0
            fulllist.Add(new ingredient("Pepper"));                 //1
            fulllist.Add(new ingredient("Lettuce"));                //2
            fulllist.Add(new ingredient("Tomato Sause"));           //3
            fulllist.Add(new ingredient("BBQ Sause"));              //4
            fulllist.Add(new ingredient("Mushrooms", "1.50"));      //5
            fulllist.Add(new ingredient("Egg", "1.00"));            //6

            List<ingredient> stake = new List<ingredient>();
            stake.Add(new ingredient("Steak"));
            stake.Add(fulllist[0]);
            stake.Add(fulllist[1]);
            stake.Add(fulllist[4]);
            List<string> temp = new List<string>();
            temp.Add("Non-vegetarian");
            food.Add(new FoodItem(null, null, stake, "Cooked medium rare, a staple of the Dancing Shamrock.", "Steak", temp, "25.00"));
            stake = new List<ingredient>();
            stake.Add(new ingredient("Beef Patty"));
            stake.Add(fulllist[0]);
            stake.Add(fulllist[1]);
            stake.Add(fulllist[2]);
            stake.Add(fulllist[3]);
            food.Add(new FoodItem(null, null, stake, "Shitty Burger", "Burger", temp, "15.00"));


            sides.Add(new Sides(null, "Fries"));
            sides.Add(new Sides(null, "Salads"));

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
                bool found = false;
                foreach (ingredient i in this.ingredients)
                {
                    if (i.Equals(x))
                    {
                        this.add.Remove(i);
                        found = true;
                        break;
                    }
                }

                if (!found)
                { 
                    Double tprice = Double.Parse(this.price) - Double.Parse(x.price);
                    this.price = tprice.ToString();
                    foreach(ingredient i in this.add)
                    {
                        if (i.Equals(x))
                        {
                            this.add.Remove(i);
                            break;
                        }
                    }
                }
            }

            public FoodItem copy()
            {
                List<ingredient> templist = new List<ingredient>();
                templist = this.ingredients.ToList<ingredient>();
                return (new FoodItem(this.Image1, this.Image2, templist, this.description, this.name, this.allergy, this.price));
            }

            public List<string> ingrendientlist()
            {
                List<string> templist = new List<string>();
                foreach(ingredient i in this.ingredients)
                {
                    templist.Add(i.name);
                }
                return templist;
            }

        }

        public class ingredient : IEquatable<ingredient>
        {
            public ingredient(string a, string b)
            {
                this.name = a;
                this.price = b;
            }

            public ingredient(string a)
            {
                this.name = a;
                this.price = "0.00";
            }

            public string name { set; get; }
            public string price { set; get; }

            public bool Equals(ingredient other)
            {
                if(this.name.Equals(other.name))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            
        }

        public class Sides
        {
            public Sides(ImageSource a, string b)
            {
                this.image = a;
                this.name = b;
                this.price = null;
            }

            public ImageSource image { set; get; }
            public string name { set; get; }
            public string price { set; get; }
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
