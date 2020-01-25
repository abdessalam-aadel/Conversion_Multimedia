namespace Conversion_Multimedia
{
    partial class AddSubtitles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddSubtitles));
            this.BtnLoadSub = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBoxSubFilename = new System.Windows.Forms.TextBox();
            this.txtBoxVideoFilename = new System.Windows.Forms.TextBox();
            this.BtnLoadVideo = new System.Windows.Forms.Button();
            this.BtnStartAdd = new System.Windows.Forms.Button();
            this.pictureDrag5 = new System.Windows.Forms.PictureBox();
            this.panelLoading = new System.Windows.Forms.Panel();
            this.labelWait2 = new System.Windows.Forms.Label();
            this.pictureLoading = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDrag5)).BeginInit();
            this.panelLoading.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLoading)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnLoadSub
            // 
            this.BtnLoadSub.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLoadSub.Enabled = false;
            this.BtnLoadSub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLoadSub.Location = new System.Drawing.Point(256, 93);
            this.BtnLoadSub.Name = "BtnLoadSub";
            this.BtnLoadSub.Size = new System.Drawing.Size(66, 24);
            this.BtnLoadSub.TabIndex = 0;
            this.BtnLoadSub.TabStop = false;
            this.BtnLoadSub.Text = "...";
            this.BtnLoadSub.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnLoadSub.UseVisualStyleBackColor = true;
            this.BtnLoadSub.Click += new System.EventHandler(this.BtnLoadSub_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.OrangeRed;
            this.label5.Location = new System.Drawing.Point(157, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Add Subtitles";
            // 
            // txtBoxSubFilename
            // 
            this.txtBoxSubFilename.Enabled = false;
            this.txtBoxSubFilename.Location = new System.Drawing.Point(17, 95);
            this.txtBoxSubFilename.Name = "txtBoxSubFilename";
            this.txtBoxSubFilename.ReadOnly = true;
            this.txtBoxSubFilename.Size = new System.Drawing.Size(233, 20);
            this.txtBoxSubFilename.TabIndex = 0;
            this.txtBoxSubFilename.TabStop = false;
            this.txtBoxSubFilename.Text = "Chose your subtitle ...";
            // 
            // txtBoxVideoFilename
            // 
            this.txtBoxVideoFilename.Location = new System.Drawing.Point(17, 64);
            this.txtBoxVideoFilename.Name = "txtBoxVideoFilename";
            this.txtBoxVideoFilename.ReadOnly = true;
            this.txtBoxVideoFilename.Size = new System.Drawing.Size(233, 20);
            this.txtBoxVideoFilename.TabIndex = 0;
            this.txtBoxVideoFilename.TabStop = false;
            this.txtBoxVideoFilename.Text = "Chose your video file ...";
            // 
            // BtnLoadVideo
            // 
            this.BtnLoadVideo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLoadVideo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLoadVideo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLoadVideo.Location = new System.Drawing.Point(256, 62);
            this.BtnLoadVideo.Name = "BtnLoadVideo";
            this.BtnLoadVideo.Size = new System.Drawing.Size(66, 24);
            this.BtnLoadVideo.TabIndex = 0;
            this.BtnLoadVideo.TabStop = false;
            this.BtnLoadVideo.Text = "...";
            this.BtnLoadVideo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnLoadVideo.UseVisualStyleBackColor = true;
            this.BtnLoadVideo.Click += new System.EventHandler(this.BtnLoadVideo_Click);
            // 
            // BtnStartAdd
            // 
            this.BtnStartAdd.BackColor = System.Drawing.Color.LimeGreen;
            this.BtnStartAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnStartAdd.Enabled = false;
            this.BtnStartAdd.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnStartAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnStartAdd.ForeColor = System.Drawing.Color.White;
            this.BtnStartAdd.Location = new System.Drawing.Point(329, 62);
            this.BtnStartAdd.Name = "BtnStartAdd";
            this.BtnStartAdd.Size = new System.Drawing.Size(75, 55);
            this.BtnStartAdd.TabIndex = 0;
            this.BtnStartAdd.TabStop = false;
            this.BtnStartAdd.Text = "Start";
            this.BtnStartAdd.UseVisualStyleBackColor = false;
            this.BtnStartAdd.Click += new System.EventHandler(this.BtnStartAdd_Click);
            // 
            // pictureDrag5
            // 
            this.pictureDrag5.Image = ((System.Drawing.Image)(resources.GetObject("pictureDrag5.Image")));
            this.pictureDrag5.Location = new System.Drawing.Point(3, 30);
            this.pictureDrag5.Name = "pictureDrag5";
            this.pictureDrag5.Size = new System.Drawing.Size(414, 91);
            this.pictureDrag5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureDrag5.TabIndex = 19;
            this.pictureDrag5.TabStop = false;
            this.pictureDrag5.Visible = false;
            // 
            // panelLoading
            // 
            this.panelLoading.Controls.Add(this.labelWait2);
            this.panelLoading.Controls.Add(this.pictureLoading);
            this.panelLoading.Location = new System.Drawing.Point(3, 30);
            this.panelLoading.Name = "panelLoading";
            this.panelLoading.Size = new System.Drawing.Size(414, 91);
            this.panelLoading.TabIndex = 0;
            this.panelLoading.TabStop = true;
            this.panelLoading.Visible = false;
            // 
            // labelWait2
            // 
            this.labelWait2.AutoSize = true;
            this.labelWait2.BackColor = System.Drawing.Color.Transparent;
            this.labelWait2.ForeColor = System.Drawing.Color.DimGray;
            this.labelWait2.Location = new System.Drawing.Point(154, 71);
            this.labelWait2.Name = "labelWait2";
            this.labelWait2.Size = new System.Drawing.Size(113, 13);
            this.labelWait2.TabIndex = 22;
            this.labelWait2.Text = "Loading please wait ...";
            // 
            // pictureLoading
            // 
            this.pictureLoading.Image = ((System.Drawing.Image)(resources.GetObject("pictureLoading.Image")));
            this.pictureLoading.Location = new System.Drawing.Point(95, 3);
            this.pictureLoading.Name = "pictureLoading";
            this.pictureLoading.Size = new System.Drawing.Size(225, 65);
            this.pictureLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureLoading.TabIndex = 21;
            this.pictureLoading.TabStop = false;
            // 
            // AddSubtitles
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelLoading);
            this.Controls.Add(this.BtnStartAdd);
            this.Controls.Add(this.txtBoxVideoFilename);
            this.Controls.Add(this.BtnLoadVideo);
            this.Controls.Add(this.txtBoxSubFilename);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BtnLoadSub);
            this.Controls.Add(this.pictureDrag5);
            this.Name = "AddSubtitles";
            this.Size = new System.Drawing.Size(420, 124);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.AddSubtitles_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.AddSubtitles_DragEnter);
            this.DragLeave += new System.EventHandler(this.AddSubtitles_DragLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AddSubtitles_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pictureDrag5)).EndInit();
            this.panelLoading.ResumeLayout(false);
            this.panelLoading.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLoading)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnLoadSub;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBoxSubFilename;
        private System.Windows.Forms.TextBox txtBoxVideoFilename;
        private System.Windows.Forms.Button BtnLoadVideo;
        private System.Windows.Forms.Button BtnStartAdd;
        private System.Windows.Forms.PictureBox pictureDrag5;
        private System.Windows.Forms.Panel panelLoading;
        private System.Windows.Forms.PictureBox pictureLoading;
        private System.Windows.Forms.Label labelWait2;
    }
}
