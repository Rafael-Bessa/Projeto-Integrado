namespace PIM_Desktop
{
    partial class Login
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnlogin = new System.Windows.Forms.Button();
            this.lbllogin = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblsenha = new System.Windows.Forms.Label();
            this.TextoLogin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnlogin.Location = new System.Drawing.Point(1349, 497);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(86, 44);
            this.btnlogin.TabIndex = 0;
            this.btnlogin.Text = "Entrar";
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // lbllogin
            // 
            this.lbllogin.AutoSize = true;
            this.lbllogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lbllogin.Location = new System.Drawing.Point(729, 332);
            this.lbllogin.Name = "lbllogin";
            this.lbllogin.Size = new System.Drawing.Size(75, 29);
            this.lbllogin.TabIndex = 1;
            this.lbllogin.Text = "Login";
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(847, 339);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(452, 22);
            this.txtLogin.TabIndex = 2;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(847, 400);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(452, 22);
            this.txtSenha.TabIndex = 4;
            // 
            // lblsenha
            // 
            this.lblsenha.AutoSize = true;
            this.lblsenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblsenha.Location = new System.Drawing.Point(718, 393);
            this.lblsenha.Name = "lblsenha";
            this.lblsenha.Size = new System.Drawing.Size(86, 29);
            this.lblsenha.TabIndex = 3;
            this.lblsenha.Text = "Senha";
            // 
            // TextoLogin
            // 
            this.TextoLogin.AutoSize = true;
            this.TextoLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F);
            this.TextoLogin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TextoLogin.Location = new System.Drawing.Point(760, 53);
            this.TextoLogin.Name = "TextoLogin";
            this.TextoLogin.Size = new System.Drawing.Size(649, 67);
            this.TextoLogin.TabIndex = 5;
            this.TextoLogin.Text = "Insira suas credenciais ";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1870, 914);
            this.Controls.Add(this.TextoLogin);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.lblsenha);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.lbllogin);
            this.Controls.Add(this.btnlogin);
            this.Name = "Login";
            this.Text = "Tela Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.Label lbllogin;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lblsenha;
        private System.Windows.Forms.Label TextoLogin;
    }
}

