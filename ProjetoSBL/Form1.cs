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

            try
            {
                string connectionString = "datasource=localhost;port=3306;username=root;password=s3t3mbr0;database=mydb;";
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                databaseConnection.Open();
                MySqlCommand commandDatabase = new MySqlCommand("select * from usuario where usuario.login = @Login and usuario.senha = @Senha", databaseConnection);
                commandDatabase.Parameters.Add("@Login", MySqlDbType.VarChar).Value = usu.login;
                commandDatabase.Parameters.Add("@Senha", MySqlDbType.VarChar).Value = usu.senha;
                commandDatabase.CommandTimeout = 60;
                MySqlDataReader reader = commandDatabase.ExecuteReader();
                
                if (reader.HasRows)
                {
                    if (reader.Read())
                    {
                        GuardaID.ID = reader.GetInt64(0);
                        GuardaID.CPF_Resp = reader.GetInt64(3);
                    }
                    //MessageBox.Show("");
                    Form8Opc frmopc = new Form8Opc();
                    frmopc.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Login ou senha incorreto!");
                }
                databaseConnection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            usu.login = txtLogin.Text;
            usu.senha = txtSenha.Text;

            try
            {
                string connectionString = "datasource=localhost;port=3306;username=root;password=s3t3mbr0;database=mydb;";
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                databaseConnection.Open();
                MySqlCommand commandDatabase = new MySqlCommand("select * from usuario_escola where usuario_escola.login = @Login and usuario_escola.senha = @Senha", databaseConnection);
                commandDatabase.Parameters.Add("@Login", MySqlDbType.VarChar).Value = usu.login;
                commandDatabase.Parameters.Add("@Senha", MySqlDbType.VarChar).Value = usu.senha;
                commandDatabase.CommandTimeout = 60;
                MySqlDataReader reader = commandDatabase.ExecuteReader();

                if (reader.HasRows)
                {
                     if (reader.Read())
                    {
                        //Session["Salvarid"] = reader.GetUInt32(3);
                        GuardaID.ID = reader.GetInt64(0);
                    }
                    //GuardaID.ID = reader.g;
                    //MessageBox.Show("OK" + GuardaID.ID);
                    Form4Opcoes frmopc = new Form4Opcoes();
                    frmopc.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Login ou senha incorreto!");
                }
                databaseConnection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
    }
}
