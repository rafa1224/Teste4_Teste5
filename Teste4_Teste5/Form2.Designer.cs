namespace Teste4_Teste5
{
    partial class Form2
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
            this.nomeAluno = new System.Windows.Forms.TextBox();
            this.nota1semestre = new System.Windows.Forms.TextBox();
            this.nota2semestre = new System.Windows.Forms.TextBox();
            this.envia = new System.Windows.Forms.Button();
            this.Limpar = new System.Windows.Forms.Button();
            this.Nome = new System.Windows.Forms.Label();
            this.Nota1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NaoEnviado = new System.Windows.Forms.Label();
            this.NotaEnviada = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nomeAluno
            // 
            this.nomeAluno.Location = new System.Drawing.Point(72, 138);
            this.nomeAluno.Name = "nomeAluno";
            this.nomeAluno.Size = new System.Drawing.Size(304, 22);
            this.nomeAluno.TabIndex = 0;
            // 
            // nota1semestre
            // 
            this.nota1semestre.Location = new System.Drawing.Point(72, 198);
            this.nota1semestre.Name = "nota1semestre";
            this.nota1semestre.Size = new System.Drawing.Size(137, 22);
            this.nota1semestre.TabIndex = 1;
            // 
            // nota2semestre
            // 
            this.nota2semestre.Location = new System.Drawing.Point(250, 198);
            this.nota2semestre.Name = "nota2semestre";
            this.nota2semestre.Size = new System.Drawing.Size(126, 22);
            this.nota2semestre.TabIndex = 2;
            this.nota2semestre.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // envia
            // 
            this.envia.Location = new System.Drawing.Point(72, 258);
            this.envia.Name = "envia";
            this.envia.Size = new System.Drawing.Size(181, 23);
            this.envia.TabIndex = 3;
            this.envia.Text = "Enviar";
            this.envia.UseVisualStyleBackColor = true;
            this.envia.Click += new System.EventHandler(this.envia_Click);
            // 
            // Limpar
            // 
            this.Limpar.Location = new System.Drawing.Point(259, 258);
            this.Limpar.Name = "Limpar";
            this.Limpar.Size = new System.Drawing.Size(117, 23);
            this.Limpar.TabIndex = 4;
            this.Limpar.Text = "Limpar campos";
            this.Limpar.UseVisualStyleBackColor = true;
            this.Limpar.Click += new System.EventHandler(this.button2_Click);
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.Location = new System.Drawing.Point(69, 119);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(100, 16);
            this.Nome.TabIndex = 5;
            this.Nome.Text = "Nome do Aluno";
            // 
            // Nota1
            // 
            this.Nota1.AutoSize = true;
            this.Nota1.Location = new System.Drawing.Point(69, 179);
            this.Nota1.Name = "Nota1";
            this.Nota1.Size = new System.Drawing.Size(129, 16);
            this.Nota1.TabIndex = 6;
            this.Nota1.Text = "Nota do 1º semestre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(247, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nota do 2º semestre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 335);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Status do aluno:";
            // 
            // NaoEnviado
            // 
            this.NaoEnviado.AutoSize = true;
            this.NaoEnviado.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.NaoEnviado.Location = new System.Drawing.Point(215, 335);
            this.NaoEnviado.Name = "NaoEnviado";
            this.NaoEnviado.Size = new System.Drawing.Size(111, 16);
            this.NaoEnviado.TabIndex = 9;
            this.NaoEnviado.Text = "nota não enviada";
            // 
            // NotaEnviada
            // 
            this.NotaEnviada.AutoSize = true;
            this.NotaEnviada.Location = new System.Drawing.Point(215, 335);
            this.NotaEnviada.Name = "NotaEnviada";
            this.NotaEnviada.Size = new System.Drawing.Size(0, 16);
            this.NotaEnviada.TabIndex = 10;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 655);
            this.Controls.Add(this.NotaEnviada);
            this.Controls.Add(this.NaoEnviado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Nota1);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.Limpar);
            this.Controls.Add(this.envia);
            this.Controls.Add(this.nota2semestre);
            this.Controls.Add(this.nota1semestre);
            this.Controls.Add(this.nomeAluno);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nomeAluno;
        private System.Windows.Forms.TextBox nota1semestre;
        private System.Windows.Forms.TextBox nota2semestre;
        private System.Windows.Forms.Button envia;
        private System.Windows.Forms.Button Limpar;
        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.Label Nota1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label NaoEnviado;
        private System.Windows.Forms.Label NotaEnviada;
    }
}