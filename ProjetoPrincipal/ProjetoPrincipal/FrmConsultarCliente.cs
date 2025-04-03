using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoPrincipal
{
    public partial class FrmConsultarCliente : Form
    {
        public FrmConsultarCliente()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmConsultarCliente_Load(object sender, EventArgs e)
        {
            // apenas um teste de preenchimento do DataGridView
            dgvClientes.Rows.Add();
            dgvClientes.Rows[0].Cells[0].Value = 1;
            dgvClientes.Rows[0].Cells[1].Value = "525.140.068-27";
            dgvClientes.Rows[0].Cells[2].Value = "Gabriel Cabral";
            dgvClientes.Rows[0].Cells[3].Value = "gabriel.cmmariano@gmail.com";
            dgvClientes.Rows[0].Cells[4].Value = "(11) 94138-1718";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmPrincipal.pnlMenu.Visible = true;
        }
    }
}
