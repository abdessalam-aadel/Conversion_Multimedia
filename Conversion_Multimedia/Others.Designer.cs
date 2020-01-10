namespace Conversion_Multimedia
{
    partial class Others
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
            this.BtnGetInfo = new System.Windows.Forms.Button();
            this.process1 = new System.Diagnostics.Process();
            this.rtxtBoxInfo = new System.Windows.Forms.RichTextBox();
            this.CheckBoxCrop = new System.Windows.Forms.CheckBox();
            this.CheckBoxResize = new System.Windows.Forms.CheckBox();
            this.CheckBoxSubtitles = new System.Windows.Forms.CheckBox();
            this.labelChoseOptions = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnGetInfo
            // 
            this.BtnGetInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGetInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGetInfo.Location = new System.Drawing.Point(122, 33);
            this.BtnGetInfo.Name = "BtnGetInfo";
            this.BtnGetInfo.Size = new System.Drawing.Size(176, 23);
            this.BtnGetInfo.TabIndex = 0;
            this.BtnGetInfo.Text = "Get infoormation for video file";
            this.BtnGetInfo.UseVisualStyleBackColor = true;
            this.BtnGetInfo.Click += new System.EventHandler(this.BtnGetInfo_Click);
            // 
            // process1
            // 
            this.process1.EnableRaisingEvents = true;
            this.process1.StartInfo.Domain = "";
            this.process1.StartInfo.LoadUserProfile = false;
            this.process1.StartInfo.Password = null;
            this.process1.StartInfo.RedirectStandardError = true;
            this.process1.StartInfo.StandardErrorEncoding = null;
            this.process1.StartInfo.StandardOutputEncoding = null;
            this.process1.StartInfo.UserName = "";
            this.process1.StartInfo.UseShellExecute = false;
            this.process1.SynchronizingObject = this;
            this.process1.ErrorDataReceived += new System.Diagnostics.DataReceivedEventHandler(this.process1_ErrorDataReceived);
            // 
            // rtxtBoxInfo
            // 
            this.rtxtBoxInfo.Location = new System.Drawing.Point(3, 3);
            this.rtxtBoxInfo.Name = "rtxtBoxInfo";
            this.rtxtBoxInfo.Size = new System.Drawing.Size(116, 26);
            this.rtxtBoxInfo.TabIndex = 4;
            this.rtxtBoxInfo.Text = "";
            this.rtxtBoxInfo.Visible = false;
            // 
            // CheckBoxCrop
            // 
            this.CheckBoxCrop.AutoSize = true;
            this.CheckBoxCrop.Location = new System.Drawing.Point(33, 95);
            this.CheckBoxCrop.Name = "CheckBoxCrop";
            this.CheckBoxCrop.Size = new System.Drawing.Size(86, 17);
            this.CheckBoxCrop.TabIndex = 6;
            this.CheckBoxCrop.Text = "Crop a video";
            this.CheckBoxCrop.UseVisualStyleBackColor = true;
            this.CheckBoxCrop.CheckedChanged += new System.EventHandler(this.CheckBoxCrop_CheckedChanged);
            // 
            // CheckBoxResize
            // 
            this.CheckBoxResize.AutoSize = true;
            this.CheckBoxResize.Location = new System.Drawing.Point(162, 95);
            this.CheckBoxResize.Name = "CheckBoxResize";
            this.CheckBoxResize.Size = new System.Drawing.Size(96, 17);
            this.CheckBoxResize.TabIndex = 7;
            this.CheckBoxResize.Text = "Resize a video";
            this.CheckBoxResize.UseVisualStyleBackColor = true;
            this.CheckBoxResize.CheckedChanged += new System.EventHandler(this.CheckBoxResize_CheckedChanged);
            // 
            // CheckBoxSubtitles
            // 
            this.CheckBoxSubtitles.AutoSize = true;
            this.CheckBoxSubtitles.Location = new System.Drawing.Point(301, 95);
            this.CheckBoxSubtitles.Name = "CheckBoxSubtitles";
            this.CheckBoxSubtitles.Size = new System.Drawing.Size(86, 17);
            this.CheckBoxSubtitles.TabIndex = 8;
            this.CheckBoxSubtitles.Text = "Add subtitles";
            this.CheckBoxSubtitles.UseVisualStyleBackColor = true;
            this.CheckBoxSubtitles.CheckedChanged += new System.EventHandler(this.CheckBoxSubtitles_CheckedChanged);
            // 
            // labelChoseOptions
            // 
            this.labelChoseOptions.AutoSize = true;
            this.labelChoseOptions.BackColor = System.Drawing.SystemColors.Control;
            this.labelChoseOptions.ForeColor = System.Drawing.Color.OrangeRed;
            this.labelChoseOptions.Location = new System.Drawing.Point(154, 74);
            this.labelChoseOptions.Name = "labelChoseOptions";
            this.labelChoseOptions.Size = new System.Drawing.Size(112, 13);
            this.labelChoseOptions.TabIndex = 9;
            this.labelChoseOptions.Text = "Chose others options :";
            // 
            // Others
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelChoseOptions);
            this.Controls.Add(this.CheckBoxSubtitles);
            this.Controls.Add(this.CheckBoxResize);
            this.Controls.Add(this.CheckBoxCrop);
            this.Controls.Add(this.rtxtBoxInfo);
            this.Controls.Add(this.BtnGetInfo);
            this.Name = "Others";
            this.Size = new System.Drawing.Size(420, 124);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnGetInfo;
        private System.Diagnostics.Process process1;
        private System.Windows.Forms.RichTextBox rtxtBoxInfo;
        private System.Windows.Forms.CheckBox CheckBoxSubtitles;
        private System.Windows.Forms.CheckBox CheckBoxResize;
        private System.Windows.Forms.CheckBox CheckBoxCrop;
        private System.Windows.Forms.Label labelChoseOptions;
    }
}
