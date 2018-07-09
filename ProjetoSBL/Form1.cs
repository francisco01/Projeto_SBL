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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Usuario usu = new Usuario();

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Form2Cadastro novoform = new Form2Cadastro();
            novoform.Show();
            this.Hide();
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            usu.login = txtLogin.Text;
            usu.senha = txtSenha.Text;
            if (usu.logarResponsavel())
            {
                telaOpcRes();
            }
        }
        private void telaOpcRes()
        {
            Form8Opc frmopc = new Form8Opc();
            frmopc.Show();
            this.Hide();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            usu.login = txtLogin.Text;
            usu.senha = txtSenha.Text;

            if (usu.logarDiretor())
            {
                telaOpcDir();
            }

        }

        private void telaOpcDir()
        {
            Form4Opcoes frmopc = new Form4Opcoes();
            frmopc.Show();
            this.Hide();
        }
    }
}
