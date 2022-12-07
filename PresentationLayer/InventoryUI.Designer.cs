namespace PresentationLayer {
    partial class InventoryUI {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryUI));
            this.panel1 = new System.Windows.Forms.Panel();
            this.instrumentsManagerBtn = new System.Windows.Forms.Button();
            this.logoBtn = new System.Windows.Forms.Button();
            this.cartBtn = new System.Windows.Forms.Button();
            this.profileBtn = new System.Windows.Forms.Button();
            this.inventoryLayout = new System.Windows.Forms.TableLayoutPanel();
            this.xmlLinkLabel = new System.Windows.Forms.LinkLabel();
            this.xmlBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.instrumentsManagerBtn);
            this.panel1.Controls.Add(this.logoBtn);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(924, 59);
            this.panel1.TabIndex = 8;
            // 
            // instrumentsManagerBtn
            // 
            this.instrumentsManagerBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.instrumentsManagerBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.instrumentsManagerBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.instrumentsManagerBtn.FlatAppearance.BorderSize = 4;
            this.instrumentsManagerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.instrumentsManagerBtn.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.instrumentsManagerBtn.ForeColor = System.Drawing.Color.White;
            this.instrumentsManagerBtn.Location = new System.Drawing.Point(694, 3);
            this.instrumentsManagerBtn.Name = "instrumentsManagerBtn";
            this.instrumentsManagerBtn.Size = new System.Drawing.Size(75, 53);
            this.instrumentsManagerBtn.TabIndex = 10;
            this.instrumentsManagerBtn.Text = "Instruments Manager";
            this.instrumentsManagerBtn.UseVisualStyleBackColor = false;
            this.instrumentsManagerBtn.Click += new System.EventHandler(this.instrumentsManagerBtn_Click);
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
            this.cartBtn.Location = new System.Drawing.Point(775, 4);
            this.cartBtn.Name = "cartBtn";
            this.cartBtn.Size = new System.Drawing.Size(75, 53);
            this.cartBtn.TabIndex = 7;
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
            this.profileBtn.Location = new System.Drawing.Point(847, 4);
            this.profileBtn.Name = "profileBtn";
            this.profileBtn.Size = new System.Drawing.Size(75, 53);
            this.profileBtn.TabIndex = 6;
            this.profileBtn.Text = "Profile";
            this.profileBtn.UseVisualStyleBackColor = false;
            this.profileBtn.Click += new System.EventHandler(this.profileBtn_Click);
            // 
            // inventoryLayout
            // 
            this.inventoryLayout.ColumnCount = 1;
            this.inventoryLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.inventoryLayout.Location = new System.Drawing.Point(330, 79);
            this.inventoryLayout.Name = "inventoryLayout";
            this.inventoryLayout.RowCount = 1;
            this.inventoryLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.inventoryLayout.Size = new System.Drawing.Size(549, 400);
            this.inventoryLayout.TabIndex = 9;
            // 
            // xmlLinkLabel
            // 
            this.xmlLinkLabel.LinkColor = System.Drawing.Color.Black;
            this.xmlLinkLabel.Location = new System.Drawing.Point(12, 440);
            this.xmlLinkLabel.Name = "xmlLinkLabel";
            this.xmlLinkLabel.Size = new System.Drawing.Size(302, 42);
            this.xmlLinkLabel.TabIndex = 10;
            this.xmlLinkLabel.TabStop = true;
            this.xmlLinkLabel.Text = "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA";
            this.xmlLinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.xmlLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.xmlLinkLabel_LinkClicked);
            // 
            // xmlBtn
            // 
            this.xmlBtn.Location = new System.Drawing.Point(92, 396);
            this.xmlBtn.Name = "xmlBtn";
            this.xmlBtn.Size = new System.Drawing.Size(124, 41);
            this.xmlBtn.TabIndex = 11;
            this.xmlBtn.Text = "Export XML";
            this.xmlBtn.UseVisualStyleBackColor = true;
            this.xmlBtn.Click += new System.EventHandler(this.xmlBtn_Click);
            // 
            // InventoryUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 491);
            this.Controls.Add(this.xmlBtn);
            this.Controls.Add(this.xmlLinkLabel);
            this.Controls.Add(this.inventoryLayout);
            this.Controls.Add(this.cartBtn);
            this.Controls.Add(this.profileBtn);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InventoryUI";
            this.Text = "InventoryUI";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button logoBtn;
        private Button cartBtn;
        private Button profileBtn;
        private TableLayoutPanel inventoryLayout;
        private Button instrumentsManagerBtn;
        private LinkLabel xmlLinkLabel;
        private Button xmlBtn;
    }
}