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

        public static void apagarUsuario(int idUser)
        {
            string VstrSQL = "delete TB_USUARIO where ID = " + idUser;
            SqlConnection conn = new SqlConnection(Conexao.stringconexao);
            SqlCommand cmd = new SqlCommand(VstrSQL, conn);

            conn.Open();
            try
            {
                int i = cmd.ExecuteNonQuery();
                if(i > 0)
                {
                    MessageBox.Show("Usuário apagado com sucesso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception err)
            {
                MessageBox.Show("Não foi possível apagar o usuário: " + err.ToString(), "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        public static void atualizaUsuario(string nome, string senha, int idUser)
        {
            string VstrSQL = "update TB_USUARIO set NOME = '" + nome + "', SENHA = '" + senha + "' where ID = " + idUser + "";
            SqlConnection conn = new SqlConnection(Conexao.stringconexao);
            SqlCommand cmd = new SqlCommand(VstrSQL, conn);
            MessageBox.Show(VstrSQL);
            conn.Open();
            try
            {
                int i = cmd.ExecuteNonQuery();
                if(i > 0)
                {
                    MessageBox.Show("Usuário atualizado com sucesso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }
            catch (Exception err)
            {
                MessageBox.Show("Erro: " + err.ToString());
            }

        }

        public static DataTable getUsuarios()
        {
            DataTable dt = new DataTable();

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = Conexao.stringconexao;

            string VstrSQL = "select * from TB_USUARIO";
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(VstrSQL, conn);
                da.Fill(dt);

            }
            catch (Exception err)
            {

                MessageBox.Show("Erro de Conexão " + err.ToString());
            }

            finally
            {
                if (conn.State != ConnectionState.Closed) 
                {
                    conn.Close();
                }
            }




            return dt;
        }
    }
}
