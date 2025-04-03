namespace ProjetoPrincipal
{
    public partial class FrmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlMenu = new Panel();
            btnSair = new Button();
            btnDashBoard = new Button();
            btnCaixa = new Button();
            btnProduto = new Button();
            btnConsultarUsuario = new Button();
            btnCadastrarUsuario = new Button();
            btnNovoCliente = new Button();
            btnConsultarCliente = new Button();
            pnlCentral = new Panel();
            pnlMenu.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = Color.FromArgb(224, 224, 224);
            pnlMenu.Controls.Add(btnSair);
            pnlMenu.Controls.Add(btnDashBoard);
            pnlMenu.Controls.Add(btnCaixa);
            pnlMenu.Controls.Add(btnProduto);
            pnlMenu.Controls.Add(btnConsultarUsuario);
            pnlMenu.Controls.Add(btnCadastrarUsuario);
            pnlMenu.Controls.Add(btnNovoCliente);
            pnlMenu.Controls.Add(btnConsultarCliente);
            pnlMenu.Font = new Font("Rockwell", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pnlMenu.ForeColor = SystemColors.Control;
            pnlMenu.Location = new Point(241, 188);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(662, 327);
            pnlMenu.TabIndex = 3;
            pnlMenu.TabStop = true;
            // 
            // btnSair
            // 
            btnSair.BackColor = Color.Gold;
            btnSair.FlatAppearance.BorderSize = 0;
            btnSair.FlatStyle = FlatStyle.Flat;
            btnSair.Font = new Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSair.ForeColor = Color.Black;
            btnSair.Location = new Point(5, 293);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(160, 29);
            btnSair.TabIndex = 9;
            btnSair.Text = "Fechar";
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click;
            // 
            // btnDashBoard
            // 
            btnDashBoard.BackColor = Color.Gold;
            btnDashBoard.FlatAppearance.BorderSize = 0;
            btnDashBoard.FlatStyle = FlatStyle.Flat;
            btnDashBoard.Font = new Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDashBoard.ForeColor = Color.Black;
            btnDashBoard.Location = new Point(333, 38);
            btnDashBoard.Name = "btnDashBoard";
            btnDashBoard.Size = new Size(160, 29);
            btnDashBoard.TabIndex = 8;
            btnDashBoard.Text = "DashBoard";
            btnDashBoard.UseVisualStyleBackColor = false;
            btnDashBoard.Click += btnDashBoard_Click;
            // 
            // btnCaixa
            // 
            btnCaixa.BackColor = Color.Gold;
            btnCaixa.FlatAppearance.BorderSize = 0;
            btnCaixa.FlatStyle = FlatStyle.Flat;
            btnCaixa.Font = new Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCaixa.ForeColor = Color.Black;
            btnCaixa.Location = new Point(169, 38);
            btnCaixa.Name = "btnCaixa";
            btnCaixa.Size = new Size(160, 29);
            btnCaixa.TabIndex = 7;
            btnCaixa.Text = "Caixa";
            btnCaixa.UseVisualStyleBackColor = false;
            btnCaixa.Click += btnCaixa_Click;
            // 
            // btnProduto
            // 
            btnProduto.BackColor = Color.Gold;
            btnProduto.FlatAppearance.BorderSize = 0;
            btnProduto.FlatStyle = FlatStyle.Flat;
            btnProduto.Font = new Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnProduto.ForeColor = Color.Black;
            btnProduto.Location = new Point(5, 38);
            btnProduto.Name = "btnProduto";
            btnProduto.Size = new Size(160, 29);
            btnProduto.TabIndex = 6;
            btnProduto.Text = "Cadastrar Produto";
            btnProduto.UseVisualStyleBackColor = false;
            btnProduto.Click += btnProduto_Click;
            // 
            // btnConsultarUsuario
            // 
            btnConsultarUsuario.BackColor = Color.Gold;
            btnConsultarUsuario.FlatAppearance.BorderSize = 0;
            btnConsultarUsuario.FlatStyle = FlatStyle.Flat;
            btnConsultarUsuario.Font = new Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnConsultarUsuario.ForeColor = Color.Black;
            btnConsultarUsuario.Location = new Point(497, 5);
            btnConsultarUsuario.Name = "btnConsultarUsuario";
            btnConsultarUsuario.Size = new Size(160, 29);
            btnConsultarUsuario.TabIndex = 5;
            btnConsultarUsuario.Text = "Funcionarios";
            btnConsultarUsuario.UseVisualStyleBackColor = false;
            btnConsultarUsuario.Click += btnConsultarUsuario_Click;
            // 
            // btnCadastrarUsuario
            // 
            btnCadastrarUsuario.BackColor = Color.Gold;
            btnCadastrarUsuario.FlatAppearance.BorderSize = 0;
            btnCadastrarUsuario.FlatStyle = FlatStyle.Flat;
            btnCadastrarUsuario.Font = new Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCadastrarUsuario.ForeColor = Color.Black;
            btnCadastrarUsuario.Location = new Point(333, 5);
            btnCadastrarUsuario.Name = "btnCadastrarUsuario";
            btnCadastrarUsuario.Size = new Size(160, 29);
            btnCadastrarUsuario.TabIndex = 4;
            btnCadastrarUsuario.Text = "Cadastrar Usuario";
            btnCadastrarUsuario.UseVisualStyleBackColor = false;
            btnCadastrarUsuario.Click += btnCadastrarUsuario_Click;
            // 
            // btnNovoCliente
            // 
            btnNovoCliente.BackColor = Color.Gold;
            btnNovoCliente.FlatAppearance.BorderSize = 0;
            btnNovoCliente.FlatStyle = FlatStyle.Flat;
            btnNovoCliente.Font = new Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNovoCliente.ForeColor = Color.Black;
            btnNovoCliente.Location = new Point(5, 5);
            btnNovoCliente.Name = "btnNovoCliente";
            btnNovoCliente.Size = new Size(160, 29);
            btnNovoCliente.TabIndex = 3;
            btnNovoCliente.Text = "Cadastrar Cliente";
            btnNovoCliente.UseVisualStyleBackColor = false;
            btnNovoCliente.Click += btnNovoCliente_Click;
            // 
            // btnConsultarCliente
            // 
            btnConsultarCliente.BackColor = Color.Gold;
            btnConsultarCliente.FlatAppearance.BorderSize = 0;
            btnConsultarCliente.FlatStyle = FlatStyle.Flat;
            btnConsultarCliente.Font = new Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnConsultarCliente.ForeColor = Color.Black;
            btnConsultarCliente.Location = new Point(169, 5);
            btnConsultarCliente.Name = "btnConsultarCliente";
            btnConsultarCliente.Size = new Size(160, 29);
            btnConsultarCliente.TabIndex = 1;
            btnConsultarCliente.Text = "Clientes";
            btnConsultarCliente.UseVisualStyleBackColor = false;
            btnConsultarCliente.Click += button1_Click;
            // 
            // pnlCentral
            // 
            pnlCentral.BackColor = SystemColors.Control;
            pnlCentral.Dock = DockStyle.Fill;
            pnlCentral.Location = new Point(0, 0);
            pnlCentral.Name = "pnlCentral";
            pnlCentral.Size = new Size(1124, 702);
            pnlCentral.TabIndex = 5;
            pnlCentral.Visible = false;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1124, 702);
            Controls.Add(pnlMenu);
            Controls.Add(pnlCentral);
            IsMdiContainer = true;
            Name = "FrmPrincipal";
            Text = "FrmPrincipal";
            WindowState = FormWindowState.Maximized;
            Load += FrmPrincipal_Load;
            pnlMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button btnConsultarCliente;
        private Button btnNovoCliente;
        private Button btnCadastrarUsuario;
        private Button btnConsultarUsuario;
        private Button btnProduto;
        private Button btnCaixa;
        private Button btnDashBoard;
        private Button btnSair;
        public Panel pnlCentral;
        public Panel pnlMenu;
    }
}
