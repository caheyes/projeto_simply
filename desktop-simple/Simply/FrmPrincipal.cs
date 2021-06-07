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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            FrmCadastro formCadastro = new FrmCadastro();
            
            formCadastro.ShowDialog();
        }

        private void btnTransacao_Click(object sender, EventArgs e)
        {
            FrmEmDesenvolvimento formEmDesenvolvimento = new FrmEmDesenvolvimento();
            formEmDesenvolvimento.ShowDialog(); FrmTransacao formTransacao = new FrmTransacao();
            formTransacao.ShowDialog();
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            FrmEmDesenvolvimento formEmDesenvolvimento = new FrmEmDesenvolvimento();
            formEmDesenvolvimento.ShowDialog();
            FrmRelatorio formRelatorio = new FrmRelatorio();
            formRelatorio.ShowDialog();
        }

        private void btnSobre_Click(object sender, EventArgs e)
        {
            FrmSobre formSobre = new FrmSobre();
            formSobre.ShowDialog();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            FrmSair formSair = new FrmSair();
            formSair.ShowDialog();
        }

        private void btnConfiguracao_Click(object sender, EventArgs e)
        {

        }

        private void lblDatadoDia_Click(object sender, EventArgs e)
        {
           
        }

        private void lblHorariodoDia_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHorariodoDia.ForeColor = Color.BlueViolet;
            lblDatadoDia.ForeColor = Color.BlueViolet;
            lblHorariodoDia.Text = DateTime.Now.ToString("HH:mm:ss");
            lblDatadoDia.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
