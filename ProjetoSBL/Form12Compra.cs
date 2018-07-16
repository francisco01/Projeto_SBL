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
    public partial class Form12Compra : Form
    {
        public Form12Compra()
        {
            InitializeComponent();
        }
        Lista_ind lst = new Lista_ind();
        Livro livro = new Livro();
        bool aux = false;
        bool aux2 = false;
        string idexemplar;

        private void Form12Compra_Load(object sender, EventArgs e)
        {
            cmbLista.DataSource = lst.buscarListas2();
            cmbLista.DisplayMember = "Nivel";
            cmbLista.ValueMember = "idLista_Ind";
            aux = true;
        }

        private void cmbLista_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (aux)
            {
                cmbLivro.DataSource = livro.buscarLivro2(cmbLista);
                cmbLivro.DisplayMember = "Titulo";
                cmbLivro.ValueMember = "ISBN";
                aux2 = true;
            }
        }

        private void cmbLivro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (aux2)
            {
                carregarGrid(cmbLivro);
            }
        }
        private void carregarGrid(ComboBox cmb)
        {
            try
            {
                //string aux = DropDownServ.SelectedValue.Trim();
                //conexão;
                string connectionString = "datasource=localhost;port=3306;username=root;password=mysql;database=mydb;";
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                databaseConnection.Open();
                MySqlCommand commandDatabase = new MySqlCommand("select idExemplar as Codigo, Dobra, Anotacao, Situacao, Entrega, Preco from exemplar where Livro_ISBN = " + cmb.SelectedValue + " and Situacao like 'disponivel%' ", databaseConnection);
                commandDatabase.CommandTimeout = 60;
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(commandDatabase);
                da.Fill(dt);
                MySqlDataReader reader;

                //databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                grdvexemplar.DataSource = dt;
                //grdvexemplar.DataBindings();
                //grdvexemplar.DataBind();
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                // Show any error message.
                MessageBox.Show(ex.Message);
            }

        }

        private void grdvexemplar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show("tst");
            
            idexemplar = grdvexemplar.Rows[grdvexemplar.CurrentRow.Index].Cells[1].Value.ToString();
            //MessageBox.Show("tst  " + aux);
            realizarCompra();

        }
        private void realizarCompra()
        {
            try
            {
                string connectionString = "datasource=localhost;port=3306;username=root;password=mysql;database=mydb;";
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                databaseConnection.Open();
                MySqlCommand commandDatabase = new MySqlCommand("update exemplar set Responsavel_CPF = '" + GuardaID.CPF_Resp + "', Situacao = 'Comprado'  where idExemplar =" + Convert.ToInt64(idexemplar) +" ", databaseConnection);
                commandDatabase.CommandTimeout = 60;
                MySqlDataReader reader = commandDatabase.ExecuteReader();
                databaseConnection.Close();
                MessageBox.Show("Compra Realizada com sucesso!");
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            voltar();
        }
        public void voltar()
        {
            Form8Opc opc = new Form8Opc();
            opc.Show();
            this.Hide();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            voltar();
        }
    }
}
