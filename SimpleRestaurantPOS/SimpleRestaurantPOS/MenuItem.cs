using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleRestaurantPOS
{

    enum MenuType
    {
        Entree,
        Side,
        Drink,
        Dessert
    }

    class MenuItem
    {
        private string _Title;
        private MenuType _Group;
        private decimal _Price;

        public MenuItem()
        {

        }

        public MenuItem(string title, MenuType group, decimal price)
        {
            _Title = title;
            _Group = group;
            _Price = price;
        }

        public string Title
        {
            get { return _Title; }
            set { _Title = value; }
        }

        public MenuType Group
        {
            get { return _Group; }
            set { _Group = value; }
        }

        public decimal Price
        {
            get { return _Price; }
            set { _Price = value; }
        }

    }


}
