namespace Armarios
{
    partial class formCadastrarVinculo
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
            this.lbTitulo = new System.Windows.Forms.Label();
            this.lbPessoa = new System.Windows.Forms.Label();
            this.tbPessoa = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btSalvar = new System.Windows.Forms.Button();
            this.btNovaPessoa = new System.Windows.Forms.Button();
            this.btFindPessoa = new System.Windows.Forms.Button();
            this.gbPessoa = new System.Windows.Forms.GroupBox();
            this.dataGridPessoa = new System.Windows.Forms.DataGridView();
            this.gbArmario = new System.Windows.Forms.GroupBox();
            this.dataGridArmario = new System.Windows.Forms.DataGridView();
            this.tbArmario = new System.Windows.Forms.TextBox();
            this.btNovoArmario = new System.Windows.Forms.Button();
            this.lbArmario = new System.Windows.Forms.Label();
            this.btFindArmario = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.statusProgress = new System.Windows.Forms.Label();
            this.gbPessoa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPessoa)).BeginInit();
            this.gbArmario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridArmario)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.Location = new System.Drawing.Point(12, 5);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(90, 25);
            this.lbTitulo.TabIndex = 0;
            this.lbTitulo.Text = "Vincular";
            // 
            // lbPessoa
            // 
            this.lbPessoa.AutoSize = true;
            this.lbPessoa.Location = new System.Drawing.Point(6, 22);
            this.lbPessoa.Name = "lbPessoa";
            this.lbPessoa.Size = new System.Drawing.Size(42, 13);
            this.lbPessoa.TabIndex = 1;
            this.lbPessoa.Text = "Pessoa";
            // 
            // tbPessoa
            // 
            this.tbPessoa.Location = new System.Drawing.Point(9, 38);
            this.tbPessoa.Name = "tbPessoa";
            this.tbPessoa.Size = new System.Drawing.Size(382, 20);
            this.tbPessoa.TabIndex = 2;
            this.tbPessoa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbPessoa_KeyDown);
            this.tbPessoa.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbPessoa_KeyUp);
            // 
            // btSalvar
            // 
            this.btSalvar.BackgroundImage = global::Armarios.Properties.Resources.Save;
            this.btSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSalvar.Location = new System.Drawing.Point(12, 347);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(85, 32);
            this.btSalvar.TabIndex = 6;
            this.btSalvar.Text = "Vincular";
            this.btSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btSalvar, "Vincular");
            this.btSalvar.UseVisualStyleBackColor = false;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // btNovaPessoa
            // 
            this.btNovaPessoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNovaPessoa.Image = global::Armarios.Properties.Resources._1379624549_contact_new;
            this.btNovaPessoa.Location = new System.Drawing.Point(435, 31);
            this.btNovaPessoa.Name = "btNovaPessoa";
            this.btNovaPessoa.Size = new System.Drawing.Size(32, 32);
            this.btNovaPessoa.TabIndex = 4;
            this.toolTip1.SetToolTip(this.btNovaPessoa, "Novo Cadastro");
            this.btNovaPessoa.UseVisualStyleBackColor = false;
            this.btNovaPessoa.Click += new System.EventHandler(this.btNovaPessoa_Click);
            // 
            // btFindPessoa
            // 
            this.btFindPessoa.BackgroundImage = global::Armarios.Properties.Resources.find;
            this.btFindPessoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFindPessoa.Location = new System.Drawing.Point(397, 31);
            this.btFindPessoa.Name = "btFindPessoa";
            this.btFindPessoa.Size = new System.Drawing.Size(32, 32);
            this.btFindPessoa.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btFindPessoa, "Procurar Pessoa");
            this.btFindPessoa.UseVisualStyleBackColor = false;
            this.btFindPessoa.Click += new System.EventHandler(this.btFindPessoa_Click);
            // 
            // gbPessoa
            // 
            this.gbPessoa.Controls.Add(this.dataGridPessoa);
            this.gbPessoa.Controls.Add(this.btNovaPessoa);
            this.gbPessoa.Controls.Add(this.lbPessoa);
            this.gbPessoa.Controls.Add(this.btFindPessoa);
            this.gbPessoa.Controls.Add(this.tbPessoa);
            this.gbPessoa.Location = new System.Drawing.Point(17, 34);
            this.gbPessoa.Name = "gbPessoa";
            this.gbPessoa.Size = new System.Drawing.Size(485, 271);
            this.gbPessoa.TabIndex = 4;
            this.gbPessoa.TabStop = false;
            this.gbPessoa.Text = "Informações do Locador";
            // 
            // dataGridPessoa
            // 
            this.dataGridPessoa.AllowUserToAddRows = false;
            this.dataGridPessoa.AllowUserToDeleteRows = false;
            this.dataGridPessoa.BackgroundColor = System.Drawing.Color.White;
            this.dataGridPessoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPessoa.Location = new System.Drawing.Point(9, 64);
            this.dataGridPessoa.Name = "dataGridPessoa";
            this.dataGridPessoa.ReadOnly = true;
            this.dataGridPessoa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridPessoa.Size = new System.Drawing.Size(458, 191);
            this.dataGridPessoa.TabIndex = 5;
            // 
            // gbArmario
            // 
            this.gbArmario.Controls.Add(this.dataGridArmario);
            this.gbArmario.Controls.Add(this.tbArmario);
            this.gbArmario.Controls.Add(this.btNovoArmario);
            this.gbArmario.Controls.Add(this.lbArmario);
            this.gbArmario.Controls.Add(this.btFindArmario);
            this.gbArmario.Location = new System.Drawing.Point(508, 34);
            this.gbArmario.Name = "gbArmario";
            this.gbArmario.Size = new System.Drawing.Size(485, 271);
            this.gbArmario.TabIndex = 5;
            this.gbArmario.TabStop = false;
            this.gbArmario.Text = "Informações do Armário";
            // 
            // dataGridArmario
            // 
            this.dataGridArmario.AllowUserToAddRows = false;
            this.dataGridArmario.AllowUserToDeleteRows = false;
            this.dataGridArmario.BackgroundColor = System.Drawing.Color.White;
            this.dataGridArmario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridArmario.Location = new System.Drawing.Point(9, 64);
            this.dataGridArmario.Name = "dataGridArmario";
            this.dataGridArmario.ReadOnly = true;
            this.dataGridArmario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridArmario.Size = new System.Drawing.Size(461, 191);
            this.dataGridArmario.TabIndex = 5;
            // 
            // tbArmario
            // 
            this.tbArmario.Location = new System.Drawing.Point(9, 38);
            this.tbArmario.Name = "tbArmario";
            this.tbArmario.Size = new System.Drawing.Size(385, 20);
            this.tbArmario.TabIndex = 1;
            this.tbArmario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbArmario_KeyDown);
            // 
            // btNovoArmario
            // 
            this.btNovoArmario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNovoArmario.Image = global::Armarios.Properties.Resources._1379632304_file_manager;
            this.btNovoArmario.Location = new System.Drawing.Point(438, 31);
            this.btNovoArmario.Name = "btNovoArmario";
            this.btNovoArmario.Size = new System.Drawing.Size(32, 32);
            this.btNovoArmario.TabIndex = 4;
            this.btNovoArmario.UseVisualStyleBackColor = false;
            this.btNovoArmario.Click += new System.EventHandler(this.btNovoArmario_Click);
            // 
            // lbArmario
            // 
            this.lbArmario.AutoSize = true;
            this.lbArmario.Location = new System.Drawing.Point(6, 20);
            this.lbArmario.Name = "lbArmario";
            this.lbArmario.Size = new System.Drawing.Size(42, 13);
            this.lbArmario.TabIndex = 0;
            this.lbArmario.Text = "Armario";
            // 
            // btFindArmario
            // 
            this.btFindArmario.BackgroundImage = global::Armarios.Properties.Resources.find;
            this.btFindArmario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFindArmario.Location = new System.Drawing.Point(400, 31);
            this.btFindArmario.Name = "btFindArmario";
            this.btFindArmario.Size = new System.Drawing.Size(32, 32);
            this.btFindArmario.TabIndex = 3;
            this.btFindArmario.UseVisualStyleBackColor = false;
            this.btFindArmario.Click += new System.EventHandler(this.btFindArmario_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.BackgroundImage = global::Armarios.Properties.Resources._1379666600_cross;
            this.btCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCancelar.Location = new System.Drawing.Point(909, 347);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(84, 32);
            this.btCancelar.TabIndex = 7;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btCancelar.UseVisualStyleBackColor = false;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(112, 353);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(390, 19);
            this.progressBar1.TabIndex = 8;
            // 
            // statusProgress
            // 
            this.statusProgress.AutoSize = true;
            this.statusProgress.Location = new System.Drawing.Point(152, 484);
            this.statusProgress.Name = "statusProgress";
            this.statusProgress.Size = new System.Drawing.Size(16, 13);
            this.statusProgress.TabIndex = 9;
            this.statusProgress.Text = "...";
            // 
            // formCadastrarVinculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 384);
            this.Controls.Add(this.statusProgress);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.gbArmario);
            this.Controls.Add(this.gbPessoa);
            this.Controls.Add(this.lbTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formCadastrarVinculo";
            this.Text = "Vincular";
            this.Load += new System.EventHandler(this.formCadastrarVinculo_Load);
            this.gbPessoa.ResumeLayout(false);
            this.gbPessoa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPessoa)).EndInit();
            this.gbArmario.ResumeLayout(false);
            this.gbArmario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridArmario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Label lbPessoa;
        private System.Windows.Forms.TextBox tbPessoa;
        private System.Windows.Forms.Button btFindPessoa;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox gbPessoa;
        private System.Windows.Forms.Button btNovaPessoa;
        private System.Windows.Forms.DataGridView dataGridPessoa;
        private System.Windows.Forms.GroupBox gbArmario;
        private System.Windows.Forms.TextBox tbArmario;
        private System.Windows.Forms.Button btNovoArmario;
        private System.Windows.Forms.Label lbArmario;
        private System.Windows.Forms.Button btFindArmario;
        private System.Windows.Forms.DataGridView dataGridArmario;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label statusProgress;
    }
}