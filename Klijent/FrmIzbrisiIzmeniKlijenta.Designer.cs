namespace Klijent
{
    partial class FrmIzbrisiIzmeniKlijenta
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
            cbTipKlijenta = new ComboBox();
            tbxEmailKlijenta = new TextBox();
            tbxBrojTelefona = new TextBox();
            tbxPrezimeKlijenta = new TextBox();
            tbxImeKlijenta = new TextBox();
            lblTipKlijenta = new Label();
            lblEmailKlijenta = new Label();
            lblBrojTelefona = new Label();
            lblPrezimeKlijenta = new Label();
            lblImeKlijenta = new Label();
            btnIzmeni = new Button();
            btnObrisi = new Button();
            SuspendLayout();
            // 
            // cbTipKlijenta
            // 
            cbTipKlijenta.BackColor = SystemColors.ControlLightLight;
            cbTipKlijenta.FormattingEnabled = true;
            cbTipKlijenta.Location = new Point(184, 259);
            cbTipKlijenta.Name = "cbTipKlijenta";
            cbTipKlijenta.Size = new Size(223, 28);
            cbTipKlijenta.TabIndex = 19;
            // 
            // tbxEmailKlijenta
            // 
            tbxEmailKlijenta.BackColor = SystemColors.ControlLightLight;
            tbxEmailKlijenta.Location = new Point(184, 202);
            tbxEmailKlijenta.Name = "tbxEmailKlijenta";
            tbxEmailKlijenta.Size = new Size(223, 27);
            tbxEmailKlijenta.TabIndex = 18;
            // 
            // tbxBrojTelefona
            // 
            tbxBrojTelefona.BackColor = SystemColors.ControlLightLight;
            tbxBrojTelefona.Location = new Point(184, 152);
            tbxBrojTelefona.Name = "tbxBrojTelefona";
            tbxBrojTelefona.Size = new Size(223, 27);
            tbxBrojTelefona.TabIndex = 17;
            // 
            // tbxPrezimeKlijenta
            // 
            tbxPrezimeKlijenta.BackColor = SystemColors.ControlLightLight;
            tbxPrezimeKlijenta.Location = new Point(184, 101);
            tbxPrezimeKlijenta.Name = "tbxPrezimeKlijenta";
            tbxPrezimeKlijenta.Size = new Size(223, 27);
            tbxPrezimeKlijenta.TabIndex = 16;
            // 
            // tbxImeKlijenta
            // 
            tbxImeKlijenta.BackColor = SystemColors.ControlLightLight;
            tbxImeKlijenta.Location = new Point(184, 53);
            tbxImeKlijenta.Name = "tbxImeKlijenta";
            tbxImeKlijenta.Size = new Size(223, 27);
            tbxImeKlijenta.TabIndex = 15;
            // 
            // lblTipKlijenta
            // 
            lblTipKlijenta.AutoSize = true;
            lblTipKlijenta.Location = new Point(77, 262);
            lblTipKlijenta.Name = "lblTipKlijenta";
            lblTipKlijenta.Size = new Size(101, 20);
            lblTipKlijenta.TabIndex = 14;
            lblTipKlijenta.Text = "Tip klijenta:";
            // 
            // lblEmailKlijenta
            // 
            lblEmailKlijenta.AutoSize = true;
            lblEmailKlijenta.Location = new Point(119, 209);
            lblEmailKlijenta.Name = "lblEmailKlijenta";
            lblEmailKlijenta.Size = new Size(59, 20);
            lblEmailKlijenta.TabIndex = 13;
            lblEmailKlijenta.Text = "Email:";
            // 
            // lblBrojTelefona
            // 
            lblBrojTelefona.AutoSize = true;
            lblBrojTelefona.Location = new Point(67, 155);
            lblBrojTelefona.Name = "lblBrojTelefona";
            lblBrojTelefona.Size = new Size(111, 20);
            lblBrojTelefona.TabIndex = 12;
            lblBrojTelefona.Text = "Broj telefona:";
            // 
            // lblPrezimeKlijenta
            // 
            lblPrezimeKlijenta.AutoSize = true;
            lblPrezimeKlijenta.Location = new Point(103, 104);
            lblPrezimeKlijenta.Name = "lblPrezimeKlijenta";
            lblPrezimeKlijenta.Size = new Size(75, 20);
            lblPrezimeKlijenta.TabIndex = 11;
            lblPrezimeKlijenta.Text = "Prezime:";
            // 
            // lblImeKlijenta
            // 
            lblImeKlijenta.AutoSize = true;
            lblImeKlijenta.Location = new Point(134, 56);
            lblImeKlijenta.Name = "lblImeKlijenta";
            lblImeKlijenta.Size = new Size(44, 20);
            lblImeKlijenta.TabIndex = 10;
            lblImeKlijenta.Text = "Ime:";
            // 
            // btnIzmeni
            // 
            btnIzmeni.BackColor = Color.Thistle;
            btnIzmeni.Location = new Point(67, 343);
            btnIzmeni.Name = "btnIzmeni";
            btnIzmeni.Size = new Size(154, 54);
            btnIzmeni.TabIndex = 20;
            btnIzmeni.Text = "Izmeni";
            btnIzmeni.UseVisualStyleBackColor = false;
            btnIzmeni.Click += btnIzmeni_Click;
            // 
            // btnObrisi
            // 
            btnObrisi.BackColor = Color.Thistle;
            btnObrisi.Location = new Point(253, 343);
            btnObrisi.Name = "btnObrisi";
            btnObrisi.Size = new Size(154, 54);
            btnObrisi.TabIndex = 21;
            btnObrisi.Text = "Obriši";
            btnObrisi.UseVisualStyleBackColor = false;
            btnObrisi.Click += btnObrisi_Click;
            // 
            // FrmIzbrisiIzmeniKlijenta
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(519, 469);
            Controls.Add(btnObrisi);
            Controls.Add(btnIzmeni);
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
            Margin = new Padding(4, 3, 4, 3);
            Name = "FrmIzbrisiIzmeniKlijenta";
            Text = "Izmena korisnika";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        internal ComboBox cbTipKlijenta;
        internal TextBox tbxEmailKlijenta;
        internal TextBox tbxBrojTelefona;
        internal TextBox tbxPrezimeKlijenta;
        internal TextBox tbxImeKlijenta;
        private Label lblTipKlijenta;
        private Label lblEmailKlijenta;
        private Label lblBrojTelefona;
        private Label lblPrezimeKlijenta;
        private Label lblImeKlijenta;
        private Button btnIzmeni;
        private Button btnObrisi;
    }
}