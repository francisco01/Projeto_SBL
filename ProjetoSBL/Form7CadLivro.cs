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
    public partial class Form7CadLivro : Form
    {
        public Form7CadLivro()
        {
            InitializeComponent();
        }
        Livro livro = new Livro();
        Preco prc = new Preco();
        Form4Opcoes frmopc = new Form4Opcoes();
        long idprc;
        bool aux = false;
        

        private void button1_Click(object sender, EventArgs e)
        {
            voltar();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            livro.titulo = txtTitulo.Text;
            livro.autor = txtAutor.Text;
            livro.editora = txteditora.Text;
            livro.edicao = txtedicao.Text;
            livro.ano = txtAno.Text;
            livro.tipo = txtTipo.Text;
            livro.cadastrarLivro(idprc, cmbListas);
            voltar();
            
        }

        private void Form7CadLivro_Load(object sender, EventArgs e)
        {
            livro.lista.escola.buscarUsuarioEscola();
            cmbListas.DataSource = livro.lista.buscarListas();
            cmbListas.DisplayMember = "Nivel";
            cmbListas.ValueMember = "idLista_Ind";
            aux = true;
        }
        private void voltar()
        {
            frmopc.Show();
            this.Hide();
        }

        private void cmbListas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (aux)
            {
                idprc = livro.lista.buscarIdPreco(cmbListas);
                txtPreco.Text = Convert.ToString(livro.preco.buscarPreco(idprc));
            }
        }

        private void btnCadastrar_MouseEnter(object sender, EventArgs e)
        {
            if (txtTitulo.Text.Equals("") || txtAutor.Text.Equals("") || txtedicao.Text.Equals("")
                || txteditora.Text.Equals("") || txtAno.Text.Equals("") || txtTipo.Text.Equals("")
                || txtPreco.Text.Equals(""))
            {
                MessageBox.Show("Preencha todos os campos!");
            }

        }
    }
}
