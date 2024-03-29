﻿namespace WinTestUtils
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.butTest = new System.Windows.Forms.Button();
            this.butTestLog4net = new System.Windows.Forms.Button();
            this.ucLoadFile1 = new CommonUtils.WinCompTb.UCSelectedFile();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.butTestFunction = new System.Windows.Forms.Button();
            this.txtOutPut = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // butTest
            // 
            this.butTest.Location = new System.Drawing.Point(22, 29);
            this.butTest.Name = "butTest";
            this.butTest.Size = new System.Drawing.Size(131, 77);
            this.butTest.TabIndex = 0;
            this.butTest.Text = "Test Conn";
            this.butTest.UseVisualStyleBackColor = true;
            this.butTest.Click += new System.EventHandler(this.ButTest_Click);
            // 
            // butTestLog4net
            // 
            this.butTestLog4net.Location = new System.Drawing.Point(206, 29);
            this.butTestLog4net.Name = "butTestLog4net";
            this.butTestLog4net.Size = new System.Drawing.Size(131, 77);
            this.butTestLog4net.TabIndex = 1;
            this.butTestLog4net.Text = "Test Log4Net";
            this.butTestLog4net.UseVisualStyleBackColor = true;
            this.butTestLog4net.Click += new System.EventHandler(this.ButTestLog4net_Click);
            // 
            // ucLoadFile1
            // 
            this.ucLoadFile1.Location = new System.Drawing.Point(22, 142);
            this.ucLoadFile1.Margin = new System.Windows.Forms.Padding(4);
            this.ucLoadFile1.Name = "ucLoadFile1";
            this.ucLoadFile1.Size = new System.Drawing.Size(608, 140);
            this.ucLoadFile1.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(411, 172);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 37);
            this.comboBox1.TabIndex = 3;
            // 
            // butTestFunction
            // 
            this.butTestFunction.Location = new System.Drawing.Point(411, 29);
            this.butTestFunction.Name = "butTestFunction";
            this.butTestFunction.Size = new System.Drawing.Size(131, 77);
            this.butTestFunction.TabIndex = 4;
            this.butTestFunction.Text = "Test Function SP";
            this.butTestFunction.UseVisualStyleBackColor = true;
            this.butTestFunction.Click += new System.EventHandler(this.ButTestFunction_Click);
            // 
            // txtOutPut
            // 
            this.txtOutPut.Location = new System.Drawing.Point(71, 346);
            this.txtOutPut.Multiline = true;
            this.txtOutPut.Name = "txtOutPut";
            this.txtOutPut.Size = new System.Drawing.Size(619, 113);
            this.txtOutPut.TabIndex = 5;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 476);
            this.Controls.Add(this.txtOutPut);
            this.Controls.Add(this.butTestFunction);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.ucLoadFile1);
            this.Controls.Add(this.butTestLog4net);
            this.Controls.Add(this.butTest);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmPrincipal";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butTest;
        private System.Windows.Forms.Button butTestLog4net;
        private CommonUtils.WinCompTb.UCSelectedFile ucLoadFile1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button butTestFunction;
        private System.Windows.Forms.TextBox txtOutPut;
    }
}

