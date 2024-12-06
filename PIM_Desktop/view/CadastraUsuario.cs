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
    public partial class CadastraUsuario : Form
    {

        private EnderecoDAO enderecoDao = new EnderecoDAO();
        private UsuarioDAO usuarioDAO = new UsuarioDAO();

        public CadastraUsuario()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            cmbNivelAcesso.Items.AddRange(Enum.GetNames(typeof(NivelAcesso)));
        }

        private void btnCadastrarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                Endereco endereco = new Endereco
                {
                    Logradouro = txtLogradouro.Text,
                    Numero = txtNumero.Text,
                    Complemento = txtComplemento.Text,
                    Bairro = txtBairro.Text,
                    Cidade = txtCidade.Text,
                    Cep = txtCep.Text
                };

                int enderecoId = enderecoDao.cadastraNovoEndereco(endereco);

                if (enderecoId > 0)
                {
                   
                    Usuario usuario = new Usuario
                    {
                        Login = txtLogin.Text,
                        Senha = txtSenha.Text,
                        Nome = txtNome.Text,
                        Sobrenome = txtSobrenome.Text,
                        Email = txtEmail.Text,
                        Cpf = txtCpf.Text,
                        Telefone = txtTelefone.Text,
                        Salario = decimal.TryParse(txtSalario.Text, out decimal salario) ? (decimal?)salario : null,
                        Status = Status.ATIVO,
                        Endereco_id_fk = enderecoId
                    };

                    string selectedValue = cmbNivelAcesso.SelectedItem.ToString().Trim();
                    if (Enum.TryParse<NivelAcesso>(selectedValue, true, out NivelAcesso nivelAcesso))
                    {
                        usuario.NivelAcesso = nivelAcesso; 
                    }
                    else
                    {
                        MessageBox.Show("Nível de acesso inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    usuarioDAO.cadastraNovoUsuarioDoSistema(usuario, enderecoId);

                    if (usuarioDAO.getUsuarioByLogin(usuario.Login).Usuario_id > 0)
                    {
                        MessageBox.Show("Usuário cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Erro ao cadastrar o usuário.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar o endereço.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
