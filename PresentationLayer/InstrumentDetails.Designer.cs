namespace PresentationLayer {
    partial class InstrumentDetails {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InstrumentDetails));
            this.panel1 = new System.Windows.Forms.Panel();
            this.deleteInstrumentBtn = new System.Windows.Forms.Button();
            this.logoBtn = new System.Windows.Forms.Button();
            this.cartBtn = new System.Windows.Forms.Button();
            this.profileBtn = new System.Windows.Forms.Button();
            this.instrumentLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.typeLabel = new System.Windows.Forms.Label();
            this.manufacturerLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.buyLabel = new System.Windows.Forms.Label();
            this.rentLabel = new System.Windows.Forms.Label();
            this.addToCartBtn = new System.Windows.Forms.Button();
            this.rentCheckBox = new System.Windows.Forms.CheckBox();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.deleteInstrumentBtn);
            this.panel1.Controls.Add(this.logoBtn);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(924, 59);
            this.panel1.TabIndex = 11;
            // 
            // deleteInstrumentBtn
            // 
            this.deleteInstrumentBtn.BackColor = System.Drawing.Color.Firebrick;
            this.deleteInstrumentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteInstrumentBtn.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deleteInstrumentBtn.Location = new System.Drawing.Point(663, 8);
            this.deleteInstrumentBtn.Name = "deleteInstrumentBtn";
            this.deleteInstrumentBtn.Size = new System.Drawing.Size(105, 46);
            this.deleteInstrumentBtn.TabIndex = 23;
            this.deleteInstrumentBtn.Text = "Delete";
            this.deleteInstrumentBtn.UseVisualStyleBackColor = false;
            this.deleteInstrumentBtn.Click += new System.EventHandler(this.deleteInstrumentBtn_Click);
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
            // cartBtn
            // 
            this.cartBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cartBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cartBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cartBtn.FlatAppearance.BorderSize = 4;
            this.cartBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cartBtn.ForeColor = System.Drawing.Color.White;
            this.cartBtn.Location = new System.Drawing.Point(774, 4);
            this.cartBtn.Name = "cartBtn";
            this.cartBtn.Size = new System.Drawing.Size(75, 53);
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
            this.profileBtn.Location = new System.Drawing.Point(846, 4);
            this.profileBtn.Name = "profileBtn";
            this.profileBtn.Size = new System.Drawing.Size(75, 53);
            this.profileBtn.TabIndex = 9;
            this.profileBtn.Text = "Profile";
            this.profileBtn.UseVisualStyleBackColor = false;
            this.profileBtn.Click += new System.EventHandler(this.profileBtn_Click);
            // 
            // instrumentLabel
            // 
            this.instrumentLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.instrumentLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.instrumentLabel.Location = new System.Drawing.Point(494, 92);
            this.instrumentLabel.Name = "instrumentLabel";
            this.instrumentLabel.Size = new System.Drawing.Size(282, 41);
            this.instrumentLabel.TabIndex = 12;
            this.instrumentLabel.Text = "Instrument";
            this.instrumentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.Location = new System.Drawing.Point(495, 140);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(281, 113);
            this.descriptionLabel.TabIndex = 13;
            this.descriptionLabel.Text = "description";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(167, 92);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(232, 235);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // typeLabel
            // 
            this.typeLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.typeLabel.Location = new System.Drawing.Point(167, 341);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(232, 19);
            this.typeLabel.TabIndex = 15;
            this.typeLabel.Text = "- type";
            // 
            // manufacturerLabel
            // 
            this.manufacturerLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.manufacturerLabel.Location = new System.Drawing.Point(167, 360);
            this.manufacturerLabel.Name = "manufacturerLabel";
            this.manufacturerLabel.Size = new System.Drawing.Size(232, 19);
            this.manufacturerLabel.TabIndex = 16;
            this.manufacturerLabel.Text = "- manufacturer";
            // 
            // nameLabel
            // 
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nameLabel.Location = new System.Drawing.Point(167, 379);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(232, 19);
            this.nameLabel.TabIndex = 17;
            this.nameLabel.Text = "- name";
            // 
            // buyLabel
            // 
            this.buyLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.buyLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buyLabel.Location = new System.Drawing.Point(493, 268);
            this.buyLabel.Name = "buyLabel";
            this.buyLabel.Size = new System.Drawing.Size(283, 29);
            this.buyLabel.TabIndex = 18;
            this.buyLabel.Text = "PRICE TO BUY";
            this.buyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rentLabel
            // 
            this.rentLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rentLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rentLabel.Location = new System.Drawing.Point(493, 298);
            this.rentLabel.Name = "rentLabel";
            this.rentLabel.Size = new System.Drawing.Size(283, 29);
            this.rentLabel.TabIndex = 19;
            this.rentLabel.Text = "PRICE TO RENT";
            this.rentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addToCartBtn
            // 
            this.addToCartBtn.BackColor = System.Drawing.Color.Firebrick;
            this.addToCartBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addToCartBtn.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addToCartBtn.Location = new System.Drawing.Point(562, 379);
            this.addToCartBtn.Name = "addToCartBtn";
            this.addToCartBtn.Size = new System.Drawing.Size(130, 54);
            this.addToCartBtn.TabIndex = 20;
            this.addToCartBtn.Text = "Add to cart";
            this.addToCartBtn.UseVisualStyleBackColor = false;
            this.addToCartBtn.Click += new System.EventHandler(this.addToCartBtn_Click);
            // 
            // rentCheckBox
            // 
            this.rentCheckBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rentCheckBox.Location = new System.Drawing.Point(718, 391);
            this.rentCheckBox.Name = "rentCheckBox";
            this.rentCheckBox.Size = new System.Drawing.Size(131, 28);
            this.rentCheckBox.TabIndex = 21;
            this.rentCheckBox.Text = "Rent item";
            this.rentCheckBox.UseVisualStyleBackColor = true;
            // 
            // quantityLabel
            // 
            this.quantityLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.quantityLabel.Location = new System.Drawing.Point(493, 333);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(152, 19);
            this.quantityLabel.TabIndex = 22;
            this.quantityLabel.Text = "quantity";
            // 
            // InstrumentDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 491);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.rentCheckBox);
            this.Controls.Add(this.addToCartBtn);
            this.Controls.Add(this.rentLabel);
            this.Controls.Add(this.buyLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.manufacturerLabel);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.instrumentLabel);
            this.Controls.Add(this.cartBtn);
            this.Controls.Add(this.profileBtn);
            this.Controls.Add(this.panel1);
            this.Name = "InstrumentDetails";
            this.Text = "InstrumentDetails";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button logoBtn;
        private Button cartBtn;
        private Button profileBtn;
        private Label instrumentLabel;
        private Label descriptionLabel;
        private PictureBox pictureBox1;
        private Label typeLabel;
        private Label manufacturerLabel;
        private Label nameLabel;
        private Label buyLabel;
        private Label rentLabel;
        private Button addToCartBtn;
        private CheckBox rentCheckBox;
        private Label quantityLabel;
        private Button deleteInstrumentBtn;
    }
}