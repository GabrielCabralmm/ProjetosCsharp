using ProjetoTesteClass;

namespace ProjetoTesteDesk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var usuario = Usuario.ObterPorId(int.Parse(txtId.Text));
            txtNome.Text = usuario.Nome;
            txtEmail.Text = usuario.Email;
            txtTelefone.Text = usuario.Telefone;
            txtSenha.Text = usuario.Senha;
            chkAtivo.Checked = usuario.Ativo;
        }
    }
}
