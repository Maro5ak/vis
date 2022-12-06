namespace PresentationLayer {
    partial class InstrumentAddScreen {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InstrumentAddScreen));
            this.panel1 = new System.Windows.Forms.Panel();
            this.typeMenu = new System.Windows.Forms.ComboBox();
            this.rentableCheck = new System.Windows.Forms.CheckBox();
            this.depositBox = new System.Windows.Forms.TextBox();
            this.depositLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buyPriceBox = new System.Windows.Forms.TextBox();
            this.goBackBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.manufacturerBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rentPriceLabel = new System.Windows.Forms.Label();
            this.registerBtn = new System.Windows.Forms.Button();
            this.rentPriceBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.typeMenu);
            this.panel1.Controls.Add(this.rentableCheck);
            this.panel1.Controls.Add(this.depositBox);
            this.panel1.Controls.Add(this.depositLabel);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.buyPriceBox);
            this.panel1.Controls.Add(this.goBackBtn);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.manufacturerBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.rentPriceLabel);
            this.panel1.Controls.Add(this.registerBtn);
            this.panel1.Controls.Add(this.rentPriceBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.nameBox);
            this.panel1.Location = new System.Drawing.Point(180, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(562, 387);
            this.panel1.TabIndex = 12;
            // 
            // typeMenu
            // 
            this.typeMenu.AllowDrop = true;
            this.typeMenu.AutoCompleteCustomSource.AddRange(new string[] {
            "HHHHHHHHHHHHHHHHHHHHHHHHHHHHH"});
            this.typeMenu.FormattingEnabled = true;
            this.typeMenu.Location = new System.Drawing.Point(23, 94);
            this.typeMenu.MaxDropDownItems = 99;
            this.typeMenu.Name = "typeMenu";
            this.typeMenu.Size = new System.Drawing.Size(242, 23);
            this.typeMenu.TabIndex = 21;
            // 
            // rentableCheck
            // 
            this.rentableCheck.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rentableCheck.ForeColor = System.Drawing.Color.White;
            this.rentableCheck.Location = new System.Drawing.Point(154, 317);
            this.rentableCheck.Name = "rentableCheck";
            this.rentableCheck.Size = new System.Drawing.Size(111, 37);
            this.rentableCheck.TabIndex = 20;
            this.rentableCheck.Text = "Rentable";
            this.rentableCheck.UseVisualStyleBackColor = true;
            this.rentableCheck.CheckedChanged += new System.EventHandler(this.rentableCheck_CheckedChanged);
            // 
            // depositBox
            // 
            this.depositBox.Location = new System.Drawing.Point(296, 253);
            this.depositBox.MaxLength = 30;
            this.depositBox.Name = "depositBox";
            this.depositBox.Size = new System.Drawing.Size(242, 23);
            this.depositBox.TabIndex = 19;
            // 
            // depositLabel
            // 
            this.depositLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.depositLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.depositLabel.ForeColor = System.Drawing.Color.White;
            this.depositLabel.Location = new System.Drawing.Point(296, 226);
            this.depositLabel.Name = "depositLabel";
            this.depositLabel.Size = new System.Drawing.Size(161, 24);
            this.depositLabel.TabIndex = 18;
            this.depositLabel.Text = "Deposit";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(296, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 24);
            this.label6.TabIndex = 16;
            this.label6.Text = "Buy Price";
            // 
            // buyPriceBox
            // 
            this.buyPriceBox.Location = new System.Drawing.Point(296, 172);
            this.buyPriceBox.MaxLength = 80;
            this.buyPriceBox.Name = "buyPriceBox";
            this.buyPriceBox.Size = new System.Drawing.Size(242, 23);
            this.buyPriceBox.TabIndex = 15;
            // 
            // goBackBtn
            // 
            this.goBackBtn.FlatAppearance.BorderSize = 0;
            this.goBackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goBackBtn.Image = ((System.Drawing.Image)(resources.GetObject("goBackBtn.Image")));
            this.goBackBtn.Location = new System.Drawing.Point(524, 3);
            this.goBackBtn.Name = "goBackBtn";
            this.goBackBtn.Size = new System.Drawing.Size(35, 35);
            this.goBackBtn.TabIndex = 14;
            this.goBackBtn.UseVisualStyleBackColor = true;
            this.goBackBtn.Click += new System.EventHandler(this.goBackBtn_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(296, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 24);
            this.label5.TabIndex = 14;
            this.label5.Text = "Manufacturer";
            // 
            // manufacturerBox
            // 
            this.manufacturerBox.Location = new System.Drawing.Point(296, 94);
            this.manufacturerBox.MaxLength = 80;
            this.manufacturerBox.Name = "manufacturerBox";
            this.manufacturerBox.Size = new System.Drawing.Size(242, 23);
            this.manufacturerBox.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(141, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 45);
            this.label1.TabIndex = 6;
            this.label1.Text = "Instrument Data";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(23, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 24);
            this.label4.TabIndex = 12;
            this.label4.Text = "Instrument Type";
            // 
            // rentPriceLabel
            // 
            this.rentPriceLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rentPriceLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rentPriceLabel.ForeColor = System.Drawing.Color.White;
            this.rentPriceLabel.Location = new System.Drawing.Point(23, 226);
            this.rentPriceLabel.Name = "rentPriceLabel";
            this.rentPriceLabel.Size = new System.Drawing.Size(150, 24);
            this.rentPriceLabel.TabIndex = 10;
            this.rentPriceLabel.Text = "Rent Price";
            // 
            // registerBtn
            // 
            this.registerBtn.BackColor = System.Drawing.Color.Maroon;
            this.registerBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.registerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.registerBtn.ForeColor = System.Drawing.Color.White;
            this.registerBtn.Location = new System.Drawing.Point(296, 317);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(80, 37);
            this.registerBtn.TabIndex = 0;
            this.registerBtn.Text = "Go";
            this.registerBtn.UseVisualStyleBackColor = false;
            // 
            // rentPriceBox
            // 
            this.rentPriceBox.Location = new System.Drawing.Point(23, 253);
            this.rentPriceBox.MaxLength = 80;
            this.rentPriceBox.Name = "rentPriceBox";
            this.rentPriceBox.Size = new System.Drawing.Size(242, 23);
            this.rentPriceBox.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(23, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Name";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(23, 172);
            this.nameBox.MaxLength = 80;
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(242, 23);
            this.nameBox.TabIndex = 7;
            // 
            // InstrumentAddScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 491);
            this.Controls.Add(this.panel1);
            this.Name = "InstrumentAddScreen";
            this.Text = "InstrumentAddScreen";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private TextBox depositBox;
        private Label depositLabel;
        private Label label6;
        private TextBox buyPriceBox;
        private Button goBackBtn;
        private Label label5;
        private TextBox manufacturerBox;
        private Label label1;
        private Label label4;
        private Label rentPriceLabel;
        private Button registerBtn;
        private TextBox rentPriceBox;
        private Label label2;
        private TextBox nameBox;
        private CheckBox rentableCheck;
        private ComboBox typeMenu;
    }
}