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
    public partial class Form4Opcoes : Form
    {
        public Form4Opcoes()
        {
            InitializeComponent();
        }

        private void btnCadescola_Click(object sender, EventArgs e)
        {
            Form5Cadescola frmesc = new Form5Cadescola();
            frmesc.Show();
            this.Hide();
        }

        private void btnCadLista_Click(object sender, EventArgs e)
        {
            Form6Lista frmlist = new Form6Lista();
            frmlist.Show();
            this.Hide();
        }

        private void btnCadLivro_Click(object sender, EventArgs e)
        {
            Form7CadLivro frmlivro = new Form7CadLivro();
            frmlivro.Show();
            this.Hide();
        }

        private void btneditarescola_Click(object sender, EventArgs e)
        {
            Form10editarescola frmsco = new Form10editarescola();
            frmsco.Show();
            this.Hide();
        }

        private void btneditarlista_Click(object sender, EventArgs e)
        {
            Form11editarlista frmlst = new Form11editarlista();
            frmlst.Show();
            this.Hide();
        }
    }
}
