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
using ExternalLibraries;

namespace PresentationLayer {
    public partial class InstrumentDetails : Form {
        Instrument currentInstrument;
        public InstrumentDetails(int id) {
            InitializeComponent();
            currentInstrument = Inventory.inventoryMap[id];
            this.Text = $"Product: {currentInstrument.Manufacturer} {currentInstrument.Name}";
            instrumentLabel.Text = currentInstrument.Name;
            manufacturerLabel.Text = currentInstrument.Manufacturer;
            descriptionLabel.Text = currentInstrument.Description;
            nameLabel.Text = currentInstrument.Name;
            typeLabel.Text = currentInstrument.Type;
            buyLabel.Text = $"Price to buy: ${currentInstrument.PriceBuy}";
            int priceRent = currentInstrument.PriceRent;
            if (priceRent == 0) {
                rentLabel.Hide();
                rentCheckBox.Hide();
            }
            else rentLabel.Text = $"Price to rent: ${priceRent}";


        }

        

        private void logoBtn_Click(object sender, EventArgs e) {
            SceneManager.ChangeScene(this, new InventoryUI());
        }

        private void profileBtn_Click(object sender, EventArgs e) {
            Form nextForm = new AccountManager();
            if (!Runtime.loginState)
                nextForm = new LoginOrRegister();

            SceneManager.ChangeScene(this, nextForm);
        }

        private void addToCartBtn_Click(object sender, EventArgs e) {
            if (rentCheckBox.Checked) {
                Cart.Add(new CartItem(currentInstrument, Payment.RentalOrder.RENTAL));
            }
            else {
                Cart.Add(new CartItem(currentInstrument, Payment.RentalOrder.ORDER));
            }
        }

        private void cartBtn_Click(object sender, EventArgs e) {
            SceneManager.ChangeScene(this, new CartPage());
        }
    }
}
