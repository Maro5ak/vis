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
    public partial class LoginPage : Form {
        public LoginPage() {
            InitializeComponent();
        }

        private void goBackBtn_Click(object sender, EventArgs e) {
            var frm = new InventoryUI();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Close(); };
            frm.Show();
            this.Hide();
        }
        
        private void loginBtn_Click(object sender, EventArgs e) {
            
            User user = new User(emailBox.Text, passwordBox.Text);
            if (!user.Validate(out Runtime.loggedIn)) {
                MessageBox.Show("Incorrect email or password.");
            }
            else {
                Runtime.loginState = true;
                var frm = new InventoryUI();
                frm.Location = this.Location;
                frm.StartPosition = FormStartPosition.Manual;
                frm.FormClosing += delegate { this.Close(); };
                frm.Show();
                this.Hide();
            }
        }
    }
}
