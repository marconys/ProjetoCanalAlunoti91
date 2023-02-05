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

            DataTable dt = new DataTable();
            dt = Aluno.listarAlunos();
            dgvAluno.DataSource = dt;
        }
    }
}
