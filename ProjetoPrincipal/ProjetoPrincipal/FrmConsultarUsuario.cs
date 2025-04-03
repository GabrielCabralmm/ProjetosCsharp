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
    public partial class FrmConsultarUsuario : Form
    {
        public FrmConsultarUsuario()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmPrincipal.pnlMenu.Visible = true;
        }
    }
}
