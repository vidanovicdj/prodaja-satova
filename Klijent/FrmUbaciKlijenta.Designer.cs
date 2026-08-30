namespace Klijent
{
    partial class FrmUbaciKlijenta
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
            lblImeKlijenta = new Label();
            lblPrezimeKlijenta = new Label();
            lblBrojTelefona = new Label();
            lblEmailKlijenta = new Label();
            lblTipKlijenta = new Label();
            tbxImeKlijenta = new TextBox();
            tbxPrezimeKlijenta = new TextBox();
            tbxBrojTelefona = new TextBox();
            tbxEmailKlijenta = new TextBox();
            cbTipKlijenta = new ComboBox();
            btnSacuvaj = new Button();
            SuspendLayout();
            // 
            // lblImeKlijenta
            // 
            lblImeKlijenta.AutoSize = true;
            lblImeKlijenta.Location = new Point(128, 53);
            lblImeKlijenta.Name = "lblImeKlijenta";
            lblImeKlijenta.Size = new Size(44, 20);
            lblImeKlijenta.TabIndex = 0;
            lblImeKlijenta.Text = "Ime:";
            // 
            // lblPrezimeKlijenta
            // 
            lblPrezimeKlijenta.AutoSize = true;
            lblPrezimeKlijenta.Location = new Point(97, 101);
            lblPrezimeKlijenta.Name = "lblPrezimeKlijenta";
            lblPrezimeKlijenta.Size = new Size(75, 20);
            lblPrezimeKlijenta.TabIndex = 1;
            lblPrezimeKlijenta.Text = "Prezime:";
            // 
            // lblBrojTelefona
            // 
            lblBrojTelefona.AutoSize = true;
            lblBrojTelefona.Location = new Point(61, 152);
            lblBrojTelefona.Name = "lblBrojTelefona";
            lblBrojTelefona.Size = new Size(111, 20);
            lblBrojTelefona.TabIndex = 2;
            lblBrojTelefona.Text = "Broj telefona:";
            // 
            // lblEmailKlijenta
            // 
            lblEmailKlijenta.AutoSize = true;
            lblEmailKlijenta.Location = new Point(113, 206);
            lblEmailKlijenta.Name = "lblEmailKlijenta";
            lblEmailKlijenta.Size = new Size(59, 20);
            lblEmailKlijenta.TabIndex = 3;
            lblEmailKlijenta.Text = "Email:";
            // 
            // lblTipKlijenta
            // 
            lblTipKlijenta.AutoSize = true;
            lblTipKlijenta.Location = new Point(71, 259);
            lblTipKlijenta.Name = "lblTipKlijenta";
            lblTipKlijenta.Size = new Size(101, 20);
            lblTipKlijenta.TabIndex = 4;
            lblTipKlijenta.Text = "Tip klijenta:";
            // 
            // tbxImeKlijenta
            // 
            tbxImeKlijenta.BackColor = SystemColors.ControlLightLight;
            tbxImeKlijenta.Location = new Point(178, 50);
            tbxImeKlijenta.Name = "tbxImeKlijenta";
            tbxImeKlijenta.Size = new Size(223, 27);
            tbxImeKlijenta.TabIndex = 5;
            // 
            // tbxPrezimeKlijenta
            // 
            tbxPrezimeKlijenta.BackColor = SystemColors.ControlLightLight;
            tbxPrezimeKlijenta.Location = new Point(178, 98);
            tbxPrezimeKlijenta.Name = "tbxPrezimeKlijenta";
            tbxPrezimeKlijenta.Size = new Size(223, 27);
            tbxPrezimeKlijenta.TabIndex = 6;
            // 
            // tbxBrojTelefona
            // 
            tbxBrojTelefona.BackColor = SystemColors.ControlLightLight;
            tbxBrojTelefona.Location = new Point(178, 149);
            tbxBrojTelefona.Name = "tbxBrojTelefona";
            tbxBrojTelefona.Size = new Size(223, 27);
            tbxBrojTelefona.TabIndex = 7;
            // 
            // tbxEmailKlijenta
            // 
            tbxEmailKlijenta.BackColor = SystemColors.ControlLightLight;
            tbxEmailKlijenta.Location = new Point(178, 199);
            tbxEmailKlijenta.Name = "tbxEmailKlijenta";
            tbxEmailKlijenta.Size = new Size(223, 27);
            tbxEmailKlijenta.TabIndex = 8;
            // 
            // cbTipKlijenta
            // 
            cbTipKlijenta.BackColor = SystemColors.ControlLightLight;
            cbTipKlijenta.FormattingEnabled = true;
            cbTipKlijenta.Location = new Point(178, 256);
            cbTipKlijenta.Name = "cbTipKlijenta";
            cbTipKlijenta.Size = new Size(223, 28);
            cbTipKlijenta.TabIndex = 9;
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.BackColor = Color.Thistle;
            btnSacuvaj.Location = new Point(178, 353);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(203, 60);
            btnSacuvaj.TabIndex = 10;
            btnSacuvaj.Text = "Sačuvaj";
            btnSacuvaj.UseVisualStyleBackColor = false;
            btnSacuvaj.Click += btnSacuvaj_Click;
            // 
            // FrmUbaciKlijenta
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(535, 531);
            Controls.Add(btnSacuvaj);
            Controls.Add(cbTipKlijenta);
            Controls.Add(tbxEmailKlijenta);
            Controls.Add(tbxBrojTelefona);
            Controls.Add(tbxPrezimeKlijenta);
            Controls.Add(tbxImeKlijenta);
            Controls.Add(lblTipKlijenta);
            Controls.Add(lblEmailKlijenta);
            Controls.Add(lblBrojTelefona);
            Controls.Add(lblPrezimeKlijenta);
            Controls.Add(lblImeKlijenta);
            Font = new Font("Georgia", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "FrmUbaciKlijenta";
            Text = "Ubaci klijenta";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblImeKlijenta;
        private Label lblPrezimeKlijenta;
        private Label lblBrojTelefona;
        private Label lblEmailKlijenta;
        private Label lblTipKlijenta;
        internal TextBox tbxImeKlijenta;
        internal TextBox tbxPrezimeKlijenta;
        internal TextBox tbxBrojTelefona;
        internal TextBox tbxEmailKlijenta;
        internal ComboBox cbTipKlijenta;
        internal Button btnSacuvaj;
    }
}