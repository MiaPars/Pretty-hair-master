using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pretty_hair
{
    public class Controller
    {
        MainWindow main;
        New_Order mainPage;

        public Controller(MainWindow v)
        {
            mainPage = new New_Order(this);
            main = v;
        }

        public void OpenMainWindow()
        {
            main.Content = mainPage;
        }

        public bool CheckCustomerInDatabase(int CustomerID)
        {
            return false;
        }
        public void CreateCustomer(string name, string address, int ZIP, string Town, int TelephoneNumber)
        {

        }
    }
}
