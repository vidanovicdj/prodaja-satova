namespace Klijent
{
    partial class FrmGlavna
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip = new MenuStrip();
            satToolStripMenuItem = new ToolStripMenuItem();
            ubaciSatToolStripMenuItem = new ToolStripMenuItem();
            klijentToolStripMenuItem = new ToolStripMenuItem();
            ubaciKlijentaToolStripMenuItem = new ToolStripMenuItem();
            pretraziKlijentaToolStripMenuItem = new ToolStripMenuItem();
            racunToolStripMenuItem = new ToolStripMenuItem();
            ubaciRacunToolStripMenuItem = new ToolStripMenuItem();
            pretraziRacunToolStripMenuItem = new ToolStripMenuItem();
            sertifikatToolStripMenuItem = new ToolStripMenuItem();
            ubaciSertifikatToolStripMenuItem = new ToolStripMenuItem();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.BackColor = Color.Thistle;
            menuStrip.Font = new Font("Georgia", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuStrip.ImageScalingSize = new Size(20, 20);
            menuStrip.Items.AddRange(new ToolStripItem[] { satToolStripMenuItem, klijentToolStripMenuItem, racunToolStripMenuItem, sertifikatToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Padding = new Padding(8, 2, 0, 2);
            menuStrip.Size = new Size(764, 28);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "menuStrip1";
            // 
            // satToolStripMenuItem
            // 
            satToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ubaciSatToolStripMenuItem });
            satToolStripMenuItem.Name = "satToolStripMenuItem";
            satToolStripMenuItem.Size = new Size(48, 24);
            satToolStripMenuItem.Text = "Sat";
            // 
            // ubaciSatToolStripMenuItem
            // 
            ubaciSatToolStripMenuItem.Name = "ubaciSatToolStripMenuItem";
            ubaciSatToolStripMenuItem.Size = new Size(224, 26);
            ubaciSatToolStripMenuItem.Text = "Ubaci sat";
            ubaciSatToolStripMenuItem.Click += ubaciSatToolStripMenuItem_Click;
            // 
            // klijentToolStripMenuItem
            // 
            klijentToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ubaciKlijentaToolStripMenuItem, pretraziKlijentaToolStripMenuItem });
            klijentToolStripMenuItem.Name = "klijentToolStripMenuItem";
            klijentToolStripMenuItem.Size = new Size(74, 24);
            klijentToolStripMenuItem.Text = "Klijent";
            // 
            // ubaciKlijentaToolStripMenuItem
            // 
            ubaciKlijentaToolStripMenuItem.Name = "ubaciKlijentaToolStripMenuItem";
            ubaciKlijentaToolStripMenuItem.Size = new Size(224, 26);
            ubaciKlijentaToolStripMenuItem.Text = "Ubaci klijenta";
            ubaciKlijentaToolStripMenuItem.Click += ubaciKlijentaToolStripMenuItem_Click;
            // 
            // pretraziKlijentaToolStripMenuItem
            // 
            pretraziKlijentaToolStripMenuItem.Name = "pretraziKlijentaToolStripMenuItem";
            pretraziKlijentaToolStripMenuItem.Size = new Size(224, 26);
            pretraziKlijentaToolStripMenuItem.Text = "Pretraži klijenta";
            // 
            // racunToolStripMenuItem
            // 
            racunToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ubaciRacunToolStripMenuItem, pretraziRacunToolStripMenuItem });
            racunToolStripMenuItem.Name = "racunToolStripMenuItem";
            racunToolStripMenuItem.Size = new Size(72, 24);
            racunToolStripMenuItem.Text = "Račun";
            racunToolStripMenuItem.Click += sertifikatToolStripMenuItem_Click;
            // 
            // ubaciRacunToolStripMenuItem
            // 
            ubaciRacunToolStripMenuItem.Name = "ubaciRacunToolStripMenuItem";
            ubaciRacunToolStripMenuItem.Size = new Size(200, 26);
            ubaciRacunToolStripMenuItem.Text = "Ubaci račun";
            // 
            // pretraziRacunToolStripMenuItem
            // 
            pretraziRacunToolStripMenuItem.Name = "pretraziRacunToolStripMenuItem";
            pretraziRacunToolStripMenuItem.Size = new Size(200, 26);
            pretraziRacunToolStripMenuItem.Text = "Pretraži račun";
            // 
            // sertifikatToolStripMenuItem
            // 
            sertifikatToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ubaciSertifikatToolStripMenuItem });
            sertifikatToolStripMenuItem.Name = "sertifikatToolStripMenuItem";
            sertifikatToolStripMenuItem.Size = new Size(94, 24);
            sertifikatToolStripMenuItem.Text = "Sertifikat";
            // 
            // ubaciSertifikatToolStripMenuItem
            // 
            ubaciSertifikatToolStripMenuItem.Name = "ubaciSertifikatToolStripMenuItem";
            ubaciSertifikatToolStripMenuItem.Size = new Size(209, 26);
            ubaciSertifikatToolStripMenuItem.Text = "Ubaci sertifikat";
            // 
            // FrmGlavna
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(764, 450);
            Controls.Add(menuStrip);
            Font = new Font("Georgia", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MainMenuStrip = menuStrip;
            Margin = new Padding(4, 3, 4, 3);
            Name = "FrmGlavna";
            Text = "Prodaja satova";
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip;
        private ToolStripMenuItem satToolStripMenuItem;
        private ToolStripMenuItem klijentToolStripMenuItem;
        private ToolStripMenuItem racunToolStripMenuItem;
        private ToolStripMenuItem sertifikatToolStripMenuItem;
        private ToolStripMenuItem ubaciSatToolStripMenuItem;
        private ToolStripMenuItem ubaciKlijentaToolStripMenuItem;
        private ToolStripMenuItem pretraziKlijentaToolStripMenuItem;
        private ToolStripMenuItem ubaciRacunToolStripMenuItem;
        private ToolStripMenuItem pretraziRacunToolStripMenuItem;
        private ToolStripMenuItem ubaciSertifikatToolStripMenuItem;
    }
}
