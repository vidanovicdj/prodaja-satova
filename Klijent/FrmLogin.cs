using Klijent.GUIKontroler.ProdavacKontroler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klijent
{
    public partial class FrmLogin : Form
    {
        private ProdavacPrijavaController controller;
        public FrmLogin()
        {
            InitializeComponent();
            controller = new ProdavacPrijavaController(this);
            tbxPassword.UseSystemPasswordChar = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            controller.Login();
        }
    }
}
