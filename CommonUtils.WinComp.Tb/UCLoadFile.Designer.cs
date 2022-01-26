namespace CommonUtils.WinComp.Tb
{
    partial class UCLoadFile
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblPathFname = new System.Windows.Forms.Label();
            this.butBrowseFiles = new System.Windows.Forms.Button();
            this.txtPathFname = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblPathFname
            // 
            this.lblPathFname.AutoSize = true;
            this.lblPathFname.Location = new System.Drawing.Point(28, 25);
            this.lblPathFname.Name = "lblPathFname";
            this.lblPathFname.Size = new System.Drawing.Size(70, 13);
            this.lblPathFname.TabIndex = 17;
            this.lblPathFname.Text = "Archivo Subir";
            // 
            // butBrowseFiles
            // 
            this.butBrowseFiles.Location = new System.Drawing.Point(436, 72);
            this.butBrowseFiles.Name = "butBrowseFiles";
            this.butBrowseFiles.Size = new System.Drawing.Size(118, 28);
            this.butBrowseFiles.TabIndex = 16;
            this.butBrowseFiles.Text = "Browse";
            this.butBrowseFiles.UseVisualStyleBackColor = true;
            // 
            // txtPathFname
            // 
            this.txtPathFname.Location = new System.Drawing.Point(19, 44);
            this.txtPathFname.Name = "txtPathFname";
            this.txtPathFname.Size = new System.Drawing.Size(550, 20);
            this.txtPathFname.TabIndex = 15;
            // 
            // UCLoadFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblPathFname);
            this.Controls.Add(this.butBrowseFiles);
            this.Controls.Add(this.txtPathFname);
            this.Name = "UCLoadFile";
            this.Size = new System.Drawing.Size(613, 140);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPathFname;
        private System.Windows.Forms.Button butBrowseFiles;
        private System.Windows.Forms.TextBox txtPathFname;
    }
}
