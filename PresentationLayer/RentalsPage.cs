using DataLayer;
using ExternalLibraries;
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
    public partial class RentalsPage : Form {
        public RentalsPage() {
            InitializeComponent(); 
            List<string> data = RentalDataGW.GetOrdersForUser(Runtime.loggedIn);
            rentalList.ColumnCount = 1;
            int rowCount = rentalList.RowCount = data.Count;
            rentalList.ColumnStyles.Clear();
            rentalList.RowStyles.Clear();

            rentalList.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100));
            for (int i = 0; i < rowCount; i++) rentalList.RowStyles.Add(new RowStyle(SizeType.Absolute, 60));

            bool swap = true;
            for (int i = 0; i < rowCount; i++) {
                Label label = new Label();
                label.AutoSize = false;
                label.Width = 828;
                label.Height = 40;
                label.Name = $"item{i}";
                label.Font = new Font("Seoge UI", 9);
                label.BackColor = Color.LightGray;
                label.TextAlign = ContentAlignment.MiddleCenter;
                //label.Click += new EventHandler(HandleRemoveItem_Click);
                label.Text = data[i];
                if (swap) label.BackColor = Color.LightSlateGray;
                rentalList.Controls.Add(label);
                swap = !swap;

            }


        }
        private void profileBtn_Click(object sender, EventArgs e) {
            SceneManager.ChangeScene(this, new AccountManager());
        }

        private void cartBtn_Click(object sender, EventArgs e) {
            SceneManager.ChangeScene(this, new CartPage());
        }

        private void logoBtn_Click(object sender, EventArgs e) {
            SceneManager.ChangeScene(this, new InventoryUI());
        }
    }
    
}
