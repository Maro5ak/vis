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
    public partial class RegisterPage : Form {
        public RegisterPage() {
            InitializeComponent();
        }

        private void registerBtn_Click(object sender, EventArgs e) {
            Runtime.loginState = true;
            User user = new User();
            Customer customer;
            user.Register(firstNameBox.Text, lastNameBox.Text, emailBox.Text, passwordBox.Text, Int32.Parse(phoneBox.Text), addressBox.Text, out customer);
            Runtime.loggedIn = customer.Id;
            var frm = new InventoryUI();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Close(); };
            frm.Show();
            this.Hide();
        }

        private void goBackBtn_Click(object sender, EventArgs e) {
            var frm = new InventoryUI();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Close(); };
            frm.Show();
            this.Hide();
        }
    }
}
