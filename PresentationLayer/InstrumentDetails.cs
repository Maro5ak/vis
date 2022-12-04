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
    public partial class InstrumentDetails : Form {
        public InstrumentDetails() {
            InitializeComponent();
        }

        private void logoBtn_Click(object sender, EventArgs e) {
            var frm = new InventoryUI();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
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
    }
}
