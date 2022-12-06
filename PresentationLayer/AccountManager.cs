using BusinessLayer;
using ExternalLibraries;

namespace PresentationLayer {
    public partial class AccountManager : Form {
        Customer current;
        public AccountManager() {
            InitializeComponent();
            ticketsBtn.Hide();
            
            if (Runtime.privilegedMode) {
                ticketsBtn.Show();
                current = new Admin(Runtime.loggedIn);
            }
            else current = new Customer(Runtime.loggedIn);

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
            current.Update();
        }

        private void ordersBtn_Click(object sender, EventArgs e) {
            SceneManager.ChangeScene(this, new OrdersPage());
        }

        private void rentalBtn_Click(object sender, EventArgs e) {
            SceneManager.ChangeScene(this, new RentalsPage());
        }
    }
}