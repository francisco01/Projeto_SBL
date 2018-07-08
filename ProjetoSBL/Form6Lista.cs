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
    public partial class Form6Lista : Form
    {
        public Form6Lista()
        {
            InitializeComponent();
        }

        Lista_ind lst = new Lista_ind();
        Form4Opcoes frmopc = new Form4Opcoes();

        private void Form6Lista_Load(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "datasource=localhost;port=3306;username=root;password=s3t3mbr0;database=mydb;";
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                databaseConnection.Open();
                MySqlCommand commandDatabase = new MySqlCommand("select * from  escola", databaseConnection);
                commandDatabase.CommandTimeout = 60;
                MySqlDataAdapter da = new MySqlDataAdapter(commandDatabase);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cmbescola.DataSource = dt;

                cmbescola.DisplayMember = "Nome";
                cmbescola.ValueMember = "idEscola";

               databaseConnection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void btnCad_Click(object sender, EventArgs e)
        {
            lst.nivel = txtNivel.Text;
            lst.serie = txtSerie.Text;
            lst.ano = txtAno.Text;
            cadastarLista();

        }

        private void cadastarLista()
        {
            try
            {
                string connectionString = "datasource=localhost;port=3306;username=root;password=s3t3mbr0;database=mydb;";
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                databaseConnection.Open();
                MySqlCommand commandDatabase = new MySqlCommand("INSERT INTO lista_ind(Nivel, Serie, Ano, Escola_idEscola)" + "VALUES( '" + lst.nivel.Trim() + "','" + lst.serie.Trim() + "','" + lst.ano.Trim() + "', '" + cmbescola.SelectedValue + "' )", databaseConnection);
                commandDatabase.CommandTimeout = 60;
                commandDatabase.ExecuteNonQuery();
                databaseConnection.Close();
                MessageBox.Show("Lista cadastrada com sucesso!");
                voltar();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            voltar();
        }
        private void voltar()
        {
            frmopc.Show();
            this.Hide();
        }
    }
}
