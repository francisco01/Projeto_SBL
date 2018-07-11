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
    public partial class Form2Cadastro : Form
    {
        public Form2Cadastro()
        {
            InitializeComponent();
        }

        Responsavel respon = new Responsavel();
        Usuario usu = new Usuario();
        Form1 formlogin = new Form1();

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            voltar();
        }
        private void voltar()
        {
            formlogin.Show();
            this.Hide();
        }

        private void btnCad_Click(object sender, EventArgs e)
        {
            respon.nome = txtNome.Text;
            respon.cpf = txtCPF.Text;
            respon.telefone = txtFone.Text;
            respon.endereco = txtend.Text;
            respon.email = txtemail.Text;
            usu.login = txtLogin.Text;
            usu.senha = txtSenha.Text;
            usu.responsavel = respon;
            if (respon.cadastrarResponsavel())
            {
                voltar();
            }
            if (usu.cadastraLoginUsuario())
            {
                voltar();
            }
            
        }

        private void btnCad_MouseEnter(object sender, EventArgs e)
        {
            if (txtCPF.Text.Equals("") || txtNome.Text.Equals("") || txtFone.Text.Equals("")
                || txtend.Text.Equals("") || txtemail.Text.Equals("") || txtLogin.Text.Equals("")
                || txtSenha.Text.Equals(""))
            {
                MessageBox.Show("Preencha todos os campos!");
            }
            
        }
    }
}
