﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        //Métodos construtores da classe
        public Aluno()
        {

        }

        public Aluno(string name, string email, string cpf, DateTime dataNasc, int idCurso)
        {
            Name = name;
            Email = email;
            Cpf = cpf;
            DataNasc = dataNasc;
            IdCurso = idCurso;
        }

        public Aluno(int id, string name, string email, string cpf, DateTime dataNasc, int idCurso)
        {
            Id = id;
            Name = name;
            Email = email;
            Cpf = cpf;
            DataNasc = dataNasc;
            IdCurso = idCurso;
        }

        //Métodos da classe / Funções

        //Função Create
        public void InserirAluno()
        {
            var sql = "INSERT INTO tbalunos(nome_aluno, email_aluno, cpf_aluno, data_nasc_aluno, id_curso_aluno)" +
                "VALUES(@nome, @email, @cpf, @dataNascimento, @idCurso)";

            try
            {
                using (var cn = new MySqlConnection(DataBase.strConn))
                {
                    cn.Open();

                    using (var cmd = new MySqlCommand(sql, cn))
                    {
                        //Adiciona os parâmetros de values da query no MysQl
                        cmd.Parameters.AddWithValue("@nome", this.Name);
                        cmd.Parameters.AddWithValue("@email", this.Email);
                        cmd.Parameters.AddWithValue("@cpf", this.Cpf);
                        cmd.Parameters.AddWithValue("@dataNascimento", this.DataNasc);
                        cmd.Parameters.AddWithValue("@idCurso", this.IdCurso);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message);
            }
        }        
    }
}