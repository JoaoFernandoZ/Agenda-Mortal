namespace Agenda_Mortal
{
    partial class SignIn
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
            CadastrarBotao = new Button();
            SenhaMaskedTextBox = new MaskedTextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            NomeTextBox = new TextBox();
            label4 = new Label();
            UsuarioTextBox = new TextBox();
            label5 = new Label();
            TelefoneTextBox = new TextBox();
            ConfirmarSenhaMaskedTextBox = new MaskedTextBox();
            label6 = new Label();
            Entrar = new LinkLabel();
            SuspendLayout();
            // 
            // CadastrarBotao
            // 
            CadastrarBotao.Enabled = false;
            CadastrarBotao.Font = new Font("Segoe UI", 10F);
            CadastrarBotao.Location = new Point(12, 327);
            CadastrarBotao.Name = "CadastrarBotao";
            CadastrarBotao.Size = new Size(335, 28);
            CadastrarBotao.TabIndex = 12;
            CadastrarBotao.Text = "Cadastrar-me";
            CadastrarBotao.UseVisualStyleBackColor = true;
            CadastrarBotao.Click += CadastrarBotao_Click;
            // 
            // SenhaMaskedTextBox
            // 
            SenhaMaskedTextBox.Font = new Font("Segoe UI", 10F);
            SenhaMaskedTextBox.Location = new Point(12, 232);
            SenhaMaskedTextBox.Name = "SenhaMaskedTextBox";
            SenhaMaskedTextBox.Size = new Size(335, 25);
            SenhaMaskedTextBox.TabIndex = 11;
            SenhaMaskedTextBox.UseSystemPasswordChar = true;
            SenhaMaskedTextBox.TextChanged += SenhaMaskedTextBox_TextChanged;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 10F);
            label3.ImageAlign = ContentAlignment.MiddleLeft;
            label3.Location = new Point(12, 209);
            label3.Margin = new Padding(0);
            label3.Name = "label3";
            label3.Size = new Size(335, 20);
            label3.TabIndex = 10;
            label3.Text = "Senha:";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 10F);
            label2.ImageAlign = ContentAlignment.MiddleLeft;
            label2.Location = new Point(12, 56);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(335, 20);
            label2.TabIndex = 9;
            label2.Text = "Nome:";
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 18F);
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(8, 10);
            label1.Name = "label1";
            label1.Size = new Size(335, 34);
            label1.TabIndex = 8;
            label1.Text = "Cadastro";
            // 
            // NomeTextBox
            // 
            NomeTextBox.Font = new Font("Segoe UI", 10F);
            NomeTextBox.Location = new Point(12, 79);
            NomeTextBox.Name = "NomeTextBox";
            NomeTextBox.Size = new Size(335, 25);
            NomeTextBox.TabIndex = 7;
            NomeTextBox.TextChanged += NomeTextBox_TextChanged;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 10F);
            label4.ImageAlign = ContentAlignment.MiddleLeft;
            label4.Location = new Point(12, 107);
            label4.Margin = new Padding(0);
            label4.Name = "label4";
            label4.Size = new Size(335, 20);
            label4.TabIndex = 14;
            label4.Text = "Usuário:";
            // 
            // UsuarioTextBox
            // 
            UsuarioTextBox.Font = new Font("Segoe UI", 10F);
            UsuarioTextBox.Location = new Point(12, 130);
            UsuarioTextBox.Name = "UsuarioTextBox";
            UsuarioTextBox.Size = new Size(335, 25);
            UsuarioTextBox.TabIndex = 13;
            UsuarioTextBox.TextChanged += UsuarioTextBox_TextChanged;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 10F);
            label5.ImageAlign = ContentAlignment.MiddleLeft;
            label5.Location = new Point(12, 158);
            label5.Margin = new Padding(0);
            label5.Name = "label5";
            label5.Size = new Size(335, 20);
            label5.TabIndex = 16;
            label5.Text = "Telefone:";
            // 
            // TelefoneTextBox
            // 
            TelefoneTextBox.Font = new Font("Segoe UI", 10F);
            TelefoneTextBox.Location = new Point(12, 181);
            TelefoneTextBox.Name = "TelefoneTextBox";
            TelefoneTextBox.Size = new Size(335, 25);
            TelefoneTextBox.TabIndex = 15;
            TelefoneTextBox.TextChanged += TelefoneTextBox_TextChanged;
            // 
            // ConfirmarSenhaMaskedTextBox
            // 
            ConfirmarSenhaMaskedTextBox.Font = new Font("Segoe UI", 10F);
            ConfirmarSenhaMaskedTextBox.Location = new Point(12, 284);
            ConfirmarSenhaMaskedTextBox.Name = "ConfirmarSenhaMaskedTextBox";
            ConfirmarSenhaMaskedTextBox.Size = new Size(335, 25);
            ConfirmarSenhaMaskedTextBox.TabIndex = 18;
            ConfirmarSenhaMaskedTextBox.UseSystemPasswordChar = true;
            ConfirmarSenhaMaskedTextBox.TextChanged += ConfirmarSenhaMaskedTextBox_TextChanged;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 10F);
            label6.ImageAlign = ContentAlignment.MiddleLeft;
            label6.Location = new Point(12, 261);
            label6.Margin = new Padding(0);
            label6.Name = "label6";
            label6.Size = new Size(335, 20);
            label6.TabIndex = 17;
            label6.Text = "Confirmar senha:";
            // 
            // Entrar
            // 
            Entrar.Location = new Point(12, 370);
            Entrar.Name = "Entrar";
            Entrar.Size = new Size(335, 23);
            Entrar.TabIndex = 19;
            Entrar.TabStop = true;
            Entrar.Text = "Já possuo conta, entrar";
            Entrar.TextAlign = ContentAlignment.MiddleCenter;
            Entrar.Click += Entrar_Click;
            // 
            // SignIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(359, 461);
            Controls.Add(Entrar);
            Controls.Add(ConfirmarSenhaMaskedTextBox);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(TelefoneTextBox);
            Controls.Add(label4);
            Controls.Add(UsuarioTextBox);
            Controls.Add(CadastrarBotao);
            Controls.Add(SenhaMaskedTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(NomeTextBox);
            MaximizeBox = false;
            MaximumSize = new Size(375, 500);
            MinimumSize = new Size(375, 500);
            Name = "SignIn";
            StartPosition = FormStartPosition.CenterParent;
            Text = "SignIn - Agenda Mortal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CadastrarBotao;
        private MaskedTextBox SenhaMaskedTextBox;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox NomeTextBox;
        private Label label4;
        private TextBox UsuarioTextBox;
        private Label label5;
        private TextBox TelefoneTextBox;
        private MaskedTextBox ConfirmarSenhaMaskedTextBox;
        private Label label6;
        private LinkLabel Entrar;
    }
}