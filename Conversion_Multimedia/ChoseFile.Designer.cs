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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChoseFile));
            this.BtnLoad = new System.Windows.Forms.Button();
            this.BtnStart = new System.Windows.Forms.Button();
            this.txtboxFileName = new System.Windows.Forms.TextBox();
            this.rtxtboxCmd = new System.Windows.Forms.RichTextBox();
            this.labelFilename = new System.Windows.Forms.Label();
            this.pictureDrag3 = new System.Windows.Forms.PictureBox();
            this.panelLoading = new System.Windows.Forms.Panel();
            this.labelWait2 = new System.Windows.Forms.Label();
            this.pictureLoading = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDrag3)).BeginInit();
            this.panelLoading.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLoading)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnLoad
            // 
            this.BtnLoad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLoad.Location = new System.Drawing.Point(332, 11);
            this.BtnLoad.Name = "BtnLoad";
            this.BtnLoad.Size = new System.Drawing.Size(75, 23);
            this.BtnLoad.TabIndex = 0;
            this.BtnLoad.TabStop = false;
            this.BtnLoad.Text = "Load File";
            this.BtnLoad.UseVisualStyleBackColor = true;
            this.BtnLoad.Click += new System.EventHandler(this.BtnLoad_Click);
            // 
            // BtnStart
            // 
            this.BtnStart.BackColor = System.Drawing.Color.ForestGreen;
            this.BtnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnStart.Enabled = false;
            this.BtnStart.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnStart.ForeColor = System.Drawing.Color.White;
            this.BtnStart.Location = new System.Drawing.Point(332, 55);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(75, 63);
            this.BtnStart.TabIndex = 0;
            this.BtnStart.TabStop = false;
            this.BtnStart.Text = "Start";
            this.BtnStart.UseVisualStyleBackColor = false;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // txtboxFileName
            // 
            this.txtboxFileName.Location = new System.Drawing.Point(14, 12);
            this.txtboxFileName.Name = "txtboxFileName";
            this.txtboxFileName.ReadOnly = true;
            this.txtboxFileName.Size = new System.Drawing.Size(312, 20);
            this.txtboxFileName.TabIndex = 0;
            this.txtboxFileName.TabStop = false;
            this.txtboxFileName.Text = "Chose your file ...";
            // 
            // rtxtboxCmd
            // 
            this.rtxtboxCmd.BackColor = System.Drawing.Color.DarkSlateGray;
            this.rtxtboxCmd.ForeColor = System.Drawing.SystemColors.Window;
            this.rtxtboxCmd.Location = new System.Drawing.Point(14, 55);
            this.rtxtboxCmd.Name = "rtxtboxCmd";
            this.rtxtboxCmd.ReadOnly = true;
            this.rtxtboxCmd.Size = new System.Drawing.Size(312, 64);
            this.rtxtboxCmd.TabIndex = 0;
            this.rtxtboxCmd.TabStop = false;
            this.rtxtboxCmd.Text = "";
            // 
            // labelFilename
            // 
            this.labelFilename.AutoSize = true;
            this.labelFilename.Location = new System.Drawing.Point(14, 35);
            this.labelFilename.Name = "labelFilename";
            this.labelFilename.Size = new System.Drawing.Size(16, 13);
            this.labelFilename.TabIndex = 0;
            this.labelFilename.Text = "...";
            // 
            // pictureDrag3
            // 
            this.pictureDrag3.BackColor = System.Drawing.Color.Transparent;
            this.pictureDrag3.Image = ((System.Drawing.Image)(resources.GetObject("pictureDrag3.Image")));
            this.pictureDrag3.Location = new System.Drawing.Point(16, 59);
            this.pictureDrag3.Name = "pictureDrag3";
            this.pictureDrag3.Size = new System.Drawing.Size(95, 55);
            this.pictureDrag3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureDrag3.TabIndex = 6;
            this.pictureDrag3.TabStop = false;
            this.pictureDrag3.Visible = false;
            // 
            // panelLoading
            // 
            this.panelLoading.Controls.Add(this.labelWait2);
            this.panelLoading.Controls.Add(this.pictureLoading);
            this.panelLoading.Location = new System.Drawing.Point(14, 35);
            this.panelLoading.Name = "panelLoading";
            this.panelLoading.Size = new System.Drawing.Size(312, 95);
            this.panelLoading.TabIndex = 0;
            this.panelLoading.Visible = false;
            // 
            // labelWait2
            // 
            this.labelWait2.AutoSize = true;
            this.labelWait2.BackColor = System.Drawing.Color.Transparent;
            this.labelWait2.ForeColor = System.Drawing.Color.DimGray;
            this.labelWait2.Location = new System.Drawing.Point(101, 73);
            this.labelWait2.Name = "labelWait2";
            this.labelWait2.Size = new System.Drawing.Size(113, 13);
            this.labelWait2.TabIndex = 22;
            this.labelWait2.Text = "Loading please wait ...";
            // 
            // pictureLoading
            // 
            this.pictureLoading.Image = ((System.Drawing.Image)(resources.GetObject("pictureLoading.Image")));
            this.pictureLoading.Location = new System.Drawing.Point(45, 5);
            this.pictureLoading.Name = "pictureLoading";
            this.pictureLoading.Size = new System.Drawing.Size(225, 65);
            this.pictureLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureLoading.TabIndex = 21;
            this.pictureLoading.TabStop = false;
            // 
            // ChoseFile
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelLoading);
            this.Controls.Add(this.pictureDrag3);
            this.Controls.Add(this.labelFilename);
            this.Controls.Add(this.rtxtboxCmd);
            this.Controls.Add(this.txtboxFileName);
            this.Controls.Add(this.BtnStart);
            this.Controls.Add(this.BtnLoad);
            this.Name = "ChoseFile";
            this.Size = new System.Drawing.Size(420, 124);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.ChoseFile_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.ChoseFile_DragEnter);
            this.DragLeave += new System.EventHandler(this.ChoseFile_DragLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ChoseFile_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pictureDrag3)).EndInit();
            this.panelLoading.ResumeLayout(false);
            this.panelLoading.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLoading)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnLoad;
        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.TextBox txtboxFileName;
        private System.Windows.Forms.RichTextBox rtxtboxCmd;
        private System.Windows.Forms.Label labelFilename;
        private System.Windows.Forms.PictureBox pictureDrag3;
        private System.Windows.Forms.Panel panelLoading;
        private System.Windows.Forms.Label labelWait2;
        private System.Windows.Forms.PictureBox pictureLoading;
    }
}
