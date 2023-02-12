﻿using ProjetoCanalAlunoti91.Classes;
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

            DataTable dt = new DataTable();
            dt = Aluno.listarAlunos();
            dgvAluno.DataSource = dt;
        }

        private void dgvAluno_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Aluno aluno = new Aluno();

            //verifica se o datagridView possui informações
            if (dgvAluno.Rows.Count > 0)
            {
                var id = Convert.ToInt32(dgvAluno.Rows[dgvAluno.CurrentCell.RowIndex].Cells["ID ALUNO"].Value);
                aluno.buscarAlunoPorId(id);
                tbNome.Text = aluno.Name;
                tbEmail.Text = aluno.Email;
                mkCpf.Text = aluno.Cpf;
                mkDateBirth.Text = aluno.DataNasc.ToString("dd/MM/yyyy");
            }
        }
    }
}
