using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teste4_Teste5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Login_TextChanged(object sender, EventArgs e)
        {
            if(Login.Text == "") { }
        }

        private void senha_TextChanged(object sender, EventArgs e)
        {
            if (senha.Text == "") {  }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Login.Text == "") { ErroLogin.Text = "O Login é obrigatório"; }
            if (senha.Text == "") { ErroSenha.Text = "A Senha é obrigatória"; }
            if (senha.Text != "" && Login.Text != "") {
                Form2 form2 = new Form2();
                form2.Show();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
