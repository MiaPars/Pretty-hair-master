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

namespace Pretty_hair
{
    /// <summary>
    /// Interaction logic for New_Order.xaml
    /// </summary>
    public partial class New_Order : Page
    {
        Make_Order makeOrder = new Make_Order();
        New_Customer newCustomer = new New_Customer();

        Controller controller;
        public New_Order(Controller controller)
        {

            this.controller = controller;
            InitializeComponent();
            LabelTryAgain.Visibility = Visibility.Hidden;

        }

        private void Textbox_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            textBox.Text = "";
        }

        private void Find_Customer_Click(object sender, RoutedEventArgs e)
        {
        }

        private void Find_Customer_Textbox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (controller.CheckCustomerInDatabase(Convert.ToInt32(Find_Customer_Textbox.Text)) == true)
            {
                Application.Current.MainWindow.Content = makeOrder;
            }
            else
            {
                Application.Current.MainWindow.Content = this;
                LabelTryAgain.Visibility = Visibility.Visible;
            }
        }

        private void Image_MouseLeave(object sender, MouseEventArgs e)
        {
            Image img = ((Image)sender);

            img.Height = img.Height / 1.1;
            img.Width = img.Height / 1.1;
        }

        private void Image_MouseEnter(object sender, MouseEventArgs e)
        {
            Image img = ((Image)sender);
            img.Height = img.Height * 1.1;
            img.Width = img.Height * 1.1;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.Content = newCustomer;
        }

        private void Image_MouseEnter_1(object sender, MouseEventArgs e)
        {
            Image img = ((Image)sender);
            img.Height = img.Height * 1.1;
            img.Width = img.Height * 1.1;
        }

        private void Image_MouseLeave_1(object sender, MouseEventArgs e)
        {
            Image img = ((Image)sender);

            img.Height = img.Height / 1.1;
            img.Width = img.Height / 1.1;
        }
    }
}
