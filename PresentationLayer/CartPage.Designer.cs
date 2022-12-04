namespace PresentationLayer {
    partial class CartPage {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CartPage));
            this.panel1 = new System.Windows.Forms.Panel();
            this.logoBtn = new System.Windows.Forms.Button();
            this.cartBtn = new System.Windows.Forms.Button();
            this.profileBtn = new System.Windows.Forms.Button();
            this.orderList = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.logoBtn);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(924, 59);
            this.panel1.TabIndex = 8;
            // 
            // logoBtn
            // 
            this.logoBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.logoBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.logoBtn.FlatAppearance.BorderSize = 0;
            this.logoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoBtn.ForeColor = System.Drawing.Color.White;
            this.logoBtn.Image = ((System.Drawing.Image)(resources.GetObject("logoBtn.Image")));
            this.logoBtn.Location = new System.Drawing.Point(3, 3);
            this.logoBtn.Name = "logoBtn";
            this.logoBtn.Size = new System.Drawing.Size(75, 53);
            this.logoBtn.TabIndex = 14;
            this.logoBtn.UseVisualStyleBackColor = false;
            // 
            // cartBtn
            // 
            this.cartBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cartBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cartBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cartBtn.FlatAppearance.BorderSize = 4;
            this.cartBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cartBtn.ForeColor = System.Drawing.Color.White;
            this.cartBtn.Location = new System.Drawing.Point(775, 3);
            this.cartBtn.Name = "cartBtn";
            this.cartBtn.Size = new System.Drawing.Size(75, 53);
            this.cartBtn.TabIndex = 7;
            this.cartBtn.Text = "Cart";
            this.cartBtn.UseVisualStyleBackColor = false;
            // 
            // profileBtn
            // 
            this.profileBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.profileBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.profileBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.profileBtn.FlatAppearance.BorderSize = 4;
            this.profileBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.profileBtn.ForeColor = System.Drawing.Color.White;
            this.profileBtn.Location = new System.Drawing.Point(847, 3);
            this.profileBtn.Name = "profileBtn";
            this.profileBtn.Size = new System.Drawing.Size(75, 53);
            this.profileBtn.TabIndex = 6;
            this.profileBtn.Text = "Profile";
            this.profileBtn.UseVisualStyleBackColor = false;
            // 
            // orderList
            // 
            this.orderList.AutoScroll = true;
            this.orderList.BackColor = System.Drawing.Color.White;
            this.orderList.ColumnCount = 1;
            this.orderList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.orderList.Location = new System.Drawing.Point(41, 31);
            this.orderList.Name = "orderList";
            this.orderList.RowCount = 1;
            this.orderList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.orderList.Size = new System.Drawing.Size(762, 273);
            this.orderList.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.orderList);
            this.panel2.Location = new System.Drawing.Point(47, 79);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(837, 393);
            this.panel2.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(733, 402);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 52);
            this.button1.TabIndex = 11;
            this.button1.Text = "Checkout";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // CartPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 491);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cartBtn);
            this.Controls.Add(this.profileBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "CartPage";
            this.Text = "CartPage";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button logoBtn;
        private Button cartBtn;
        private Button profileBtn;
        private TableLayoutPanel orderList;
        private Panel panel2;
        private Button button1;
    }
}