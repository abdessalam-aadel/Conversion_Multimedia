namespace Conversion_Multimedia
{
    partial class ChoseFile
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnLoad = new System.Windows.Forms.Button();
            this.BtnStart = new System.Windows.Forms.Button();
            this.txtboxFileName = new System.Windows.Forms.TextBox();
            this.rtxtboxCmd = new System.Windows.Forms.RichTextBox();
            this.labelFilename = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnLoad
            // 
            this.BtnLoad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLoad.Location = new System.Drawing.Point(332, 6);
            this.BtnLoad.Name = "BtnLoad";
            this.BtnLoad.Size = new System.Drawing.Size(75, 23);
            this.BtnLoad.TabIndex = 1;
            this.BtnLoad.Text = "Load File";
            this.BtnLoad.UseVisualStyleBackColor = true;
            this.BtnLoad.Click += new System.EventHandler(this.BtnLoad_Click);
            // 
            // BtnStart
            // 
            this.BtnStart.BackColor = System.Drawing.Color.ForestGreen;
            this.BtnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnStart.Enabled = false;
            this.BtnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnStart.Location = new System.Drawing.Point(332, 55);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(75, 63);
            this.BtnStart.TabIndex = 2;
            this.BtnStart.Text = "Start";
            this.BtnStart.UseVisualStyleBackColor = false;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // txtboxFileName
            // 
            this.txtboxFileName.Location = new System.Drawing.Point(14, 9);
            this.txtboxFileName.Name = "txtboxFileName";
            this.txtboxFileName.Size = new System.Drawing.Size(312, 20);
            this.txtboxFileName.TabIndex = 3;
            this.txtboxFileName.Text = "Chose your file ...";
            // 
            // rtxtboxCmd
            // 
            this.rtxtboxCmd.BackColor = System.Drawing.SystemColors.InfoText;
            this.rtxtboxCmd.ForeColor = System.Drawing.SystemColors.Window;
            this.rtxtboxCmd.Location = new System.Drawing.Point(14, 55);
            this.rtxtboxCmd.Name = "rtxtboxCmd";
            this.rtxtboxCmd.Size = new System.Drawing.Size(312, 64);
            this.rtxtboxCmd.TabIndex = 4;
            this.rtxtboxCmd.Text = "";
            // 
            // labelFilename
            // 
            this.labelFilename.AutoSize = true;
            this.labelFilename.Location = new System.Drawing.Point(14, 35);
            this.labelFilename.Name = "labelFilename";
            this.labelFilename.Size = new System.Drawing.Size(16, 13);
            this.labelFilename.TabIndex = 5;
            this.labelFilename.Text = "...";
            // 
            // ChoseFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelFilename);
            this.Controls.Add(this.rtxtboxCmd);
            this.Controls.Add(this.txtboxFileName);
            this.Controls.Add(this.BtnStart);
            this.Controls.Add(this.BtnLoad);
            this.Name = "ChoseFile";
            this.Size = new System.Drawing.Size(420, 124);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnLoad;
        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.TextBox txtboxFileName;
        private System.Windows.Forms.RichTextBox rtxtboxCmd;
        private System.Windows.Forms.Label labelFilename;
    }
}
