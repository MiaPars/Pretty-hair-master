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

        }

        private void Image_MouseLeave(object sender, MouseEventArgs e)
        {
            Image img = ((Image)sender);
            // Height="86" Width="109"

            img.Height = img.Height / 1.1;
            img.Width = img.Height / 1.1;
        }

        private void Image_MouseEnter(object sender, MouseEventArgs e)
        {
            Image img = ((Image)sender);
            // Height="86" Width="109"
            img.Height = img.Height * 1.1;
            img.Width = img.Height * 1.1;
        }
    }
}
