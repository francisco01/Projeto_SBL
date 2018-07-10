using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoSBL
{
    class Livro
    {
        public string titulo { get; set; }
        public string autor { get; set; }
        public string editora { get; set; }
        public string edicao { get; set; }
        public string ano { get; set; }
        public string tipo { get; set; }
        public Preco preco = new Preco();
        public Lista_ind lista = new Lista_ind();

        public void cadastrarLivro(long idprc, ComboBox cmb)
        {
            try
            {
                string connectionString = "datasource=localhost;port=3306;username=root;password=s3t3mbr0;database=mydb;";
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                databaseConnection.Open();
                MySqlCommand commandDatabase = new MySqlCommand("INSERT INTO livro(Titulo, Autor, Editora, Ano, Edicao, Tipo, Preco_Sugerido_idPreco, Lista_Ind_idLista_Ind)" + "VALUES( '" + this.titulo.Trim() + "','" + this.autor.Trim() + "','" + this.editora.Trim() + "', '" + this.ano.Trim() + "', '" + this.edicao.Trim() + "', '" + this.tipo.Trim() + "', '" + idprc + "', '" + cmb.SelectedValue + "' )", databaseConnection);
                commandDatabase.CommandTimeout = 60;
                commandDatabase.ExecuteNonQuery();
                databaseConnection.Close();
                MessageBox.Show("Livro cadastrada com sucesso!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
