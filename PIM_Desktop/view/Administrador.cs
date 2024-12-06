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
    public partial class Administrador : Form
    {
        public Administrador()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            ListaUsuarios listaUsuarios = new ListaUsuarios();
            listaUsuarios.ShowDialog();

        }

        private void btnBuscaUsuario_Click(object sender, EventArgs e)
        {
            BuscaUsuario buscaUsuarioForm = new BuscaUsuario();
            buscaUsuarioForm.ShowDialog();
        }

        private void btnCadastraUsuario_Click(object sender, EventArgs e)
        {
            CadastraUsuario cadastraUsuarioForm = new CadastraUsuario();
            cadastraUsuarioForm.ShowDialog();
        }

        private void btnAtualizaUsuario_Click(object sender, EventArgs e)
        {
            AtualizaUsuario atualizaUsuarioForm = new AtualizaUsuario();
            atualizaUsuarioForm.ShowDialog();
        }

        private void btnDesativaUsuario_Click(object sender, EventArgs e)
        {
            DesativaUsuario desativa = new DesativaUsuario();
            desativa.ShowDialog();
        }

        private void btnDeslogar_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.ShowDialog();
            this.Close();
        }
    }
}
