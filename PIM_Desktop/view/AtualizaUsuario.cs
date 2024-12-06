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
    public partial class AtualizaUsuario : Form
    {

        
        public AtualizaUsuario()
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

                if (usuario == null)
                {
                    MessageBox.Show("CPF inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Endereco enderecoAtualizado = new Endereco
                    {
                        Logradouro = txtLogradouro.Text,
                        Numero = txtNumero.Text,
                        Complemento = txtComplemento.Text,
                        Bairro = txtBairro.Text,
                        Cidade = txtCidade.Text,
                        Cep = txtCep.Text,
                        Id_endereco = usuario.Endereco_id_fk,
                    };

                    Usuario usuarioAtualizado = new Usuario
                    {
                        Usuario_id = usuario.Usuario_id,
                        Login = usuario.Login,
                        Senha = txtSenha.Text,
                        Cpf = usuario.Cpf,
                        NivelAcesso = usuario.NivelAcesso,
                        Nome = txtNome.Text,
                        Sobrenome = txtSobrenome.Text,
                        Email = txtEmail.Text,
                        Telefone = txtTelefone.Text,
                        Salario = decimal.TryParse(txtSalario.Text, out decimal salario) ? (decimal?)salario : null,
                        Endereco_id_fk = usuario.Endereco_id_fk,
                        Status = usuario.Status,
                    };

                    dao.atualizaUsuarioEEndereco(usuarioAtualizado, enderecoAtualizado);


                    MessageBox.Show("Usuário atualizado com sucesso");
                    this.Close();
                }
            }
            
        }
    }
}
