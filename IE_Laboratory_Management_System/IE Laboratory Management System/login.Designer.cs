namespace WindowsFormsApp1
{
    partial class login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.pnlLoginpage = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.lblCredits = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblLoginpage = new System.Windows.Forms.Label();
            this.pbLoginpage = new System.Windows.Forms.PictureBox();
            this.pnlLoginpage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoginpage)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLoginpage
            // 
            this.pnlLoginpage.BackColor = System.Drawing.Color.Transparent;
            this.pnlLoginpage.Controls.Add(this.button1);
            this.pnlLoginpage.Controls.Add(this.lblCredits);
            this.pnlLoginpage.Controls.Add(this.btnLogin);
            this.pnlLoginpage.Controls.Add(this.tbPassword);
            this.pnlLoginpage.Controls.Add(this.tbUsername);
            this.pnlLoginpage.Controls.Add(this.lblPassword);
            this.pnlLoginpage.Controls.Add(this.lblUsername);
            this.pnlLoginpage.Controls.Add(this.lblLoginpage);
            this.pnlLoginpage.Controls.Add(this.pbLoginpage);
            this.pnlLoginpage.Location = new System.Drawing.Point(2, 1);
            this.pnlLoginpage.Name = "pnlLoginpage";
            this.pnlLoginpage.Size = new System.Drawing.Size(703, 270);
            this.pnlLoginpage.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.button1.Location = new System.Drawing.Point(440, 199);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(235, 41);
            this.button1.TabIndex = 8;
            this.button1.Text = "Enter Without Login";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblCredits
            // 
            this.lblCredits.AutoSize = true;
            this.lblCredits.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCredits.Location = new System.Drawing.Point(409, 252);
            this.lblCredits.Name = "lblCredits";
            this.lblCredits.Size = new System.Drawing.Size(291, 15);
            this.lblCredits.TabIndex = 7;
            this.lblCredits.Text = "Designed and Developed by Jayasurya Obbu";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnLogin.Location = new System.Drawing.Point(297, 199);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(115, 41);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(458, 158);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(217, 20);
            this.tbPassword.TabIndex = 5;
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(458, 113);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(217, 20);
            this.tbUsername.TabIndex = 4;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(280, 152);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(116, 26);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Password";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(280, 107);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(132, 26);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "User Name";
            // 
            // lblLoginpage
            // 
            this.lblLoginpage.AutoSize = true;
            this.lblLoginpage.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginpage.Location = new System.Drawing.Point(30, 29);
            this.lblLoginpage.Name = "lblLoginpage";
            this.lblLoginpage.Size = new System.Drawing.Size(645, 39);
            this.lblLoginpage.TabIndex = 1;
            this.lblLoginpage.Text = "IE Laboratory Management Login Page";
            // 
            // pbLoginpage
            // 
            this.pbLoginpage.Image = ((System.Drawing.Image)(resources.GetObject("pbLoginpage.Image")));
            this.pbLoginpage.Location = new System.Drawing.Point(37, 85);
            this.pbLoginpage.Name = "pbLoginpage";
            this.pbLoginpage.Size = new System.Drawing.Size(208, 137);
            this.pbLoginpage.TabIndex = 0;
            this.pbLoginpage.TabStop = false;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 272);
            this.Controls.Add(this.pnlLoginpage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "login";
            this.Text = "IE Laboratory Management - Login Page";
            this.Load += new System.EventHandler(this.login_Load);
            this.pnlLoginpage.ResumeLayout(false);
            this.pnlLoginpage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoginpage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLoginpage;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblLoginpage;
        private System.Windows.Forms.PictureBox pbLoginpage;
        private System.Windows.Forms.Label lblCredits;
        private System.Windows.Forms.Button button1;
    }
}

