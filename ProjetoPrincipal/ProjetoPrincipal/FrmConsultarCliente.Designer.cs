namespace ProjetoPrincipal
{
    partial class FrmConsultarCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvClientes = new DataGridView();
            clnId = new DataGridViewTextBoxColumn();
            clnCpf = new DataGridViewTextBoxColumn();
            clnNome = new DataGridViewTextBoxColumn();
            clnEmail = new DataGridViewTextBoxColumn();
            clnTelefone = new DataGridViewTextBoxColumn();
            label1 = new Label();
            textBox1 = new TextBox();
            btnInicio = new Button();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // dgvClientes
            // 
            dgvClientes.AllowUserToAddRows = false;
            dgvClientes.AllowUserToDeleteRows = false;
            dgvClientes.BackgroundColor = Color.FromArgb(64, 64, 64);
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Columns.AddRange(new DataGridViewColumn[] { clnId, clnCpf, clnNome, clnEmail, clnTelefone });
            dgvClientes.GridColor = SystemColors.Control;
            dgvClientes.Location = new Point(255, 253);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.ReadOnly = true;
            dgvClientes.RowHeadersVisible = false;
            dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClientes.Size = new Size(610, 250);
            dgvClientes.TabIndex = 0;
            // 
            // clnId
            // 
            clnId.Frozen = true;
            clnId.HeaderText = "ID";
            clnId.Name = "clnId";
            clnId.ReadOnly = true;
            clnId.Width = 50;
            // 
            // clnCpf
            // 
            clnCpf.Frozen = true;
            clnCpf.HeaderText = "CPF";
            clnCpf.Name = "clnCpf";
            clnCpf.ReadOnly = true;
            clnCpf.Width = 80;
            // 
            // clnNome
            // 
            clnNome.Frozen = true;
            clnNome.HeaderText = "Nome";
            clnNome.Name = "clnNome";
            clnNome.ReadOnly = true;
            clnNome.Width = 190;
            // 
            // clnEmail
            // 
            clnEmail.HeaderText = "Email";
            clnEmail.Name = "clnEmail";
            clnEmail.ReadOnly = true;
            clnEmail.Width = 190;
            // 
            // clnTelefone
            // 
            clnTelefone.HeaderText = "Telefone";
            clnTelefone.Name = "clnTelefone";
            clnTelefone.ReadOnly = true;
            clnTelefone.Width = 97;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Rockwell", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(255, 196);
            label1.Name = "label1";
            label1.Size = new Size(223, 25);
            label1.TabIndex = 1;
            label1.Text = "Consulta de Clientes";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.ForeColor = SystemColors.Control;
            textBox1.Location = new Point(255, 224);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Pesquise por Id, CPF ou parte de Nome";
            textBox1.Size = new Size(610, 19);
            textBox1.TabIndex = 2;
            // 
            // btnInicio
            // 
            btnInicio.BackColor = Color.FromArgb(64, 64, 64);
            btnInicio.FlatAppearance.MouseOverBackColor = Color.White;
            btnInicio.FlatStyle = FlatStyle.Flat;
            btnInicio.Font = new Font("Rockwell", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnInicio.ForeColor = SystemColors.Control;
            btnInicio.Location = new Point(12, 39);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(243, 32);
            btnInicio.TabIndex = 16;
            btnInicio.Text = "Início";
            btnInicio.UseVisualStyleBackColor = false;
            btnInicio.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Rockwell", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 9);
            label4.Name = "label4";
            label4.Size = new Size(243, 27);
            label4.TabIndex = 15;
            label4.Text = "Consulta de Clientes";
            label4.Click += label4_Click;
            // 
            // FrmConsultarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1120, 699);
            Controls.Add(btnInicio);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(dgvClientes);
            Name = "FrmConsultarCliente";
            Text = "FrmConsultarCliente";
            Load += FrmConsultarCliente_Load;
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvClientes;
        private DataGridViewTextBoxColumn clnId;
        private DataGridViewTextBoxColumn clnCpf;
        private DataGridViewTextBoxColumn clnNome;
        private DataGridViewTextBoxColumn clnEmail;
        private DataGridViewTextBoxColumn clnTelefone;
        private Label label1;
        private TextBox textBox1;
        private Button btnInicio;
        private Label label4;
    }
}