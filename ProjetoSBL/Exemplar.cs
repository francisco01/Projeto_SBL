using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoSBL
{
    class Exemplar
    {
        public int dobra { get; set; }
        public int anotacao { get; set; }
        public string situacao { get; set; }
        public string entrega { get; set; }
        public Livro livro = new Livro();
        public Responsavel responsavel = new Responsavel();


        public bool cadastrarExemplar(ComboBox cmb, long aux)
        {
            try
            {
                string connectionString = "datasource=localhost;port=3306;username=root;password=s3t3mbr0;database=mydb;";
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                databaseConnection.Open();
                MySqlCommand commandDatabase = new MySqlCommand("insert into exemplar(Dobra, Anotacao, Situacao, Entrega, Responsavel_CPF, Livro_ISBN, Livro_Preco_Sugerido_idPreco)" + "VALUES( '" + this.dobra + "','" + this.anotacao + "','" + this.situacao.Trim() + "', '" + this.entrega.Trim() + "','" + GuardaID.CPF_Resp + "','" + cmb.SelectedValue + "','" + aux + "' )", databaseConnection);
                commandDatabase.CommandTimeout = 60;
                commandDatabase.ExecuteNonQuery();
                databaseConnection.Close();
                MessageBox.Show("Exemplar cadastrado com sucesso!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            return true;
        }

    }
}
