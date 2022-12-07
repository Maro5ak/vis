namespace PresentationLayer {
    partial class AccountManager {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountManager));
            this.profileBtn = new System.Windows.Forms.Button();
            this.cartBtn = new System.Windows.Forms.Button();
            this.profilePic = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.logoBtn = new System.Windows.Forms.Button();
            this.profileNameBox = new System.Windows.Forms.TextBox();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.phoneBox = new System.Windows.Forms.TextBox();
            this.addressBox = new System.Windows.Forms.TextBox();
            this.ordersBtn = new System.Windows.Forms.Button();
            this.rentalBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.logFileLinkLabel = new System.Windows.Forms.LinkLabel();
            this.logFileLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.profilePic)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // profileBtn
            // 
            this.profileBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.profileBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.profileBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.profileBtn.FlatAppearance.BorderSize = 4;
            this.profileBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.profileBtn.ForeColor = System.Drawing.Color.White;
            this.profileBtn.Location = new System.Drawing.Point(847, 2);
            this.profileBtn.Name = "profileBtn";
            this.profileBtn.Size = new System.Drawing.Size(75, 53);
            this.profileBtn.TabIndex = 0;
            this.profileBtn.Text = "Profile";
            this.profileBtn.UseVisualStyleBackColor = false;
            // 
            // cartBtn
            // 
            this.cartBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cartBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cartBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cartBtn.FlatAppearance.BorderSize = 4;
            this.cartBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cartBtn.ForeColor = System.Drawing.Color.White;
            this.cartBtn.Location = new System.Drawing.Point(775, 2);
            this.cartBtn.Name = "cartBtn";
            this.cartBtn.Size = new System.Drawing.Size(75, 53);
            this.cartBtn.TabIndex = 1;
            this.cartBtn.Text = "Cart";
            this.cartBtn.UseVisualStyleBackColor = false;
            this.cartBtn.Click += new System.EventHandler(this.cartBtn_Click);
            // 
            // profilePic
            // 
            this.profilePic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.profilePic.Image = ((System.Drawing.Image)(resources.GetObject("profilePic.Image")));
            this.profilePic.Location = new System.Drawing.Point(103, 84);
            this.profilePic.Name = "profilePic";
            this.profilePic.Size = new System.Drawing.Size(220, 220);
            this.profilePic.TabIndex = 4;
            this.profilePic.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.logoBtn);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(924, 59);
            this.panel1.TabIndex = 5;
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
            this.logoBtn.Click += new System.EventHandler(this.logoBtn_Click);
            // 
            // profileNameBox
            // 
            this.profileNameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.profileNameBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.profileNameBox.Location = new System.Drawing.Point(125, 310);
            this.profileNameBox.MaxLength = 50;
            this.profileNameBox.Name = "profileNameBox";
            this.profileNameBox.Size = new System.Drawing.Size(180, 25);
            this.profileNameBox.TabIndex = 6;
            this.profileNameBox.Text = "Profile Name";
            this.profileNameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // emailBox
            // 
            this.emailBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emailBox.Location = new System.Drawing.Point(556, 91);
            this.emailBox.MaxLength = 80;
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(259, 23);
            this.emailBox.TabIndex = 7;
            this.emailBox.Text = "Email";
            this.emailBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // passwordBox
            // 
            this.passwordBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordBox.Location = new System.Drawing.Point(556, 138);
            this.passwordBox.MaxLength = 80;
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(259, 23);
            this.passwordBox.TabIndex = 8;
            this.passwordBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.passwordBox.UseSystemPasswordChar = true;
            // 
            // phoneBox
            // 
            this.phoneBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.phoneBox.Location = new System.Drawing.Point(556, 186);
            this.phoneBox.MaxLength = 9;
            this.phoneBox.Name = "phoneBox";
            this.phoneBox.Size = new System.Drawing.Size(259, 23);
            this.phoneBox.TabIndex = 9;
            this.phoneBox.Text = "Phone";
            this.phoneBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // addressBox
            // 
            this.addressBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addressBox.Location = new System.Drawing.Point(556, 234);
            this.addressBox.MaxLength = 80;
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(259, 23);
            this.addressBox.TabIndex = 10;
            this.addressBox.Text = "Address";
            this.addressBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ordersBtn
            // 
            this.ordersBtn.BackColor = System.Drawing.Color.Silver;
            this.ordersBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ordersBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ordersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ordersBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ordersBtn.Location = new System.Drawing.Point(556, 287);
            this.ordersBtn.Name = "ordersBtn";
            this.ordersBtn.Size = new System.Drawing.Size(101, 48);
            this.ordersBtn.TabIndex = 11;
            this.ordersBtn.Text = "Orders";
            this.ordersBtn.UseVisualStyleBackColor = false;
            this.ordersBtn.Click += new System.EventHandler(this.ordersBtn_Click);
            // 
            // rentalBtn
            // 
            this.rentalBtn.BackColor = System.Drawing.Color.Silver;
            this.rentalBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rentalBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.rentalBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rentalBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rentalBtn.Location = new System.Drawing.Point(714, 287);
            this.rentalBtn.Name = "rentalBtn";
            this.rentalBtn.Size = new System.Drawing.Size(101, 48);
            this.rentalBtn.TabIndex = 12;
            this.rentalBtn.Text = "Rented Items";
            this.rentalBtn.UseVisualStyleBackColor = false;
            this.rentalBtn.Click += new System.EventHandler(this.rentalBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.Silver;
            this.saveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.saveBtn.Location = new System.Drawing.Point(162, 370);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(101, 36);
            this.saveBtn.TabIndex = 13;
            this.saveBtn.Text = "Save Changes";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // logFileLinkLabel
            // 
            this.logFileLinkLabel.LinkColor = System.Drawing.Color.Black;
            this.logFileLinkLabel.Location = new System.Drawing.Point(59, 440);
            this.logFileLinkLabel.Name = "logFileLinkLabel";
            this.logFileLinkLabel.Size = new System.Drawing.Size(302, 42);
            this.logFileLinkLabel.TabIndex = 15;
            this.logFileLinkLabel.TabStop = true;
            this.logFileLinkLabel.Text = "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA";
            this.logFileLinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logFileLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.logFileLinkLabel_LinkClicked);
            // 
            // logFileLabel
            // 
            this.logFileLabel.AutoSize = true;
            this.logFileLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.logFileLabel.Location = new System.Drawing.Point(59, 425);
            this.logFileLabel.Name = "logFileLabel";
            this.logFileLabel.Size = new System.Drawing.Size(67, 21);
            this.logFileLabel.TabIndex = 16;
            this.logFileLabel.Text = "Log File:";
            // 
            // AccountManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 491);
            this.Controls.Add(this.logFileLabel);
            this.Controls.Add(this.logFileLinkLabel);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.rentalBtn);
            this.Controls.Add(this.ordersBtn);
            this.Controls.Add(this.addressBox);
            this.Controls.Add(this.phoneBox);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.profileNameBox);
            this.Controls.Add(this.profilePic);
            this.Controls.Add(this.cartBtn);
            this.Controls.Add(this.profileBtn);
            this.Controls.Add(this.panel1);
            this.Name = "AccountManager";
            this.Text = "Account Manager";
            ((System.ComponentModel.ISupportInitialize)(this.profilePic)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button profileBtn;
        private Button cartBtn;
        private PictureBox profilePic;
        private Panel panel1;
        private TextBox profileNameBox;
        private TextBox emailBox;
        private TextBox passwordBox;
        private TextBox phoneBox;
        private TextBox addressBox;
        private Button ordersBtn;
        private Button rentalBtn;
        private Button saveBtn;
        private Button logoBtn;
        private LinkLabel logFileLinkLabel;
        private Label logFileLabel;
    }
}