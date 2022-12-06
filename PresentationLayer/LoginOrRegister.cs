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
    public partial class LoginOrRegister : Form {
        public LoginOrRegister() {
            InitializeComponent();
        }

        private void loginPageBtn_Click(object sender, EventArgs e) {
            SceneManager.ChangeScene(this, new LoginPage());
        }

        private void registerPageBtn_Click(object sender, EventArgs e) {
            SceneManager.ChangeScene(this, new RegisterPage());
        }

        private void goBackBtn_Click(object sender, EventArgs e) {
            SceneManager.ChangeScene(this, new InventoryUI());
        }
    }
}
