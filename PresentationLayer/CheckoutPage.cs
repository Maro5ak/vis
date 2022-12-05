using ExternalLibraries;
using BusinessLayer;
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
    public partial class CheckoutPage : Form {
        private int fullPrice = 0;
        Cart cart;
        Payment.P paymentMethod;
        private int paymentAddon, deliveryAddon;
        public CheckoutPage(Cart cart) {
            InitializeComponent();
            this.cart = cart;
            Customer current = cart.Customer;
            
            nameBox.Text = Utils.Concat(current.Firstname, current.Lastname);
            emailBox.Text = current.Email;
            addressBox.Text = current.Address;
            paymentLabel.Text = "Payment Method: | + $0";
            deliveryLabel.Text = "Delivery: | + $0";
            itemsPriceLabel.Text = $"Items Price: ${cart.SumPrices()}";
            depositLabel.Text = $"Deposit: ${cart.SumDeposits()}";
            fullPrice += cart.SumPrices();

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

        private void paymentMethodCheckBox_ItemCheck(object sender, ItemCheckEventArgs e) {
            for (int i = 0; i < paymentMethodCheckBox.Items.Count; i++)
                if (i != e.Index) paymentMethodCheckBox.SetItemChecked(i, false);
            for(int i = 0; i < paymentMethodCheckBox.Items.Count; i++) { 
                if (i == e.Index && i == 0) {
                    paymentLabel.Text = $"PayPal | + ${(int)(fullPrice * 0.03)}";
                    paymentAddon = (int)(1.03 * fullPrice);
                    paymentMethod = "paypal";
                    break;
                }
                else if (i == e.Index && i == 1) {
                    paymentLabel.Text = "Cash | + $5";
                    paymentAddon = 5;
                    paymentMethod = "cash";
                    break;
                }
                else if (i == e.Index && i == 2) {
                    paymentLabel.Text = "Bank Transfer | + $0";
                    paymentAddon = 0;
                    paymentMethod = "transfer";
                    break;
                }
                else if (i == e.Index && i == 3) {
                    paymentLabel.Text = "Card | + $0";
                    paymentAddon = 0;
                    paymentMethod = "card";
                    break;
                }
            }
        }

        private void confirmBtn_Click(object sender, EventArgs e) {
            Payment.PaymentMethodEnum method = Payment.PaymentMethodEnum.CARD;
            if (paymentMethod == "paypal")
                 method = Payment.PaymentMethodEnum.CARD;
            if (paymentMethod == "cash")
                method = Payment.PaymentMethodEnum.CASH;
            if (paymentMethod == "transfer")
                method = Payment.PaymentMethodEnum.TRANSFER;
            if (paymentMethod == "card")
                method = Payment.PaymentMethodEnum.CARD;
            

            foreach (ICart i in cart.Items) {
                if(i is Order) {
                    (i as Order).Payment = new Payment(i.SumPrices() + paymentAddon + deliveryAddon, method, Payment.RentalOrder.ORDER);
                    (i as Order).CreateOrder();
                }
                else {
                    (i as Rental).Payment = new Payment(i.SumPrices() + paymentAddon + deliveryAddon, method, Payment.RentalOrder.RENTAL);
                    (i as Rental).CreateRental();
                }
            }

            

            Form nextForm = new OrderSuccess(cart.GetOrderId());
            nextForm.Location = this.Location;
            nextForm.StartPosition = FormStartPosition.Manual;
            nextForm.FormClosing += delegate { this.Close(); };
            nextForm.Show();
            this.Hide();
        }

        private void deliveryOptionsCheckBox_ItemCheck(object sender, ItemCheckEventArgs e) {
            for (int i = 0; i < deliveryOptionsCheckBox.Items.Count; i++)
                if (i != e.Index) deliveryOptionsCheckBox.SetItemChecked(i, false);
            for (int i = 0; i < deliveryOptionsCheckBox.Items.Count; i++) {
                if (i == e.Index && i == 0) {
                    deliveryLabel.Text = "Pickup | + $0";
                    deliveryAddon = 0;
                    break;
                }
                else if (i == e.Index && i == 1) {
                    deliveryLabel.Text = $"Delivery | + $5";
                    paymentAddon = 5;
                    break;
                }
            }
        }
    }
}
