namespace ProjetoPrincipal
{
    partial class FrmNovoCliente
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            label4 = new Label();
            textBox4 = new TextBox();
            textBox6 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            maskedTextBox1 = new MaskedTextBox();
            maskedTextBox2 = new MaskedTextBox();
            btnInicio = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Rockwell", 12F);
            textBox1.Location = new Point(289, 52);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(551, 26);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Rockwell", 12F);
            textBox2.Location = new Point(289, 140);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(551, 26);
            textBox2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Rockwell", 9.75F);
            label1.Location = new Point(289, 33);
            label1.Name = "label1";
            label1.Size = new Size(41, 16);
            label1.TabIndex = 7;
            label1.Text = "Nome";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Rockwell", 9.75F);
            label2.Location = new Point(289, 121);
            label2.Name = "label2";
            label2.Size = new Size(39, 16);
            label2.TabIndex = 8;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Rockwell", 9.75F);
            label3.Location = new Point(289, 209);
            label3.Name = "label3";
            label3.Size = new Size(56, 16);
            label3.TabIndex = 9;
            label3.Text = "Telefone";
            label3.Click += label3_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(64, 64, 64);
            button1.FlatAppearance.MouseOverBackColor = Color.White;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Rockwell", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(448, 582);
            button1.Name = "button1";
            button1.Size = new Size(233, 32);
            button1.TabIndex = 6;
            button1.Text = "Cadastrar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Rockwell", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 9);
            label4.Name = "label4";
            label4.Size = new Size(235, 27);
            label4.TabIndex = 13;
            label4.Text = "Cadastro de Cliente";
            label4.Click += label4_Click;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Rockwell", 12F);
            textBox4.Location = new Point(289, 405);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(551, 26);
            textBox4.TabIndex = 4;
            textBox4.UseSystemPasswordChar = true;
            // 
            // textBox6
            // 
            textBox6.Font = new Font("Rockwell", 12F);
            textBox6.Location = new Point(289, 493);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(551, 26);
            textBox6.TabIndex = 5;
            textBox6.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Rockwell", 9.75F);
            label5.Location = new Point(289, 473);
            label5.Name = "label5";
            label5.Size = new Size(104, 16);
            label5.TabIndex = 12;
            label5.Text = "Confirmar Senha";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Rockwell", 9.75F);
            label6.Location = new Point(289, 385);
            label6.Name = "label6";
            label6.Size = new Size(42, 16);
            label6.TabIndex = 11;
            label6.Text = "Senha";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Rockwell", 9.75F);
            label7.Location = new Point(289, 297);
            label7.Name = "label7";
            label7.Size = new Size(31, 16);
            label7.TabIndex = 10;
            label7.Text = "CPF";
            label7.Click += label7_Click;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Font = new Font("Rockwell", 12F);
            maskedTextBox1.Location = new Point(289, 229);
            maskedTextBox1.Mask = "+55  (00) 00000-0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(551, 26);
            maskedTextBox1.TabIndex = 2;
            maskedTextBox1.MaskInputRejected += maskedTextBox1_MaskInputRejected;
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Font = new Font("Rockwell", 12F);
            maskedTextBox2.Location = new Point(289, 317);
            maskedTextBox2.Mask = "000.000.000-00";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(551, 26);
            maskedTextBox2.TabIndex = 3;
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
            btnInicio.TabIndex = 14;
            btnInicio.Text = "Início";
            btnInicio.UseVisualStyleBackColor = false;
            btnInicio.Click += button2_Click;
            // 
            // FrmNovoCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1128, 703);
            Controls.Add(btnInicio);
            Controls.Add(maskedTextBox2);
            Controls.Add(maskedTextBox1);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(textBox6);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "FrmNovoCliente";
            Text = "FrmNovoCliente";
            Load += FrmNovoCliente_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Label label4;
        private TextBox textBox4;
        private TextBox textBox6;
        private Label label5;
        private Label label6;
        private Label label7;
        private MaskedTextBox maskedTextBox1;
        private MaskedTextBox maskedTextBox2;
        private Button btnInicio;
    }
}