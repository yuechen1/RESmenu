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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Drink_Menu
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public static List<DrinkItem> drinks =  new List<DrinkItem>();
        public static List<FoodItem> food = new List<FoodItem>();

        public MainWindow()
        {
            InitializeComponent();
            //add drink items
            drinks.Add(new DrinkItem { Image = null, Name = "Water", price12 = "0.00", price16 = "0.00", description = "The best tap water you can find" });
            drinks.Add(new DrinkItem { Image = null, Name = "Light Beer", price12 = "6.50", price16 = "8.00", description = "Genaric light beer" });
            drinks.Add(new DrinkItem { Image = null, Name = "Beer", price12 = "6.50", price16 = "8.00", description = "Some Beer" });
            drinks.Add(new DrinkItem { Image = null, Name = "Bear", price12 = "8.00", price16 = "12.00", description = "Real Bear? I don't know" });
            drinks.Add(new DrinkItem { Image = null, Name = "Red Wine", price12 = "12.00", price16 = "35.00", description = "WHY ARE YOU READING THIS?" });
            drinks.Add(new DrinkItem { Image = null, Name = "White Wine", price12 = "12.00", price16 = "35.00", description = "DO YOU LOOK AT EVERY SINGLE ONE?" });
            drinks.Add(new DrinkItem { Image = null, Name = "Drink 1", price12 = "7.00", price16 = "9.00", description = "WHY AM I EVEN WRITING THESE" });
            drinks.Add(new DrinkItem { Image = null, Name = "Moonshine", price12 = "6.50", price16 = "8.50", description = "NO HOPE IN HERE" });
            drinks.Add(new DrinkItem { Image = null, Name = "Banana Flush", price12 = "5.50", price16 = "10.00", description = "I DON\'T EVEN KNOW WHAT TO WRITE" });
            drinks.Add(new DrinkItem { Image = null, Name = "Drink 2", price12 = "3.00", price16 = "5.00", description = "ARE THERE EVEN MORE THAN 10 DRINKS?" });
            drinks.Add(new DrinkItem { Image = null, Name = "Almost Out of Ideas", price12 = "30.00", price16 = "50.00", description = "WHAT DO PEOPLE THINK ABOUT WHEN DRINKING?" });
            drinks.Add(new DrinkItem { Image = null, Name = "Out of Ideas", price12 = "60.00", price16 = "120.00", description = "THIS IS THE LAST ONE" });
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
            public ImageSource Image { get; set; }
            public string Name { get; set; }
            public string price12 { get; set; }
            public string price16 { get; set; }
            public string description { get; set; }

        }

        public class FoodItem
        {
            public string Image1 { set; get; }
            public string Image2 { set; get; }
            public List<ingredient> ingredients { set; get; }
            public string description { set; get; }
            public string name { set; get; }
            public List<string> allergy { set; get; }

            public void addingredient(ingredient x)
            {
                this.ingredients.Add(x);
            }

            public void removeingredient(ingredient x)
            {
                this.ingredients.Remove(x);
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
            Menushow.Width = 470;
        }

        private void quitmenu_Click(object sender, RoutedEventArgs e)
        {
            Menushow.Width = 0;
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
        }

        private void pagename_SourceUpdated(object sender, DataTransferEventArgs e)
        {

        }
    }
}
