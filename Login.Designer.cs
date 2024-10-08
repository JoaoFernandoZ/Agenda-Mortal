namespace Agenda_Mortal
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            UsuarioTextBox = new TextBox();
            Titulo = new Label();
            UsuarioLabel = new Label();
            SenhaLabel = new Label();
            SenhaMaskedTextBox = new MaskedTextBox();
            EntrarBotao = new Button();
            CadastrarMeBotao = new LinkLabel();
            SuspendLayout();
            // 
            // UsuarioTextBox
            // 
            UsuarioTextBox.Font = new Font("Segoe UI", 10F);
            UsuarioTextBox.Location = new Point(12, 78);
            UsuarioTextBox.Name = "UsuarioTextBox";
            UsuarioTextBox.Size = new Size(335, 25);
            UsuarioTextBox.TabIndex = 0;
            UsuarioTextBox.TextChanged += UsuarioTextBox_TextChanged;
            // 
            // Titulo
            // 
            Titulo.Font = new Font("Segoe UI", 18F);
            Titulo.ImageAlign = ContentAlignment.MiddleLeft;
            Titulo.Location = new Point(8, 9);
            Titulo.Name = "Titulo";
            Titulo.Size = new Size(335, 34);
            Titulo.TabIndex = 1;
            Titulo.Text = "Entrar";
            // 
            // UsuarioLabel
            // 
            UsuarioLabel.Font = new Font("Segoe UI", 10F);
            UsuarioLabel.ImageAlign = ContentAlignment.MiddleLeft;
            UsuarioLabel.Location = new Point(12, 55);
            UsuarioLabel.Margin = new Padding(0);
            UsuarioLabel.Name = "UsuarioLabel";
            UsuarioLabel.Size = new Size(335, 20);
            UsuarioLabel.TabIndex = 2;
            UsuarioLabel.Text = "Usuário:";
            // 
            // SenhaLabel
            // 
            SenhaLabel.Font = new Font("Segoe UI", 10F);
            SenhaLabel.ImageAlign = ContentAlignment.MiddleLeft;
            SenhaLabel.Location = new Point(12, 108);
            SenhaLabel.Margin = new Padding(0);
            SenhaLabel.Name = "SenhaLabel";
            SenhaLabel.Size = new Size(335, 20);
            SenhaLabel.TabIndex = 4;
            SenhaLabel.Text = "Senha:";
            // 
            // SenhaMaskedTextBox
            // 
            SenhaMaskedTextBox.Font = new Font("Segoe UI", 10F);
            SenhaMaskedTextBox.Location = new Point(12, 131);
            SenhaMaskedTextBox.Name = "SenhaMaskedTextBox";
            SenhaMaskedTextBox.Size = new Size(335, 25);
            SenhaMaskedTextBox.TabIndex = 5;
            SenhaMaskedTextBox.UseSystemPasswordChar = true;
            SenhaMaskedTextBox.TextChanged += SenhaMaskedTextBox_TextChanged;
            // 
            // EntrarBotao
            // 
            EntrarBotao.Enabled = false;
            EntrarBotao.Font = new Font("Segoe UI", 10F);
            EntrarBotao.Location = new Point(12, 171);
            EntrarBotao.Name = "EntrarBotao";
            EntrarBotao.Size = new Size(335, 28);
            EntrarBotao.TabIndex = 6;
            EntrarBotao.Text = "Entrar";
            EntrarBotao.UseVisualStyleBackColor = true;
            // 
            // CadastrarMeBotao
            // 
            CadastrarMeBotao.Location = new Point(12, 214);
            CadastrarMeBotao.Name = "CadastrarMeBotao";
            CadastrarMeBotao.Size = new Size(335, 23);
            CadastrarMeBotao.TabIndex = 7;
            CadastrarMeBotao.TabStop = true;
            CadastrarMeBotao.Text = "Cadastrar-me";
            CadastrarMeBotao.TextAlign = ContentAlignment.MiddleCenter;
            CadastrarMeBotao.Click += CadastrarMeBotao_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(359, 311);
            Controls.Add(CadastrarMeBotao);
            Controls.Add(EntrarBotao);
            Controls.Add(SenhaMaskedTextBox);
            Controls.Add(SenhaLabel);
            Controls.Add(UsuarioLabel);
            Controls.Add(Titulo);
            Controls.Add(UsuarioTextBox);
            MaximizeBox = false;
            MaximumSize = new Size(375, 350);
            MinimumSize = new Size(375, 350);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login - Agenda Mortal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox UsuarioTextBox;
        private Label Titulo;
        private Label UsuarioLabel;
        private Label SenhaLabel;
        private MaskedTextBox SenhaMaskedTextBox;
        private Button EntrarBotao;
        private LinkLabel CadastrarMeBotao;
    }
}
