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
    public partial class Form5Cadescola : Form
    {
        public Form5Cadescola()
        {
            InitializeComponent();
        }
        Escola esc = new Escola();
        Form4Opcoes frmopc = new Form4Opcoes();

        private void btnVoltar_Click(object sender, EventArgs e)
        {

            voltar();
        }

        private void voltar()
        {
            frmopc.Show();
            this.Hide();
        }

        private void btnCad_Click(object sender, EventArgs e)
        {
            esc.nome = txtNome.Text;
            esc.cnpj = txtCNPJ.Text;
            esc.endereco = txtend.Text;
            cadastrarEscola();
        }
        private void cadastrarEscola()
        {
            try
            {
                string connectionString = "datasource=localhost;port=3306;username=root;password=s3t3mbr0;database=mydb;";
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                databaseConnection.Open();
                MySqlCommand commandDatabase = new MySqlCommand("INSERT INTO escola(Nome, CNPJ, Endereco, Usuario_escola_idUsuario_escola)" + "VALUES( '" + esc.nome.Trim() + "','" + esc.cnpj.Trim() + "','" + esc.endereco.Trim() + "', '" + GuardaID.ID + "' )", databaseConnection);
                commandDatabase.CommandTimeout = 60;
                commandDatabase.ExecuteNonQuery();
                databaseConnection.Close();
                MessageBox.Show("Escola cadastrada com sucesso!");
                voltar();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
