namespace Klijent
{
    partial class FrmIzmeniRacun
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
            cbNacinPlacanja = new ComboBox();
            lblNacinPlacanja = new Label();
            cbProdavci = new ComboBox();
            btnIzmeniRacun = new Button();
            dgvStavke = new DataGridView();
            btnObrisiStavku = new Button();
            pnlUnosStavki = new Panel();
            btnDodajStavku = new Button();
            tbxCenaStavke = new TextBox();
            tbxKolicina = new TextBox();
            tbxJedinicnaCena = new TextBox();
            cbSatovi = new ComboBox();
            lblCenaStavke = new Label();
            lblKolicina = new Label();
            lblJedinicnaCena = new Label();
            lblSat = new Label();
            tbxCenaSaPopustom = new TextBox();
            tbxProcenatPopusta = new TextBox();
            cbKlijenti = new ComboBox();
            lblDatumIzdavanja = new Label();
            lblKlijent = new Label();
            lblProdavac = new Label();
            tbxPunaCena = new TextBox();
            lblKrajnjaCena = new Label();
            lblPogodnost = new Label();
            lblPunaCena = new Label();
            dtpDatumIzdavanja = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dgvStavke).BeginInit();
            pnlUnosStavki.SuspendLayout();
            SuspendLayout();
            // 
            // cbNacinPlacanja
            // 
            cbNacinPlacanja.FormattingEnabled = true;
            cbNacinPlacanja.Location = new Point(798, 171);
            cbNacinPlacanja.Name = "cbNacinPlacanja";
            cbNacinPlacanja.Size = new Size(199, 28);
            cbNacinPlacanja.TabIndex = 34;
            // 
            // lblNacinPlacanja
            // 
            lblNacinPlacanja.AutoSize = true;
            lblNacinPlacanja.Location = new Point(664, 174);
            lblNacinPlacanja.Name = "lblNacinPlacanja";
            lblNacinPlacanja.Size = new Size(128, 20);
            lblNacinPlacanja.TabIndex = 33;
            lblNacinPlacanja.Text = "Način plaćanja:";
            // 
            // cbProdavci
            // 
            cbProdavci.FormattingEnabled = true;
            cbProdavci.Location = new Point(185, 35);
            cbProdavci.Name = "cbProdavci";
            cbProdavci.Size = new Size(283, 28);
            cbProdavci.TabIndex = 32;
            // 
            // btnIzmeniRacun
            // 
            btnIzmeniRacun.BackColor = Color.Thistle;
            btnIzmeniRacun.Location = new Point(784, 540);
            btnIzmeniRacun.Name = "btnIzmeniRacun";
            btnIzmeniRacun.Size = new Size(244, 60);
            btnIzmeniRacun.TabIndex = 31;
            btnIzmeniRacun.Text = "Izmeni račun";
            btnIzmeniRacun.UseVisualStyleBackColor = false;
            btnIzmeniRacun.Click += btnIzmeniRacun_Click;
            // 
            // dgvStavke
            // 
            dgvStavke.BackgroundColor = Color.WhiteSmoke;
            dgvStavke.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStavke.Location = new Point(623, 225);
            dgvStavke.Name = "dgvStavke";
            dgvStavke.RowHeadersWidth = 51;
            dgvStavke.Size = new Size(533, 293);
            dgvStavke.TabIndex = 30;
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
            pnlUnosStavki.Location = new Point(35, 225);
            pnlUnosStavki.Name = "pnlUnosStavki";
            pnlUnosStavki.Size = new Size(534, 375);
            pnlUnosStavki.TabIndex = 29;
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
            // tbxCenaSaPopustom
            // 
            tbxCenaSaPopustom.Location = new Point(798, 127);
            tbxCenaSaPopustom.Name = "tbxCenaSaPopustom";
            tbxCenaSaPopustom.ReadOnly = true;
            tbxCenaSaPopustom.Size = new Size(199, 27);
            tbxCenaSaPopustom.TabIndex = 28;
            // 
            // tbxProcenatPopusta
            // 
            tbxProcenatPopusta.Location = new Point(798, 83);
            tbxProcenatPopusta.Name = "tbxProcenatPopusta";
            tbxProcenatPopusta.ReadOnly = true;
            tbxProcenatPopusta.Size = new Size(199, 27);
            tbxProcenatPopusta.TabIndex = 27;
            // 
            // cbKlijenti
            // 
            cbKlijenti.FormattingEnabled = true;
            cbKlijenti.Location = new Point(185, 83);
            cbKlijenti.Name = "cbKlijenti";
            cbKlijenti.Size = new Size(283, 28);
            cbKlijenti.TabIndex = 21;
            cbKlijenti.SelectedIndexChanged += cbKlijenti_SelectedIndexChanged;
            // 
            // lblDatumIzdavanja
            // 
            lblDatumIzdavanja.AutoSize = true;
            lblDatumIzdavanja.Location = new Point(35, 130);
            lblDatumIzdavanja.Name = "lblDatumIzdavanja";
            lblDatumIzdavanja.Size = new Size(144, 20);
            lblDatumIzdavanja.TabIndex = 20;
            lblDatumIzdavanja.Text = "Datum izdavanja:";
            // 
            // lblKlijent
            // 
            lblKlijent.AutoSize = true;
            lblKlijent.Location = new Point(114, 86);
            lblKlijent.Name = "lblKlijent";
            lblKlijent.Size = new Size(65, 20);
            lblKlijent.TabIndex = 19;
            lblKlijent.Text = "Klijent:";
            // 
            // lblProdavac
            // 
            lblProdavac.AutoSize = true;
            lblProdavac.Location = new Point(95, 38);
            lblProdavac.Name = "lblProdavac";
            lblProdavac.Size = new Size(84, 20);
            lblProdavac.TabIndex = 18;
            lblProdavac.Text = "Prodavac:";
            // 
            // tbxPunaCena
            // 
            tbxPunaCena.Location = new Point(798, 35);
            tbxPunaCena.Name = "tbxPunaCena";
            tbxPunaCena.ReadOnly = true;
            tbxPunaCena.Size = new Size(199, 27);
            tbxPunaCena.TabIndex = 26;
            // 
            // lblKrajnjaCena
            // 
            lblKrajnjaCena.AutoSize = true;
            lblKrajnjaCena.Location = new Point(682, 130);
            lblKrajnjaCena.Name = "lblKrajnjaCena";
            lblKrajnjaCena.Size = new Size(110, 20);
            lblKrajnjaCena.TabIndex = 25;
            lblKrajnjaCena.Text = "Krajnja cena:";
            // 
            // lblPogodnost
            // 
            lblPogodnost.AutoSize = true;
            lblPogodnost.Location = new Point(623, 86);
            lblPogodnost.Name = "lblPogodnost";
            lblPogodnost.Size = new Size(169, 20);
            lblPogodnost.TabIndex = 24;
            lblPogodnost.Text = "Procenat pogodnosti:";
            // 
            // lblPunaCena
            // 
            lblPunaCena.AutoSize = true;
            lblPunaCena.Location = new Point(700, 38);
            lblPunaCena.Name = "lblPunaCena";
            lblPunaCena.Size = new Size(92, 20);
            lblPunaCena.TabIndex = 23;
            lblPunaCena.Text = "Puna cena:";
            // 
            // dtpDatumIzdavanja
            // 
            dtpDatumIzdavanja.Location = new Point(185, 125);
            dtpDatumIzdavanja.Name = "dtpDatumIzdavanja";
            dtpDatumIzdavanja.Size = new Size(283, 27);
            dtpDatumIzdavanja.TabIndex = 22;
            // 
            // FrmIzmeniRacun
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(1189, 623);
            Controls.Add(cbNacinPlacanja);
            Controls.Add(lblNacinPlacanja);
            Controls.Add(cbProdavci);
            Controls.Add(btnIzmeniRacun);
            Controls.Add(dgvStavke);
            Controls.Add(pnlUnosStavki);
            Controls.Add(tbxCenaSaPopustom);
            Controls.Add(tbxProcenatPopusta);
            Controls.Add(cbKlijenti);
            Controls.Add(lblDatumIzdavanja);
            Controls.Add(lblKlijent);
            Controls.Add(lblProdavac);
            Controls.Add(tbxPunaCena);
            Controls.Add(lblKrajnjaCena);
            Controls.Add(lblPogodnost);
            Controls.Add(lblPunaCena);
            Controls.Add(dtpDatumIzdavanja);
            Font = new Font("Georgia", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FrmIzmeniRacun";
            Text = "Izmena računa";
            ((System.ComponentModel.ISupportInitialize)dgvStavke).EndInit();
            pnlUnosStavki.ResumeLayout(false);
            pnlUnosStavki.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        internal ComboBox cbNacinPlacanja;
        private Label lblNacinPlacanja;
        internal ComboBox cbProdavci;
        internal Button btnIzmeniRacun;
        internal DataGridView dgvStavke;
        internal Button btnObrisiStavku;
        internal Panel pnlUnosStavki;
        internal Button btnDodajStavku;
        internal TextBox tbxCenaStavke;
        internal TextBox tbxKolicina;
        internal TextBox tbxJedinicnaCena;
        internal ComboBox cbSatovi;
        private Label lblCenaStavke;
        private Label lblKolicina;
        private Label lblJedinicnaCena;
        private Label lblSat;
        internal TextBox tbxCenaSaPopustom;
        internal TextBox tbxProcenatPopusta;
        internal ComboBox cbKlijenti;
        private Label lblDatumIzdavanja;
        private Label lblKlijent;
        private Label lblProdavac;
        internal TextBox tbxPunaCena;
        private Label lblKrajnjaCena;
        private Label lblPogodnost;
        private Label lblPunaCena;
        internal DateTimePicker dtpDatumIzdavanja;
    }
}