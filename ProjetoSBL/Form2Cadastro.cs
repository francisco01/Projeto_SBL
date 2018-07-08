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
            cadastrarResponsavel();
            cadastraLogin();
        }
        private void cadastrarResponsavel()
        {
            try
            {
                string connectionString = "datasource=localhost;port=3306;username=root;password=s3t3mbr0;database=mydb;";
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                databaseConnection.Open();
                MySqlCommand commandDatabase = new MySqlCommand("INSERT INTO responsavel(CPF, Nome, Telefone, Email, Endereco)" + "VALUES( '" + respon.cpf.Trim() + "','" + respon.nome.Trim() + "','" + respon.telefone.Trim() + "', '" + respon.email.Trim() + "', '" + respon.endereco.Trim() + "' )", databaseConnection);
                commandDatabase.CommandTimeout = 60;
                commandDatabase.ExecuteNonQuery();
                databaseConnection.Close();
            }
            catch (Exception ex)
            {

            }
        }
        private void cadastraLogin()
        {
            try
            {
                string connectionString = "datasource=localhost;port=3306;username=root;password=s3t3mbr0;database=mydb;";
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                databaseConnection.Open();
                MySqlCommand commandDatabase = new MySqlCommand("INSERT INTO usuario(Login, Senha, Responsavel_CPF)" + "VALUES( '" + usu.login.Trim() + "','" + usu.senha.Trim() + "','" + usu.responsavel.cpf.Trim() + "' )", databaseConnection);
                commandDatabase.CommandTimeout = 60;
                commandDatabase.ExecuteNonQuery();
                databaseConnection.Close();
                formlogin.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
    }
}
