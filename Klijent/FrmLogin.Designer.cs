namespace Klijent
{
    partial class FrmLogin
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
            lblUsername = new Label();
            lblPassword = new Label();
            tbxUsername = new TextBox();
            tbxPassword = new TextBox();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Georgia", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsername.Location = new Point(87, 99);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(137, 21);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Korisničko ime:";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Georgia", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPassword.Location = new Point(144, 161);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(80, 21);
            lblPassword.TabIndex = 1;
            lblPassword.Text = "Lozinka:";
            // 
            // tbxUsername
            // 
            tbxUsername.BackColor = SystemColors.ControlLightLight;
            tbxUsername.Font = new Font("Georgia", 10.8F);
            tbxUsername.Location = new Point(230, 97);
            tbxUsername.Name = "tbxUsername";
            tbxUsername.Size = new Size(223, 28);
            tbxUsername.TabIndex = 2;
            // 
            // tbxPassword
            // 
            tbxPassword.BackColor = SystemColors.ControlLightLight;
            tbxPassword.Font = new Font("Georgia", 10.8F);
            tbxPassword.Location = new Point(230, 159);
            tbxPassword.Name = "tbxPassword";
            tbxPassword.Size = new Size(223, 28);
            tbxPassword.TabIndex = 3;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Thistle;
            btnLogin.Location = new Point(144, 241);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(241, 61);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "PRIJAVI SE";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(585, 393);
            Controls.Add(btnLogin);
            Controls.Add(tbxPassword);
            Controls.Add(tbxUsername);
            Controls.Add(lblPassword);
            Controls.Add(lblUsername);
            Font = new Font("Georgia", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUsername;
        private Label lblPassword;
        internal TextBox tbxUsername;
        internal TextBox tbxPassword;
        private Button btnLogin;
    }
}