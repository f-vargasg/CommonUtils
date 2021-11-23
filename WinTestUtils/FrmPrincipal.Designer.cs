namespace WinTestUtils
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
            this.butTest = new System.Windows.Forms.Button();
            this.butTestLog4net = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // butTest
            // 
            this.butTest.Location = new System.Drawing.Point(25, 112);
            this.butTest.Name = "butTest";
            this.butTest.Size = new System.Drawing.Size(131, 77);
            this.butTest.TabIndex = 0;
            this.butTest.Text = "Test Conn";
            this.butTest.UseVisualStyleBackColor = true;
            this.butTest.Click += new System.EventHandler(this.butTest_Click);
            // 
            // butTestLog4net
            // 
            this.butTestLog4net.Location = new System.Drawing.Point(250, 112);
            this.butTestLog4net.Name = "butTestLog4net";
            this.butTestLog4net.Size = new System.Drawing.Size(131, 77);
            this.butTestLog4net.TabIndex = 1;
            this.butTestLog4net.Text = "Test Log4Net";
            this.butTestLog4net.UseVisualStyleBackColor = true;
            this.butTestLog4net.Click += new System.EventHandler(this.butTestLog4net_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 402);
            this.Controls.Add(this.butTestLog4net);
            this.Controls.Add(this.butTest);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmPrincipal";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butTest;
        private System.Windows.Forms.Button butTestLog4net;
    }
}

