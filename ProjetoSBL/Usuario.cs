using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoSBL
{
    class Usuario
    {
        public string login { get; set; }
        public string senha { get; set; }
        public Responsavel responsavel { get; set; }

        public bool logarResponsavel()
        {
            try
            {
                string connectionString = "datasource=localhost;port=3306;username=root;password=mysql;database=mydb;";
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                databaseConnection.Open();
                MySqlCommand commandDatabase = new MySqlCommand("select * from usuario where usuario.login = @Login and usuario.senha = @Senha", databaseConnection);
                commandDatabase.Parameters.Add("@Login", MySqlDbType.VarChar).Value = this.login;
                commandDatabase.Parameters.Add("@Senha", MySqlDbType.VarChar).Value = this.senha;
                commandDatabase.CommandTimeout = 60;
                MySqlDataReader reader = commandDatabase.ExecuteReader();

                if (reader.HasRows)
                {
                    if (reader.Read())
                    {
                        GuardaID.ID = reader.GetInt64(0);
                        GuardaID.CPF_Resp = reader.GetInt64(3);
                       
                    }
                  
                }
                else
                {
                    MessageBox.Show("Login ou senha incorreto!");
                    return false;
                }
                databaseConnection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            return true;
        }
        public bool logarDiretor()
        {
            try
            {
                string connectionString = "datasource=localhost;port=3306;username=root;password=mysql;database=mydb;";
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                databaseConnection.Open();
                MySqlCommand commandDatabase = new MySqlCommand("select * from usuario_escola where usuario_escola.login = @Login and usuario_escola.senha = @Senha", databaseConnection);
                commandDatabase.Parameters.Add("@Login", MySqlDbType.VarChar).Value = this.login;
                commandDatabase.Parameters.Add("@Senha", MySqlDbType.VarChar).Value = this.senha;
                commandDatabase.CommandTimeout = 60;
                MySqlDataReader reader = commandDatabase.ExecuteReader();

                if (reader.HasRows)
                {
                    if (reader.Read())
                    {
                        //Session["Salvarid"] = reader.GetUInt32(3);
                        GuardaID.ID = reader.GetInt64(0);
                        
                    }
                   
                }
                else
                {
                    MessageBox.Show("Login ou senha incorreto!");
                    return false;
                }
                databaseConnection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;

            }
            return true;
        }

        public bool cadastraLoginUsuario()
        {
            try
            {
                string connectionString = "datasource=localhost;port=3306;username=root;password=mysql;database=mydb;";
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                databaseConnection.Open();
                MySqlCommand commandDatabase = new MySqlCommand("INSERT INTO usuario(Login, Senha, Responsavel_CPF)" + "VALUES( '" + this.login.Trim() + "','" + this.senha.Trim() + "','" + this.responsavel.cpf.Trim() + "' )", databaseConnection);
                commandDatabase.CommandTimeout = 60;
                commandDatabase.ExecuteNonQuery();
                databaseConnection.Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;

            }
            return true;
        }
    }
}
