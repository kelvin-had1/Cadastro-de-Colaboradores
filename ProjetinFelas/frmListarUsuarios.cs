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
    public partial class frmListarUsuarios : Form
    {
        public frmListarUsuarios()
        {
            InitializeComponent();
        }

        private void frmListarUsuarios_Load(object sender, EventArgs e)
        {
            DataTable dt = Usuario.carregaUsuarios();
            for(int i = 0; i < dt.Rows.Count; i++)
            {
                DataG.Rows.Add(dt.Rows[i]["ID"], dt.Rows[i]["NOME"], dt.Rows[i]["SENHA"]);
            }

        }
    }
}
