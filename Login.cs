namespace Agenda_Mortal
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void atualizar_entrar()
        {
            EntrarBotao.Enabled = (UsuarioTextBox.Text != "" && SenhaMaskedTextBox.Text.Length >= 8);
        }

        private void CadastrarMeBotao_Click(object sender, EventArgs e)
        {
            SignIn CadastrarMe = new SignIn();
            CadastrarMe.ShowDialog();
        }

        private void UsuarioTextBox_TextChanged(object sender, EventArgs e)
        {
            atualizar_entrar();
        }

        private void SenhaMaskedTextBox_TextChanged(object sender, EventArgs e)
        {
            atualizar_entrar();
        }
    }
}
