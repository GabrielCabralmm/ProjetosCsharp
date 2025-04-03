namespace ProjetoPrincipal
{
    partial class FrmDashBoard
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
            btnInicio = new Button();
            label4 = new Label();
            bntVendas = new Button();
            btnClientes = new Button();
            btnProdutos = new Button();
            btnGeral = new Button();
            btnPromocoes = new Button();
            SuspendLayout();
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
            btnInicio.Size = new Size(233, 32);
            btnInicio.TabIndex = 16;
            btnInicio.Text = "Início";
            btnInicio.UseVisualStyleBackColor = false;
            btnInicio.Click += btnInicio_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Rockwell", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 9);
            label4.Name = "label4";
            label4.Size = new Size(134, 27);
            label4.TabIndex = 15;
            label4.Text = "DashBoard";
            // 
            // bntVendas
            // 
            bntVendas.BackColor = Color.FromArgb(64, 64, 64);
            bntVendas.FlatAppearance.MouseOverBackColor = Color.White;
            bntVendas.FlatStyle = FlatStyle.Flat;
            bntVendas.Font = new Font("Rockwell", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bntVendas.ForeColor = SystemColors.Control;
            bntVendas.Location = new Point(12, 189);
            bntVendas.Name = "bntVendas";
            bntVendas.Size = new Size(134, 32);
            bntVendas.TabIndex = 17;
            bntVendas.Text = "Vendas";
            bntVendas.UseVisualStyleBackColor = false;
            // 
            // btnClientes
            // 
            btnClientes.BackColor = Color.FromArgb(64, 64, 64);
            btnClientes.FlatAppearance.MouseOverBackColor = Color.White;
            btnClientes.FlatStyle = FlatStyle.Flat;
            btnClientes.Font = new Font("Rockwell", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClientes.ForeColor = SystemColors.Control;
            btnClientes.Location = new Point(12, 237);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(134, 32);
            btnClientes.TabIndex = 18;
            btnClientes.Text = "Clientes";
            btnClientes.UseVisualStyleBackColor = false;
            // 
            // btnProdutos
            // 
            btnProdutos.BackColor = Color.FromArgb(64, 64, 64);
            btnProdutos.FlatAppearance.MouseOverBackColor = Color.White;
            btnProdutos.FlatStyle = FlatStyle.Flat;
            btnProdutos.Font = new Font("Rockwell", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnProdutos.ForeColor = SystemColors.Control;
            btnProdutos.Location = new Point(12, 285);
            btnProdutos.Name = "btnProdutos";
            btnProdutos.Size = new Size(134, 32);
            btnProdutos.TabIndex = 20;
            btnProdutos.Text = "Produtos";
            btnProdutos.UseVisualStyleBackColor = false;
            // 
            // btnGeral
            // 
            btnGeral.BackColor = Color.FromArgb(64, 64, 64);
            btnGeral.FlatAppearance.MouseOverBackColor = Color.White;
            btnGeral.FlatStyle = FlatStyle.Flat;
            btnGeral.Font = new Font("Rockwell", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGeral.ForeColor = SystemColors.Control;
            btnGeral.Location = new Point(12, 381);
            btnGeral.Name = "btnGeral";
            btnGeral.Size = new Size(134, 32);
            btnGeral.TabIndex = 23;
            btnGeral.Text = "Geral";
            btnGeral.UseVisualStyleBackColor = false;
            // 
            // btnPromocoes
            // 
            btnPromocoes.BackColor = Color.FromArgb(64, 64, 64);
            btnPromocoes.FlatAppearance.MouseOverBackColor = Color.White;
            btnPromocoes.FlatStyle = FlatStyle.Flat;
            btnPromocoes.Font = new Font("Rockwell", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPromocoes.ForeColor = SystemColors.Control;
            btnPromocoes.Location = new Point(12, 333);
            btnPromocoes.Name = "btnPromocoes";
            btnPromocoes.Size = new Size(134, 32);
            btnPromocoes.TabIndex = 22;
            btnPromocoes.Text = "Promoções";
            btnPromocoes.UseVisualStyleBackColor = false;
            // 
            // FrmDashBoard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1110, 700);
            Controls.Add(btnGeral);
            Controls.Add(btnPromocoes);
            Controls.Add(btnProdutos);
            Controls.Add(btnClientes);
            Controls.Add(bntVendas);
            Controls.Add(btnInicio);
            Controls.Add(label4);
            Name = "FrmDashBoard";
            Text = "FrmDashBoard";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnInicio;
        private Label label4;
        private Button bntVendas;
        private Button btnClientes;
        private Button btnProdutos;
        private Button btnGeral;
        private Button btnPromocoes;
    }
}