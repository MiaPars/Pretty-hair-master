using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pretty_hair
{
    public class Controller
    {
        MainWindow start;
        New_Order mainPage;

        public Controller(MainWindow v)
        {
            start = v;
            mainPage = new New_Order(this);
        }

        public void OpenMainWindow()
        {
            start.Content = mainPage;
        }
    }
}
