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
                MySqlCommand commandDatabase = new MySqlCommand("select * from  escola", databaseConnection);
                commandDatabase.CommandTimeout = 60;
                MySqlDataAdapter da = new MySqlDataAdapter(commandDatabase);
                
                da.Fill(dt);
                databaseConnection.Close();
                
                //cmbescola.DataSource = dt;

                //cmbescola.DisplayMember = "Nome";
                //cmbescola.ValueMember = "idEscola";

                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            return dt;
        }
    }
}
