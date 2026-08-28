using System.Net.Sockets;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Server
{
    public partial class FrmServer : Form
    {
        private Server s;
        public FrmServer()
        {
            InitializeComponent();
            btnStart.Enabled = true;
            btnStop.Enabled = false;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                s = new Server();
                s.Start();
                btnStart.Enabled = false;
                btnStop.Enabled = true;
                Thread serverNit = new Thread(s.Listen);
                serverNit.IsBackground = true;
                serverNit.Start();
                tbxStanje.Text = "Server je uključen.";
            }
            catch (IOException)
            {
                MessageBox.Show("Server ne može da se pokrene!");
            }
            catch (SocketException)
            {
                MessageBox.Show("Server je već pokrenut!");
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            s.Stop();
            btnStart.Enabled = true;
            btnStop.Enabled = false;
            tbxStanje.Text = "Server je isključen";
            MessageBox.Show("Server je zaustavljen!", "Server isključen", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
