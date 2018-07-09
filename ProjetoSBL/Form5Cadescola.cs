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
    public partial class Form5Cadescola : Form
    {
        public Form5Cadescola()
        {
            InitializeComponent();
        }
        Escola esc = new Escola();
        Form4Opcoes frmopc = new Form4Opcoes();

        private void btnVoltar_Click(object sender, EventArgs e)
        {

            voltar();
        }

        private void voltar()
        {
            frmopc.Show();
            this.Hide();
        }

        private void btnCad_Click(object sender, EventArgs e)
        {
            esc.nome = txtNome.Text;
            esc.cnpj = txtCNPJ.Text;
            esc.endereco = txtend.Text;
            if (esc.cadastrarEscola())
            {
                voltar();
            }
        }
        
    }
}
