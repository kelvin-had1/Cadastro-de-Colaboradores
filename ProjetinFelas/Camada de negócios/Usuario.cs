using ProjetinFelas.Camada_de_Conexão;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetinFelas.Camada_de_negócios
{
    class Usuario
    {
        public string nome;
        public string senha;

        public void gravarUsuario(string nome, string senha)
        {
            TB_Usuario user = new TB_Usuario();
            user.gravar(nome, senha);



        }
    }
}
