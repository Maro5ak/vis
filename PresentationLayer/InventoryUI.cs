using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using ExternalLibraries;

namespace PresentationLayer {
    public partial class InventoryUI : Form {

        public InventoryUI() {
            InitializeComponent();
            instrumentsManagerBtn.Visible = false;
            if (Runtime.privilegedMode) {
                instrumentsManagerBtn.Visible = true;
            }
            int instrumentCount = Inventory.inventoryMap.Count;
            int columnCount = inventoryLayout.ColumnCount = 5;
            int rowCount = inventoryLayout.RowCount = 1 + (instrumentCount / 5);

            inventoryLayout.RowStyles.Clear();
            inventoryLayout.ColumnStyles.Clear();
            inventoryLayout.AutoScroll = true;

            for (int i = 0; i < columnCount; i++) inventoryLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100));
            for (int i = 0; i < rowCount; i++) inventoryLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 100));

            int buttons = 0;
            for(int i = 0; i < rowCount; i++) {
                if (buttons == instrumentCount) break;
                for (int j = 0; j < columnCount; j++) {
                    if (buttons == instrumentCount) break;
                    Button btn = new Button();
                    btn.Text = Inventory.inventoryMap[buttons + 1].Manufacturer + "\n" + Inventory.inventoryMap[buttons + 1].Name;
                    btn.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                    btn.Name = "btn" + (buttons + 1);
                    btn.Height = 100;
                    btn.Width = 100;
                    btn.BackColor = Color.Gray;
                    inventoryLayout.Controls.Add(btn, j, i);
                    btn.Click += new EventHandler(instrumentButtonClick);
                    buttons++;
                }
            }
        }

        private void instrumentButtonClick(object sender, EventArgs e) {
            Button pressed = (Button)sender;

            int instrumentId = Int32.Parse(pressed.Name.Substring(3));
            SceneManager.ChangeScene(this, new InstrumentDetails(instrumentId));
            
        }

        private void profileBtn_Click(object sender, EventArgs e) {
            Form nextForm = new AccountManager();
            
            if (!Runtime.loginState)
                nextForm = new LoginOrRegister();

            SceneManager.ChangeScene(this, nextForm);
            
        }

        private void cartBtn_Click(object sender, EventArgs e) {
            SceneManager.ChangeScene(this, new CartPage());
        }

        private void instrumentsManagerBtn_Click(object sender, EventArgs e) {
            SceneManager.ChangeScene(this, new InstrumentAddScreen());
        }
    }
}
