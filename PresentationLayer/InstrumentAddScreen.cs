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
        public InstrumentAddScreen() {
            InitializeComponent();
            rentableCheck.Checked = false;
            rentPriceBox.Visible = false;
            depositBox.Visible = false;
            rentPriceLabel.Visible = false;
            depositLabel.Visible = false;

            typeMenu.DataSource = Inventory.GetTypes().ToList();
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
    }
}
