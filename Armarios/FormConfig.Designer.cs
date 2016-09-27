namespace Armarios
{
    partial class FormConfig
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConfig));
            this.btCaminho = new System.Windows.Forms.Button();
            this.tbCaminho = new System.Windows.Forms.TextBox();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.lbCaminho = new System.Windows.Forms.Label();
            this.lbSenha = new System.Windows.Forms.Label();
            this.tbSenha = new System.Windows.Forms.TextBox();
            this.btMostrar = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btSalvar = new System.Windows.Forms.Button();
            this.panelLogoAccess = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelLogoAccess.SuspendLayout();
            this.SuspendLayout();
            // 
            // btCaminho
            // 
            this.btCaminho.Location = new System.Drawing.Point(296, 64);
            this.btCaminho.Name = "btCaminho";
            this.btCaminho.Size = new System.Drawing.Size(34, 23);
            this.btCaminho.TabIndex = 3;
            this.btCaminho.Text = "...";
            this.toolTip1.SetToolTip(this.btCaminho, "Buscar arquivo");
            this.btCaminho.UseVisualStyleBackColor = true;
            this.btCaminho.Click += new System.EventHandler(this.btCaminho_Click);
            // 
            // tbCaminho
            // 
            this.tbCaminho.Location = new System.Drawing.Point(12, 67);
            this.tbCaminho.Name = "tbCaminho";
            this.tbCaminho.Size = new System.Drawing.Size(278, 20);
            this.tbCaminho.TabIndex = 2;
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.Location = new System.Drawing.Point(63, 9);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(227, 24);
            this.lbTitulo.TabIndex = 0;
            this.lbTitulo.Text = "Configurações de Acesso";
            // 
            // lbCaminho
            // 
            this.lbCaminho.AutoSize = true;
            this.lbCaminho.Location = new System.Drawing.Point(9, 51);
            this.lbCaminho.Name = "lbCaminho";
            this.lbCaminho.Size = new System.Drawing.Size(146, 13);
            this.lbCaminho.TabIndex = 1;
            this.lbCaminho.Text = "Caminho do Banco de Dados";
            // 
            // lbSenha
            // 
            this.lbSenha.AutoSize = true;
            this.lbSenha.Location = new System.Drawing.Point(12, 94);
            this.lbSenha.Name = "lbSenha";
            this.lbSenha.Size = new System.Drawing.Size(90, 13);
            this.lbSenha.TabIndex = 4;
            this.lbSenha.Text = "Senha de acesso";
            // 
            // tbSenha
            // 
            this.tbSenha.Location = new System.Drawing.Point(15, 111);
            this.tbSenha.Name = "tbSenha";
            this.tbSenha.Size = new System.Drawing.Size(275, 20);
            this.tbSenha.TabIndex = 5;
            // 
            // btMostrar
            // 
            this.btMostrar.AccessibleName = "Mostarr";
            this.btMostrar.Location = new System.Drawing.Point(296, 108);
            this.btMostrar.Name = "btMostrar";
            this.btMostrar.Size = new System.Drawing.Size(34, 23);
            this.btMostrar.TabIndex = 6;
            this.btMostrar.Text = "***";
            this.toolTip1.SetToolTip(this.btMostrar, "Mostrar Caracteres");
            this.btMostrar.UseVisualStyleBackColor = true;
            this.btMostrar.Click += new System.EventHandler(this.btMostrar_Click);
            // 
            // btSalvar
            // 
            this.btSalvar.Location = new System.Drawing.Point(98, 146);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(135, 23);
            this.btSalvar.TabIndex = 7;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // panelLogoAccess
            // 
            this.panelLogoAccess.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelLogoAccess.BackgroundImage")));
            this.panelLogoAccess.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelLogoAccess.Controls.Add(this.label2);
            this.panelLogoAccess.Controls.Add(this.label1);
            this.panelLogoAccess.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelLogoAccess.Location = new System.Drawing.Point(0, 165);
            this.panelLogoAccess.Name = "panelLogoAccess";
            this.panelLogoAccess.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panelLogoAccess.Size = new System.Drawing.Size(336, 80);
            this.panelLogoAccess.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "PowerBy: Microsoft Access";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Utilize base de dados Access com extensão .mdb";
            // 
            // FormConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(336, 245);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.btMostrar);
            this.Controls.Add(this.tbSenha);
            this.Controls.Add(this.lbSenha);
            this.Controls.Add(this.lbCaminho);
            this.Controls.Add(this.lbTitulo);
            this.Controls.Add(this.panelLogoAccess);
            this.Controls.Add(this.tbCaminho);
            this.Controls.Add(this.btCaminho);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormConfig";
            this.ShowIcon = false;
            this.Text = "Configurações";
            this.Load += new System.EventHandler(this.FormConfig_Load);
            this.panelLogoAccess.ResumeLayout(false);
            this.panelLogoAccess.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCaminho;
        private System.Windows.Forms.TextBox tbCaminho;
        private System.Windows.Forms.Panel panelLogoAccess;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Label lbCaminho;
        private System.Windows.Forms.Label lbSenha;
        private System.Windows.Forms.TextBox tbSenha;
        private System.Windows.Forms.Button btMostrar;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}