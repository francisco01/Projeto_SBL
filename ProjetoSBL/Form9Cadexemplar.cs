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
    public partial class Form9Cadexemplar : Form
    {
        public Form9Cadexemplar()
        {
            InitializeComponent();
        }
      
        string idprc;
        bool flag = false;
        Exemplar xmp = new Exemplar();
        int aux, anot = 0, dobra = 0;
      
        
        private void Form9Cadexemplar_Load(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "datasource=localhost;port=3306;username=root;password=s3t3mbr0;database=mydb;";
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                databaseConnection.Open();
                MySqlCommand commandDatabase = new MySqlCommand("select * from  Livro", databaseConnection);
                commandDatabase.CommandTimeout = 60;
                MySqlDataAdapter da = new MySqlDataAdapter(commandDatabase);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cmbLivro.DataSource = dt;
                cmbLivro.DisplayMember = "Titulo";
                cmbLivro.ValueMember = "ISBN";
                databaseConnection.Close();
                flag = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }


        private void cmbLivro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (flag)
            {
                
                try
                {
                    string connectionString = "datasource=localhost;port=3306;username=root;password=s3t3mbr0;database=mydb;";
                    MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                    databaseConnection.Open();
                    MySqlCommand commandDatabase = new MySqlCommand("select Preco_Sugerido_idPreco from Livro where ISBN = " + cmbLivro.SelectedValue + " ", databaseConnection);
                    commandDatabase.CommandTimeout = 60;
                    idprc = commandDatabase.ExecuteScalar().ToString();
                    databaseConnection.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
                int aux = Convert.ToInt32(idprc);
                try
                {
                    string connectionString = "datasource=localhost;port=3306;username=root;password=s3t3mbr0;database=mydb;";
                    MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                    databaseConnection.Open();
                    MySqlCommand commandDatabase = new MySqlCommand("select Preco from preco_sugerido where idPreco = " + aux + " ", databaseConnection);
                    commandDatabase.CommandTimeout = 60;
                    lblPrc.Text = "Preço sugerido R$ " + commandDatabase.ExecuteScalar().ToString();
                    databaseConnection.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }
        }

        private void btnCadexemp_Click(object sender, EventArgs e)
        {
            xmp.anotacao = ckbAnot.Checked;
            xmp.dobra = ckbDobra.Checked;
            xmp.situacao = txtSituacao.Text;
            xmp.entrega = txtentrega.Text;
            aux = Convert.ToInt32(idprc);
            if (xmp.anotacao)
            {
                anot = 1;
            }
            if (xmp.dobra)
            {
                dobra = 1;
            }
            cadastarExemplar();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            voltar();
        }

        private void cadastarExemplar()
        {
            try
            {
                string connectionString = "datasource=localhost;port=3306;username=root;password=s3t3mbr0;database=mydb;";
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                databaseConnection.Open();
                MySqlCommand commandDatabase = new MySqlCommand("insert into exemplar(Dobra, Anotacao, Situacao, Entrega, Responsavel_CPF, Livro_ISBN, Livro_Preco_Sugerido_idPreco)" + "VALUES( '" + dobra + "','" + anot + "','" + xmp.situacao.Trim() + "', '" + xmp.entrega.Trim() + "','" + GuardaID.CPF_Resp + "','" + cmbLivro.SelectedValue + "','" + aux + "' )", databaseConnection);
                commandDatabase.CommandTimeout = 60;
                commandDatabase.ExecuteNonQuery();
                databaseConnection.Close();
                MessageBox.Show("Exemplar cadastrado com sucesso!");
                voltar();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
        private void voltar()
        {
            Form8Opc frmopc2 = new Form8Opc();
            frmopc2.Show();
            this.Hide();
        }
    }
}
