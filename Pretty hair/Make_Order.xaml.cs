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
    /// Interaction logic for Make_Order.xaml
    /// </summary>
    public partial class Make_Order : Page
    {
        DB_Controller controller = new DB_Controller();
        public Make_Order(string ID)
        {
            InitializeComponent();
            CustomerID_Textbox.Text = ID;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DateTime b = DateTime.Parse(OrderDate_Textbox.Text);
            DateTime d = DateTime.Parse(DeliveryDate_Textbox.Text);
            controller.CreateNewOrder(b, d, CustomerID_Textbox.Text);
            Application.Current.MainWindow.Content = new AddProductToOrder();
        }
    }
}
