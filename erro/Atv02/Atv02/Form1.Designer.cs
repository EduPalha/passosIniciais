using System;

namespace Atv02
{
    partial class Form1
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
            this.lable_login = new System.Windows.Forms.Label();
            this.label_senha = new System.Windows.Forms.Label();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.dataGridView_BDs = new System.Windows.Forms.DataGridView();
            this.btnListarTabelas = new System.Windows.Forms.Button();
            this.dataGridView_Usuarios = new System.Windows.Forms.DataGridView();
            this.txtSenhaUsuario = new System.Windows.Forms.TextBox();
            this.txtLoginUsuario = new System.Windows.Forms.TextBox();
            this.btnUsuario = new System.Windows.Forms.Button();
            this.label_senhaNovoUsuario = new System.Windows.Forms.Label();
            this.label_tituloNovoUsuario = new System.Windows.Forms.Label();
            this.panel_Login = new System.Windows.Forms.Panel();
            this.panel_novoUsuario = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label_titulo = new System.Windows.Forms.Label();
            this.label_loginNovoUsuario = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_BDs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Usuarios)).BeginInit();
            this.panel_Login.SuspendLayout();
            this.panel_novoUsuario.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lable_login
            // 
            this.lable_login.AutoSize = true;
            this.lable_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable_login.Location = new System.Drawing.Point(23, 24);
            this.lable_login.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lable_login.Name = "lable_login";
            this.lable_login.Size = new System.Drawing.Size(66, 25);
            this.lable_login.TabIndex = 0;
            this.lable_login.Text = "Login:";
            // 
            // label_senha
            // 
            this.label_senha.AutoSize = true;
            this.label_senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_senha.Location = new System.Drawing.Point(23, 118);
            this.label_senha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_senha.Name = "label_senha";
            this.label_senha.Size = new System.Drawing.Size(76, 25);
            this.label_senha.TabIndex = 1;
            this.label_senha.Text = "Senha:";
            // 
            // btnEnviar
            // 
            this.btnEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.Location = new System.Drawing.Point(76, 220);
            this.btnEnviar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(153, 46);
            this.btnEnviar.TabIndex = 2;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // txtLogin
            // 
            this.txtLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogin.Location = new System.Drawing.Point(28, 53);
            this.txtLogin.Margin = new System.Windows.Forms.Padding(4);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(257, 30);
            this.txtLogin.TabIndex = 3;
            this.txtLogin.TextChanged += new System.EventHandler(this.txtLogin_TextChanged);
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(28, 147);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(4);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(257, 30);
            this.txtSenha.TabIndex = 4;
            // 
            // dataGridView_BDs
            // 
            this.dataGridView_BDs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_BDs.Location = new System.Drawing.Point(420, 132);
            this.dataGridView_BDs.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView_BDs.Name = "dataGridView_BDs";
            this.dataGridView_BDs.RowHeadersWidth = 51;
            this.dataGridView_BDs.Size = new System.Drawing.Size(461, 181);
            this.dataGridView_BDs.TabIndex = 5;
            // 
            // btnListarTabelas
            // 
            this.btnListarTabelas.Location = new System.Drawing.Point(716, 321);
            this.btnListarTabelas.Margin = new System.Windows.Forms.Padding(4);
            this.btnListarTabelas.Name = "btnListarTabelas";
            this.btnListarTabelas.Size = new System.Drawing.Size(165, 28);
            this.btnListarTabelas.TabIndex = 6;
            this.btnListarTabelas.Text = "Listar tabelas";
            this.btnListarTabelas.UseVisualStyleBackColor = true;
            this.btnListarTabelas.Click += new System.EventHandler(this.btnListarTabelas_Click);
            // 
            // dataGridView_Usuarios
            // 
            this.dataGridView_Usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Usuarios.Location = new System.Drawing.Point(420, 377);
            this.dataGridView_Usuarios.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView_Usuarios.Name = "dataGridView_Usuarios";
            this.dataGridView_Usuarios.RowHeadersWidth = 51;
            this.dataGridView_Usuarios.Size = new System.Drawing.Size(461, 303);
            this.dataGridView_Usuarios.TabIndex = 7;
            // 
            // txtSenhaUsuario
            // 
            this.txtSenhaUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenhaUsuario.Location = new System.Drawing.Point(45, 199);
            this.txtSenhaUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtSenhaUsuario.Name = "txtSenhaUsuario";
            this.txtSenhaUsuario.ReadOnly = true;
            this.txtSenhaUsuario.Size = new System.Drawing.Size(257, 30);
            this.txtSenhaUsuario.TabIndex = 12;
            // 
            // txtLoginUsuario
            // 
            this.txtLoginUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoginUsuario.Location = new System.Drawing.Point(45, 105);
            this.txtLoginUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtLoginUsuario.Name = "txtLoginUsuario";
            this.txtLoginUsuario.ReadOnly = true;
            this.txtLoginUsuario.Size = new System.Drawing.Size(257, 30);
            this.txtLoginUsuario.TabIndex = 11;
            // 
            // btnUsuario
            // 
            this.btnUsuario.Enabled = false;
            this.btnUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuario.Location = new System.Drawing.Point(94, 270);
            this.btnUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(157, 46);
            this.btnUsuario.TabIndex = 10;
            this.btnUsuario.Text = "Gravar";
            this.btnUsuario.UseVisualStyleBackColor = true;
            this.btnUsuario.Click += new System.EventHandler(this.btnUsuario_Click);
            // 
            // label_senhaNovoUsuario
            // 
            this.label_senhaNovoUsuario.AutoSize = true;
            this.label_senhaNovoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_senhaNovoUsuario.Location = new System.Drawing.Point(41, 170);
            this.label_senhaNovoUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_senhaNovoUsuario.Name = "label_senhaNovoUsuario";
            this.label_senhaNovoUsuario.Size = new System.Drawing.Size(76, 25);
            this.label_senhaNovoUsuario.TabIndex = 9;
            this.label_senhaNovoUsuario.Text = "Senha:";
            // 
            // label_tituloNovoUsuario
            // 
            this.label_tituloNovoUsuario.AutoSize = true;
            this.label_tituloNovoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tituloNovoUsuario.Location = new System.Drawing.Point(107, 13);
            this.label_tituloNovoUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_tituloNovoUsuario.Name = "label_tituloNovoUsuario";
            this.label_tituloNovoUsuario.Size = new System.Drawing.Size(130, 25);
            this.label_tituloNovoUsuario.TabIndex = 14;
            this.label_tituloNovoUsuario.Text = "Novo Usuário";
            // 
            // panel_Login
            // 
            this.panel_Login.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Login.Controls.Add(this.txtLogin);
            this.panel_Login.Controls.Add(this.label_senha);
            this.panel_Login.Controls.Add(this.btnEnviar);
            this.panel_Login.Controls.Add(this.txtSenha);
            this.panel_Login.Controls.Add(this.lable_login);
            this.panel_Login.Location = new System.Drawing.Point(36, 132);
            this.panel_Login.Name = "panel_Login";
            this.panel_Login.Size = new System.Drawing.Size(319, 282);
            this.panel_Login.TabIndex = 15;
            // 
            // panel_novoUsuario
            // 
            this.panel_novoUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_novoUsuario.Controls.Add(this.label_loginNovoUsuario);
            this.panel_novoUsuario.Controls.Add(this.label_tituloNovoUsuario);
            this.panel_novoUsuario.Controls.Add(this.label_senhaNovoUsuario);
            this.panel_novoUsuario.Controls.Add(this.btnUsuario);
            this.panel_novoUsuario.Controls.Add(this.txtSenhaUsuario);
            this.panel_novoUsuario.Controls.Add(this.txtLoginUsuario);
            this.panel_novoUsuario.Location = new System.Drawing.Point(949, 132);
            this.panel_novoUsuario.Name = "panel_novoUsuario";
            this.panel_novoUsuario.Size = new System.Drawing.Size(341, 337);
            this.panel_novoUsuario.TabIndex = 16;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.checkedListBox1);
            this.panel3.Location = new System.Drawing.Point(950, 487);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(340, 193);
            this.panel3.TabIndex = 17;
            // 
            // label_titulo
            // 
            this.label_titulo.AutoSize = true;
            this.label_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_titulo.Location = new System.Drawing.Point(416, 37);
            this.label_titulo.Name = "label_titulo";
            this.label_titulo.Size = new System.Drawing.Size(465, 39);
            this.label_titulo.TabIndex = 18;
            this.label_titulo.Text = "Sistema Gerenciador de DB";
            // 
            // label_loginNovoUsuario
            // 
            this.label_loginNovoUsuario.AutoSize = true;
            this.label_loginNovoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_loginNovoUsuario.Location = new System.Drawing.Point(40, 76);
            this.label_loginNovoUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_loginNovoUsuario.Name = "label_loginNovoUsuario";
            this.label_loginNovoUsuario.Size = new System.Drawing.Size(66, 25);
            this.label_loginNovoUsuario.TabIndex = 5;
            this.label_loginNovoUsuario.Text = "Login:";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.Enabled = false;
            this.checkedListBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Grant",
            "Deny",
            "Revoke"});
            this.checkedListBox1.Location = new System.Drawing.Point(34, 25);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(268, 79);
            this.checkedListBox1.TabIndex = 0;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(93, 127);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 46);
            this.button1.TabIndex = 15;
            this.button1.Text = "Gravar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1323, 775);
            this.Controls.Add(this.label_titulo);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel_novoUsuario);
            this.Controls.Add(this.panel_Login);
            this.Controls.Add(this.dataGridView_Usuarios);
            this.Controls.Add(this.btnListarTabelas);
            this.Controls.Add(this.dataGridView_BDs);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_BDs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Usuarios)).EndInit();
            this.panel_Login.ResumeLayout(false);
            this.panel_Login.PerformLayout();
            this.panel_novoUsuario.ResumeLayout(false);
            this.panel_novoUsuario.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lable_login;
        private System.Windows.Forms.Label label_senha;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.DataGridView dataGridView_BDs;
        private System.Windows.Forms.Button btnListarTabelas;
        private System.Windows.Forms.DataGridView dataGridView_Usuarios;
        private System.Windows.Forms.TextBox txtSenhaUsuario;
        private System.Windows.Forms.TextBox txtLoginUsuario;
        private System.Windows.Forms.Button btnUsuario;
        private System.Windows.Forms.Label label_senhaNovoUsuario;
        private System.Windows.Forms.Label label_tituloNovoUsuario;
        private System.Windows.Forms.Panel panel_Login;
        private System.Windows.Forms.Panel panel_novoUsuario;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label_loginNovoUsuario;
        private System.Windows.Forms.Label label_titulo;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button button1;
    }
}

