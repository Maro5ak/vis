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
            SceneManager.ChangeScene(this, new LoginOrRegister());
        }
        
        private void loginBtn_Click(object sender, EventArgs e) {
            
            User user = new User(emailBox.Text, passwordBox.Text);
            if (!user.Validate(out Runtime.loggedIn, out string errorMsg)) {
                MessageBox.Show(errorMsg);
            }
            else {
                Runtime.loginState = true;
                SceneManager.ChangeScene(this, new InventoryUI());
            }
        }
    }
}
