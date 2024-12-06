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
    public partial class DadosUsuario : Form
    {
        private int usuarioId;
        private UsuarioDAO dao = new UsuarioDAO();
        private EnderecoDAO enderecodao = new EnderecoDAO();

        public DadosUsuario(int usuarioId)
        {
            InitializeComponent();
            this.usuarioId = usuarioId;
            this.WindowState = FormWindowState.Maximized;
            CarregarDadosUsuario();
        }

        private void CarregarDadosUsuario()
        {
            // Aqui você obtém todos os dados do usuário do banco de dados usando o usuarioId
            
            Usuario usuario = dao.getUsuarioById(usuarioId);// Chamada ao banco de dados para obter os detalhes do usuário
            Endereco endereco = enderecodao.getEnderecoById(usuario.Endereco_id_fk);
            // Exiba os dados do usuário nos controles apropriados
            
            
            lblLogin.Text = usuario.Login;
            lblNome.Text = usuario.Nome;
            lblSobrenome.Text = usuario.Sobrenome;
            lblEmail.Text = usuario.Email;
            lblCpf.Text = usuario.Cpf;
            lblTelefone.Text = usuario.Telefone;
            lblStatus.Text = usuario.Status.ToString();
            lblNivelAcesso.Text = usuario.NivelAcesso.ToString();
            
            lblLogradouro.Text = endereco.Logradouro;
            lblNumero.Text = endereco.Numero;
            lblBairro.Text = endereco.Bairro;
            lblCep.Text = endereco.Cep;
            lblComplemento.Text = endereco.Complemento;
            lblCidade.Text = endereco.Cidade;



        }

        private void DadosUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}
