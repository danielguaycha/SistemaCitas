namespace ProisProject.View
{
    partial class FrmRptPacientes
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
            this.ViewRptPacientes = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // ViewRptPacientes
            // 
            this.ViewRptPacientes.ActiveViewIndex = -1;
            this.ViewRptPacientes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ViewRptPacientes.Cursor = System.Windows.Forms.Cursors.Default;
            this.ViewRptPacientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ViewRptPacientes.Location = new System.Drawing.Point(0, 0);
            this.ViewRptPacientes.Name = "ViewRptPacientes";
            this.ViewRptPacientes.Size = new System.Drawing.Size(589, 443);
            this.ViewRptPacientes.TabIndex = 0;
            // 
            // FrmRptPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 443);
            this.Controls.Add(this.ViewRptPacientes);
            this.Name = "FrmRptPacientes";
            this.Text = "FrmRptPacientes";
            this.Load += new System.EventHandler(this.FrmRptPacientes_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer ViewRptPacientes;
    }
}