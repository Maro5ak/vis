namespace PresentationLayer {
    partial class CheckoutPage {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckoutPage));
            this.panel1 = new System.Windows.Forms.Panel();
            this.confirmBtn = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.depositLabel = new System.Windows.Forms.Label();
            this.priceSumLabel = new System.Windows.Forms.Label();
            this.itemsPriceLabel = new System.Windows.Forms.Label();
            this.deliveryLabel = new System.Windows.Forms.Label();
            this.paymentLabel = new System.Windows.Forms.Label();
            this.deliveryOptionsCheckBox = new System.Windows.Forms.CheckedListBox();
            this.paymentMethodCheckBox = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addressBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.logoBtn = new System.Windows.Forms.Button();
            this.cartBtn = new System.Windows.Forms.Button();
            this.profileBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.confirmBtn);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.deliveryOptionsCheckBox);
            this.panel1.Controls.Add(this.paymentMethodCheckBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.emailBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.addressBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.nameBox);
            this.panel1.Location = new System.Drawing.Point(117, 98);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 346);
            this.panel1.TabIndex = 0;
            // 
            // confirmBtn
            // 
            this.confirmBtn.BackColor = System.Drawing.Color.Maroon;
            this.confirmBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirmBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.confirmBtn.ForeColor = System.Drawing.Color.White;
            this.confirmBtn.Location = new System.Drawing.Point(519, 273);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(150, 52);
            this.confirmBtn.TabIndex = 22;
            this.confirmBtn.Text = "Confirm and Order";
            this.confirmBtn.UseVisualStyleBackColor = false;
            this.confirmBtn.Click += new System.EventHandler(this.confirmBtn_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(449, 188);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(215, 3);
            this.panel4.TabIndex = 21;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.Controls.Add(this.depositLabel);
            this.panel3.Controls.Add(this.priceSumLabel);
            this.panel3.Controls.Add(this.itemsPriceLabel);
            this.panel3.Controls.Add(this.deliveryLabel);
            this.panel3.Controls.Add(this.paymentLabel);
            this.panel3.Location = new System.Drawing.Point(438, 20);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(231, 226);
            this.panel3.TabIndex = 20;
            // 
            // depositLabel
            // 
            this.depositLabel.BackColor = System.Drawing.Color.Gray;
            this.depositLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.depositLabel.ForeColor = System.Drawing.Color.Black;
            this.depositLabel.Location = new System.Drawing.Point(16, 133);
            this.depositLabel.Name = "depositLabel";
            this.depositLabel.Size = new System.Drawing.Size(201, 29);
            this.depositLabel.TabIndex = 25;
            this.depositLabel.Text = "Deposit";
            // 
            // priceSumLabel
            // 
            this.priceSumLabel.BackColor = System.Drawing.Color.Gray;
            this.priceSumLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.priceSumLabel.ForeColor = System.Drawing.Color.Black;
            this.priceSumLabel.Location = new System.Drawing.Point(16, 178);
            this.priceSumLabel.Name = "priceSumLabel";
            this.priceSumLabel.Size = new System.Drawing.Size(201, 29);
            this.priceSumLabel.TabIndex = 24;
            this.priceSumLabel.Text = "Sum";
            this.priceSumLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // itemsPriceLabel
            // 
            this.itemsPriceLabel.BackColor = System.Drawing.Color.Gray;
            this.itemsPriceLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.itemsPriceLabel.ForeColor = System.Drawing.Color.Black;
            this.itemsPriceLabel.Location = new System.Drawing.Point(16, 90);
            this.itemsPriceLabel.Name = "itemsPriceLabel";
            this.itemsPriceLabel.Size = new System.Drawing.Size(201, 29);
            this.itemsPriceLabel.TabIndex = 23;
            this.itemsPriceLabel.Text = "Itemsprice";
            // 
            // deliveryLabel
            // 
            this.deliveryLabel.BackColor = System.Drawing.Color.Gray;
            this.deliveryLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deliveryLabel.ForeColor = System.Drawing.Color.Black;
            this.deliveryLabel.Location = new System.Drawing.Point(16, 48);
            this.deliveryLabel.Name = "deliveryLabel";
            this.deliveryLabel.Size = new System.Drawing.Size(201, 29);
            this.deliveryLabel.TabIndex = 22;
            this.deliveryLabel.Text = "Delivery";
            // 
            // paymentLabel
            // 
            this.paymentLabel.BackColor = System.Drawing.Color.Gray;
            this.paymentLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.paymentLabel.ForeColor = System.Drawing.Color.Black;
            this.paymentLabel.Location = new System.Drawing.Point(16, 11);
            this.paymentLabel.Name = "paymentLabel";
            this.paymentLabel.Size = new System.Drawing.Size(201, 29);
            this.paymentLabel.TabIndex = 21;
            this.paymentLabel.Text = "Payment";
            // 
            // deliveryOptionsCheckBox
            // 
            this.deliveryOptionsCheckBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.deliveryOptionsCheckBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.deliveryOptionsCheckBox.CheckOnClick = true;
            this.deliveryOptionsCheckBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deliveryOptionsCheckBox.ForeColor = System.Drawing.Color.White;
            this.deliveryOptionsCheckBox.FormattingEnabled = true;
            this.deliveryOptionsCheckBox.Items.AddRange(new object[] {
            "Pickup",
            "Deliver"});
            this.deliveryOptionsCheckBox.Location = new System.Drawing.Point(219, 198);
            this.deliveryOptionsCheckBox.Name = "deliveryOptionsCheckBox";
            this.deliveryOptionsCheckBox.Size = new System.Drawing.Size(90, 48);
            this.deliveryOptionsCheckBox.TabIndex = 19;
            this.deliveryOptionsCheckBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.deliveryOptionsCheckBox_ItemCheck);
            // 
            // paymentMethodCheckBox
            // 
            this.paymentMethodCheckBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.paymentMethodCheckBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.paymentMethodCheckBox.CheckOnClick = true;
            this.paymentMethodCheckBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.paymentMethodCheckBox.ForeColor = System.Drawing.Color.White;
            this.paymentMethodCheckBox.FormattingEnabled = true;
            this.paymentMethodCheckBox.Items.AddRange(new object[] {
            "PayPal",
            "Cash",
            "Bank Transfer",
            "Card"});
            this.paymentMethodCheckBox.Location = new System.Drawing.Point(31, 198);
            this.paymentMethodCheckBox.Name = "paymentMethodCheckBox";
            this.paymentMethodCheckBox.Size = new System.Drawing.Size(122, 96);
            this.paymentMethodCheckBox.TabIndex = 18;
            this.paymentMethodCheckBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.paymentMethodCheckBox_ItemCheck);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(31, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 24);
            this.label3.TabIndex = 17;
            this.label3.Text = "Email";
            // 
            // emailBox
            // 
            this.emailBox.Location = new System.Drawing.Point(31, 153);
            this.emailBox.MaxLength = 80;
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(278, 23);
            this.emailBox.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(31, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 24);
            this.label1.TabIndex = 15;
            this.label1.Text = "Address";
            // 
            // addressBox
            // 
            this.addressBox.Location = new System.Drawing.Point(31, 100);
            this.addressBox.MaxLength = 80;
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(278, 23);
            this.addressBox.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(31, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 24);
            this.label2.TabIndex = 13;
            this.label2.Text = "Name";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(31, 47);
            this.nameBox.MaxLength = 80;
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(278, 23);
            this.nameBox.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.logoBtn);
            this.panel2.Location = new System.Drawing.Point(-1, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(924, 60);
            this.panel2.TabIndex = 11;
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
            this.cartBtn.Size = new System.Drawing.Size(75, 54);
            this.cartBtn.TabIndex = 10;
            this.cartBtn.Text = "Cart";
            this.cartBtn.UseVisualStyleBackColor = false;
            this.cartBtn.Click += new System.EventHandler(this.cartBtn_Click);
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
            this.profileBtn.Size = new System.Drawing.Size(75, 54);
            this.profileBtn.TabIndex = 9;
            this.profileBtn.Text = "Profile";
            this.profileBtn.UseVisualStyleBackColor = false;
            this.profileBtn.Click += new System.EventHandler(this.profileBtn_Click);
            // 
            // CheckoutPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 491);
            this.Controls.Add(this.cartBtn);
            this.Controls.Add(this.profileBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "CheckoutPage";
            this.Text = "CheckoutPage";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button logoBtn;
        private Button cartBtn;
        private Button profileBtn;
        private CheckedListBox paymentMethodCheckBox;
        private Label label3;
        private TextBox emailBox;
        private Label label1;
        private TextBox addressBox;
        private Label label2;
        private TextBox nameBox;
        private Button confirmBtn;
        private Panel panel4;
        private Panel panel3;
        private Label priceSumLabel;
        private Label itemsPriceLabel;
        private Label deliveryLabel;
        private Label paymentLabel;
        private CheckedListBox deliveryOptionsCheckBox;
        private Label depositLabel;
    }
}