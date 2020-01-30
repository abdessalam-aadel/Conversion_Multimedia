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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Others));
            this.BtnGetInfo = new System.Windows.Forms.Button();
            this.process1 = new System.Diagnostics.Process();
            this.labelChoseOptions = new System.Windows.Forms.Label();
            this.pictureDrag1 = new System.Windows.Forms.PictureBox();
            this.RdBtnCrop = new System.Windows.Forms.RadioButton();
            this.RdBtnResize = new System.Windows.Forms.RadioButton();
            this.RdBtnAddSub = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDrag1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnGetInfo
            // 
            this.BtnGetInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGetInfo.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.BtnGetInfo.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.BtnGetInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed;
            this.BtnGetInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGetInfo.Location = new System.Drawing.Point(122, 33);
            this.BtnGetInfo.Name = "BtnGetInfo";
            this.BtnGetInfo.Size = new System.Drawing.Size(176, 23);
            this.BtnGetInfo.TabIndex = 0;
            this.BtnGetInfo.TabStop = false;
            this.BtnGetInfo.Text = "Get infoormation for video file";
            this.BtnGetInfo.UseVisualStyleBackColor = true;
            this.BtnGetInfo.Click += new System.EventHandler(this.BtnGetInfo_Click);
            // 
            // process1
            // 
            this.process1.EnableRaisingEvents = true;
            this.process1.StartInfo.CreateNoWindow = true;
            this.process1.StartInfo.Domain = "";
            this.process1.StartInfo.LoadUserProfile = false;
            this.process1.StartInfo.Password = null;
            this.process1.StartInfo.RedirectStandardError = true;
            this.process1.StartInfo.RedirectStandardOutput = true;
            this.process1.StartInfo.StandardErrorEncoding = null;
            this.process1.StartInfo.StandardOutputEncoding = null;
            this.process1.StartInfo.UserName = "";
            this.process1.StartInfo.UseShellExecute = false;
            this.process1.SynchronizingObject = this;
            // 
            // labelChoseOptions
            // 
            this.labelChoseOptions.AutoSize = true;
            this.labelChoseOptions.BackColor = System.Drawing.SystemColors.Control;
            this.labelChoseOptions.ForeColor = System.Drawing.Color.OrangeRed;
            this.labelChoseOptions.Location = new System.Drawing.Point(154, 74);
            this.labelChoseOptions.Name = "labelChoseOptions";
            this.labelChoseOptions.Size = new System.Drawing.Size(112, 13);
            this.labelChoseOptions.TabIndex = 0;
            this.labelChoseOptions.Text = "Chose others options :";
            // 
            // pictureDrag1
            // 
            this.pictureDrag1.Image = ((System.Drawing.Image)(resources.GetObject("pictureDrag1.Image")));
            this.pictureDrag1.Location = new System.Drawing.Point(-17, 0);
            this.pictureDrag1.Name = "pictureDrag1";
            this.pictureDrag1.Size = new System.Drawing.Size(145, 124);
            this.pictureDrag1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureDrag1.TabIndex = 10;
            this.pictureDrag1.TabStop = false;
            this.pictureDrag1.Visible = false;
            // 
            // RdBtnCrop
            // 
            this.RdBtnCrop.AutoSize = true;
            this.RdBtnCrop.Location = new System.Drawing.Point(33, 100);
            this.RdBtnCrop.Name = "RdBtnCrop";
            this.RdBtnCrop.Size = new System.Drawing.Size(85, 17);
            this.RdBtnCrop.TabIndex = 0;
            this.RdBtnCrop.Text = "Crop a video";
            this.RdBtnCrop.UseVisualStyleBackColor = true;
            this.RdBtnCrop.CheckedChanged += new System.EventHandler(this.RdBtnCrop_CheckedChanged);
            // 
            // RdBtnResize
            // 
            this.RdBtnResize.AutoSize = true;
            this.RdBtnResize.Location = new System.Drawing.Point(162, 100);
            this.RdBtnResize.Name = "RdBtnResize";
            this.RdBtnResize.Size = new System.Drawing.Size(95, 17);
            this.RdBtnResize.TabIndex = 0;
            this.RdBtnResize.Text = "Resize a video";
            this.RdBtnResize.UseVisualStyleBackColor = true;
            this.RdBtnResize.CheckedChanged += new System.EventHandler(this.RdBtnResize_CheckedChanged);
            // 
            // RdBtnAddSub
            // 
            this.RdBtnAddSub.AutoSize = true;
            this.RdBtnAddSub.Location = new System.Drawing.Point(301, 100);
            this.RdBtnAddSub.Name = "RdBtnAddSub";
            this.RdBtnAddSub.Size = new System.Drawing.Size(87, 17);
            this.RdBtnAddSub.TabIndex = 0;
            this.RdBtnAddSub.Text = "Add Subtitles";
            this.RdBtnAddSub.UseVisualStyleBackColor = true;
            this.RdBtnAddSub.CheckedChanged += new System.EventHandler(this.RdBtnAddSub_CheckedChanged);
            // 
            // Others
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RdBtnAddSub);
            this.Controls.Add(this.RdBtnResize);
            this.Controls.Add(this.RdBtnCrop);
            this.Controls.Add(this.labelChoseOptions);
            this.Controls.Add(this.BtnGetInfo);
            this.Controls.Add(this.pictureDrag1);
            this.Name = "Others";
            this.Size = new System.Drawing.Size(420, 124);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Others_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Others_DragEnter);
            this.DragLeave += new System.EventHandler(this.Others_DragLeave);
            ((System.ComponentModel.ISupportInitialize)(this.pictureDrag1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnGetInfo;
        private System.Diagnostics.Process process1;
        private System.Windows.Forms.Label labelChoseOptions;
        private System.Windows.Forms.PictureBox pictureDrag1;
        private System.Windows.Forms.RadioButton RdBtnAddSub;
        private System.Windows.Forms.RadioButton RdBtnResize;
        private System.Windows.Forms.RadioButton RdBtnCrop;
    }
}
