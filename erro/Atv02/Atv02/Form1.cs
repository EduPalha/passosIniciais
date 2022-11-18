using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atv02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            Banco banco = new Banco();
            //MessageBox.Show("Login: " + txtLogin.Text + " e Senha: " + txtSenha.Text + ";");
            if(banco.User == txtLogin.Text && banco.Password == txtSenha.Text)
            {
                dataGridView_BDs.DataSource = banco.executaConsulta("select database_id, name, create_date from sys.databases where database_id > 4;");
                btnUsuario.Enabled = true;
                txtLoginUsuario.ReadOnly = false;
                txtSenhaUsuario.ReadOnly = false;
            }
            else
            {
                MessageBox.Show("Login e/ou senha incorreto", "ERRO!");
            }
        }

        private void btnListarTabelas_Click(object sender, EventArgs e)
        {
            Banco banco = new Banco();
            banco.Db = dataGridView_BDs.CurrentRow.Cells[1].Value.ToString();
            MessageBox.Show(banco.Db);
            dataGridView_Usuarios.DataSource = banco.executaConsulta("select table_catalog, table_schema, table_name, table_type from information_schema.tables;");
            //LEMBRAR DE DAR PERMISSÃO AO USUARIO NO SQLSERVER PARA CADA BANCO DE DADOS
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            Usuario u = new Usuario(txtLoginUsuario.Text, txtSenhaUsuario.Text, dataGridView_BDs.CurrentRow.Cells[1].Value.ToString());
            //bool aux = u.gravarUsuario();
            if (u.gravarUsuario())
            {
                MessageBox.Show("Sucesso!");
            }
            else
            {
                MessageBox.Show("Deu xabu");
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
