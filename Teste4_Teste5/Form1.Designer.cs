namespace Teste4_Teste5
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.entrar = new System.Windows.Forms.Button();
            this.Login = new System.Windows.Forms.TextBox();
            this.senha = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ErroLogin = new System.Windows.Forms.Label();
            this.ErroSenha = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // entrar
            // 
            this.entrar.Location = new System.Drawing.Point(388, 205);
            this.entrar.Name = "entrar";
            this.entrar.Size = new System.Drawing.Size(75, 23);
            this.entrar.TabIndex = 0;
            this.entrar.Text = "Entrar";
            this.entrar.UseVisualStyleBackColor = true;
            this.entrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(108, 206);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(128, 22);
            this.Login.TabIndex = 1;
            this.Login.TextChanged += new System.EventHandler(this.Login_TextChanged);
            // 
            // senha
            // 
            this.senha.Location = new System.Drawing.Point(242, 206);
            this.senha.Name = "senha";
            this.senha.PasswordChar = '*';
            this.senha.Size = new System.Drawing.Size(138, 22);
            this.senha.TabIndex = 2;
            this.senha.TextChanged += new System.EventHandler(this.senha_TextChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ErroLogin
            // 
            this.ErroLogin.AutoSize = true;
            this.ErroLogin.ForeColor = System.Drawing.Color.Red;
            this.ErroLogin.Location = new System.Drawing.Point(105, 247);
            this.ErroLogin.Name = "ErroLogin";
            this.ErroLogin.Size = new System.Drawing.Size(0, 16);
            this.ErroLogin.TabIndex = 3;
            this.ErroLogin.Click += new System.EventHandler(this.label1_Click);
            // 
            // ErroSenha
            // 
            this.ErroSenha.AutoSize = true;
            this.ErroSenha.ForeColor = System.Drawing.Color.Red;
            this.ErroSenha.Location = new System.Drawing.Point(243, 247);
            this.ErroSenha.Name = "ErroSenha";
            this.ErroSenha.Size = new System.Drawing.Size(0, 16);
            this.ErroSenha.TabIndex = 4;
            this.ErroSenha.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ErroSenha);
            this.Controls.Add(this.ErroLogin);
            this.Controls.Add(this.senha);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.entrar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button entrar;
        private System.Windows.Forms.TextBox Login;
        private System.Windows.Forms.TextBox senha;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label ErroLogin;
        private System.Windows.Forms.Label ErroSenha;
    }
}

