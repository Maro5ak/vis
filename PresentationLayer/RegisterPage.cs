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
            Int32.TryParse(phoneBox.Text, out int phoneNum);
            if (!user.Register(firstNameBox.Text, lastNameBox.Text, emailBox.Text, passwordBox.Text, phoneNum, addressBox.Text, out customer, out string msg)) {
                MessageBox.Show(msg);
                return;
            }
            
            Runtime.loggedIn = customer.Id;
            SceneManager.ChangeScene(this, new InventoryUI());
        }

        private void goBackBtn_Click(object sender, EventArgs e) {
            SceneManager.ChangeScene(this, new LoginOrRegister());
        }
    }
}
