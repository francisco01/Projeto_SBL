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
    public partial class Form9Cadexemplar : Form
    {
        public Form9Cadexemplar()
        {
            InitializeComponent();
        }
      
        bool flag = false;
        Exemplar xmp = new Exemplar();
        long aux;
        
        private void Form9Cadexemplar_Load(object sender, EventArgs e)
        {
            cmbLivro.DataSource = xmp.livro.buscarLivro();
            cmbLivro.DisplayMember = "Titulo";
            cmbLivro.ValueMember = "ISBN";
            flag = true;
        }

        private void cmbLivro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (flag)
            {
                aux = xmp.livro.buscarIdPrecoLivro(cmbLivro);
                double prc = xmp.livro.preco.buscarPreco(aux);
                lblPrc.Text = "Preço sugerido R$ " + prc;  
            }
        }

        private void btnCadexemp_Click(object sender, EventArgs e)
        {
            xmp.situacao = txtSituacao.Text;
            xmp.entrega = txtentrega.Text;
            if (ckbAnot.Checked)
            {
                xmp.anotacao = 1;
            }
            if (ckbDobra.Checked)
            {
                xmp.dobra = 1;
            }
            xmp.cadastrarExemplar(cmbLivro, aux);
            voltar();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            voltar();
        }
        private void voltar()
        {
            Form8Opc frmopc2 = new Form8Opc();
            frmopc2.Show();
            this.Hide();
        }
    }
}
