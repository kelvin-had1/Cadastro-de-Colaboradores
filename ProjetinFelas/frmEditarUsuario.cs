using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetinFelas.Camada_de_negócios;
namespace ProjetinFelas
{
    public partial class frmEditarUsuario : Form
    {
        public int idUsuario = 0;
        public string nome = "";
        public string senha = "";
        public frmListarUsuarios frm;
        public frmEditarUsuario()
        {
            InitializeComponent();
        }

        private void frmEditarUsuario_Load(object sender, EventArgs e)
        {
            txtSenha.Text = this.senha;
            txtNome.Text = this.nome;
            txtSenha.PasswordChar = '*';
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string senha = txtSenha.Text;
            
            Usuario.atualizarUsuario(nome, senha, this.idUsuario);
            this.frm.carregaGrid();
            this.Dispose();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            Usuario.apagarUsuario(this.idUsuario);
            this.frm.carregaGrid();
            this.Dispose();
        }
    }
}
