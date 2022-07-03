using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetinFelas.Camada_de_Conexão
{  
    class TB_Usuario
    {
        
        public void gravar(string nome, string senha)
        {
            string VstrSQL = "insert into TB_USUARIO (nome, senha) values ( '"+nome+"', '"+senha+"' )";
            
            SqlConnection cnn = new SqlConnection(Conexao.stringconexao);
            SqlCommand cmd = new SqlCommand(VstrSQL, cnn);
            
            
            cnn.Open();
                         
            try
            {
                int i = cmd.ExecuteNonQuery();
                if(i > 0)
                {
                    MessageBox.Show("Usuário cadastrado com sucesso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.ToString());
                
            }
            






        }
    }
}
