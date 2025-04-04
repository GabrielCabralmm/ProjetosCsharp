using TDSQueueClass;

namespace TDSQueueDesk
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
            txtSenha.Text = usuario.Senha;
            chkAtivo.Checked = usuario.Ativo;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var usuarios = Usuario.ObterLista();
            int linha = 0;
            foreach (var usuario in usuarios)
            {
                dgvUsuarios.Rows.Add();
                dgvUsuarios.Rows[linha].Cells[0].Value = usuario.Id;
                dgvUsuarios.Rows[linha].Cells[1].Value = usuario.Nome;
                dgvUsuarios.Rows[linha].Cells[2].Value = usuario.Email;
                dgvUsuarios.Rows[linha].Cells[3].Value = usuario.Ativo;

                linha++;
            }
        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            Usuario usuario = new(txtNome.Text, txtEmail.Text, txtSenha.Text);
            usuario.Inserir();
            txtId.Text = usuario.Id.ToString();
            MessageBox.Show($"Usuário gravado com sucesso! Id: {usuario.Id}");
            Form1_Load(sender, e);
        }
    }
}
