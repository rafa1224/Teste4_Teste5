using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Teste4_Teste5
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            nomeAluno.Text = string.Empty;
            nota1semestre.Text = string.Empty;
            nota2semestre.Text = string.Empty;

            NaoEnviado.Text = "nota não enviada";
            NotaEnviada.Text = "";
        }

        

        private void envia_Click(object sender, EventArgs e)
        {
            String nome = nomeAluno.Text;
            float nota1 = float.Parse(nota1semestre.Text);
            float nota2 = float.Parse(nota2semestre.Text);

            //criar a database no sql server manager

            //LAPTOP - C06OBA9V\SQLSERVER2022
            //database Aluno

            //criar a tabela alunos dentro da DB Aluno


            using (SqlConnection conexao = new SqlConnection("Data Source=LAPTOP-C06OBA9V\\SQLSERVER2022;Initial Catalog=Aluno;Integrated Security=True;"))
            {
                conexao.Open();

                string sqlconsulta = "INSERT INTO Alunos (nome , [nota 1º semestre], [nota 2º semestre]) VALUES (@nome, @nota1, @nota2)";

                using (SqlCommand command = new SqlCommand(sqlconsulta, conexao))
                {
                    // Set the parameter values
                    command.Parameters.AddWithValue("@nome", nome);
                    command.Parameters.AddWithValue("@nota1", nota1);
                    command.Parameters.AddWithValue("@nota2", nota2);

                    // Execute the query
                    command.ExecuteNonQuery();

                    NaoEnviado.Text = "";
                    NotaEnviada.Text = "nota enviada";
                }
            }
        }
    }
}
