namespace Armarios
{
    partial class formSelecionaRelatorioEmprestimo
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
            this.gBoxSeleciona = new System.Windows.Forms.GroupBox();
            this.btGerar = new System.Windows.Forms.Button();
            this.rbRelatorio3 = new System.Windows.Forms.RadioButton();
            this.rbRelatorio2 = new System.Windows.Forms.RadioButton();
            this.rbRelatorio1 = new System.Windows.Forms.RadioButton();
            this.gBoxOrdenacao = new System.Windows.Forms.GroupBox();
            this.ordem1 = new System.Windows.Forms.RadioButton();
            this.ordem2 = new System.Windows.Forms.RadioButton();
            this.ordem3 = new System.Windows.Forms.RadioButton();
            this.ordem4 = new System.Windows.Forms.RadioButton();
            this.gBoxSeleciona.SuspendLayout();
            this.gBoxOrdenacao.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBoxSeleciona
            // 
            this.gBoxSeleciona.Controls.Add(this.rbRelatorio3);
            this.gBoxSeleciona.Controls.Add(this.rbRelatorio2);
            this.gBoxSeleciona.Controls.Add(this.rbRelatorio1);
            this.gBoxSeleciona.Dock = System.Windows.Forms.DockStyle.Top;
            this.gBoxSeleciona.Location = new System.Drawing.Point(0, 0);
            this.gBoxSeleciona.Name = "gBoxSeleciona";
            this.gBoxSeleciona.Size = new System.Drawing.Size(290, 113);
            this.gBoxSeleciona.TabIndex = 0;
            this.gBoxSeleciona.TabStop = false;
            this.gBoxSeleciona.Text = "Tipo de Relatório";
            this.gBoxSeleciona.Enter += new System.EventHandler(this.gBoxSeleciona_Enter);
            // 
            // btGerar
            // 
            this.btGerar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btGerar.Location = new System.Drawing.Point(0, 255);
            this.btGerar.Name = "btGerar";
            this.btGerar.Size = new System.Drawing.Size(290, 23);
            this.btGerar.TabIndex = 3;
            this.btGerar.Text = "Gerar Relatório";
            this.btGerar.UseVisualStyleBackColor = true;
            this.btGerar.Click += new System.EventHandler(this.btGerar_Click);
            // 
            // rbRelatorio3
            // 
            this.rbRelatorio3.AutoSize = true;
            this.rbRelatorio3.Location = new System.Drawing.Point(12, 79);
            this.rbRelatorio3.Name = "rbRelatorio3";
            this.rbRelatorio3.Size = new System.Drawing.Size(125, 17);
            this.rbRelatorio3.TabIndex = 2;
            this.rbRelatorio3.TabStop = true;
            this.rbRelatorio3.Text = "Exportar para EXCEL";
            this.rbRelatorio3.UseVisualStyleBackColor = true;
            // 
            // rbRelatorio2
            // 
            this.rbRelatorio2.AutoSize = true;
            this.rbRelatorio2.Location = new System.Drawing.Point(12, 56);
            this.rbRelatorio2.Name = "rbRelatorio2";
            this.rbRelatorio2.Size = new System.Drawing.Size(117, 17);
            this.rbRelatorio2.TabIndex = 1;
            this.rbRelatorio2.TabStop = true;
            this.rbRelatorio2.Text = "Relatório em HTML";
            this.rbRelatorio2.UseVisualStyleBackColor = true;
            // 
            // rbRelatorio1
            // 
            this.rbRelatorio1.AutoSize = true;
            this.rbRelatorio1.Checked = true;
            this.rbRelatorio1.Location = new System.Drawing.Point(12, 33);
            this.rbRelatorio1.Name = "rbRelatorio1";
            this.rbRelatorio1.Size = new System.Drawing.Size(150, 17);
            this.rbRelatorio1.TabIndex = 0;
            this.rbRelatorio1.TabStop = true;
            this.rbRelatorio1.Text = "Relatório Geral do Sistema";
            this.rbRelatorio1.UseVisualStyleBackColor = true;
            // 
            // gBoxOrdenacao
            // 
            this.gBoxOrdenacao.Controls.Add(this.ordem4);
            this.gBoxOrdenacao.Controls.Add(this.ordem3);
            this.gBoxOrdenacao.Controls.Add(this.ordem2);
            this.gBoxOrdenacao.Controls.Add(this.ordem1);
            this.gBoxOrdenacao.Dock = System.Windows.Forms.DockStyle.Top;
            this.gBoxOrdenacao.Location = new System.Drawing.Point(0, 113);
            this.gBoxOrdenacao.Name = "gBoxOrdenacao";
            this.gBoxOrdenacao.Size = new System.Drawing.Size(290, 135);
            this.gBoxOrdenacao.TabIndex = 4;
            this.gBoxOrdenacao.TabStop = false;
            this.gBoxOrdenacao.Text = "Ordenação";
            // 
            // ordem1
            // 
            this.ordem1.AutoSize = true;
            this.ordem1.Checked = true;
            this.ordem1.Location = new System.Drawing.Point(12, 20);
            this.ordem1.Name = "ordem1";
            this.ordem1.Size = new System.Drawing.Size(112, 17);
            this.ordem1.TabIndex = 0;
            this.ordem1.TabStop = true;
            this.ordem1.Text = "Ordem por Armário";
            this.ordem1.UseVisualStyleBackColor = true;
            // 
            // ordem2
            // 
            this.ordem2.AutoSize = true;
            this.ordem2.Location = new System.Drawing.Point(12, 43);
            this.ordem2.Name = "ordem2";
            this.ordem2.Size = new System.Drawing.Size(112, 17);
            this.ordem2.TabIndex = 1;
            this.ordem2.TabStop = true;
            this.ordem2.Text = "Ordem por Pessoa";
            this.ordem2.UseVisualStyleBackColor = true;
            // 
            // ordem3
            // 
            this.ordem3.AutoSize = true;
            this.ordem3.Location = new System.Drawing.Point(12, 67);
            this.ordem3.Name = "ordem3";
            this.ordem3.Size = new System.Drawing.Size(107, 17);
            this.ordem3.TabIndex = 2;
            this.ordem3.TabStop = true;
            this.ordem3.Text = "Ordem por Turma";
            this.ordem3.UseVisualStyleBackColor = true;
            // 
            // ordem4
            // 
            this.ordem4.AutoSize = true;
            this.ordem4.Location = new System.Drawing.Point(13, 91);
            this.ordem4.Name = "ordem4";
            this.ordem4.Size = new System.Drawing.Size(100, 17);
            this.ordem4.TabIndex = 3;
            this.ordem4.TabStop = true;
            this.ordem4.Text = "Ordem por Data";
            this.ordem4.UseVisualStyleBackColor = true;
            // 
            // formSelecionaRelatorioEmprestimo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 278);
            this.Controls.Add(this.gBoxOrdenacao);
            this.Controls.Add(this.btGerar);
            this.Controls.Add(this.gBoxSeleciona);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formSelecionaRelatorioEmprestimo";
            this.ShowIcon = false;
            this.Text = "Selecionar Tipo de Relatório";
            this.Load += new System.EventHandler(this.formSelecionaRelatorioEmprestimo_Load);
            this.gBoxSeleciona.ResumeLayout(false);
            this.gBoxSeleciona.PerformLayout();
            this.gBoxOrdenacao.ResumeLayout(false);
            this.gBoxOrdenacao.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gBoxSeleciona;
        private System.Windows.Forms.RadioButton rbRelatorio3;
        private System.Windows.Forms.RadioButton rbRelatorio2;
        private System.Windows.Forms.RadioButton rbRelatorio1;
        private System.Windows.Forms.Button btGerar;
        private System.Windows.Forms.GroupBox gBoxOrdenacao;
        private System.Windows.Forms.RadioButton ordem4;
        private System.Windows.Forms.RadioButton ordem3;
        private System.Windows.Forms.RadioButton ordem2;
        private System.Windows.Forms.RadioButton ordem1;
    }
}