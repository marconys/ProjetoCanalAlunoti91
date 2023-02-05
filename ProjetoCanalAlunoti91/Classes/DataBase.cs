using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCanalAlunoti91.Classes
{
    public static class DataBase
    {
        //Propriedadades
        private const string servidor = "localhost";
        private const string nomeDb = "alunoti91db";
        private const string usuario = "root";
        private const string senha = "";
        private const string porta = "3306";

        // string de conexãi
        public static string strConn = $"server={servidor};database={nomeDb};User ID={usuario};password={senha};port={porta}";
    }
}
