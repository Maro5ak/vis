﻿using BusinessLayer;
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
    public partial class OrdersPage : Form {
        private List<Order> orders = new List<Order>();
        public OrdersPage() {
            InitializeComponent();
            List<string> data = OrderDataGW.GetOrdersForUser(Runtime.loggedIn);
            orderList.ColumnCount = 1;
            int rowCount = orderList.RowCount = data.Count;
            orderList.ColumnStyles.Clear();
            orderList.RowStyles.Clear();

            orderList.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100));
            for (int i = 0; i < rowCount; i++) orderList.RowStyles.Add(new RowStyle(SizeType.Absolute, 60));

            bool swap = true;
            for (int i = 0; i < rowCount; i++) {
                Label label = new Label();
                label.AutoSize = false;
                label.Width = 828;
                label.Height = 40;
                label.Name = $"item{i}";
                label.Font = new Font("Seoge UI", 14);
                label.BackColor = Color.LightGray;
                label.TextAlign = ContentAlignment.MiddleCenter;
                //label.Click += new EventHandler(HandleRemoveItem_Click);
                label.Text = data[i];
                if (swap) label.BackColor = Color.LightSlateGray;
                orderList.Controls.Add(label);
                swap = !swap;

            }

   
        }
        private void profileBtn_Click(object sender, EventArgs e) {
            Form nextForm = new AccountManager();
            if (!Runtime.loginState)
                nextForm = new LoginOrRegister();

            nextForm.Location = this.Location;
            nextForm.StartPosition = FormStartPosition.Manual;
            nextForm.FormClosing += delegate { this.Close(); };
            nextForm.Show();
            this.Hide();
        }

        private void logoBtn_Click(object sender, EventArgs e) {
            Form nextForm = new InventoryUI();
            nextForm.Location = this.Location;
            nextForm.StartPosition = FormStartPosition.Manual;
            nextForm.FormClosing += delegate { this.Close(); };
            nextForm.Show();
            this.Hide();
        }

        

        private void cartBtn_Click(object sender, EventArgs e) {
            Form nextForm = new CartPage();
            nextForm.Location = this.Location;
            nextForm.StartPosition = FormStartPosition.Manual;
            nextForm.FormClosing += delegate { this.Close(); };
            nextForm.Show();
            this.Hide();
        }

        
    }
}