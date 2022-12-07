using BusinessLayer;
using ExternalLibraries;
using System.Diagnostics;

namespace PresentationLayer {
    public partial class AccountManager : Form {
        Customer current;
        private string logFilePath = @"C:\Users\maros\source\repos\VIS\vis\ExternalLibraries\Log.txt";
        public AccountManager() {
            InitializeComponent();
            SceneManager.InitState(this);
            logFileLinkLabel.Hide();
            logFileLabel.Hide();

            if (Runtime.privilegedMode) {
                current = new Admin(Runtime.loggedIn);
                logFileLinkLabel.Show();
                logFileLabel.Show();
            }
            else current = new Customer(Runtime.loggedIn);

            logFileLinkLabel.Text = logFilePath;
            profileNameBox.Text = Utils.Concat(current.Firstname, current.Lastname);
            emailBox.Text = current.Email;
            passwordBox.Text = "notchanged";
            phoneBox.Text = current.Phone.ToString();
            addressBox.Text = current.Address;
            
        }

        private void logoBtn_Click(object sender, EventArgs e) {
            SceneManager.ChangeScene(this, new InventoryUI());
        }

        private void saveBtn_Click(object sender, EventArgs e) {
            string[] name = profileNameBox.Text.Split(" ");
            string pw = passwordBox.Text;
            Customer updateCustomer;
            if (pw.Equals("notchanged"))
                updateCustomer = new Customer(Runtime.loggedIn, name[0], name[1], emailBox.Text, Int32.Parse(phoneBox.Text), addressBox.Text);
            else updateCustomer = new Customer(Runtime.loggedIn, name[0], name[1], emailBox.Text, Int32.Parse(phoneBox.Text), pw, addressBox.Text);
            current = updateCustomer;
            current.Update(out string msg);
        }

        private void ordersBtn_Click(object sender, EventArgs e) {
            SceneManager.ChangeScene(this, new OrdersPage());
        }

        private void rentalBtn_Click(object sender, EventArgs e) {
            SceneManager.ChangeScene(this, new RentalsPage());
        }

        private void cartBtn_Click(object sender, EventArgs e) {
            SceneManager.ChangeScene(this, new CartPage());
        }

        private void logFileLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            Process.Start("explorer.exe", logFilePath);
        }
    }
}