namespace EnDec
{
    partial class Form1
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
            this.txtToEnc = new System.Windows.Forms.TextBox();
            this.cmdEncResult = new System.Windows.Forms.Label();
            this.txtEncResult = new System.Windows.Forms.TextBox();
            this.cmdToEnc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtToEnc
            // 
            this.txtToEnc.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtToEnc.Location = new System.Drawing.Point(0, 0);
            this.txtToEnc.Multiline = true;
            this.txtToEnc.Name = "txtToEnc";
            this.txtToEnc.Size = new System.Drawing.Size(263, 336);
            this.txtToEnc.TabIndex = 0;
            // 
            // cmdEncResult
            // 
            this.cmdEncResult.AutoSize = true;
            this.cmdEncResult.Location = new System.Drawing.Point(306, 46);
            this.cmdEncResult.Name = "cmdEncResult";
            this.cmdEncResult.Size = new System.Drawing.Size(53, 13);
            this.cmdEncResult.TabIndex = 4;
            this.cmdEncResult.Text = "Decrypt >";
            this.cmdEncResult.Click += new System.EventHandler(this.cmdEncResult_Click);
            // 
            // txtEncResult
            // 
            this.txtEncResult.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtEncResult.Location = new System.Drawing.Point(440, 0);
            this.txtEncResult.Multiline = true;
            this.txtEncResult.Name = "txtEncResult";
            this.txtEncResult.Size = new System.Drawing.Size(263, 336);
            this.txtEncResult.TabIndex = 2;
            // 
            // cmdToEnc
            // 
            this.cmdToEnc.AutoSize = true;
            this.cmdToEnc.Location = new System.Drawing.Point(307, 70);
            this.cmdToEnc.Name = "cmdToEnc";
            this.cmdToEnc.Size = new System.Drawing.Size(52, 13);
            this.cmdToEnc.TabIndex = 3;
            this.cmdToEnc.Text = "< Encrypt";
            this.cmdToEnc.Click += new System.EventHandler(this.cmdToEnc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 336);
            this.Controls.Add(this.cmdToEnc);
            this.Controls.Add(this.txtEncResult);
            this.Controls.Add(this.cmdEncResult);
            this.Controls.Add(this.txtToEnc);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtToEnc;
        private System.Windows.Forms.Label cmdEncResult;
        private System.Windows.Forms.TextBox txtEncResult;
        private System.Windows.Forms.Label cmdToEnc;
    }
}

