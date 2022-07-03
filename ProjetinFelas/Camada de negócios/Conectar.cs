using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetinFelas.Camada_de_negócios
{
    class Conectar
    {
        public void connect()
        {
            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = Camada_de_Conexão.Conexao.stringconexao;
            try
            {
                cnn.Open();
                MessageBox.Show("Conexão aberta!");
                cnn.Close();
            }
            catch (SqlException err)
            {
                MessageBox.Show("Erro ao conectar no banco de dados \n" + "Verifique a mensagem de erro " + err);
                throw;
            }

        }
    }
}
