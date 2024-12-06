using PIM_Desktop.dao;
using PIM_Desktop.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIM_Desktop.view
{
    public partial class BuscaUsuario : Form
    {
        public BuscaUsuario()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnBuscarUsuario_Click(object sender, EventArgs e)
        {
            UsuarioDAO dao = new UsuarioDAO();
            Usuario usuario = null;

            if (radioBtnCpf.Checked)
            {
                string cpf = txtBuscaUsuario.Text;
                usuario = dao.getUsuarioByCpf(cpf); 
            }
            else if (radioBtnLogin.Checked)
            {
                string login = txtBuscaUsuario.Text;
                usuario = dao.getUsuarioByLogin(login); 
            }
            else if (radioBtnId.Checked)
            {
                int id;
                if (int.TryParse(txtBuscaUsuario.Text, out id))
                {
                    usuario = dao.getUsuarioById(id);
                }
                else
                {
                    MessageBox.Show("ID inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if (usuario != null)
            {
                DadosUsuario formDetalhes = new DadosUsuario(usuario.Usuario_id);
                formDetalhes.ShowDialog();
            }
            else
            {
                MessageBox.Show("Usuário não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
