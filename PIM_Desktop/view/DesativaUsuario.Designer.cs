namespace PIM_Desktop.view
{
    partial class DesativaUsuario
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
            this.txtBuscaUsuario = new System.Windows.Forms.TextBox();
            this.radioBtnId = new System.Windows.Forms.RadioButton();
            this.radioBtnCpf = new System.Windows.Forms.RadioButton();
            this.radioBtnLogin = new System.Windows.Forms.RadioButton();
            this.btnDesativarUsuario = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBuscaUsuario
            // 
            this.txtBuscaUsuario.Location = new System.Drawing.Point(873, 355);
            this.txtBuscaUsuario.Name = "txtBuscaUsuario";
            this.txtBuscaUsuario.Size = new System.Drawing.Size(465, 22);
            this.txtBuscaUsuario.TabIndex = 18;
            // 
            // radioBtnId
            // 
            this.radioBtnId.AutoSize = true;
            this.radioBtnId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.radioBtnId.Location = new System.Drawing.Point(1241, 189);
            this.radioBtnId.Name = "radioBtnId";
            this.radioBtnId.Size = new System.Drawing.Size(172, 29);
            this.radioBtnId.TabIndex = 17;
            this.radioBtnId.TabStop = true;
            this.radioBtnId.Text = "Desativar por ID";
            this.radioBtnId.UseVisualStyleBackColor = true;
            // 
            // radioBtnCpf
            // 
            this.radioBtnCpf.AutoSize = true;
            this.radioBtnCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.radioBtnCpf.Location = new System.Drawing.Point(964, 189);
            this.radioBtnCpf.Name = "radioBtnCpf";
            this.radioBtnCpf.Size = new System.Drawing.Size(193, 29);
            this.radioBtnCpf.TabIndex = 16;
            this.radioBtnCpf.TabStop = true;
            this.radioBtnCpf.Text = "Desativar por CPF";
            this.radioBtnCpf.UseVisualStyleBackColor = true;
            // 
            // radioBtnLogin
            // 
            this.radioBtnLogin.AutoSize = true;
            this.radioBtnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.radioBtnLogin.Location = new System.Drawing.Point(696, 189);
            this.radioBtnLogin.Name = "radioBtnLogin";
            this.radioBtnLogin.Size = new System.Drawing.Size(201, 29);
            this.radioBtnLogin.TabIndex = 15;
            this.radioBtnLogin.TabStop = true;
            this.radioBtnLogin.Text = "Desativar por Login";
            this.radioBtnLogin.UseVisualStyleBackColor = true;
            // 
            // btnDesativarUsuario
            // 
            this.btnDesativarUsuario.Location = new System.Drawing.Point(1339, 485);
            this.btnDesativarUsuario.Name = "btnDesativarUsuario";
            this.btnDesativarUsuario.Size = new System.Drawing.Size(100, 44);
            this.btnDesativarUsuario.TabIndex = 14;
            this.btnDesativarUsuario.Text = "Desativar";
            this.btnDesativarUsuario.UseVisualStyleBackColor = true;
            this.btnDesativarUsuario.Click += new System.EventHandler(this.btnBuscarUsuario_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(866, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(373, 39);
            this.label1.TabIndex = 13;
            this.label1.Text = "Desativador de Usuário";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // DesativaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1621, 705);
            this.Controls.Add(this.txtBuscaUsuario);
            this.Controls.Add(this.radioBtnId);
            this.Controls.Add(this.radioBtnCpf);
            this.Controls.Add(this.radioBtnLogin);
            this.Controls.Add(this.btnDesativarUsuario);
            this.Controls.Add(this.label1);
            this.Name = "DesativaUsuario";
            this.Text = "DesativaUsuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBuscaUsuario;
        private System.Windows.Forms.RadioButton radioBtnId;
        private System.Windows.Forms.RadioButton radioBtnCpf;
        private System.Windows.Forms.RadioButton radioBtnLogin;
        private System.Windows.Forms.Button btnDesativarUsuario;
        private System.Windows.Forms.Label label1;
    }
}