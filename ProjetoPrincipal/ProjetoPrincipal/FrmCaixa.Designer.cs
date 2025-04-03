namespace ProjetoPrincipal
{
    partial class FrmCaixa
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
            btnFecharCaixa = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // btnFecharCaixa
            // 
            btnFecharCaixa.BackColor = Color.FromArgb(64, 64, 64);
            btnFecharCaixa.FlatAppearance.MouseOverBackColor = Color.White;
            btnFecharCaixa.FlatStyle = FlatStyle.Flat;
            btnFecharCaixa.Font = new Font("Rockwell", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFecharCaixa.ForeColor = SystemColors.Control;
            btnFecharCaixa.Location = new Point(12, 39);
            btnFecharCaixa.Name = "btnFecharCaixa";
            btnFecharCaixa.Size = new Size(233, 32);
            btnFecharCaixa.TabIndex = 15;
            btnFecharCaixa.Text = "Início";
            btnFecharCaixa.UseVisualStyleBackColor = false;
            btnFecharCaixa.Click += btnFecharCaixa_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Rockwell", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 9);
            label4.Name = "label4";
            label4.Size = new Size(76, 27);
            label4.TabIndex = 17;
            label4.Text = "Caixa";
            // 
            // FrmCaixa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1128, 705);
            Controls.Add(label4);
            Controls.Add(btnFecharCaixa);
            Name = "FrmCaixa";
            Text = "FrmCaixa";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnFecharCaixa;
        private Label label4;
    }
}