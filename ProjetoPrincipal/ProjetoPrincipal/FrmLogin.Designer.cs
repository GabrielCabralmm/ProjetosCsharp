namespace ProjetoPrincipal
{
    partial class FrmLogin
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
            btnLogar = new Button();
            label2 = new Label();
            label1 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // btnLogar
            // 
            btnLogar.BackColor = Color.FromArgb(64, 64, 64);
            btnLogar.FlatAppearance.MouseOverBackColor = Color.White;
            btnLogar.FlatStyle = FlatStyle.Flat;
            btnLogar.Font = new Font("Rockwell", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogar.ForeColor = SystemColors.Control;
            btnLogar.Location = new Point(443, 378);
            btnLogar.Name = "btnLogar";
            btnLogar.Size = new Size(233, 32);
            btnLogar.TabIndex = 21;
            btnLogar.Text = "Login";
            btnLogar.UseVisualStyleBackColor = false;
            btnLogar.Click += btnLogar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Rockwell", 9.75F);
            label2.Location = new Point(284, 190);
            label2.Name = "label2";
            label2.Size = new Size(39, 16);
            label2.TabIndex = 23;
            label2.Text = "Email";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Rockwell", 9.75F);
            label1.Location = new Point(284, 102);
            label1.Name = "label1";
            label1.Size = new Size(41, 16);
            label1.TabIndex = 22;
            label1.Text = "Nome";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Rockwell", 12F);
            textBox2.Location = new Point(284, 209);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(551, 26);
            textBox2.TabIndex = 16;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Rockwell", 12F);
            textBox1.Location = new Point(284, 121);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(551, 26);
            textBox1.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Rockwell", 9.75F);
            label3.Location = new Point(284, 277);
            label3.Name = "label3";
            label3.Size = new Size(42, 16);
            label3.TabIndex = 33;
            label3.Text = "Senha";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Rockwell", 12F);
            textBox3.Location = new Point(284, 297);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(551, 26);
            textBox3.TabIndex = 31;
            textBox3.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Rockwell", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 9);
            label4.Name = "label4";
            label4.Size = new Size(201, 27);
            label4.TabIndex = 28;
            label4.Text = "Login de Usuário";
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1119, 698);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(btnLogar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "FrmLogin";
            Text = "FrmLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnLogar;
        private Label label2;
        private Label label1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
    }
}