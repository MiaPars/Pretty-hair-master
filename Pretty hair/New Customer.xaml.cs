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

namespace Pretty_hair
{
    /// <summary>
    /// Interaction logic for New_Customer.xaml
    /// </summary>
    public partial class New_Customer : Page
    {
        DB_Controller controller = new DB_Controller();
        public New_Customer()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            controller.AddCustomer(Name_Textbox.Text, Address_Textbox.Text, ZIP_Textbox.Text, Town_Textbox.Text, Telephone_Textbox.Text);

            Application.Current.MainWindow.Content = new New_Order();
        }
    }
}
