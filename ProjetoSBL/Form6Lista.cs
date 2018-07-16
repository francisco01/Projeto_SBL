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
    public partial class Form6Lista : Form
    {
        public Form6Lista()
        {
            InitializeComponent();
        }

        Lista_ind lst = new Lista_ind();
        Form4Opcoes frmopc = new Form4Opcoes();
        Escola sco = new Escola();
        Preco prc = new Preco();

        private void Form6Lista_Load(object sender, EventArgs e)
        {
            cmbescola.DataSource = sco.buscarEscola();
            cmbescola.DisplayMember = "Nome";
            cmbescola.ValueMember = "idEscola";

        }

        private void btnCad_Click(object sender, EventArgs e)
        {
            long idprc;
            lst.nivel = txtNivel.Text;
            lst.serie = txtSerie.Text;
            lst.ano = txtAno.Text;
            prc.preco = Convert.ToDouble(txtPreco.Text);
            idprc = prc.cadastraPreco();

            if (lst.cadastarLista(cmbescola, idprc))
            {
                voltar();
            }

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            voltar();
        }
        private void voltar()
        {
            frmopc.Show();
            this.Hide();
        }

        private void btnCad_MouseEnter(object sender, EventArgs e)
        {
            if (txtNivel.Text.Equals("") || txtSerie.Text.Equals("") || txtSerie.Text.Equals("")
                || txtPreco.Text.Equals(""))
            {
                MessageBox.Show("Preencha todos os campos!");
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
