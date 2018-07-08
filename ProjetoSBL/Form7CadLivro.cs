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
    public partial class Form7CadLivro : Form
    {
        public Form7CadLivro()
        {
            InitializeComponent();
        }
        Livro livro = new Livro();
        Preco prc = new Preco();
        Form4Opcoes frmopc = new Form4Opcoes();
        long idprc;

        private void button1_Click(object sender, EventArgs e)
        {
            voltar();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            livro.titulo = txtTitulo.Text;
            livro.autor = txtAutor.Text;
            livro.editora = txteditora.Text;
            livro.edicao = txtedicao.Text;
            livro.ano = txtAno.Text;
            livro.tipo = txtTipo.Text;
            prc.preco = Convert.ToDouble(txtPreco.Text);
            cadastraPreco();
            cadastraLivro();
        }
        private void cadastraPreco()
        {
            try
            {
                string connectionString = "datasource=localhost;port=3306;username=root;password=s3t3mbr0;database=mydb;";
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                databaseConnection.Open();
                MySqlCommand commandDatabase = new MySqlCommand("INSERT INTO preco_sugerido(Preco)" + "VALUES( '" + prc.preco + "')", databaseConnection);
                commandDatabase.CommandTimeout = 60;
                commandDatabase.ExecuteNonQuery();
                idprc = commandDatabase.LastInsertedId;
                databaseConnection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cadastraLivro()
        {
            try
            {
                string connectionString = "datasource=localhost;port=3306;username=root;password=s3t3mbr0;database=mydb;";
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                databaseConnection.Open();
                MySqlCommand commandDatabase = new MySqlCommand("INSERT INTO livro(Titulo, Autor, Editora, Ano, Edicao, Tipo, Preco_Sugerido_idPreco, Lista_Ind_idLista_Ind)" + "VALUES( '" +livro.titulo.Trim() + "','" + livro.autor.Trim() + "','" + livro.editora.Trim() + "', '" + livro.ano.Trim() + "', '" + livro.edicao.Trim() + "', '" + livro.tipo.Trim() + "', '" + idprc + "', '" + cmbListas.SelectedValue + "' )", databaseConnection);
                commandDatabase.CommandTimeout = 60;
                commandDatabase.ExecuteNonQuery();
                databaseConnection.Close();
                MessageBox.Show("Livro cadastrada com sucesso!");
                voltar();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buscarID()
        {
            try
            {
                string connectionString = "datasource=localhost;port=3306;username=root;password=s3t3mbr0;database=mydb;";
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                databaseConnection.Open();
                MySqlCommand commandDatabase = new MySqlCommand("select * from escola where Usuario_escola_idUsuario_escola ="+ GuardaID.ID + "", databaseConnection);
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

        private void Form7CadLivro_Load(object sender, EventArgs e)
        {
            buscarID();
            try
            {
                string connectionString = "datasource=localhost;port=3306;username=root;password=s3t3mbr0;database=mydb;";
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                databaseConnection.Open();
                MySqlCommand commandDatabase = new MySqlCommand("select * from Lista_Ind where Escola_idEscola = '" + GuardaID.IDescola + "' ", databaseConnection);
                commandDatabase.CommandTimeout = 60;
                MySqlDataAdapter da = new MySqlDataAdapter(commandDatabase);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cmbListas.DataSource = dt;
                cmbListas.DisplayMember = "Nivel";
                cmbListas.ValueMember = "idLista_Ind";
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
        private void voltar()
        {
            frmopc.Show();
            this.Hide();
        }
    }
}
