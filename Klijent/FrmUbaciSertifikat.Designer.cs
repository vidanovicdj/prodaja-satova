namespace Klijent
{
    partial class FrmUbaciSertifikat
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
            lblNaziv = new Label();
            tbxNazivSertifikata = new TextBox();
            btnSacuvaj = new Button();
            SuspendLayout();
            // 
            // lblNaziv
            // 
            lblNaziv.AutoSize = true;
            lblNaziv.Location = new Point(70, 109);
            lblNaziv.Name = "lblNaziv";
            lblNaziv.Size = new Size(138, 20);
            lblNaziv.TabIndex = 0;
            lblNaziv.Text = "Naziv sertifikata:";
            // 
            // tbxNazivSertifikata
            // 
            tbxNazivSertifikata.Location = new Point(214, 106);
            tbxNazivSertifikata.Name = "tbxNazivSertifikata";
            tbxNazivSertifikata.Size = new Size(211, 27);
            tbxNazivSertifikata.TabIndex = 1;
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.BackColor = Color.Thistle;
            btnSacuvaj.Location = new Point(141, 188);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(203, 60);
            btnSacuvaj.TabIndex = 11;
            btnSacuvaj.Text = "Sačuvaj";
            btnSacuvaj.UseVisualStyleBackColor = false;
            btnSacuvaj.Click += btnSacuvaj_Click;
            // 
            // FrmUbaciSertifikat
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(485, 336);
            Controls.Add(btnSacuvaj);
            Controls.Add(tbxNazivSertifikata);
            Controls.Add(lblNaziv);
            Font = new Font("Georgia", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FrmUbaciSertifikat";
            Text = "Ubaci sertifikat";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNaziv;
        internal TextBox tbxNazivSertifikata;
        internal Button btnSacuvaj;
    }
}