using BusinessLayer;
using ExternalLibraries;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer {
    public partial class CartPage : Form {
        static bool activeOrder = false;
        public CartPage() {
            InitializeComponent();
            
            //orderList.Controls.Clear();
            
            Cart.Customer = new Customer(Runtime.loggedIn);
            if (!activeOrder) Cart.Add(new Order(Cart.ActiveOrder, Cart.Customer));
            activeOrder = true;
            int rowCount = 0;
            orderList.ColumnCount = 1;
            

            rowCount = orderList.RowCount += Cart.Items.Count + Cart.ActiveOrder.Count;

            orderList.RowStyles.Clear();
            orderList.ColumnStyles.Clear();
           

            orderList.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100));
            for (int i = 0; i < rowCount; i++) orderList.RowStyles.Add(new RowStyle(SizeType.Absolute, 60));

            bool swap = true;
            int totalCount = 0;
            for(int i = 0; i < Cart.Items.Count; i++) {
                if (Cart.Items[i] is Rental) {
                    Rental r = Cart.Items[i] as Rental;
                    Label label = new Label();
                    label.AutoSize = true;
                    label.Name = $"item{i}";
                    label.Font = new Font("Seoge UI", 16);
                    label.BackColor = Color.LightGray;
                    label.Click += new EventHandler(HandleRemoveItem_Click);
                    label.Text = $"Rental | {r.Instrument.Manufacturer} {r.Instrument.Name} |                                       | ${r.Instrument.Deposit} + ${r.Instrument.PriceRent} per month";
                    
                    if (swap) label.BackColor = Color.Gray;
                    orderList.Controls.Add(label);
                    swap = !swap;
                    totalCount++;
                }
            }
            
            for(int i = 0; i < Cart.ActiveOrder.Count; i++) {
                Instrument ins = Cart.ActiveOrder[i];
                Label label = new Label();
                label.AutoSize = true;
                label.Name = $"item{i + totalCount}";
                label.Font = new Font("Seoge UI", 16);
                label.BackColor = Color.LightGray;
                label.Click += new EventHandler(this.HandleRemoveItem_Click);
                label.Text = $"Order  | {ins.Manufacturer} {ins.Name} |                                                                 | ${ins.PriceBuy}";
                if (swap) label.BackColor = Color.Gray;
                orderList.Controls.Add(label);
                swap = !swap;
            }



            priceLabel.Text = $"Price Sum: ${Cart.SumPrices()}";
        }

        private void checkoutBtn_Click(object sender, EventArgs e) {
            if (Cart.Items.Count == 0) return;
            Form nextForm = new CheckoutPage();
            nextForm.Location = this.Location;
            nextForm.StartPosition = FormStartPosition.Manual;
            nextForm.FormClosing += delegate { this.Close(); };
            nextForm.Show();
            this.Hide();
        }

        private void profileBtn_Click(object sender, EventArgs e) {
            Form nextForm = new AccountManager();
            if (!Runtime.loginState)
                nextForm = new LoginOrRegister();

            nextForm.Location = this.Location;
            nextForm.StartPosition = FormStartPosition.Manual;
            nextForm.FormClosing += delegate { this.Close(); };
            nextForm.Show();
            this.Hide();
        }

        private void logoBtn_Click(object sender, EventArgs e) {
            Form nextForm = new InventoryUI();
            nextForm.Location = this.Location;
            nextForm.StartPosition = FormStartPosition.Manual;
            nextForm.FormClosing += delegate { this.Close(); };
            nextForm.Show();
            this.Hide();
        }

        private void HandleRemoveItem_Click(object sender, EventArgs e) {
            Label clicked = (Label)sender;
            int index = Int32.Parse(clicked.Name.Substring(4));
            
            if (Cart.ActiveOrder.Count >= index)
                Cart.ActiveOrder.RemoveAt(index);
            if (Cart.Items.Count >= index)
                Cart.Items.RemoveAt(index);

            this.orderList.Controls.Remove(clicked);
            priceLabel.Text = $"Price Sum: ${Cart.SumPrices()}";
        }
    }
}
