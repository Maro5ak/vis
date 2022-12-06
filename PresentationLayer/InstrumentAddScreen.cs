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
    public partial class InstrumentAddScreen : Form {
        private bool update = false;
        public InstrumentAddScreen() {
            InitializeComponent();
            rentableCheck.Checked = false;
            rentPriceBox.Visible = false;
            depositBox.Visible = false;
            rentPriceLabel.Visible = false;
            depositLabel.Visible = false;

            typeMenu.DataSource = Inventory.GetTypes().ToList();

            instrumentMenu.DataSource = Inventory.GetInstrumentNames();
            
        }

        private void rentableCheck_CheckedChanged(object sender, EventArgs e) {
            VisibilityToggle();
        }

        private void VisibilityToggle() {
            rentPriceBox.Visible = !rentPriceBox.Visible;
            depositBox.Visible = !depositBox.Visible;
            rentPriceLabel.Visible = !rentPriceLabel.Visible;
            depositLabel.Visible = !depositLabel.Visible;
        }

        private void goBackBtn_Click(object sender, EventArgs e) {
            SceneManager.ChangeScene(this, new InventoryUI());
        }

        private void goBtn_Click(object sender, EventArgs e) {
            string name = nameBox.Text;
            string type = typeMenu.Text;
            string manufacturer = manufacturerBox.Text;
            string description = descriptionBox.Text;
            Int32.TryParse(buyPriceBox.Text, out int buyPrice);
            Int32.TryParse(quantityBox.Text, out int quantity);
            
            Instrument instrument;
            if (rentableCheck.Checked) {
                Int32.TryParse(rentPriceBox.Text, out int rentPrice);
                Int32.TryParse(depositBox.Text, out int deposit);
                instrument = new Instrument(-1, type, manufacturer, name, description, buyPrice, rentPrice, deposit, quantity, true);
            }
            else {
                instrument = new Instrument(-1, type, manufacturer, name, description, buyPrice, quantity: quantity, rentable: false);
            }
            string msg;
            if (update) 
                instrument.Update(out msg);
             
            else 
                instrument.Insert(out msg);

            MessageBox.Show(msg);
        }

        private void instrumentMenu_SelectedIndexChanged(object sender, EventArgs e) {
            string selected = instrumentMenu.SelectedItem.ToString();
            int instrumentId = Int32.Parse(selected.Substring(0, selected.IndexOf(";")));
            if (instrumentId == 0) update = false;
            else {
                update = true;
                Instrument current = Inventory.inventoryMap[instrumentId];
                nameBox.Text = current.Name;
                manufacturerBox.Text = current.Manufacturer;
                buyPriceBox.Text = current.PriceBuy.ToString();
                descriptionBox.Text = current.Description;
                typeMenu.SelectedItem = current.Type;
                quantityBox.Text = current.Quantity.ToString();
                if (current.Rentable) {
                    rentableCheck.Checked = true;
                    rentPriceBox.Text = current.PriceRent.ToString();
                    depositBox.Text = current.Deposit.ToString();

                }
            }
        }
    }
}
