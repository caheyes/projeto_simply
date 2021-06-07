using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simply
{
    public partial class FrmSair : Form
    {
        public FrmSair()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSim_Click(object sender, EventArgs e)
        {
            //Pode usar Dispose();
            //Pode usar this.Close();
            //Pode usar this.Hide();
            //Ou usar this.Visible = false;
            //Pode usar this.Dispose();
            Hide();
            FrmAgradecimento formAgradecimento = new FrmAgradecimento();
            formAgradecimento.ShowDialog();
            Application.Exit();
        }

        private void btnNao_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
