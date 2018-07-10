﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
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
        public Escola escola = new Escola();

        public bool cadastarLista(ComboBox cmb, long idprc)
        {
            try
            {
                string connectionString = "datasource=localhost;port=3306;username=root;password=s3t3mbr0;database=mydb;";
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                databaseConnection.Open();
                MySqlCommand commandDatabase = new MySqlCommand("INSERT INTO lista_ind(Nivel, Serie, Ano, Escola_idEscola, Preco_Sugerido_idPreco)" + "VALUES( '" + this.nivel.Trim() + "','" + this.serie.Trim() + "','" + this.ano.Trim() + "', '" + cmb.SelectedValue + "', '" + idprc + "' )", databaseConnection);
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
        public long buscarIdPreco(ComboBox cmb)
        {
            long aux = 0;
            try
            {
                string connectionString = "datasource=localhost;port=3306;username=root;password=s3t3mbr0;database=mydb;";
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                databaseConnection.Open();
                MySqlCommand commandDatabase = new MySqlCommand("select * from lista_ind where idLista_Ind =" + cmb.SelectedValue + "", databaseConnection);
                commandDatabase.CommandTimeout = 60;
                MySqlDataReader reader = commandDatabase.ExecuteReader();

                if (reader.HasRows)
                {
                    if (reader.Read())
                    {
                       aux = reader.GetInt64(5);
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
        public DataTable buscarListas()
        {
            DataTable dt = new DataTable();
            try
            {
                string connectionString = "datasource=localhost;port=3306;username=root;password=s3t3mbr0;database=mydb;";
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                databaseConnection.Open();
                MySqlCommand commandDatabase = new MySqlCommand("select * from Lista_Ind where Escola_idEscola = '" + GuardaID.IDescola + "' ", databaseConnection);
                commandDatabase.CommandTimeout = 60;
                MySqlDataAdapter da = new MySqlDataAdapter(commandDatabase);
                da.Fill(dt);
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            return dt;
        }
    }
}
