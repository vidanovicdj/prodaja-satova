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
            klijentToolStripMenuItem = new ToolStripMenuItem();
            sertifikatToolStripMenuItem = new ToolStripMenuItem();
            računToolStripMenuItem = new ToolStripMenuItem();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.BackColor = Color.Thistle;
            menuStrip.Font = new Font("Georgia", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuStrip.ImageScalingSize = new Size(20, 20);
            menuStrip.Items.AddRange(new ToolStripItem[] { satToolStripMenuItem, klijentToolStripMenuItem, sertifikatToolStripMenuItem, računToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Padding = new Padding(8, 2, 0, 2);
            menuStrip.Size = new Size(764, 28);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "menuStrip1";
            // 
            // satToolStripMenuItem
            // 
            satToolStripMenuItem.Name = "satToolStripMenuItem";
            satToolStripMenuItem.Size = new Size(44, 24);
            satToolStripMenuItem.Text = "Sat";
            // 
            // klijentToolStripMenuItem
            // 
            klijentToolStripMenuItem.Name = "klijentToolStripMenuItem";
            klijentToolStripMenuItem.Size = new Size(74, 24);
            klijentToolStripMenuItem.Text = "Klijent";
            // 
            // sertifikatToolStripMenuItem
            // 
            sertifikatToolStripMenuItem.Name = "sertifikatToolStripMenuItem";
            sertifikatToolStripMenuItem.Size = new Size(94, 24);
            sertifikatToolStripMenuItem.Text = "Sertifikat";
            // 
            // računToolStripMenuItem
            // 
            računToolStripMenuItem.Name = "računToolStripMenuItem";
            računToolStripMenuItem.Size = new Size(72, 24);
            računToolStripMenuItem.Text = "Račun";
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
        private ToolStripMenuItem sertifikatToolStripMenuItem;
        private ToolStripMenuItem računToolStripMenuItem;
    }
}
