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
    public partial class Form11editarlista : Form
    {
        public Form11editarlista()
        {
            InitializeComponent();
        }

        Lista_ind lst = new Lista_ind();
        Form4Opcoes frmopc = new Form4Opcoes();
        Escola sco = new Escola();
        Preco prc = new Preco();
        bool aux = false;
        MySqlDataReader reader;
        long idprc;

        private void Form11editarlista_Load(object sender, EventArgs e)
        {
            sco.buscarUsuarioEscola();
            cmbLista.DataSource = lst.buscarListas();
            cmbLista.DisplayMember = "Nivel";
            cmbLista.ValueMember = "idLista_Ind";
            aux = true;
        }

        private void cmbLista_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (aux)
            {
                reader = lst.buscarLista(cmbLista);
                if (reader.HasRows)
                {
                    if (reader.Read())
                    {
                        txtNivel.Text = reader.GetString(1);
                        txtSerie.Text = reader.GetString(2);
                        txtAno.Text = reader.GetString(3);
                        idprc = lst.buscarIdPreco(cmbLista);
                        txtPreco.Text = Convert.ToString(prc.buscarPreco(idprc));
                    }
                }
            }
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            txtNivel.Enabled = true;
            txtSerie.Enabled = true;
            txtAno.Enabled = true;
            txtPreco.Enabled = true;
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            lst.nivel = txtNivel.Text;
            lst.serie = txtSerie.Text;
            lst.ano = txtAno.Text;
            prc.preco = Convert.ToDouble(txtPreco.Text);
            lst.atualizarLista();
            prc.atualizarPreco(idprc);
            voltar();
        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            lst.excluirLista();
            voltar();
        }
        public void voltar()
        {
            frmopc.Show();
            this.Hide();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            voltar();
        }
    }
}
