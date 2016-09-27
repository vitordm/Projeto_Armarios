namespace Armarios
{
    partial class formRelArmarios
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
            this.gBRelatorio = new System.Windows.Forms.GroupBox();
            this.rel3 = new System.Windows.Forms.RadioButton();
            this.rel2 = new System.Windows.Forms.RadioButton();
            this.rel1 = new System.Windows.Forms.RadioButton();
            this.gBOrdenacao = new System.Windows.Forms.GroupBox();
            this.ordem3 = new System.Windows.Forms.RadioButton();
            this.ordem2 = new System.Windows.Forms.RadioButton();
            this.ordem1 = new System.Windows.Forms.RadioButton();
            this.btGerar = new System.Windows.Forms.Button();
            this.gBRelatorio.SuspendLayout();
            this.gBOrdenacao.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.Location = new System.Drawing.Point(0, 0);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(219, 25);
            this.lbTitulo.TabIndex = 0;
            this.lbTitulo.Text = "Relatório de Armários";
            // 
            // gBRelatorio
            // 
            this.gBRelatorio.Controls.Add(this.rel3);
            this.gBRelatorio.Controls.Add(this.rel2);
            this.gBRelatorio.Controls.Add(this.rel1);
            this.gBRelatorio.Dock = System.Windows.Forms.DockStyle.Top;
            this.gBRelatorio.Location = new System.Drawing.Point(0, 25);
            this.gBRelatorio.Name = "gBRelatorio";
            this.gBRelatorio.Size = new System.Drawing.Size(290, 95);
            this.gBRelatorio.TabIndex = 1;
            this.gBRelatorio.TabStop = false;
            this.gBRelatorio.Text = "Relatório";
            // 
            // rel3
            // 
            this.rel3.AutoSize = true;
            this.rel3.Location = new System.Drawing.Point(13, 68);
            this.rel3.Name = "rel3";
            this.rel3.Size = new System.Drawing.Size(117, 17);
            this.rel3.TabIndex = 2;
            this.rel3.Text = "Exportar para Excel";
            this.rel3.UseVisualStyleBackColor = true;
            // 
            // rel2
            // 
            this.rel2.AutoSize = true;
            this.rel2.Location = new System.Drawing.Point(13, 44);
            this.rel2.Name = "rel2";
            this.rel2.Size = new System.Drawing.Size(117, 17);
            this.rel2.TabIndex = 1;
            this.rel2.Text = "Relatório em HTML";
            this.rel2.UseVisualStyleBackColor = true;
            // 
            // rel1
            // 
            this.rel1.AutoSize = true;
            this.rel1.Checked = true;
            this.rel1.Location = new System.Drawing.Point(13, 20);
            this.rel1.Name = "rel1";
            this.rel1.Size = new System.Drawing.Size(150, 17);
            this.rel1.TabIndex = 0;
            this.rel1.TabStop = true;
            this.rel1.Text = "Relatório Geral do Sistema";
            this.rel1.UseVisualStyleBackColor = true;
            // 
            // gBOrdenacao
            // 
            this.gBOrdenacao.Controls.Add(this.ordem3);
            this.gBOrdenacao.Controls.Add(this.ordem2);
            this.gBOrdenacao.Controls.Add(this.ordem1);
            this.gBOrdenacao.Dock = System.Windows.Forms.DockStyle.Top;
            this.gBOrdenacao.Location = new System.Drawing.Point(0, 120);
            this.gBOrdenacao.Name = "gBOrdenacao";
            this.gBOrdenacao.Size = new System.Drawing.Size(290, 100);
            this.gBOrdenacao.TabIndex = 2;
            this.gBOrdenacao.TabStop = false;
            this.gBOrdenacao.Text = "Ordem";
            // 
            // ordem3
            // 
            this.ordem3.AutoSize = true;
            this.ordem3.Location = new System.Drawing.Point(13, 68);
            this.ordem3.Name = "ordem3";
            this.ordem3.Size = new System.Drawing.Size(120, 17);
            this.ordem3.TabIndex = 2;
            this.ordem3.TabStop = true;
            this.ordem3.Text = "Situação do Armário";
            this.ordem3.UseVisualStyleBackColor = true;
            // 
            // ordem2
            // 
            this.ordem2.AutoSize = true;
            this.ordem2.Location = new System.Drawing.Point(13, 44);
            this.ordem2.Name = "ordem2";
            this.ordem2.Size = new System.Drawing.Size(82, 17);
            this.ordem2.TabIndex = 1;
            this.ordem2.TabStop = true;
            this.ordem2.Text = "Localização";
            this.ordem2.UseVisualStyleBackColor = true;
            // 
            // ordem1
            // 
            this.ordem1.AutoSize = true;
            this.ordem1.Checked = true;
            this.ordem1.Location = new System.Drawing.Point(13, 20);
            this.ordem1.Name = "ordem1";
            this.ordem1.Size = new System.Drawing.Size(100, 17);
            this.ordem1.TabIndex = 0;
            this.ordem1.TabStop = true;
            this.ordem1.Text = "Número Armário";
            this.ordem1.UseVisualStyleBackColor = true;
            // 
            // btGerar
            // 
            this.btGerar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btGerar.Location = new System.Drawing.Point(0, 227);
            this.btGerar.Name = "btGerar";
            this.btGerar.Size = new System.Drawing.Size(290, 23);
            this.btGerar.TabIndex = 3;
            this.btGerar.Text = "Gerar Relatório";
            this.btGerar.UseVisualStyleBackColor = true;
            this.btGerar.Click += new System.EventHandler(this.btGerar_Click);
            // 
            // formRelArmarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 250);
            this.Controls.Add(this.btGerar);
            this.Controls.Add(this.gBOrdenacao);
            this.Controls.Add(this.gBRelatorio);
            this.Controls.Add(this.lbTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formRelArmarios";
            this.ShowIcon = false;
            this.Text = "Relatório de Armários";
            this.Load += new System.EventHandler(this.formRelArmarios_Load);
            this.gBRelatorio.ResumeLayout(false);
            this.gBRelatorio.PerformLayout();
            this.gBOrdenacao.ResumeLayout(false);
            this.gBOrdenacao.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.GroupBox gBRelatorio;
        private System.Windows.Forms.RadioButton rel3;
        private System.Windows.Forms.RadioButton rel2;
        private System.Windows.Forms.RadioButton rel1;
        private System.Windows.Forms.GroupBox gBOrdenacao;
        private System.Windows.Forms.RadioButton ordem3;
        private System.Windows.Forms.RadioButton ordem2;
        private System.Windows.Forms.RadioButton ordem1;
        private System.Windows.Forms.Button btGerar;
    }
}