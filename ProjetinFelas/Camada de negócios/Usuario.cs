using ProjetinFelas.Camada_de_Conexão;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetinFelas.Camada_de_negócios
{
    class Usuario
    {
        public static bool validaDados(string nome, string senha)
        {
            if (nome == "" || senha == "")
            {
                MessageBox.Show("Preencha todos os campos!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            return true;
        }
        public void gravarUsuario(string nome, string senha)
        {
            bool camposValidos = validaDados(nome, senha);
            if (camposValidos)
            {
                TB_Usuario user = new TB_Usuario();
                user.gravar(nome, senha);
                return;
            }else if(!camposValidos)
            {
                return;
            }

            MessageBox.Show("Aconteceu algum erro interno!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public static void apagarUsuario(int idUser)
        {
            TB_Usuario.apagarUsuario(idUser);
        }

        public static void atualizarUsuario(string nome, string senha, int idUser)
        {
            bool camposValidos = validaDados(nome, senha);
            if (camposValidos)
            {

                TB_Usuario.atualizaUsuario(nome, senha, idUser);
                return;
            }
            else if (!camposValidos)
            {
                return;
            }

            MessageBox.Show("Aconteceu algum erro interno!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public static DataTable carregaUsuarios()
        {
            DataTable dt = TB_Usuario.getUsuarios();

            return dt;
        }

        
    }
}
