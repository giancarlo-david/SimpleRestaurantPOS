using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleRestaurantPOS
{
    public partial class FormMainMenu : Form
    {
        List<MenuItem> receiptList = new List<MenuItem>();
        List<MenuCombo> comboReceiptList = new List<MenuCombo>();

        public FormMainMenu()
        {
            InitializeComponent();
        }

        private void buttonCombo_Click(object sender, EventArgs e)
        {
            panelCombos.Visible = true;
            panelEntrees.Visible = false;
            panelSides.Visible = false;
            panelDrinks.Visible = false;
            panelDesserts.Visible = false;
        }

        private void buttonEntree_Click(object sender, EventArgs e)
        {
            panelCombos.Visible = false;
            panelEntrees.Visible = true;
            panelSides.Visible = false;
            panelDrinks.Visible = false;
            panelDesserts.Visible = false;
        }

        private void buttonSide_Click(object sender, EventArgs e)
        {
            panelCombos.Visible = false;
            panelEntrees.Visible = false;
            panelSides.Visible = true;
            panelDrinks.Visible = false;
            panelDesserts.Visible = false;
        }

        private void buttonDrink_Click(object sender, EventArgs e)
        {
            panelCombos.Visible = false;
            panelEntrees.Visible = false;
            panelSides.Visible = false;
            panelDrinks.Visible = true;
            panelDesserts.Visible = false;
        }

        private void buttonDessert_Click(object sender, EventArgs e)
        {
            panelCombos.Visible = false;
            panelEntrees.Visible = false;
            panelSides.Visible = false;
            panelDrinks.Visible = false;
            panelDesserts.Visible = true;
        }

        private void showReceipt()
        {
            CurrentReceiptView.Items.Clear();
            foreach(MenuCombo comboItem in comboReceiptList)
            {
                string[] row = new string[] { "Combo", comboItem.Entree.Title + "\n\t" + comboItem.Side.Title + "\n\t" +
                    comboItem.Drink.Title, comboItem.Price.ToString() };
                ListViewItem comboToAdd = new ListViewItem(row);
                CurrentReceiptView.Items.Add(comboToAdd);

            }

            foreach (MenuItem currentItem in receiptList)
            {
                string[] row = new string[] { currentItem.Group.ToString(), currentItem.Title, currentItem.Price.ToString("c") };
                ListViewItem itemToAdd = new ListViewItem(row);
                CurrentReceiptView.Items.Add(itemToAdd);
            }

            updateTotal();
        }

        private void updateTotal()
        {
            decimal totalPrice = 0m;
            const decimal taxPercent = .0825m;
            decimal taxAmount = 0m;

            foreach (MenuItem priceToAdd in receiptList)
            {
                totalPrice += priceToAdd.Price;
            }

            taxAmount = totalPrice * taxPercent;
            totalPrice += taxAmount;
            textBoxTotal.Text = totalPrice.ToString("c");
        }

        private void buttonCheeseburger_Click(object sender, EventArgs e)
        {
            MenuItem CheeseBurger = new MenuItem("Cheeseburger", MenuType.Entree, 4m);
            receiptList.Add(CheeseBurger);
            showReceipt();
        }

        private void buttonHotdog_Click(object sender, EventArgs e)
        {
            MenuItem HotDog = new MenuItem("Hotdog", MenuType.Entree, 3m);
            receiptList.Add(HotDog);
            showReceipt();
        }

        private void buttonChickenStrips_Click(object sender, EventArgs e)
        {
            MenuItem ChickenStrips = new MenuItem("Chicken Strips", MenuType.Entree, 4m);
            receiptList.Add(ChickenStrips);
            showReceipt();
        }

        private void buttonFries_Click(object sender, EventArgs e)
        {
            MenuItem Fries = new MenuItem("Fries", MenuType.Side, 1m);
            receiptList.Add(Fries);
            showReceipt();
        }

        private void buttonMacCheese_Click(object sender, EventArgs e)
        {
            MenuItem MacCheese = new MenuItem("Mac and Cheese", MenuType.Side, 2m);
            receiptList.Add(MacCheese);
            showReceipt();
        }

        private void buttonChips_Click(object sender, EventArgs e)
        {
            MenuItem Chips = new MenuItem("Chips", MenuType.Side, .5m);
            receiptList.Add(Chips);
            showReceipt();
        }

        private void buttonSoda_Click(object sender, EventArgs e)
        {
            MenuItem Soda = new MenuItem("Soda", MenuType.Drink, 1m);
            receiptList.Add(Soda);
            showReceipt();
        }

        private void buttonBeer_Click(object sender, EventArgs e)
        {
            MenuItem Beer = new MenuItem("Beer", MenuType.Drink, 3m);
            receiptList.Add(Beer);
            showReceipt();
        }

        private void buttonShake_Click(object sender, EventArgs e)
        {
            MenuItem Shake = new MenuItem("Shake", MenuType.Drink, 3.5m);
            receiptList.Add(Shake);
            showReceipt();
        }

        private void buttonIceCream_Click(object sender, EventArgs e)
        {
            MenuItem IceCream= new MenuItem("Ice Cream", MenuType.Dessert, 2m);
            receiptList.Add(IceCream);
            showReceipt();
        }

        private void buttonCookie_Click(object sender, EventArgs e)
        {
            MenuItem Cookie = new MenuItem("Cookie", MenuType.Dessert, 1m);
            receiptList.Add(Cookie);
            showReceipt();
        }

        private void buttonCake_Click(object sender, EventArgs e)
        {
            MenuItem Cake = new MenuItem("Cake", MenuType.Dessert, 3m);
            receiptList.Add(Cake);
            showReceipt();
        }

        private void buttonRemoveItem_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (int itemToRemove in CurrentReceiptView.SelectedIndices)
                {
                    CurrentReceiptView.Items.RemoveAt(itemToRemove);
                    receiptList.RemoveAt(itemToRemove);
                }
            }

            catch
            {
                MessageBox.Show("Please select one item at a time to remove");
            }
        }

        private void buttonCheeseburgerCombo_Click(object sender, EventArgs e)
        {
            MenuItem CheeseBurger = new MenuItem("Cheeseburger", MenuType.Entree, 7m);
            MenuItem Fries = new MenuItem("Fries", MenuType.Side, 0m);
            MenuItem Soda = new MenuItem("Soda", MenuType.Side, 0m);
            MenuCombo CheeseBurgerCombo = new MenuCombo(CheeseBurger, Fries, Soda, CheeseBurger.Price);
            comboReceiptList.Add(CheeseBurgerCombo);
            showReceipt();
        }
    }
}
