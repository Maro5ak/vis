using BusinessLayer;
using ExternalLibraries;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer {
    public partial class CartPage : Form {
        Cart cart;
        public CartPage() {
            InitializeComponent();
            cart = new Cart(new Customer(Runtime.loggedIn));
            
            int rowCount = 0;
            orderList.ColumnCount = 1;
            foreach (ICart o in cart.Items) {
                if(o is Order)
                    rowCount += (o as Order).OrderItems.Count;
            }

            rowCount = orderList.RowCount += cart.Items.Count;

            orderList.RowStyles.Clear();
            orderList.ColumnStyles.Clear();
           

            orderList.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100));
            for (int i = 0; i < rowCount; i++) orderList.RowStyles.Add(new RowStyle(SizeType.Absolute, 60));

            bool swap = true;
            for(int i = 0; i < cart.Items.Count; i++) { 
                ICart o = cart.Items[i];
                Label label = new Label();
                label.AutoSize = true;
                label.Name = $"lbl{i}";
                label.Font = new Font("Seoge UI", 16);
                label.BackColor = Color.LightGray;
                if (swap) label.BackColor = Color.Gray;
               
                if (o is Order) {
                    int orderIter = 0;
                    foreach (Instrument ins in (o as Order).OrderItems) {
                        label = new Label();
                        label.AutoSize = true;
                        label.Name = $"lbl{i + orderIter}";
                        label.Text = $"Order  | {ins.Manufacturer} {ins.Name} |                                                                 | ${ins.PriceBuy}";
                        label.Font = new Font("Seoge UI", 16);
                        label.BackColor = Color.LightGray;
                        if (swap) label.BackColor = Color.Gray;
                        orderList.Controls.Add(label);
                        swap = !swap;
                    }
                }
                else {
                    Rental r = o as Rental;
                    label.Text = $"Rental | {r.Instrument.Manufacturer} {r.Instrument.Name} |                                       | ${r.Instrument.Deposit} + ${r.Instrument.PriceRent} per month";
                    orderList.Controls.Add(label);
                    swap = !swap;
                }
            }

            priceLabel.Text = $"Price Sum: ${cart.SumPrices()}";
        }

        private void checkoutBtn_Click(object sender, EventArgs e) {
            Form nextForm = new CheckoutPage(this.cart);
            nextForm.Location = this.Location;
            nextForm.StartPosition = FormStartPosition.Manual;
            nextForm.FormClosing += delegate { this.Close(); };
            nextForm.Show();
            this.Hide();
        }

        private void cartBtn_Click(object sender, EventArgs e) {
            Form nextForm = new CartPage();
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

        }
    }
}
