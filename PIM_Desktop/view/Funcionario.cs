using PIM_Desktop.dao;
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
    public partial class Funcionario : Form
    {

        UsuarioDAO dao = new UsuarioDAO();

        public Funcionario(string login)
        {
            InitializeComponent();
            lblNomeFuncionario.Text = dao.getUsuarioByLogin(login).Nome;
        }

        private void btnDeslogar_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.ShowDialog();
            this.Close();
        }
    }
}
