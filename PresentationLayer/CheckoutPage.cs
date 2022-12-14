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
        string paymentMethod;
        private int paymentAddon, deliveryAddon;
        public CheckoutPage() {
            InitializeComponent();
            SceneManager.InitState(this);
            Customer current = Cart.Customer;
            
            nameBox.Text = Utils.Concat(current.Firstname, current.Lastname);
            emailBox.Text = current.Email;
            addressBox.Text = current.Address;
            paymentLabel.Text = "Payment Method: | + $0";
            deliveryLabel.Text = "Delivery: | + $0";
            itemsPriceLabel.Text = $"Items Price: ${Cart.SumPrices()}";
            depositLabel.Text = $"Deposit: ${Cart.SumDeposits()}";
            fullPrice += Cart.SumPrices();

        }


        private void cartBtn_Click(object sender, EventArgs e) {
            SceneManager.ChangeScene(this, new CartPage());
        }

        private void profileBtn_Click(object sender, EventArgs e) {
            Form nextForm = new AccountManager();
            if (!Runtime.loginState)
                nextForm = new LoginOrRegister();

            SceneManager.ChangeScene(this, nextForm);
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
            priceSumLabel.Text = $"Summary: ${fullPrice + paymentAddon + deliveryAddon}";
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

            bool sanityCheck = true;
            
            foreach (ICart i in Cart.Items) {
                if(i is Order) {
                    if ((i as Order).OrderItems.Count != 0) {
                        (i as Order).Payment = new Payment(i.SumPrices() + paymentAddon + deliveryAddon, method, Payment.RentalOrder.ORDER);
                        (i as Order).Payment.Insert(out string msg);
                        (i as Order).CreateOrder();
                    }
                }
                else {
                    (i as Rental).Payment = new Payment(i.SumPrices() + paymentAddon + deliveryAddon, method, Payment.RentalOrder.RENTAL);
                    (i as Rental).Payment.Insert(out string msg);
                    (i as Rental).CreateRental();
                }
                 
            }

            if (sanityCheck) 
                SceneManager.ChangeScene(this, new OrderSuccess(Cart.GetOrderId()));
            
        }

        private void logoBtn_Click(object sender, EventArgs e) {
            SceneManager.ChangeScene(this, new InventoryUI());
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
                    deliveryAddon = 5;
                    break;
                }
            }
            priceSumLabel.Text = $"Summary: ${fullPrice + paymentAddon + deliveryAddon}";
        }
    }
}
