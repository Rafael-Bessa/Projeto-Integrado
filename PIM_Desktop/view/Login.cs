using PIM_Desktop.model;
using PIM_Desktop.service;
using PIM_Desktop.view;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIM_Desktop
{
    public partial class Login : Form
    {
        private LoginService service = new LoginService();

        public Login()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

       
        private void btnlogin_Click(object sender, EventArgs e)
        {

            string login = txtLogin.Text;
            string senha = txtSenha.Text;

            if(service.ValidaAcessoUsuario(login, senha))
            {
                if(service.nivelAcessoUsuarioBuscado(login) == NivelAcesso.ADMINISTRADOR)
                {
                    Administrador formPrincipal = new Administrador();
                    formPrincipal.WindowState = FormWindowState.Maximized;
                    formPrincipal.Show();
                    this.Hide();
                }

                else if (service.nivelAcessoUsuarioBuscado(login) == NivelAcesso.FUNCIONARIO)
                {
                    Funcionario formPrincipal = new Funcionario(login);
                    formPrincipal.WindowState = FormWindowState.Maximized;
                    formPrincipal.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuário não é um Adminstrador / Funcionário", "Erro de Login",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Usuário não existe ou a senha está errada.", "Erro de Login",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }
    }
}
