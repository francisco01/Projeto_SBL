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
    public partial class Form8Opc : Form
    {
        public Form8Opc()
        {
            InitializeComponent();
        }

        Form9Cadexemplar frmxmp = new Form9Cadexemplar();

        private void btnComprar_Click(object sender, EventArgs e)
        {
            frmxmp.Show();
            this.Hide();
        }
    }
}
