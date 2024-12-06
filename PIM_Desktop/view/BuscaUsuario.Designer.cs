namespace PIM_Desktop.view
{
    partial class BuscaUsuario
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscarUsuario = new System.Windows.Forms.Button();
            this.radioBtnLogin = new System.Windows.Forms.RadioButton();
            this.radioBtnCpf = new System.Windows.Forms.RadioButton();
            this.radioBtnId = new System.Windows.Forms.RadioButton();
            this.txtBuscaUsuario = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(743, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscador de Usuário";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnBuscarUsuario
            // 
            this.btnBuscarUsuario.Location = new System.Drawing.Point(1186, 466);
            this.btnBuscarUsuario.Name = "btnBuscarUsuario";
            this.btnBuscarUsuario.Size = new System.Drawing.Size(83, 30);
            this.btnBuscarUsuario.TabIndex = 7;
            this.btnBuscarUsuario.Text = "Buscar";
            this.btnBuscarUsuario.UseVisualStyleBackColor = true;
            this.btnBuscarUsuario.Click += new System.EventHandler(this.btnBuscarUsuario_Click);
            // 
            // radioBtnLogin
            // 
            this.radioBtnLogin.AutoSize = true;
            this.radioBtnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.radioBtnLogin.Location = new System.Drawing.Point(573, 146);
            this.radioBtnLogin.Name = "radioBtnLogin";
            this.radioBtnLogin.Size = new System.Drawing.Size(180, 29);
            this.radioBtnLogin.TabIndex = 9;
            this.radioBtnLogin.TabStop = true;
            this.radioBtnLogin.Text = "Buscar por Login";
            this.radioBtnLogin.UseVisualStyleBackColor = true;
            // 
            // radioBtnCpf
            // 
            this.radioBtnCpf.AutoSize = true;
            this.radioBtnCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.radioBtnCpf.Location = new System.Drawing.Point(841, 146);
            this.radioBtnCpf.Name = "radioBtnCpf";
            this.radioBtnCpf.Size = new System.Drawing.Size(172, 29);
            this.radioBtnCpf.TabIndex = 10;
            this.radioBtnCpf.TabStop = true;
            this.radioBtnCpf.Text = "Buscar por CPF";
            this.radioBtnCpf.UseVisualStyleBackColor = true;
            // 
            // radioBtnId
            // 
            this.radioBtnId.AutoSize = true;
            this.radioBtnId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.radioBtnId.Location = new System.Drawing.Point(1118, 146);
            this.radioBtnId.Name = "radioBtnId";
            this.radioBtnId.Size = new System.Drawing.Size(151, 29);
            this.radioBtnId.TabIndex = 11;
            this.radioBtnId.TabStop = true;
            this.radioBtnId.Text = "Buscar por ID";
            this.radioBtnId.UseVisualStyleBackColor = true;
            // 
            // txtBuscaUsuario
            // 
            this.txtBuscaUsuario.Location = new System.Drawing.Point(697, 350);
            this.txtBuscaUsuario.Name = "txtBuscaUsuario";
            this.txtBuscaUsuario.Size = new System.Drawing.Size(465, 22);
            this.txtBuscaUsuario.TabIndex = 12;
            // 
            // BuscaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1843, 859);
            this.Controls.Add(this.txtBuscaUsuario);
            this.Controls.Add(this.radioBtnId);
            this.Controls.Add(this.radioBtnCpf);
            this.Controls.Add(this.radioBtnLogin);
            this.Controls.Add(this.btnBuscarUsuario);
            this.Controls.Add(this.label1);
            this.Name = "BuscaUsuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscarUsuario;
        private System.Windows.Forms.RadioButton radioBtnLogin;
        private System.Windows.Forms.RadioButton radioBtnCpf;
        private System.Windows.Forms.RadioButton radioBtnId;
        private System.Windows.Forms.TextBox txtBuscaUsuario;
    }
}