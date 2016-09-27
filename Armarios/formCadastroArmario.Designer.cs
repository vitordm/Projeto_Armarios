namespace Armarios
{
    partial class formCadastroArmario
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
            this.lbTitulo = new System.Windows.Forms.Label();
            this.lbNumeroArmario = new System.Windows.Forms.Label();
            this.tbNumeroArmario = new System.Windows.Forms.TextBox();
            this.lbLocalizacaoC = new System.Windows.Forms.Label();
            this.tbLColuna = new System.Windows.Forms.TextBox();
            this.lbLocalizacaoL = new System.Windows.Forms.Label();
            this.tbLLinha = new System.Windows.Forms.TextBox();
            this.lbLocalizaco = new System.Windows.Forms.Label();
            this.cbLocalizacao = new System.Windows.Forms.ComboBox();
            this.btSalvar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.lbSituacao = new System.Windows.Forms.Label();
            this.cbSituacao = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.Location = new System.Drawing.Point(12, 9);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(209, 25);
            this.lbTitulo.TabIndex = 0;
            this.lbTitulo.Text = "Cadastro de Armário";
            // 
            // lbNumeroArmario
            // 
            this.lbNumeroArmario.AutoSize = true;
            this.lbNumeroArmario.Location = new System.Drawing.Point(14, 53);
            this.lbNumeroArmario.Name = "lbNumeroArmario";
            this.lbNumeroArmario.Size = new System.Drawing.Size(97, 13);
            this.lbNumeroArmario.TabIndex = 1;
            this.lbNumeroArmario.Text = "Número do Armário";
            // 
            // tbNumeroArmario
            // 
            this.tbNumeroArmario.Location = new System.Drawing.Point(17, 69);
            this.tbNumeroArmario.MaxLength = 45;
            this.tbNumeroArmario.Name = "tbNumeroArmario";
            this.tbNumeroArmario.Size = new System.Drawing.Size(216, 20);
            this.tbNumeroArmario.TabIndex = 2;
            // 
            // lbLocalizacaoC
            // 
            this.lbLocalizacaoC.AutoSize = true;
            this.lbLocalizacaoC.Location = new System.Drawing.Point(14, 101);
            this.lbLocalizacaoC.Name = "lbLocalizacaoC";
            this.lbLocalizacaoC.Size = new System.Drawing.Size(117, 13);
            this.lbLocalizacaoC.TabIndex = 3;
            this.lbLocalizacaoC.Text = "Localização (COLUNA)";
            // 
            // tbLColuna
            // 
            this.tbLColuna.Location = new System.Drawing.Point(17, 117);
            this.tbLColuna.MaxLength = 12;
            this.tbLColuna.Name = "tbLColuna";
            this.tbLColuna.Size = new System.Drawing.Size(117, 20);
            this.tbLColuna.TabIndex = 4;
            // 
            // lbLocalizacaoL
            // 
            this.lbLocalizacaoL.AutoSize = true;
            this.lbLocalizacaoL.Location = new System.Drawing.Point(14, 141);
            this.lbLocalizacaoL.Name = "lbLocalizacaoL";
            this.lbLocalizacaoL.Size = new System.Drawing.Size(105, 13);
            this.lbLocalizacaoL.TabIndex = 5;
            this.lbLocalizacaoL.Text = "Localizacao (LINHA)";
            // 
            // tbLLinha
            // 
            this.tbLLinha.Location = new System.Drawing.Point(17, 157);
            this.tbLLinha.MaxLength = 12;
            this.tbLLinha.Name = "tbLLinha";
            this.tbLLinha.Size = new System.Drawing.Size(114, 20);
            this.tbLLinha.TabIndex = 6;
            // 
            // lbLocalizaco
            // 
            this.lbLocalizaco.AutoSize = true;
            this.lbLocalizaco.Location = new System.Drawing.Point(17, 184);
            this.lbLocalizaco.Name = "lbLocalizaco";
            this.lbLocalizaco.Size = new System.Drawing.Size(64, 13);
            this.lbLocalizaco.TabIndex = 7;
            this.lbLocalizaco.Text = "Localização";
            // 
            // cbLocalizacao
            // 
            this.cbLocalizacao.FormattingEnabled = true;
            this.cbLocalizacao.Location = new System.Drawing.Point(20, 201);
            this.cbLocalizacao.Name = "cbLocalizacao";
            this.cbLocalizacao.Size = new System.Drawing.Size(213, 21);
            this.cbLocalizacao.TabIndex = 8;
            this.cbLocalizacao.Text = "Localização";
            // 
            // btSalvar
            // 
            this.btSalvar.Location = new System.Drawing.Point(20, 283);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(75, 23);
            this.btSalvar.TabIndex = 9;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(219, 283);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 10;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.Location = new System.Drawing.Point(101, 283);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(75, 23);
            this.btExcluir.TabIndex = 11;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.UseVisualStyleBackColor = true;
            this.btExcluir.Visible = false;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // lbSituacao
            // 
            this.lbSituacao.AutoSize = true;
            this.lbSituacao.Location = new System.Drawing.Point(17, 234);
            this.lbSituacao.Name = "lbSituacao";
            this.lbSituacao.Size = new System.Drawing.Size(102, 13);
            this.lbSituacao.TabIndex = 12;
            this.lbSituacao.Text = "Situacao do Armário";
            // 
            // cbSituacao
            // 
            this.cbSituacao.FormattingEnabled = true;
            this.cbSituacao.Location = new System.Drawing.Point(20, 250);
            this.cbSituacao.Name = "cbSituacao";
            this.cbSituacao.Size = new System.Drawing.Size(213, 21);
            this.cbSituacao.TabIndex = 13;
            this.cbSituacao.Text = "Situação";
            // 
            // formCadastroArmario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 320);
            this.Controls.Add(this.cbSituacao);
            this.Controls.Add(this.lbSituacao);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.cbLocalizacao);
            this.Controls.Add(this.lbLocalizaco);
            this.Controls.Add(this.tbLLinha);
            this.Controls.Add(this.lbLocalizacaoL);
            this.Controls.Add(this.tbLColuna);
            this.Controls.Add(this.lbLocalizacaoC);
            this.Controls.Add(this.tbNumeroArmario);
            this.Controls.Add(this.lbNumeroArmario);
            this.Controls.Add(this.lbTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formCadastroArmario";
            this.ShowIcon = false;
            this.Text = "Cadastro de Armário";
            this.Load += new System.EventHandler(this.formCadastroArmario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Label lbNumeroArmario;
        private System.Windows.Forms.TextBox tbNumeroArmario;
        private System.Windows.Forms.Label lbLocalizacaoC;
        private System.Windows.Forms.TextBox tbLColuna;
        private System.Windows.Forms.Label lbLocalizacaoL;
        private System.Windows.Forms.TextBox tbLLinha;
        private System.Windows.Forms.Label lbLocalizaco;
        private System.Windows.Forms.ComboBox cbLocalizacao;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Label lbSituacao;
        private System.Windows.Forms.ComboBox cbSituacao;
    }
}