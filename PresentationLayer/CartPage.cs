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
        private List<Instrument> orderItems = new List<Instrument>();
        public CartPage() {
            InitializeComponent();

            //orderList.Controls.Clear();

            Cart.Customer = new Customer(Runtime.loggedIn);

            
            int rowCount = 0;
            orderList.ColumnCount = 1;


            rowCount = orderList.RowCount += Cart.CartItems.Count;

            orderList.RowStyles.Clear();
            orderList.ColumnStyles.Clear();


            orderList.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100));
            for (int i = 0; i < rowCount; i++) orderList.RowStyles.Add(new RowStyle(SizeType.Absolute, 60));
            int width = 734;
            int height = 34;
            bool swap = true;
           
            
            for (int i = 0; i < rowCount - 1; i++) {
                Label label = new Label();
                label.AutoSize = false;
                label.Width = width;
                label.Height = height;
                label.TextAlign = ContentAlignment.MiddleLeft;
                label.Name = $"item{i}";
                label.Font = new Font("Seoge UI", 15);
                label.BackColor = Color.LightGray;
                if (swap) label.BackColor = Color.Gray;
                label.Click += new EventHandler(HandleRemoveItem_Click);

                CartItem active = Cart.CartItems[i];
                if (active.RentalOrder == Payment.RentalOrder.RENTAL) {
                    label.Text = $"Rental | {active.Instrument.Manufacturer} {active.Instrument.Name} |                 | ${active.Instrument.Deposit} + ${active.Instrument.PriceRent} per month";
                    Cart.Items.Add(new Rental(active.Instrument, Cart.Customer, DateTime.Now));
                }

                else if (active.RentalOrder == Payment.RentalOrder.ORDER) {
                    label.Text = $"Order  | {active.Instrument.Manufacturer} {active.Instrument.Name} |                 | ${active.Instrument.PriceBuy}";
                    orderItems.Add(active.Instrument);
                }

                orderList.Controls.Add(label);
                swap = !swap;
            }
            
            
        }
    
        private void checkoutBtn_Click(object sender, EventArgs e) {
            Cart.Items.Add(new Order(orderItems, Cart.Customer));
            if (Cart.CartItems.Count == 0) return;
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
            Cart.CartItems.RemoveAt(index);
            
            this.orderList.Controls.Remove(clicked);
        }
    }
}
