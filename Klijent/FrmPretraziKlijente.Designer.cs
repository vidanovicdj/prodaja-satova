namespace Klijent
{
    partial class FrmPretraziKlijente
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
            lblEmail = new Label();
            tbxEmailPretraga = new TextBox();
            btnPretrazi = new Button();
            btnPrikazi = new Button();
            dgvKlijenti = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvKlijenti).BeginInit();
            SuspendLayout();
            // 
            // lblOpis
            // 
            lblOpis.AutoSize = true;
            lblOpis.Font = new Font("Georgia", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOpis.Location = new Point(31, 35);
            lblOpis.Name = "lblOpis";
            lblOpis.Size = new Size(321, 20);
            lblOpis.TabIndex = 0;
            lblOpis.Text = "Pretraga klijenata po email adresi:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(31, 85);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(59, 20);
            lblEmail.TabIndex = 1;
            lblEmail.Text = "Email:";
            // 
            // tbxEmailPretraga
            // 
            tbxEmailPretraga.Location = new Point(96, 82);
            tbxEmailPretraga.Name = "tbxEmailPretraga";
            tbxEmailPretraga.Size = new Size(321, 27);
            tbxEmailPretraga.TabIndex = 2;
            // 
            // btnPretrazi
            // 
            btnPretrazi.BackColor = Color.Thistle;
            btnPretrazi.Location = new Point(31, 133);
            btnPretrazi.Name = "btnPretrazi";
            btnPretrazi.Size = new Size(171, 49);
            btnPretrazi.TabIndex = 3;
            btnPretrazi.Text = "Pretraži";
            btnPretrazi.UseVisualStyleBackColor = false;
            btnPretrazi.Click += btnPretrazi_Click;
            // 
            // btnPrikazi
            // 
            btnPrikazi.BackColor = Color.Thistle;
            btnPrikazi.Location = new Point(246, 133);
            btnPrikazi.Name = "btnPrikazi";
            btnPrikazi.Size = new Size(171, 49);
            btnPrikazi.TabIndex = 4;
            btnPrikazi.Text = "Prikaži";
            btnPrikazi.UseVisualStyleBackColor = false;
            btnPrikazi.Click += btnPrikazi_Click;
            // 
            // dgvKlijenti
            // 
            dgvKlijenti.BackgroundColor = Color.WhiteSmoke;
            dgvKlijenti.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKlijenti.Location = new Point(31, 207);
            dgvKlijenti.Name = "dgvKlijenti";
            dgvKlijenti.RowHeadersWidth = 51;
            dgvKlijenti.Size = new Size(701, 276);
            dgvKlijenti.TabIndex = 5;
            // 
            // FrmPretraziKlijente
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(767, 495);
            Controls.Add(dgvKlijenti);
            Controls.Add(btnPrikazi);
            Controls.Add(btnPretrazi);
            Controls.Add(tbxEmailPretraga);
            Controls.Add(lblEmail);
            Controls.Add(lblOpis);
            Font = new Font("Georgia", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FrmPretraziKlijente";
            Text = "Pretraga klijenata";
            ((System.ComponentModel.ISupportInitialize)dgvKlijenti).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblOpis;
        private Label lblEmail;
        internal TextBox tbxEmailPretraga;
        private Button btnPretrazi;
        private Button btnPrikazi;
        internal DataGridView dgvKlijenti;
    }
}