using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCanalAlunoti91.Classes
{
    internal class Aluno
    {
        //Atributos/Campos
        private int _id;
        private string _name;
        private string _email;
        private string _cpf;
        private DateTime _dataNasc;
        private int _idCurso;

        //Propriedades
        public int Id { get { return _id; } set { _id = value; } }
        public string Name { get { return _name; } set { _name = value; } }
        public string Email { get { return _email; } set { _email = value; } }
        public string Cpf { get { return _cpf; } set { _cpf = value; } }
        public DateTime DataNasc { get { return _dataNasc; } set { _dataNasc = value; } }
        public int IdCurso { get { return _idCurso; } set { _idCurso = value; } }



    }
}
