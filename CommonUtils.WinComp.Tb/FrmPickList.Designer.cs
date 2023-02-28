namespace CommonUtils.WinCompTb
{
    partial class FrmPickList<T>
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
            this.buttonsPnl = new System.Windows.Forms.Panel();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.okBtn = new System.Windows.Forms.Button();
            this.paramsPnl = new System.Windows.Forms.Panel();
            this.ordenarBtn = new System.Windows.Forms.Button();
            this.toSearchTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.searchBtn = new System.Windows.Forms.Button();
            this.columnGridCmb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgrPnl = new System.Windows.Forms.Panel();
            this.dgrData = new System.Windows.Forms.DataGridView();
            this.buttonsPnl.SuspendLayout();
            this.paramsPnl.SuspendLayout();
            this.dgrPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrData)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonsPnl
            // 
            this.buttonsPnl.Controls.Add(this.cancelBtn);
            this.buttonsPnl.Controls.Add(this.okBtn);
            this.buttonsPnl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonsPnl.Location = new System.Drawing.Point(0, 672);
            this.buttonsPnl.Margin = new System.Windows.Forms.Padding(4);
            this.buttonsPnl.Name = "buttonsPnl";
            this.buttonsPnl.Size = new System.Drawing.Size(940, 153);
            this.buttonsPnl.TabIndex = 2;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(524, 30);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(4);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(323, 98);
            this.cancelBtn.TabIndex = 1;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(77, 30);
            this.okBtn.Margin = new System.Windows.Forms.Padding(4);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(323, 98);
            this.okBtn.TabIndex = 0;
            this.okBtn.Text = "Ok";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.OkBtn_Click);
            // 
            // paramsPnl
            // 
            this.paramsPnl.Controls.Add(this.ordenarBtn);
            this.paramsPnl.Controls.Add(this.toSearchTxt);
            this.paramsPnl.Controls.Add(this.label2);
            this.paramsPnl.Controls.Add(this.searchBtn);
            this.paramsPnl.Controls.Add(this.columnGridCmb);
            this.paramsPnl.Controls.Add(this.label1);
            this.paramsPnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.paramsPnl.Location = new System.Drawing.Point(0, 0);
            this.paramsPnl.Margin = new System.Windows.Forms.Padding(4);
            this.paramsPnl.Name = "paramsPnl";
            this.paramsPnl.Size = new System.Drawing.Size(940, 172);
            this.paramsPnl.TabIndex = 3;
            // 
            // ordenarBtn
            // 
            this.ordenarBtn.Location = new System.Drawing.Point(684, 40);
            this.ordenarBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ordenarBtn.Name = "ordenarBtn";
            this.ordenarBtn.Size = new System.Drawing.Size(110, 35);
            this.ordenarBtn.TabIndex = 5;
            this.ordenarBtn.Text = "Ordenar";
            this.ordenarBtn.UseVisualStyleBackColor = true;
            // 
            // toSearchTxt
            // 
            this.toSearchTxt.Location = new System.Drawing.Point(178, 92);
            this.toSearchTxt.Margin = new System.Windows.Forms.Padding(4);
            this.toSearchTxt.Name = "toSearchTxt";
            this.toSearchTxt.Size = new System.Drawing.Size(486, 29);
            this.toSearchTxt.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 96);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Buscar";
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(684, 90);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(4);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(110, 35);
            this.searchBtn.TabIndex = 2;
            this.searchBtn.Text = "Buscar";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // columnGridCmb
            // 
            this.columnGridCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.columnGridCmb.FormattingEnabled = true;
            this.columnGridCmb.Location = new System.Drawing.Point(178, 40);
            this.columnGridCmb.Margin = new System.Windows.Forms.Padding(4);
            this.columnGridCmb.Name = "columnGridCmb";
            this.columnGridCmb.Size = new System.Drawing.Size(486, 32);
            this.columnGridCmb.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ordenar por:";
            // 
            // dgrPnl
            // 
            this.dgrPnl.Controls.Add(this.dgrData);
            this.dgrPnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgrPnl.Location = new System.Drawing.Point(0, 172);
            this.dgrPnl.Margin = new System.Windows.Forms.Padding(4);
            this.dgrPnl.Name = "dgrPnl";
            this.dgrPnl.Size = new System.Drawing.Size(940, 500);
            this.dgrPnl.TabIndex = 4;
            // 
            // dgrData
            // 
            this.dgrData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgrData.Location = new System.Drawing.Point(0, 0);
            this.dgrData.Margin = new System.Windows.Forms.Padding(4);
            this.dgrData.Name = "dgrData";
            this.dgrData.RowHeadersWidth = 72;
            this.dgrData.RowTemplate.Height = 31;
            this.dgrData.Size = new System.Drawing.Size(940, 500);
            this.dgrData.TabIndex = 0;
            this.dgrData.DoubleClick += new System.EventHandler(this.DgrData_DoubleClick);
            // 
            // FrmPickList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 825);
            this.Controls.Add(this.dgrPnl);
            this.Controls.Add(this.paramsPnl);
            this.Controls.Add(this.buttonsPnl);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmPickList";
            this.Text = "FrmPickList";
            this.Load += new System.EventHandler(this.FrmPickList_Load);
            this.buttonsPnl.ResumeLayout(false);
            this.paramsPnl.ResumeLayout(false);
            this.paramsPnl.PerformLayout();
            this.dgrPnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Panel buttonsPnl;
        protected System.Windows.Forms.Button cancelBtn;
        protected System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.Panel paramsPnl;
        private System.Windows.Forms.Button ordenarBtn;
        private System.Windows.Forms.TextBox toSearchTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.ComboBox columnGridCmb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel dgrPnl;
        private System.Windows.Forms.DataGridView dgrData;
    }
}