namespace Armarios
{
    partial class ShowRelatorio
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
            this.CrystalRelatorio = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // CrystalRelatorio
            // 
            this.CrystalRelatorio.ActiveViewIndex = -1;
            this.CrystalRelatorio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CrystalRelatorio.Cursor = System.Windows.Forms.Cursors.Default;
            this.CrystalRelatorio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CrystalRelatorio.Location = new System.Drawing.Point(0, 0);
            this.CrystalRelatorio.Name = "CrystalRelatorio";
            this.CrystalRelatorio.ShowCloseButton = false;
            this.CrystalRelatorio.ShowLogo = false;
            this.CrystalRelatorio.ShowRefreshButton = false;
            this.CrystalRelatorio.Size = new System.Drawing.Size(850, 591);
            this.CrystalRelatorio.TabIndex = 0;
            this.CrystalRelatorio.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // ShowRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 591);
            this.Controls.Add(this.CrystalRelatorio);
            this.Name = "ShowRelatorio";
            this.ShowIcon = false;
            this.Text = "Relatório";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ShowRelatorio_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer CrystalRelatorio;
    }
}