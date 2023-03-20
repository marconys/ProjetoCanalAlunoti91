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
    public partial class F_ListaAlunos : Form
    {
        public F_ListaAlunos()
        {
            InitializeComponent();

            showData();


        }

        private void dgvAluno_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Aluno aluno = new Aluno();

            //verifica se o datagridView possui informações
            if (dgvAluno.Rows.Count > 0)
            {
                aluno.buscarAlunoPorId(captureId());
                tbNome.Text = aluno.Name;
                tbEmail.Text = aluno.Email;
                mkCpf.Text = aluno.Cpf;
                mkDateBirth.Text = aluno.DataNasc.ToString("dd/MM/yyyy");
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            try
            {                
                Aluno aluno = new Aluno(
                tbNome.Text,
                tbEmail.Text,
                mkCpf.Text,
                DateTime.Parse(mkDateBirth.Text));

                aluno.atualizaAlunoPorId(captureId());
                MessageBox.Show("Aluno Atualizado com sucesso!");

                showData();

            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro ao atualizar aluno! \n" + erro.Message);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                Aluno aluno = new Aluno(captureId());
                aluno.excluirAluno();

                MessageBox.Show("Aluno excluido com sucesso!");

                showData();
            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro ao tentar excluir aluno, tente novamente! \n" + erro.Message);
            }
        }

        public DataTable showData()
        {
            DataTable dt = new DataTable();
            dt = Aluno.listarAlunos();
            dgvAluno.DataSource = dt;

            return dt;
        }

        public int captureId()
        {
            var id = Convert.ToInt32(dgvAluno.Rows[dgvAluno.CurrentCell.RowIndex].Cells["ID ALUNO"].Value);
            
            return id;
        }
    }
}
