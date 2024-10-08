using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda_Mortal
{
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }

        private void atualizar_cadastro()
        {
            CadastrarBotao.Enabled = (NomeTextBox.Text != "" && UsuarioTextBox.Text != "" && SenhaMaskedTextBox.Text.Length >= 8 && ConfirmarSenhaMaskedTextBox.Text == SenhaMaskedTextBox.Text);
        }

        private void CadastrarBotao_Click(object sender, EventArgs e)
        {

        }

        private void Entrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NomeTextBox_TextChanged(object sender, EventArgs e)
        {
            atualizar_cadastro();
        }

        private void UsuarioTextBox_TextChanged(object sender, EventArgs e)
        {
            atualizar_cadastro();
        }

        private void TelefoneTextBox_TextChanged(object sender, EventArgs e)
        {
            atualizar_cadastro();
        }

        private void SenhaMaskedTextBox_TextChanged(object sender, EventArgs e)
        {
            atualizar_cadastro();
        }

        private void ConfirmarSenhaMaskedTextBox_TextChanged(object sender, EventArgs e)
        {
            atualizar_cadastro();
        }
    }
}
