using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoSBL
{
    class Preco
    {
        public double preco { get; set; }

        public long cadastraPreco()
        {
            long idprc;
            try
            {
                string connectionString = "datasource=localhost;port=3306;username=root;password=mysql;database=mydb;";
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                databaseConnection.Open();
                MySqlCommand commandDatabase = new MySqlCommand("INSERT INTO preco_sugerido(Preco)" + "VALUES( '" + this.preco + "')", databaseConnection);
                commandDatabase.CommandTimeout = 60;
                commandDatabase.ExecuteNonQuery();
                idprc = commandDatabase.LastInsertedId;
                databaseConnection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
            return idprc;
        }
        public double buscarPreco(long id)
        {
            double aux = 0;
            try
            {
                string connectionString = "datasource=localhost;port=3306;username=root;password=mysql;database=mydb;";
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                databaseConnection.Open();
                MySqlCommand commandDatabase = new MySqlCommand("select * from preco_sugerido where idPreco =" + id + "", databaseConnection);
                commandDatabase.CommandTimeout = 60;
                MySqlDataReader reader = commandDatabase.ExecuteReader();

                if (reader.HasRows)
                {
                    if (reader.Read())
                    {
                        aux = reader.GetDouble(1);
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
            return aux;
        }
        public void atualizarPreco(long idprc)
        {
            try
            {
                string connectionString = "datasource=localhost;port=3306;username=root;password=mysql;database=mydb;";
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                databaseConnection.Open();
                MySqlCommand commandDatabase = new MySqlCommand("update preco_sugerido set Preco = '" + this.preco + "' where idPreco =" + idprc + "", databaseConnection);
                commandDatabase.CommandTimeout = 60;
                MySqlDataReader reader = commandDatabase.ExecuteReader();
                databaseConnection.Close();
                //MessageBox.Show("Dados alterados com sucesso!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
    }
}
