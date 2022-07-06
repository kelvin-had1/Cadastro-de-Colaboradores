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

        public void carregaGrid()
        {
            DataTable dt = Usuario.carregaUsuarios();
            DataG.Rows.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataG.Rows.Add(dt.Rows[i]["ID"], dt.Rows[i]["NOME"], dt.Rows[i]["SENHA"]);
            }

        }
        private void frmListarUsuarios_Load(object sender, EventArgs e)
        {
            carregaGrid();
        }

        private void DataG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(DataG.Rows.Count > 1)
            {
                int idUser = Convert.ToInt32(DataG.CurrentRow.Cells[0].Value);
                string nome = DataG.CurrentRow.Cells[1].Value.ToString();
                string senha = DataG.CurrentRow.Cells[2].Value.ToString();
                frmEditarUsuario frm = new frmEditarUsuario();
                frm.idUsuario = idUser;
                frm.nome = nome;
                frm.senha = senha;
                frm.frm = this;
                frm.ShowDialog();
            }
        }
    }
}
