using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simply
{
    public partial class FrmCadastro : Form
    {
        public FrmCadastro()
        {
            InitializeComponent();
        }

        private void FrmCadastro_Load(object sender, EventArgs e)
        {
            // for (int i = 0; i < 20; i++)
            // {
            //CheckBox chb = new CheckBox();
            // chb.Text = i.ToString();
            //chb.Location = new Point(10, pnlCadastroCliente.Controls.Count * 20);
            //pnlCadastroCliente.Controls.Add(chb);
            //  }
            FrmEmDesenvolvimento formEmDesenvolvimento = new FrmEmDesenvolvimento();
            formEmDesenvolvimento.ShowDialog();
            //Coloque a string do seu banco de dados abaixo na string de conexão e não esqueça do @.

            //string strConxao = @"Data Source=JODSON-PC\SQLEXPRESS;Initial Catalog=dbAula01;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            //string Query = "Select * from tb01";
            //SqlConnection con = new SqlConnection(strConxao);
            //SqlDataAdapter da = new SqlDataAdapter(Query, con);
            //DataTable dt = new DataTable();

            //da.Fill(dt);

            //dgTabelaGeral.DataSource = dt;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            FrmEmDesenvolvimento formEmDesenvolvimento = new FrmEmDesenvolvimento();
            formEmDesenvolvimento.ShowDialog();
            string message = "Logo fará cadastro de usuários!";
            string title = "Building";
            MessageBox.Show(message, title);
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            FrmConsultaEspecifica formConsultaEspecifica = new FrmConsultaEspecifica();
            formConsultaEspecifica.ShowDialog();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            //FrmEmDesenvolvimento formEmDesenvolvimento = new FrmEmDesenvolvimento();
            //formEmDesenvolvimento.ShowDialog();
            FrmAtualizarCadastro formAtualizarCadastro = new FrmAtualizarCadastro();
            formAtualizarCadastro.ShowDialog();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            //FrmEmDesenvolvimento formEmDesenvolvimento = new FrmEmDesenvolvimento();
            //formEmDesenvolvimento.ShowDialog();
            FrmExcluirCadastro formExcluirCadastro = new FrmExcluirCadastro();
            formExcluirCadastro.ShowDialog();
        }

        private void lklAjuda_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmAjuda formAjuda = new FrmAjuda();
            formAjuda.ShowDialog();
        }
    }
}
