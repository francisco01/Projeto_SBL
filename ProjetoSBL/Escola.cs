using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoSBL
{
    class Escola
    {
        public long id { get; set; }
        public string nome { get; set; }
        public string cnpj { get; set; }
        public string endereco { get; set; }
        MySqlDataReader reader;

        public bool cadastrarEscola()
        {
            try
            {
                string connectionString = "datasource=localhost;port=3306;username=root;password=s3t3mbr0;database=mydb;";
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                databaseConnection.Open();
                MySqlCommand commandDatabase = new MySqlCommand("INSERT INTO escola(Nome, CNPJ, Endereco, Usuario_escola_idUsuario_escola)" + "VALUES( '" + this.nome.Trim() + "','" + this.cnpj.Trim() + "','" + this.endereco.Trim() + "', '" + GuardaID.ID + "' )", databaseConnection);
                commandDatabase.CommandTimeout = 60;
                commandDatabase.ExecuteNonQuery();
                databaseConnection.Close();
                MessageBox.Show("Escola cadastrada com sucesso!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            return true;
        }
        public DataTable buscarEscola()
        {
            DataTable dt = new DataTable();
            try
            {
                string connectionString = "datasource=localhost;port=3306;username=root;password=s3t3mbr0;database=mydb;";
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                databaseConnection.Open();
                MySqlCommand commandDatabase = new MySqlCommand("select * from escola", databaseConnection);
                commandDatabase.CommandTimeout = 60;
                MySqlDataAdapter da = new MySqlDataAdapter(commandDatabase);
                
                da.Fill(dt);
                databaseConnection.Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            return dt;
        }
        public void buscarUsuarioEscola()
        {
            try
            {
                string connectionString = "datasource=localhost;port=3306;username=root;password=s3t3mbr0;database=mydb;";
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                databaseConnection.Open();
                MySqlCommand commandDatabase = new MySqlCommand("select * from escola where Usuario_escola_idUsuario_escola =" + GuardaID.ID + "", databaseConnection);
                commandDatabase.CommandTimeout = 60;
                MySqlDataReader reader = commandDatabase.ExecuteReader();

                if (reader.HasRows)
                {
                    if (reader.Read())
                    {
                        GuardaID.IDescola = reader.GetInt64(0);
                    }
                }
                else
                {
                    MessageBox.Show("incorreto!");
                }
                databaseConnection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public MySqlDataReader buscaEscola()
        {
            
            try
            {
                string connectionString = "datasource=localhost;port=3306;username=root;password=s3t3mbr0;database=mydb;";
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                databaseConnection.Open();
                MySqlCommand commandDatabase = new MySqlCommand("select * from escola where Usuario_escola_idUsuario_escola =" + GuardaID.ID + "", databaseConnection);
                commandDatabase.CommandTimeout = 60;
                reader = commandDatabase.ExecuteReader();
                //databaseConnection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            return reader;
        }
        public void atualizarEscola()
        {
            try
            {
                string connectionString = "datasource=localhost;port=3306;username=root;password=s3t3mbr0;database=mydb;";
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                databaseConnection.Open();
                MySqlCommand commandDatabase = new MySqlCommand("update escola set Nome = '" + this.nome.Trim() + "', CNPJ = '" + this.cnpj.Trim() + "', Endereco = '" + this.endereco.Trim() + "'  where Usuario_escola_idUsuario_escola =" + GuardaID.ID + "", databaseConnection);
                commandDatabase.CommandTimeout = 60;
                reader = commandDatabase.ExecuteReader();
                databaseConnection.Close();
                MessageBox.Show("Dados alterados com sucesso!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
        public void excluirEscola()
        {
            try
            {
                string connectionString = "datasource=localhost;port=3306;username=root;password=s3t3mbr0;database=mydb;";
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                databaseConnection.Open();
                MySqlCommand commandDatabase = new MySqlCommand("delete from escola where Usuario_escola_idUsuario_escola =" + GuardaID.ID + "", databaseConnection);
                commandDatabase.CommandTimeout = 60;
                reader = commandDatabase.ExecuteReader();
                databaseConnection.Close();
                MessageBox.Show("Dados excluidos com sucesso!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
    }
}
