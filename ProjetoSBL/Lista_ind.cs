using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoSBL
{
    class Lista_ind
    {
        public string nivel { get; set; }
        public string serie { get; set; }
        public string ano { get; set; }
        public Escola escola { get; set; }

        public bool cadastarLista(ComboBox cmb)
        {
            try
            {
                string connectionString = "datasource=localhost;port=3306;username=root;password=s3t3mbr0;database=mydb;";
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                databaseConnection.Open();
                MySqlCommand commandDatabase = new MySqlCommand("INSERT INTO lista_ind(Nivel, Serie, Ano, Escola_idEscola)" + "VALUES( '" + this.nivel.Trim() + "','" + this.serie.Trim() + "','" + this.ano.Trim() + "', '" + cmb.SelectedValue + "' )", databaseConnection);
                commandDatabase.CommandTimeout = 60;
                commandDatabase.ExecuteNonQuery();
                databaseConnection.Close();
                
              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            MessageBox.Show("Lista cadastrada com sucesso!");
            return true;
        }
    }
}
