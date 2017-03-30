﻿using System;
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
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
            List<Drinkdisplay> items = new List<Drinkdisplay>();
            items.Add(new Drinkdisplay { Image = null, Name = "suger water", price12 = "8.00", price16 = "10.00", Image_1 = null, Name_1 = "Water", price12_1 = "8.00", price16_1 = "10.00" });
            items.Add(new Drinkdisplay { Image = null, Name = "suger water", price12 = "8.00", price16 = "10.00", Image_1 = null, Name_1 = "Water", price12_1 = "8.00", price16_1 = "10.00" });
            items.Add(new Drinkdisplay { Image = null, Name = "suger water", price12 = "8.00", price16 = "10.00", Image_1 = null, Name_1 = "Water", price12_1 = "8.00", price16_1 = "10.00" });
            items.Add(new Drinkdisplay { Image = null, Name = "suger water", price12 = "8.00", price16 = "10.00", Image_1 = null, Name_1 = "Water", price12_1 = "8.00", price16_1 = "10.00" });
            items.Add(new Drinkdisplay { Image = null, Name = "suger water", price12 = "8.00", price16 = "10.00", Image_1 = null, Name_1 = "Water", price12_1 = "8.00", price16_1 = "10.00" });
            items.Add(new Drinkdisplay { Image = null, Name = "suger water", price12 = "8.00", price16 = "10.00", Image_1 = null, Name_1 = "Water", price12_1 = "8.00", price16_1 = "10.00" });
            items.Add(new Drinkdisplay { Image = null, Name = "suger water", price12 = "8.00", price16 = "10.00", Image_1 = null, Name_1 = "Water", price12_1 = "8.00", price16_1 = "10.00" });
            items.Add(new Drinkdisplay { Image = null, Name = "suger water", price12 = "8.00", price16 = "10.00", Image_1 = null, Name_1 = "Water", price12_1 = "8.00", price16_1 = "10.00" });
            DrinkBox.ItemsSource = items;
        }

        private void DrinkBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Window2 tempWindow = new Drink_Menu.Window2();
            tempWindow.Show();
        }

        private void DrinkBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        public class Drinkdisplay
        {
            public string Image { get; set; }
            public string Name { get; set; }
            public string price12 { get; set; }
            public string price16 { get; set; }
            public string Image_1 { get; set; }
            public string Name_1 { get; set; }
            public string price12_1 { get; set; }
            public string price16_1 { get; set; }
        }
    }
}