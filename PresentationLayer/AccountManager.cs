namespace PresentationLayer {
    public partial class AccountManager : Form {
        public AccountManager() {
            InitializeComponent();
        }

        private void logoBtn_Click(object sender, EventArgs e) {

            var frm = new InventoryUI();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Close(); };
            frm.Show();
            this.Hide();
        }




    }
}