namespace Server
{
    partial class FrmServer
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
            btnStart = new Button();
            btnStop = new Button();
            tbxStanje = new TextBox();
            SuspendLayout();
            // 
            // btnStart
            // 
            btnStart.BackColor = Color.Thistle;
            btnStart.Location = new Point(78, 90);
            btnStart.Margin = new Padding(4);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(150, 47);
            btnStart.TabIndex = 0;
            btnStart.Text = "START";
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += btnStart_Click;
            // 
            // btnStop
            // 
            btnStop.BackColor = Color.Thistle;
            btnStop.Location = new Point(333, 90);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(150, 47);
            btnStop.TabIndex = 1;
            btnStop.Text = "STOP";
            btnStop.UseVisualStyleBackColor = false;
            btnStop.Click += btnStop_Click;
            // 
            // tbxStanje
            // 
            tbxStanje.BackColor = SystemColors.ControlLightLight;
            tbxStanje.Location = new Point(163, 230);
            tbxStanje.Name = "tbxStanje";
            tbxStanje.ReadOnly = true;
            tbxStanje.Size = new Size(233, 27);
            tbxStanje.TabIndex = 2;
            // 
            // FrmServer
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(596, 450);
            Controls.Add(tbxStanje);
            Controls.Add(btnStop);
            Controls.Add(btnStart);
            Font = new Font("Georgia", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "FrmServer";
            Text = "Server";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnStart;
        private Button btnStop;
        private TextBox tbxStanje;
    }
}
