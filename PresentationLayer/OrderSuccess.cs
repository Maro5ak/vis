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

namespace PresentationLayer {
    public partial class OrderSuccess : Form {
        public OrderSuccess(int id) {
            InitializeComponent();
            msgLabel.Text = $"Order {id} Successfully placed!";
        }

        private void backBtn_Click(object sender, EventArgs e) {
            SceneManager.ChangeScene(this, new InventoryUI());
        }
    }
}
