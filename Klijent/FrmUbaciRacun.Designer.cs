namespace Klijent
{
    partial class FrmUbaciRacun
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
            lblProdavac = new Label();
            lblKlijent = new Label();
            lblDatumIzdavanja = new Label();
            cbKlijenti = new ComboBox();
            dtpDatumIzdavanja = new DateTimePicker();
            lblPunaCena = new Label();
            lblPogodnost = new Label();
            lblKrajnjaCena = new Label();
            tbxPunaCena = new TextBox();
            tbxProcenatPopusta = new TextBox();
            tbxCenaSaPopustom = new TextBox();
            pnlUnosStavki = new Panel();
            btnObrisiStavku = new Button();
            btnDodajStavku = new Button();
            tbxCenaStavke = new TextBox();
            tbxKolicina = new TextBox();
            tbxJedinicnaCena = new TextBox();
            cbSatovi = new ComboBox();
            lblCenaStavke = new Label();
            lblKolicina = new Label();
            lblJedinicnaCena = new Label();
            lblSat = new Label();
            dgvStavke = new DataGridView();
            btnSacuvajRacun = new Button();
            cbProdavci = new ComboBox();
            lblNacinPlacanja = new Label();
            cbNacinPlacanja = new ComboBox();
            pnlUnosStavki.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStavke).BeginInit();
            SuspendLayout();
            // 
            // lblProdavac
            // 
            lblProdavac.AutoSize = true;
            lblProdavac.Location = new Point(118, 43);
            lblProdavac.Name = "lblProdavac";
            lblProdavac.Size = new Size(84, 20);
            lblProdavac.TabIndex = 0;
            lblProdavac.Text = "Prodavac:";
            // 
            // lblKlijent
            // 
            lblKlijent.AutoSize = true;
            lblKlijent.Location = new Point(137, 91);
            lblKlijent.Name = "lblKlijent";
            lblKlijent.Size = new Size(65, 20);
            lblKlijent.TabIndex = 1;
            lblKlijent.Text = "Klijent:";
            // 
            // lblDatumIzdavanja
            // 
            lblDatumIzdavanja.AutoSize = true;
            lblDatumIzdavanja.Location = new Point(58, 135);
            lblDatumIzdavanja.Name = "lblDatumIzdavanja";
            lblDatumIzdavanja.Size = new Size(144, 20);
            lblDatumIzdavanja.TabIndex = 2;
            lblDatumIzdavanja.Text = "Datum izdavanja:";
            // 
            // cbKlijenti
            // 
            cbKlijenti.FormattingEnabled = true;
            cbKlijenti.Location = new Point(208, 88);
            cbKlijenti.Name = "cbKlijenti";
            cbKlijenti.Size = new Size(283, 28);
            cbKlijenti.TabIndex = 4;
            cbKlijenti.SelectedIndexChanged += cbKlijenti_SelectedIndexChanged;
            // 
            // dtpDatumIzdavanja
            // 
            dtpDatumIzdavanja.Location = new Point(208, 130);
            dtpDatumIzdavanja.Name = "dtpDatumIzdavanja";
            dtpDatumIzdavanja.Size = new Size(283, 27);
            dtpDatumIzdavanja.TabIndex = 5;
            // 
            // lblPunaCena
            // 
            lblPunaCena.AutoSize = true;
            lblPunaCena.Location = new Point(723, 43);
            lblPunaCena.Name = "lblPunaCena";
            lblPunaCena.Size = new Size(92, 20);
            lblPunaCena.TabIndex = 6;
            lblPunaCena.Text = "Puna cena:";
            // 
            // lblPogodnost
            // 
            lblPogodnost.AutoSize = true;
            lblPogodnost.Location = new Point(646, 91);
            lblPogodnost.Name = "lblPogodnost";
            lblPogodnost.Size = new Size(169, 20);
            lblPogodnost.TabIndex = 7;
            lblPogodnost.Text = "Procenat pogodnosti:";
            // 
            // lblKrajnjaCena
            // 
            lblKrajnjaCena.AutoSize = true;
            lblKrajnjaCena.Location = new Point(705, 135);
            lblKrajnjaCena.Name = "lblKrajnjaCena";
            lblKrajnjaCena.Size = new Size(110, 20);
            lblKrajnjaCena.TabIndex = 8;
            lblKrajnjaCena.Text = "Krajnja cena:";
            // 
            // tbxPunaCena
            // 
            tbxPunaCena.Location = new Point(821, 40);
            tbxPunaCena.Name = "tbxPunaCena";
            tbxPunaCena.ReadOnly = true;
            tbxPunaCena.Size = new Size(199, 27);
            tbxPunaCena.TabIndex = 9;
            // 
            // tbxProcenatPopusta
            // 
            tbxProcenatPopusta.Location = new Point(821, 88);
            tbxProcenatPopusta.Name = "tbxProcenatPopusta";
            tbxProcenatPopusta.ReadOnly = true;
            tbxProcenatPopusta.Size = new Size(199, 27);
            tbxProcenatPopusta.TabIndex = 10;
            // 
            // tbxCenaSaPopustom
            // 
            tbxCenaSaPopustom.Location = new Point(821, 132);
            tbxCenaSaPopustom.Name = "tbxCenaSaPopustom";
            tbxCenaSaPopustom.ReadOnly = true;
            tbxCenaSaPopustom.Size = new Size(199, 27);
            tbxCenaSaPopustom.TabIndex = 11;
            // 
            // pnlUnosStavki
            // 
            pnlUnosStavki.Controls.Add(btnObrisiStavku);
            pnlUnosStavki.Controls.Add(btnDodajStavku);
            pnlUnosStavki.Controls.Add(tbxCenaStavke);
            pnlUnosStavki.Controls.Add(tbxKolicina);
            pnlUnosStavki.Controls.Add(tbxJedinicnaCena);
            pnlUnosStavki.Controls.Add(cbSatovi);
            pnlUnosStavki.Controls.Add(lblCenaStavke);
            pnlUnosStavki.Controls.Add(lblKolicina);
            pnlUnosStavki.Controls.Add(lblJedinicnaCena);
            pnlUnosStavki.Controls.Add(lblSat);
            pnlUnosStavki.Location = new Point(58, 230);
            pnlUnosStavki.Name = "pnlUnosStavki";
            pnlUnosStavki.Size = new Size(534, 375);
            pnlUnosStavki.TabIndex = 12;
            // 
            // btnObrisiStavku
            // 
            btnObrisiStavku.BackColor = Color.Thistle;
            btnObrisiStavku.Location = new Point(246, 275);
            btnObrisiStavku.Name = "btnObrisiStavku";
            btnObrisiStavku.Size = new Size(187, 53);
            btnObrisiStavku.TabIndex = 9;
            btnObrisiStavku.Text = "Obriši stavku";
            btnObrisiStavku.UseVisualStyleBackColor = false;
            btnObrisiStavku.Click += btnObrisiStavku_Click;
            // 
            // btnDodajStavku
            // 
            btnDodajStavku.BackColor = Color.Thistle;
            btnDodajStavku.Location = new Point(17, 275);
            btnDodajStavku.Name = "btnDodajStavku";
            btnDodajStavku.Size = new Size(187, 53);
            btnDodajStavku.TabIndex = 8;
            btnDodajStavku.Text = "Dodaj stavku";
            btnDodajStavku.UseVisualStyleBackColor = false;
            btnDodajStavku.Click += btnDodajStavku_Click;
            // 
            // tbxCenaStavke
            // 
            tbxCenaStavke.Location = new Point(150, 205);
            tbxCenaStavke.Name = "tbxCenaStavke";
            tbxCenaStavke.ReadOnly = true;
            tbxCenaStavke.Size = new Size(283, 27);
            tbxCenaStavke.TabIndex = 7;
            // 
            // tbxKolicina
            // 
            tbxKolicina.Location = new Point(150, 149);
            tbxKolicina.Name = "tbxKolicina";
            tbxKolicina.Size = new Size(283, 27);
            tbxKolicina.TabIndex = 6;
            tbxKolicina.TextChanged += tbxKolicina_TextChanged;
            // 
            // tbxJedinicnaCena
            // 
            tbxJedinicnaCena.Location = new Point(150, 95);
            tbxJedinicnaCena.Name = "tbxJedinicnaCena";
            tbxJedinicnaCena.ReadOnly = true;
            tbxJedinicnaCena.Size = new Size(283, 27);
            tbxJedinicnaCena.TabIndex = 5;
            // 
            // cbSatovi
            // 
            cbSatovi.FormattingEnabled = true;
            cbSatovi.Location = new Point(150, 46);
            cbSatovi.Name = "cbSatovi";
            cbSatovi.Size = new Size(283, 28);
            cbSatovi.TabIndex = 4;
            cbSatovi.SelectedIndexChanged += cbSatovi_SelectedIndexChanged;
            // 
            // lblCenaStavke
            // 
            lblCenaStavke.AutoSize = true;
            lblCenaStavke.Location = new Point(41, 208);
            lblCenaStavke.Name = "lblCenaStavke";
            lblCenaStavke.Size = new Size(103, 20);
            lblCenaStavke.TabIndex = 3;
            lblCenaStavke.Text = "Cena stavke:";
            // 
            // lblKolicina
            // 
            lblKolicina.AutoSize = true;
            lblKolicina.Location = new Point(67, 152);
            lblKolicina.Name = "lblKolicina";
            lblKolicina.Size = new Size(77, 20);
            lblKolicina.TabIndex = 2;
            lblKolicina.Text = "Količina:";
            // 
            // lblJedinicnaCena
            // 
            lblJedinicnaCena.AutoSize = true;
            lblJedinicnaCena.Location = new Point(17, 98);
            lblJedinicnaCena.Name = "lblJedinicnaCena";
            lblJedinicnaCena.Size = new Size(127, 20);
            lblJedinicnaCena.TabIndex = 1;
            lblJedinicnaCena.Text = "Jedinična cena:";
            // 
            // lblSat
            // 
            lblSat.AutoSize = true;
            lblSat.Location = new Point(105, 49);
            lblSat.Name = "lblSat";
            lblSat.Size = new Size(39, 20);
            lblSat.TabIndex = 0;
            lblSat.Text = "Sat:";
            // 
            // dgvStavke
            // 
            dgvStavke.BackgroundColor = Color.WhiteSmoke;
            dgvStavke.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStavke.Location = new Point(646, 230);
            dgvStavke.Name = "dgvStavke";
            dgvStavke.RowHeadersWidth = 51;
            dgvStavke.Size = new Size(533, 293);
            dgvStavke.TabIndex = 13;
            // 
            // btnSacuvajRacun
            // 
            btnSacuvajRacun.BackColor = Color.Thistle;
            btnSacuvajRacun.Location = new Point(807, 545);
            btnSacuvajRacun.Name = "btnSacuvajRacun";
            btnSacuvajRacun.Size = new Size(244, 60);
            btnSacuvajRacun.TabIndex = 14;
            btnSacuvajRacun.Text = "Sačuvaj račun";
            btnSacuvajRacun.UseVisualStyleBackColor = false;
            btnSacuvajRacun.Click += btnSacuvajRacun_Click;
            // 
            // cbProdavci
            // 
            cbProdavci.FormattingEnabled = true;
            cbProdavci.Location = new Point(208, 40);
            cbProdavci.Name = "cbProdavci";
            cbProdavci.Size = new Size(283, 28);
            cbProdavci.TabIndex = 15;
            // 
            // lblNacinPlacanja
            // 
            lblNacinPlacanja.AutoSize = true;
            lblNacinPlacanja.Location = new Point(687, 179);
            lblNacinPlacanja.Name = "lblNacinPlacanja";
            lblNacinPlacanja.Size = new Size(128, 20);
            lblNacinPlacanja.TabIndex = 16;
            lblNacinPlacanja.Text = "Način plaćanja:";
            // 
            // cbNacinPlacanja
            // 
            cbNacinPlacanja.FormattingEnabled = true;
            cbNacinPlacanja.Location = new Point(821, 176);
            cbNacinPlacanja.Name = "cbNacinPlacanja";
            cbNacinPlacanja.Size = new Size(199, 28);
            cbNacinPlacanja.TabIndex = 17;
            // 
            // FrmUbaciRacun
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(1191, 646);
            Controls.Add(cbNacinPlacanja);
            Controls.Add(lblNacinPlacanja);
            Controls.Add(cbProdavci);
            Controls.Add(btnSacuvajRacun);
            Controls.Add(dgvStavke);
            Controls.Add(pnlUnosStavki);
            Controls.Add(tbxCenaSaPopustom);
            Controls.Add(tbxProcenatPopusta);
            Controls.Add(tbxPunaCena);
            Controls.Add(lblKrajnjaCena);
            Controls.Add(lblPogodnost);
            Controls.Add(lblPunaCena);
            Controls.Add(dtpDatumIzdavanja);
            Controls.Add(cbKlijenti);
            Controls.Add(lblDatumIzdavanja);
            Controls.Add(lblKlijent);
            Controls.Add(lblProdavac);
            Font = new Font("Georgia", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "FrmUbaciRacun";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ubaci račun";
            pnlUnosStavki.ResumeLayout(false);
            pnlUnosStavki.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStavke).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblProdavac;
        private Label lblKlijent;
        private Label lblDatumIzdavanja;
        internal TextBox tbxProdavac;
        internal ComboBox cbKlijenti;
        internal DateTimePicker dtpDatumIzdavanja;
        private Label lblPunaCena;
        private Label lblPogodnost;
        private Label lblKrajnjaCena;
        internal TextBox tbxPunaCena;
        internal TextBox tbxProcenatPopusta;
        internal TextBox tbxCenaSaPopustom;
        internal Panel pnlUnosStavki;
        internal TextBox tbxKolicina;
        internal TextBox tbxJedinicnaCena;
        internal ComboBox cbSatovi;
        private Label lblCenaStavke;
        private Label lblKolicina;
        private Label lblJedinicnaCena;
        private Label lblSat;
        internal TextBox tbxCenaStavke;
        internal Button btnObrisiStavku;
        internal Button btnDodajStavku;
        internal DataGridView dgvStavke;
        internal Button btnSacuvajRacun;
        internal ComboBox cbProdavci;
        private Label lblNacinPlacanja;
        internal ComboBox cbNacinPlacanja;
    }
}