using ProjetoCanalAlunoti91.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoCanalAlunoti91
{
    public partial class F_Alunos : Form
    {
        public F_Alunos()
        {
            InitializeComponent();

            Cb_Cursos.Text = "ESCOLHER";
        }

        private void btn_enviar_Click(object sender, EventArgs e)
        {
            int idCurso = 0;

            //Verifica  o curso selecionado e atribui o valor  a variável idCurso
            if (Cb_Cursos.Text == "C#")
            {
                idCurso = 1;
            }
            else if (Cb_Cursos.Text == "PHP")
            {
                idCurso = 2;
            }
            else if (Cb_Cursos.Text == "JAVASCRIPT")
            {
                idCurso = 3;
            }
            else
            {
                idCurso = 4;
            }

            //Converte o dataTimePicker para string e atribui o valor a variável data
            string data = Dtp_Nascimento.Value.ToString("dd-MM-yyyy");

            try
            {
                Aluno aluno = new Aluno(
                    tb_nome.Text,
                    tb_Email.Text,
                    Msk_Cpf.Text,
                    DateTime.Parse(data),
                    idCurso);

                aluno.InserirAluno();
                MessageBox.Show("Aluno matriculado com sucesso!");

                //Limpa os campos abaixo
                tb_nome.Clear();
                tb_Email.Clear();
                Msk_Cpf.Clear();
                Cb_Cursos.Text = "ESCOLHER";

                using (var flistarAluno = new F_ListaAlunos())
                {
                    flistarAluno.ShowDialog();
                }
            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro ao matricular aluno! \n" + erro.Message);
            }


        }
    }
}
