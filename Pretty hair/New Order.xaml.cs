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
    public partial class New_Order : Page
    {
        DB_Controller con = new DB_Controller();
        public New_Order()
        {
            InitializeComponent();
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
            string text = Find_Customer_Textbox.Text;
            Customer customer = con.FindCustomer(text);
            Application.Current.MainWindow.Content = new Make_Order(text);


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
            Application.Current.MainWindow.Content = new New_Customer();
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
