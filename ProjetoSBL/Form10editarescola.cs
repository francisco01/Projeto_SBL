using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoSBL
{
    public partial class Form10editarescola : Form
    {
        public Form10editarescola()
        {
            InitializeComponent();
        }
        Form4Opcoes frmop = new Form4Opcoes();
        Escola sco = new Escola();
        private void Form10editarescola_Load(object sender, EventArgs e)
        {
            MySqlDataReader reader = sco.buscaEscola();
            if (reader.HasRows)
            {
                if (reader.Read())
                {
                    txtNome.Text = reader.GetString(1);
                    txtCNPJ.Text = reader.GetString(2);
                    txtend.Text = reader.GetString(3);
                }
            }
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            txtNome.Enabled = true;
            txtCNPJ.Enabled = true;
            txtend.Enabled = true;
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            sco.nome = txtNome.Text;
            sco.cnpj = txtCNPJ.Text;
            sco.endereco = txtend.Text;
            sco.atualizarEscola();
            voltar();
        }

        private void btnescluir_Click(object sender, EventArgs e)
        {
            sco.excluirEscola();
            voltar();
        }
        public void voltar()
        {
            frmop.Show();
            this.Hide();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            voltar();
        }
    }
}
