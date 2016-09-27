namespace Armarios
{
    partial class formDesvincular
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
            this.lbArmario = new System.Windows.Forms.Label();
            this.tbArmario = new System.Windows.Forms.TextBox();
            this.lbPessoa = new System.Windows.Forms.Label();
            this.tbPessoa = new System.Windows.Forms.TextBox();
            this.lbTurma = new System.Windows.Forms.Label();
            this.tbTurma = new System.Windows.Forms.TextBox();
            this.lbLocal = new System.Windows.Forms.Label();
            this.tbLocal = new System.Windows.Forms.TextBox();
            this.lbData = new System.Windows.Forms.Label();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btDesvincular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.Location = new System.Drawing.Point(13, 13);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(228, 25);
            this.lbTitulo.TabIndex = 0;
            this.lbTitulo.Text = "Desvínculo de Armário";
            // 
            // lbArmario
            // 
            this.lbArmario.AutoSize = true;
            this.lbArmario.Location = new System.Drawing.Point(18, 51);
            this.lbArmario.Name = "lbArmario";
            this.lbArmario.Size = new System.Drawing.Size(42, 13);
            this.lbArmario.TabIndex = 1;
            this.lbArmario.Text = "Armário";
            // 
            // tbArmario
            // 
            this.tbArmario.Location = new System.Drawing.Point(21, 68);
            this.tbArmario.Name = "tbArmario";
            this.tbArmario.ReadOnly = true;
            this.tbArmario.Size = new System.Drawing.Size(296, 20);
            this.tbArmario.TabIndex = 2;
            // 
            // lbPessoa
            // 
            this.lbPessoa.AutoSize = true;
            this.lbPessoa.Location = new System.Drawing.Point(21, 95);
            this.lbPessoa.Name = "lbPessoa";
            this.lbPessoa.Size = new System.Drawing.Size(42, 13);
            this.lbPessoa.TabIndex = 3;
            this.lbPessoa.Text = "Pessoa";
            // 
            // tbPessoa
            // 
            this.tbPessoa.Location = new System.Drawing.Point(24, 112);
            this.tbPessoa.Name = "tbPessoa";
            this.tbPessoa.ReadOnly = true;
            this.tbPessoa.Size = new System.Drawing.Size(293, 20);
            this.tbPessoa.TabIndex = 4;
            // 
            // lbTurma
            // 
            this.lbTurma.AutoSize = true;
            this.lbTurma.Location = new System.Drawing.Point(24, 139);
            this.lbTurma.Name = "lbTurma";
            this.lbTurma.Size = new System.Drawing.Size(37, 13);
            this.lbTurma.TabIndex = 5;
            this.lbTurma.Text = "Turma";
            // 
            // tbTurma
            // 
            this.tbTurma.Location = new System.Drawing.Point(27, 156);
            this.tbTurma.Name = "tbTurma";
            this.tbTurma.ReadOnly = true;
            this.tbTurma.Size = new System.Drawing.Size(180, 20);
            this.tbTurma.TabIndex = 6;
            // 
            // lbLocal
            // 
            this.lbLocal.AutoSize = true;
            this.lbLocal.Location = new System.Drawing.Point(27, 183);
            this.lbLocal.Name = "lbLocal";
            this.lbLocal.Size = new System.Drawing.Size(64, 13);
            this.lbLocal.TabIndex = 7;
            this.lbLocal.Text = "Localização";
            // 
            // tbLocal
            // 
            this.tbLocal.Location = new System.Drawing.Point(30, 200);
            this.tbLocal.Name = "tbLocal";
            this.tbLocal.ReadOnly = true;
            this.tbLocal.Size = new System.Drawing.Size(287, 20);
            this.tbLocal.TabIndex = 8;
            // 
            // lbData
            // 
            this.lbData.AutoSize = true;
            this.lbData.Location = new System.Drawing.Point(30, 233);
            this.lbData.Name = "lbData";
            this.lbData.Size = new System.Drawing.Size(34, 13);
            this.lbData.TabIndex = 9;
            this.lbData.Text = ".........";
            // 
            // btCancelar
            // 
            this.btCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCancelar.Image = global::Armarios.Properties.Resources._1379666600_cross;
            this.btCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btCancelar.Location = new System.Drawing.Point(225, 260);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(92, 32);
            this.btCancelar.TabIndex = 11;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btDesvincular
            // 
            this.btDesvincular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDesvincular.Image = global::Armarios.Properties.Resources.Lock_32;
            this.btDesvincular.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btDesvincular.Location = new System.Drawing.Point(27, 260);
            this.btDesvincular.Name = "btDesvincular";
            this.btDesvincular.Size = new System.Drawing.Size(101, 32);
            this.btDesvincular.TabIndex = 10;
            this.btDesvincular.Text = "Desvínculo";
            this.btDesvincular.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btDesvincular.UseVisualStyleBackColor = true;
            this.btDesvincular.Click += new System.EventHandler(this.btDesvincular_Click);
            // 
            // formDesvincular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 307);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btDesvincular);
            this.Controls.Add(this.lbData);
            this.Controls.Add(this.tbLocal);
            this.Controls.Add(this.lbLocal);
            this.Controls.Add(this.tbTurma);
            this.Controls.Add(this.lbTurma);
            this.Controls.Add(this.tbPessoa);
            this.Controls.Add(this.lbPessoa);
            this.Controls.Add(this.tbArmario);
            this.Controls.Add(this.lbArmario);
            this.Controls.Add(this.lbTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formDesvincular";
            this.ShowIcon = false;
            this.Text = "Desvínculo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Label lbArmario;
        private System.Windows.Forms.TextBox tbArmario;
        private System.Windows.Forms.Label lbPessoa;
        private System.Windows.Forms.TextBox tbPessoa;
        private System.Windows.Forms.Label lbTurma;
        private System.Windows.Forms.TextBox tbTurma;
        private System.Windows.Forms.Label lbLocal;
        private System.Windows.Forms.TextBox tbLocal;
        private System.Windows.Forms.Label lbData;
        private System.Windows.Forms.Button btDesvincular;
        private System.Windows.Forms.Button btCancelar;
    }
}