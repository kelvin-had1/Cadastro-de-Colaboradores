using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetinFelas.Camada_de_negócios;

namespace ProjetinFelas
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }        

        private void Inicio_Load(object sender, EventArgs e)
        {
            txtSenha.PasswordChar = '*';
        }

        private void resetaCampos()
        {
            txtNome.Text = "";
            txtSenha.Text = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string senha = txtSenha.Text;
            
            Usuario usuario = new Usuario();

            usuario.gravarUsuario(nome, senha);
            resetaCampos();
            
            
        }

        private void btnTestar_Click(object sender, EventArgs e)
        {
            Camada_de_negócios.Conectar conectar = new Camada_de_negócios.Conectar();

            conectar.connect();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            frmListarUsuarios frmListaUsuarios = new frmListarUsuarios();
            
            frmListaUsuarios.ShowDialog();
            
            

        }
    }
}
