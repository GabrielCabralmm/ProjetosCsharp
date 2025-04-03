namespace ProjetoPrincipal
{
    public partial class FrmPrincipal : Form
    {
        public static bool logado = false;
        public FrmPrincipal()
        {
            InitializeComponent();
        }
        private void btnNovoCliente_Click(object sender, EventArgs e)
        {
            FrmNovoCliente frmNovoCliente = new();
            frmNovoCliente.TopLevel = false;
            frmNovoCliente.FormBorderStyle = FormBorderStyle.None;
            frmNovoCliente.MaximizeBox = true;
            frmNovoCliente.AutoSize = true;
            frmNovoCliente.Size = pnlCentral.Size;
            pnlCentral.Controls.Clear();
            pnlCentral.Controls.Add(frmNovoCliente);
            pnlMenu.Visible = false;

            frmNovoCliente.Show();
            pnlCentral.Visible = true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            FrmConsultarCliente frmConsultarCliente = new();
            frmConsultarCliente.TopLevel = false;
            frmConsultarCliente.FormBorderStyle = FormBorderStyle.None;
            frmConsultarCliente.MaximizeBox = true;
            frmConsultarCliente.AutoSize = true;
            frmConsultarCliente.Size = pnlCentral.Size;
            pnlCentral.Controls.Clear();
            pnlCentral.Controls.Add(frmConsultarCliente);
            pnlMenu.Visible = false;

            frmConsultarCliente.Show();
            pnlCentral.Visible = true;
        }

        private void btnCadastrarUsuario_Click(object sender, EventArgs e)
        {
            FrmNovoUsuario frmNovoUsuario = new();
            frmNovoUsuario.TopLevel = false;
            frmNovoUsuario.FormBorderStyle = FormBorderStyle.None;
            frmNovoUsuario.MaximizeBox = true;
            frmNovoUsuario.AutoSize = true;
            frmNovoUsuario.Size = pnlCentral.Size;
            pnlCentral.Controls.Clear();
            pnlCentral.Controls.Add(frmNovoUsuario);
            pnlMenu.Visible = false;

            frmNovoUsuario.Show();
            pnlCentral.Visible = true;
        }

        private void btnConsultarUsuario_Click(object sender, EventArgs e)
        {
            FrmConsultarUsuario frmConsultarUsuario = new();
            frmConsultarUsuario.TopLevel = false;
            frmConsultarUsuario.FormBorderStyle = FormBorderStyle.None;
            frmConsultarUsuario.MaximizeBox = true;
            frmConsultarUsuario.AutoSize = true;
            frmConsultarUsuario.Size = pnlCentral.Size;
            pnlCentral.Controls.Clear();
            pnlCentral.Controls.Add(frmConsultarUsuario);
            pnlMenu.Visible = false;

            frmConsultarUsuario.Show();
            pnlCentral.Visible = true;
        }

        private void btnProduto_Click(object sender, EventArgs e)
        {
            FrmCadastroProduto frmCadastroProduto = new();
            frmCadastroProduto.TopLevel = false;
            frmCadastroProduto.FormBorderStyle = FormBorderStyle.None;
            frmCadastroProduto.MaximizeBox = true;
            frmCadastroProduto.AutoSize = true;
            frmCadastroProduto.Size = pnlCentral.Size;
            pnlCentral.Controls.Clear();
            pnlCentral.Controls.Add(frmCadastroProduto);
            pnlMenu.Visible = false;

            frmCadastroProduto.Show();
            pnlCentral.Visible = true;
        }

        private void btnCaixa_Click(object sender, EventArgs e)
        {
            FrmCaixa frmCaixa = new();
            frmCaixa.TopLevel = false;
            frmCaixa.FormBorderStyle = FormBorderStyle.None;
            frmCaixa.MaximizeBox = true;
            frmCaixa.AutoSize = true;
            frmCaixa.Size = pnlCentral.Size;
            pnlCentral.Controls.Clear();
            pnlCentral.Controls.Add(frmCaixa);
            pnlMenu.Visible = false;

            frmCaixa.Show();
            pnlCentral.Visible = true;
        }

        private void btnDashBoard_Click(object sender, EventArgs e)
        {
            FrmDashBoard frmDashBoard = new();
            frmDashBoard.TopLevel = false;
            frmDashBoard.FormBorderStyle = FormBorderStyle.None;
            frmDashBoard.MaximizeBox = true;
            frmDashBoard.AutoSize = true;
            frmDashBoard.Size = pnlCentral.Size;
            pnlCentral.Controls.Clear();
            pnlCentral.Controls.Add(frmDashBoard);
            pnlMenu.Visible = false;

            frmDashBoard.Show();
            pnlCentral.Visible = true;
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            this.Hide();
            FrmLogin login = new();
            login.ShowDialog();
            if (logado)
            {
                this.Show();
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}