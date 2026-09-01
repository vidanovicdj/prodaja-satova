namespace Klijent
{
    partial class FrmPretraziRacune
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
            lblOpis = new Label();
            lblKriterijum = new Label();
            tbxKriterijum = new TextBox();
            btnPrikaziSve = new Button();
            btnIzmeni = new Button();
            btnPretrazi = new Button();
            dgvRacuni = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvRacuni).BeginInit();
            SuspendLayout();
            // 
            // lblOpis
            // 
            lblOpis.AutoSize = true;
            lblOpis.Font = new Font("Georgia", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOpis.Location = new Point(36, 40);
            lblOpis.Name = "lblOpis";
            lblOpis.Size = new Size(288, 20);
            lblOpis.TabIndex = 0;
            lblOpis.Text = "Pretraga računa po klijentima:";
            // 
            // lblKriterijum
            // 
            lblKriterijum.AutoSize = true;
            lblKriterijum.Location = new Point(36, 96);
            lblKriterijum.Name = "lblKriterijum";
            lblKriterijum.Size = new Size(189, 20);
            lblKriterijum.TabIndex = 1;
            lblKriterijum.Text = "Ime ili prezime klijenta:";
            // 
            // tbxKriterijum
            // 
            tbxKriterijum.Location = new Point(231, 93);
            tbxKriterijum.Name = "tbxKriterijum";
            tbxKriterijum.Size = new Size(272, 27);
            tbxKriterijum.TabIndex = 2;
            // 
            // btnPrikaziSve
            // 
            btnPrikaziSve.BackColor = Color.Thistle;
            btnPrikaziSve.Location = new Point(36, 157);
            btnPrikaziSve.Name = "btnPrikaziSve";
            btnPrikaziSve.Size = new Size(171, 49);
            btnPrikaziSve.TabIndex = 9;
            btnPrikaziSve.Text = "Prikaži sve";
            btnPrikaziSve.UseVisualStyleBackColor = false;
            btnPrikaziSve.Click += btnPrikaziSve_Click;
            // 
            // btnIzmeni
            // 
            btnIzmeni.BackColor = Color.Thistle;
            btnIzmeni.Location = new Point(466, 157);
            btnIzmeni.Name = "btnIzmeni";
            btnIzmeni.Size = new Size(171, 49);
            btnIzmeni.TabIndex = 8;
            btnIzmeni.Text = "Izmeni";
            btnIzmeni.UseVisualStyleBackColor = false;
            btnIzmeni.Click += btnIzmeni_Click;
            // 
            // btnPretrazi
            // 
            btnPretrazi.BackColor = Color.Thistle;
            btnPretrazi.Location = new Point(251, 157);
            btnPretrazi.Name = "btnPretrazi";
            btnPretrazi.Size = new Size(171, 49);
            btnPretrazi.TabIndex = 7;
            btnPretrazi.Text = "Pretraži";
            btnPretrazi.UseVisualStyleBackColor = false;
            btnPretrazi.Click += btnPretrazi_Click;
            // 
            // dgvRacuni
            // 
            dgvRacuni.BackgroundColor = Color.WhiteSmoke;
            dgvRacuni.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRacuni.Location = new Point(36, 239);
            dgvRacuni.Name = "dgvRacuni";
            dgvRacuni.RowHeadersWidth = 51;
            dgvRacuni.Size = new Size(711, 308);
            dgvRacuni.TabIndex = 10;
            // 
            // FrmPretraziRacune
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(793, 559);
            Controls.Add(dgvRacuni);
            Controls.Add(btnPrikaziSve);
            Controls.Add(btnIzmeni);
            Controls.Add(btnPretrazi);
            Controls.Add(tbxKriterijum);
            Controls.Add(lblKriterijum);
            Controls.Add(lblOpis);
            Font = new Font("Georgia", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "FrmPretraziRacune";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pretraga računa";
            ((System.ComponentModel.ISupportInitialize)dgvRacuni).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblOpis;
        private Label lblKriterijum;
        internal TextBox tbxKriterijum;
        internal Button btnPrikaziSve;
        internal Button btnIzmeni;
        internal Button btnPretrazi;
        internal DataGridView dgvRacuni;
    }
}