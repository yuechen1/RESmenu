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
using System.Windows.Shapes;

namespace Drink_Menu
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2(string name)
        {
            InitializeComponent();

            //search for drink  in liquids based on name
            MainWindow.DrinkItem k = null;
            foreach (MainWindow.DrinkItem i in MainWindow.drinks)
            {
                if (String.Compare(i.Name, name) == 0)
                {
                    k = i;
                    break;
                }
            }

            //			txtDrinkName.Text = liquids. .drinkName.get();
            txtDrinkName.Text = k.Name;
			txtDrinkInfo.Text = k.description;
            rdoSmallDrink.Content = "16oz: " + k.price12;
            rdoLargeDrink.Content = "20oz: " + k.price16;
            imgDrinkPicture.Source = k.Image;
        }

		private void btnDrinkBack_Click(object sender, RoutedEventArgs e)
		{
			this.Close();
		}
	}
}
