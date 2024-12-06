namespace PIM_Desktop.view
{
    partial class Administrador
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnListaUsuarios = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBuscaUsuario = new System.Windows.Forms.Button();
            this.btnCadastraUsuario = new System.Windows.Forms.Button();
            this.btnAtualizaUsuario = new System.Windows.Forms.Button();
            this.btnDesativaUsuario = new System.Windows.Forms.Button();
            this.btnDeslogar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1895, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnListaUsuarios
            // 
            this.btnListaUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnListaUsuarios.Location = new System.Drawing.Point(452, 418);
            this.btnListaUsuarios.Name = "btnListaUsuarios";
            this.btnListaUsuarios.Size = new System.Drawing.Size(181, 54);
            this.btnListaUsuarios.TabIndex = 1;
            this.btnListaUsuarios.Text = "Lista de Usuários";
            this.btnListaUsuarios.UseVisualStyleBackColor = true;
            this.btnListaUsuarios.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(935, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Bem vindo Administrador";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(813, 294);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(545, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "Sistema de gerenciamento da Fazenda Urbana";
            // 
            // btnBuscaUsuario
            // 
            this.btnBuscaUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscaUsuario.Location = new System.Drawing.Point(692, 418);
            this.btnBuscaUsuario.Name = "btnBuscaUsuario";
            this.btnBuscaUsuario.Size = new System.Drawing.Size(181, 54);
            this.btnBuscaUsuario.TabIndex = 8;
            this.btnBuscaUsuario.Text = "Buscar Usuário";
            this.btnBuscaUsuario.UseVisualStyleBackColor = true;
            this.btnBuscaUsuario.Click += new System.EventHandler(this.btnBuscaUsuario_Click);
            // 
            // btnCadastraUsuario
            // 
            this.btnCadastraUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastraUsuario.Location = new System.Drawing.Point(940, 418);
            this.btnCadastraUsuario.Name = "btnCadastraUsuario";
            this.btnCadastraUsuario.Size = new System.Drawing.Size(181, 54);
            this.btnCadastraUsuario.TabIndex = 9;
            this.btnCadastraUsuario.Text = "Cadastrar Usuário";
            this.btnCadastraUsuario.UseVisualStyleBackColor = true;
            this.btnCadastraUsuario.Click += new System.EventHandler(this.btnCadastraUsuario_Click);
            // 
            // btnAtualizaUsuario
            // 
            this.btnAtualizaUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtualizaUsuario.Location = new System.Drawing.Point(1189, 418);
            this.btnAtualizaUsuario.Name = "btnAtualizaUsuario";
            this.btnAtualizaUsuario.Size = new System.Drawing.Size(181, 54);
            this.btnAtualizaUsuario.TabIndex = 10;
            this.btnAtualizaUsuario.Text = "Atualizar Usuário";
            this.btnAtualizaUsuario.UseVisualStyleBackColor = true;
            this.btnAtualizaUsuario.Click += new System.EventHandler(this.btnAtualizaUsuario_Click);
            // 
            // btnDesativaUsuario
            // 
            this.btnDesativaUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDesativaUsuario.Location = new System.Drawing.Point(1444, 418);
            this.btnDesativaUsuario.Name = "btnDesativaUsuario";
            this.btnDesativaUsuario.Size = new System.Drawing.Size(181, 54);
            this.btnDesativaUsuario.TabIndex = 11;
            this.btnDesativaUsuario.Text = "Desativar Usuário";
            this.btnDesativaUsuario.UseVisualStyleBackColor = true;
            this.btnDesativaUsuario.Click += new System.EventHandler(this.btnDesativaUsuario_Click);
            // 
            // btnDeslogar
            // 
            this.btnDeslogar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeslogar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btnDeslogar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnDeslogar.Location = new System.Drawing.Point(988, 631);
            this.btnDeslogar.Name = "btnDeslogar";
            this.btnDeslogar.Size = new System.Drawing.Size(175, 71);
            this.btnDeslogar.TabIndex = 12;
            this.btnDeslogar.Text = "Deslogar";
            this.btnDeslogar.UseVisualStyleBackColor = true;
            this.btnDeslogar.Click += new System.EventHandler(this.btnDeslogar_Click);
            // 
            // Administrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(1895, 789);
            this.Controls.Add(this.btnDeslogar);
            this.Controls.Add(this.btnDesativaUsuario);
            this.Controls.Add(this.btnAtualizaUsuario);
            this.Controls.Add(this.btnCadastraUsuario);
            this.Controls.Add(this.btnBuscaUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnListaUsuarios);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Administrador";
            this.Text = "Administrador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button btnListaUsuarios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBuscaUsuario;
        private System.Windows.Forms.Button btnCadastraUsuario;
        private System.Windows.Forms.Button btnAtualizaUsuario;
        private System.Windows.Forms.Button btnDesativaUsuario;
        private System.Windows.Forms.Button btnDeslogar;
    }
}