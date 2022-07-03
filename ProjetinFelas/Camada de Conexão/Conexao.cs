using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetinFelas.Camada_de_Conexão
{
    class Conexao
    {
        public static string stringconexao
        {
            get
            {
                return @"Server=localhost\SQLEXPRESS;Database=Teste;Trusted_Connection=True;";
            }
        }

        
    }

}
