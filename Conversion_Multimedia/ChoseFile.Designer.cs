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
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.txtboxFileName = new System.Windows.Forms.TextBox();
            this.rtxtboxCmd = new System.Windows.Forms.RichTextBox();
            this.labelFilename = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLoad
            // 
            this.btnLoad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoad.Location = new System.Drawing.Point(260, 56);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "Load File";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.ForestGreen;
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart.Enabled = false;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Location = new System.Drawing.Point(260, 110);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 63);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtboxFileName
            // 
            this.txtboxFileName.Location = new System.Drawing.Point(53, 59);
            this.txtboxFileName.Name = "txtboxFileName";
            this.txtboxFileName.Size = new System.Drawing.Size(186, 20);
            this.txtboxFileName.TabIndex = 3;
            this.txtboxFileName.Text = "Chose your file ...";
            // 
            // rtxtboxCmd
            // 
            this.rtxtboxCmd.BackColor = System.Drawing.SystemColors.InfoText;
            this.rtxtboxCmd.ForeColor = System.Drawing.SystemColors.Window;
            this.rtxtboxCmd.Location = new System.Drawing.Point(53, 110);
            this.rtxtboxCmd.Name = "rtxtboxCmd";
            this.rtxtboxCmd.Size = new System.Drawing.Size(186, 64);
            this.rtxtboxCmd.TabIndex = 4;
            this.rtxtboxCmd.Text = "";
            // 
            // labelFilename
            // 
            this.labelFilename.AutoSize = true;
            this.labelFilename.Location = new System.Drawing.Point(53, 86);
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
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnLoad);
            this.Name = "ChoseFile";
            this.Size = new System.Drawing.Size(420, 183);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txtboxFileName;
        private System.Windows.Forms.RichTextBox rtxtboxCmd;
        private System.Windows.Forms.Label labelFilename;
    }
}
