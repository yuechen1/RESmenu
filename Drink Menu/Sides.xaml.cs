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
    /// Interaction logic for Window4.xaml
    /// </summary>
    public partial class Window4 : Window
    {
        MainWindow.Sides currentselected = null;
        public Window4()
        {
            InitializeComponent();

            lbxSideDisplay.ItemsSource = MainWindow.sides;
        }

		private void btnSideBack_Click(object sender, RoutedEventArgs e)
		{
            int j = MainWindow.orderedFood.Count();
            MainWindow.orderedFood.Remove(MainWindow.orderedFood[j - 1]);
			this.Close();
		}

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            RadioButton k = (RadioButton)sender;
            MainWindow.Sides food = k.DataContext as MainWindow.Sides;
            this.currentselected = food;
        }

        private void btnSideAdd_Click(object sender, RoutedEventArgs e)
        {
            if(currentselected != null)
            {
                foreach (Window1 window in Application.Current.Windows.OfType<Window1>())
                {
                    window.Close();
                    break;
                }
                MainWindow.orderedSides.Add(this.currentselected);
                this.Close();
            }
        }
    }
}
