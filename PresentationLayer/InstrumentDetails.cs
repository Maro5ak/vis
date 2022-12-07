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
            deleteInstrumentBtn.Visible = false;
            if (Runtime.privilegedMode)
                deleteInstrumentBtn.Visible = true;


            this.Text = $"Product: {currentInstrument.Manufacturer} {currentInstrument.Name}";
            instrumentLabel.Text = currentInstrument.Name;
            manufacturerLabel.Text = currentInstrument.Manufacturer;
            descriptionLabel.Text = currentInstrument.Description;
            nameLabel.Text = currentInstrument.Name;
            typeLabel.Text = currentInstrument.Type;
            buyLabel.Text = $"Price to buy: ${currentInstrument.PriceBuy}";
            if(currentInstrument.Quantity > 0)
                quantityLabel.Text = $"In stock: {currentInstrument.Quantity}";
            else {
                quantityLabel.Text = "Out of stock";
                cartBtn.Enabled = false;
            }
            if (!currentInstrument.Rentable) {
                rentLabel.Hide();
                rentCheckBox.Hide();
            }
            else rentLabel.Text = $"Price to rent: ${currentInstrument.PriceRent}";


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

        private void deleteInstrumentBtn_Click(object sender, EventArgs e) {
            Inventory.inventoryMap.Remove(currentInstrument.Id);
            currentInstrument.Delete(out string msg);
            MessageBox.Show(msg);
            SceneManager.ChangeScene(this, new InventoryUI());
        }
    }
}
