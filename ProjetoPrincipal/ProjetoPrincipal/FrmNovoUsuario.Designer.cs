namespace ProjetoPrincipal
{
    partial class FrmNovoUsuario
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
            maskedTextBox2 = new MaskedTextBox();
            maskedTextBox1 = new MaskedTextBox();
            label7 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox4 = new TextBox();
            label4 = new Label();
            button1 = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label8 = new Label();
            textBox6 = new TextBox();
            textBox3 = new TextBox();
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
            btnInicio.TabIndex = 29;
            btnInicio.Text = "Início";
            btnInicio.UseVisualStyleBackColor = false;
            btnInicio.Click += button2_Click;
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Font = new Font("Rockwell", 12F);
            maskedTextBox2.Location = new Point(286, 316);
            maskedTextBox2.Mask = "000.000.000-00";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(551, 26);
            maskedTextBox2.TabIndex = 18;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Font = new Font("Rockwell", 12F);
            maskedTextBox1.Location = new Point(286, 228);
            maskedTextBox1.Mask = "+55  (00) 00000-0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(551, 26);
            maskedTextBox1.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Rockwell", 9.75F);
            label7.Location = new Point(286, 296);
            label7.Name = "label7";
            label7.Size = new Size(31, 16);
            label7.TabIndex = 25;
            label7.Text = "CPF";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Rockwell", 9.75F);
            label5.Location = new Point(286, 472);
            label5.Name = "label5";
            label5.Size = new Size(104, 16);
            label5.TabIndex = 27;
            label5.Text = "Confirmar Senha";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Rockwell", 9.75F);
            label6.Location = new Point(286, 384);
            label6.Name = "label6";
            label6.Size = new Size(42, 16);
            label6.TabIndex = 26;
            label6.Text = "Senha";
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Rockwell", 12F);
            textBox4.Location = new Point(286, 404);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(551, 26);
            textBox4.TabIndex = 19;
            textBox4.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Rockwell", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 9);
            label4.Name = "label4";
            label4.Size = new Size(239, 27);
            label4.TabIndex = 28;
            label4.Text = "Cadastro de Usuário";
            label4.Click += label4_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(64, 64, 64);
            button1.FlatAppearance.MouseOverBackColor = Color.White;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Rockwell", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(445, 640);
            button1.Name = "button1";
            button1.Size = new Size(233, 32);
            button1.TabIndex = 21;
            button1.Text = "Cadastrar";
            button1.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Rockwell", 9.75F);
            label3.Location = new Point(286, 208);
            label3.Name = "label3";
            label3.Size = new Size(56, 16);
            label3.TabIndex = 24;
            label3.Text = "Telefone";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Rockwell", 9.75F);
            label2.Location = new Point(286, 120);
            label2.Name = "label2";
            label2.Size = new Size(39, 16);
            label2.TabIndex = 23;
            label2.Text = "Email";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Rockwell", 9.75F);
            label1.Location = new Point(286, 32);
            label1.Name = "label1";
            label1.Size = new Size(41, 16);
            label1.TabIndex = 22;
            label1.Text = "Nome";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Rockwell", 12F);
            textBox2.Location = new Point(286, 139);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(551, 26);
            textBox2.TabIndex = 16;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Rockwell", 12F);
            textBox1.Location = new Point(286, 51);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(551, 26);
            textBox1.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Rockwell", 9.75F);
            label8.Location = new Point(286, 560);
            label8.Name = "label8";
            label8.Size = new Size(44, 16);
            label8.TabIndex = 32;
            label8.Text = "Cargo";
            // 
            // textBox6
            // 
            textBox6.Font = new Font("Rockwell", 12F);
            textBox6.Location = new Point(286, 492);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(551, 26);
            textBox6.TabIndex = 20;
            textBox6.UseSystemPasswordChar = true;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Rockwell", 12F);
            textBox3.Location = new Point(286, 579);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(551, 26);
            textBox3.TabIndex = 33;
            // 
            // FrmNovoUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1122, 704);
            Controls.Add(textBox3);
            Controls.Add(label8);
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
            MdiChildrenMinimizedAnchorBottom = false;
            Name = "FrmNovoUsuario";
            Text = "FrmNovoUsuario";
            Load += FrmNovoUsuario_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnInicio;
        private MaskedTextBox maskedTextBox2;
        private MaskedTextBox maskedTextBox1;
        private Label label7;
        private Label label5;
        private Label label6;
        private TextBox textBox4;
        private Label label4;
        private Button button1;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label8;
        private TextBox textBox6;
        private TextBox textBox3;
    }
}