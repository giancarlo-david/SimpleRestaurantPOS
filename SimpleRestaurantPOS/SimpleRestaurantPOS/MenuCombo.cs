using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleRestaurantPOS
{
    class MenuCombo
    {
        private MenuItem _Entree;
        private MenuItem _Side;
        private MenuItem _Drink;
        private decimal _Price;

        public MenuCombo()
        {

        }

        public MenuCombo(MenuItem entree, MenuItem side, MenuItem drink, decimal price)
        {
            _Entree = entree;
            _Side = side;
            _Drink = drink;
            _Price = price;
        }

        public MenuItem Entree
        {
            get { return _Entree; }
            set { _Entree = value; }
        }

        public MenuItem Side
        {
            get { return _Side; }
            set { _Side = value; }
        }

        public MenuItem Drink
        {
            get { return _Drink; }
            set { _Drink = value; }
        }

        public decimal Price
        {
            get { return _Price; }
            set { _Price = value; }
        }
    }
}
