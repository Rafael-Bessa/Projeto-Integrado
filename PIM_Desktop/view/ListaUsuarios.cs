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
    public partial class ListaUsuarios : Form
    {
        private UsuarioDAO dao = new UsuarioDAO();
        public ListaUsuarios()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ListaUsuarios_Load);
            this.dataGridViewUsuarios.CellContentClick += new DataGridViewCellEventHandler(this.dataGridViewUsuarios_CellContentClick);
        }

        private void ListaUsuarios_Load(object sender, EventArgs e)
        {
            CarregarUsuarios();
        }

        private void CarregarUsuarios()
        {
            List<Usuario> usuarios = dao.getTodosUsuarios(1, 10);
            var usuariosExibidos = usuarios.Select(u => new
            {
                u.Usuario_id,
                u.Login,
                u.Nome,
                u.Sobrenome,
                u.Email,
                u.Cpf,
                u.Telefone,
                u.Status,
                u.NivelAcesso
            }).ToList();

            dataGridViewUsuarios.DataSource = usuariosExibidos;

            // Adiciona a coluna de botão "Mais Detalhes" se não existir
            if (dataGridViewUsuarios.Columns["btnDetalhes"] == null)
            {
                DataGridViewButtonColumn btnDetalhes = new DataGridViewButtonColumn();
                btnDetalhes.HeaderText = "Mais Detalhes";
                btnDetalhes.Text = "Clique aqui";
                btnDetalhes.UseColumnTextForButtonValue = true;
                btnDetalhes.Name = "btnDetalhes";
                btnDetalhes.DefaultCellStyle.BackColor = System.Drawing.Color.DarkGreen;  // Define a cor de fundo do botão
                btnDetalhes.DefaultCellStyle.ForeColor = System.Drawing.Color.Red;  // Define a cor do texto do botão
                btnDetalhes.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;  // Centraliza o texto no botão
                btnDetalhes.Width = 100;  // Define uma largura fixa para a coluna
                dataGridViewUsuarios.Columns.Add(btnDetalhes);
            }
        }


        private void dataGridViewUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewUsuarios.Columns["btnDetalhes"].Index && e.RowIndex >= 0)
            {
                int usuarioId = Convert.ToInt32(dataGridViewUsuarios.Rows[e.RowIndex].Cells["Usuario_id"].Value);

                // Abra o formulário de detalhes passando o ID do usuário
                DadosUsuario formDetalhes = new DadosUsuario(usuarioId);
                formDetalhes.ShowDialog();
            }
        }

    }
}
