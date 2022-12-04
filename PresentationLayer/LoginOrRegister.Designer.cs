namespace PresentationLayer {
    partial class LoginOrRegister {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginOrRegister));
            this.panel1 = new System.Windows.Forms.Panel();
            this.goBackBtn = new System.Windows.Forms.Button();
            this.registerPageBtn = new System.Windows.Forms.Button();
            this.loginPageBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.goBackBtn);
            this.panel1.Controls.Add(this.registerPageBtn);
            this.panel1.Controls.Add(this.loginPageBtn);
            this.panel1.Location = new System.Drawing.Point(255, 152);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(408, 156);
            this.panel1.TabIndex = 12;
            // 
            // goBackBtn
            // 
            this.goBackBtn.FlatAppearance.BorderSize = 0;
            this.goBackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goBackBtn.Image = ((System.Drawing.Image)(resources.GetObject("goBackBtn.Image")));
            this.goBackBtn.Location = new System.Drawing.Point(373, 0);
            this.goBackBtn.Name = "goBackBtn";
            this.goBackBtn.Size = new System.Drawing.Size(35, 35);
            this.goBackBtn.TabIndex = 13;
            this.goBackBtn.UseVisualStyleBackColor = true;
            this.goBackBtn.Click += new System.EventHandler(this.goBackBtn_Click);
            // 
            // registerPageBtn
            // 
            this.registerPageBtn.BackColor = System.Drawing.Color.Olive;
            this.registerPageBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.registerPageBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerPageBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.registerPageBtn.Location = new System.Drawing.Point(212, 44);
            this.registerPageBtn.Name = "registerPageBtn";
            this.registerPageBtn.Size = new System.Drawing.Size(181, 66);
            this.registerPageBtn.TabIndex = 1;
            this.registerPageBtn.Text = "Don\'t have account";
            this.registerPageBtn.UseVisualStyleBackColor = false;
            this.registerPageBtn.Click += new System.EventHandler(this.registerPageBtn_Click);
            // 
            // loginPageBtn
            // 
            this.loginPageBtn.BackColor = System.Drawing.Color.Olive;
            this.loginPageBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.loginPageBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginPageBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loginPageBtn.Location = new System.Drawing.Point(14, 44);
            this.loginPageBtn.Name = "loginPageBtn";
            this.loginPageBtn.Size = new System.Drawing.Size(181, 66);
            this.loginPageBtn.TabIndex = 0;
            this.loginPageBtn.Text = "Already have account";
            this.loginPageBtn.UseVisualStyleBackColor = false;
            this.loginPageBtn.Click += new System.EventHandler(this.loginPageBtn_Click);
            // 
            // LoginOrRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 491);
            this.Controls.Add(this.panel1);
            this.Name = "LoginOrRegister";
            this.Text = "Choose";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button registerPageBtn;
        private Button loginPageBtn;
        private Button goBackBtn;
    }
}