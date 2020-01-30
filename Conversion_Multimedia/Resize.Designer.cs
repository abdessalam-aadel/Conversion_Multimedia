namespace Conversion_Multimedia
{
    partial class Resize
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Resize));
            this.txtBoxH = new System.Windows.Forms.TextBox();
            this.txtBoxW = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnStartResize = new System.Windows.Forms.Button();
            this.txtBoxVideoFilename = new System.Windows.Forms.TextBox();
            this.BtnLoadVideo = new System.Windows.Forms.Button();
            this.pictureDrag4 = new System.Windows.Forms.PictureBox();
            this.panelLoading = new System.Windows.Forms.Panel();
            this.labelWait2 = new System.Windows.Forms.Label();
            this.pictureLoading = new System.Windows.Forms.PictureBox();
            this.labelV = new System.Windows.Forms.Label();
            this.labelVSize = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDrag4)).BeginInit();
            this.panelLoading.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLoading)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBoxH
            // 
            this.txtBoxH.Enabled = false;
            this.txtBoxH.Location = new System.Drawing.Point(88, 100);
            this.txtBoxH.Name = "txtBoxH";
            this.txtBoxH.ShortcutsEnabled = false;
            this.txtBoxH.Size = new System.Drawing.Size(114, 20);
            this.txtBoxH.TabIndex = 15;
            this.txtBoxH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxH_KeyPress);
            // 
            // txtBoxW
            // 
            this.txtBoxW.Enabled = false;
            this.txtBoxW.Location = new System.Drawing.Point(88, 73);
            this.txtBoxW.Name = "txtBoxW";
            this.txtBoxW.ShortcutsEnabled = false;
            this.txtBoxW.Size = new System.Drawing.Size(114, 20);
            this.txtBoxW.TabIndex = 14;
            this.txtBoxW.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxW_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.DarkGreen;
            this.label4.Location = new System.Drawing.Point(38, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Height :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(38, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Width :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(180, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Resize";
            // 
            // BtnStartResize
            // 
            this.BtnStartResize.BackColor = System.Drawing.Color.DarkSlateGray;
            this.BtnStartResize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnStartResize.Enabled = false;
            this.BtnStartResize.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnStartResize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnStartResize.ForeColor = System.Drawing.Color.White;
            this.BtnStartResize.Location = new System.Drawing.Point(308, 73);
            this.BtnStartResize.Name = "BtnStartResize";
            this.BtnStartResize.Size = new System.Drawing.Size(75, 47);
            this.BtnStartResize.TabIndex = 16;
            this.BtnStartResize.Text = "Start";
            this.BtnStartResize.UseVisualStyleBackColor = false;
            this.BtnStartResize.Click += new System.EventHandler(this.BtnStartResize_Click);
            // 
            // txtBoxVideoFilename
            // 
            this.txtBoxVideoFilename.Location = new System.Drawing.Point(41, 43);
            this.txtBoxVideoFilename.Name = "txtBoxVideoFilename";
            this.txtBoxVideoFilename.ReadOnly = true;
            this.txtBoxVideoFilename.Size = new System.Drawing.Size(261, 20);
            this.txtBoxVideoFilename.TabIndex = 0;
            this.txtBoxVideoFilename.TabStop = false;
            this.txtBoxVideoFilename.Text = "Chose your video file ...";
            // 
            // BtnLoadVideo
            // 
            this.BtnLoadVideo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLoadVideo.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.BtnLoadVideo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.BtnLoadVideo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLoadVideo.Location = new System.Drawing.Point(307, 42);
            this.BtnLoadVideo.Name = "BtnLoadVideo";
            this.BtnLoadVideo.Size = new System.Drawing.Size(75, 22);
            this.BtnLoadVideo.TabIndex = 0;
            this.BtnLoadVideo.TabStop = false;
            this.BtnLoadVideo.Text = "...";
            this.BtnLoadVideo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnLoadVideo.UseVisualStyleBackColor = true;
            this.BtnLoadVideo.Click += new System.EventHandler(this.BtnLoadVideo_Click);
            // 
            // pictureDrag4
            // 
            this.pictureDrag4.BackColor = System.Drawing.Color.Transparent;
            this.pictureDrag4.Image = ((System.Drawing.Image)(resources.GetObject("pictureDrag4.Image")));
            this.pictureDrag4.Location = new System.Drawing.Point(3, 30);
            this.pictureDrag4.Name = "pictureDrag4";
            this.pictureDrag4.Size = new System.Drawing.Size(414, 91);
            this.pictureDrag4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureDrag4.TabIndex = 22;
            this.pictureDrag4.TabStop = false;
            this.pictureDrag4.Visible = false;
            // 
            // panelLoading
            // 
            this.panelLoading.Controls.Add(this.labelWait2);
            this.panelLoading.Controls.Add(this.pictureLoading);
            this.panelLoading.Location = new System.Drawing.Point(0, 29);
            this.panelLoading.Name = "panelLoading";
            this.panelLoading.Size = new System.Drawing.Size(420, 92);
            this.panelLoading.TabIndex = 0;
            this.panelLoading.Visible = false;
            // 
            // labelWait2
            // 
            this.labelWait2.AutoSize = true;
            this.labelWait2.BackColor = System.Drawing.Color.Transparent;
            this.labelWait2.ForeColor = System.Drawing.Color.DimGray;
            this.labelWait2.Location = new System.Drawing.Point(156, 75);
            this.labelWait2.Name = "labelWait2";
            this.labelWait2.Size = new System.Drawing.Size(113, 13);
            this.labelWait2.TabIndex = 22;
            this.labelWait2.Text = "Loading please wait ...";
            // 
            // pictureLoading
            // 
            this.pictureLoading.Image = ((System.Drawing.Image)(resources.GetObject("pictureLoading.Image")));
            this.pictureLoading.Location = new System.Drawing.Point(98, 7);
            this.pictureLoading.Name = "pictureLoading";
            this.pictureLoading.Size = new System.Drawing.Size(225, 65);
            this.pictureLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureLoading.TabIndex = 21;
            this.pictureLoading.TabStop = false;
            // 
            // labelV
            // 
            this.labelV.AutoSize = true;
            this.labelV.Location = new System.Drawing.Point(206, 83);
            this.labelV.Name = "labelV";
            this.labelV.Size = new System.Drawing.Size(96, 13);
            this.labelV.TabIndex = 0;
            this.labelV.Text = "Origine video size :";
            // 
            // labelVSize
            // 
            this.labelVSize.AutoSize = true;
            this.labelVSize.ForeColor = System.Drawing.Color.DimGray;
            this.labelVSize.Location = new System.Drawing.Point(206, 101);
            this.labelVSize.Name = "labelVSize";
            this.labelVSize.Size = new System.Drawing.Size(30, 13);
            this.labelVSize.TabIndex = 0;
            this.labelVSize.Text = "...x...";
            // 
            // Resize
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtBoxH);
            this.Controls.Add(this.txtBoxVideoFilename);
            this.Controls.Add(this.BtnLoadVideo);
            this.Controls.Add(this.BtnStartResize);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelVSize);
            this.Controls.Add(this.labelV);
            this.Controls.Add(this.txtBoxW);
            this.Controls.Add(this.pictureDrag4);
            this.Controls.Add(this.panelLoading);
            this.Name = "Resize";
            this.Size = new System.Drawing.Size(420, 124);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Resize_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Resize_DragEnter);
            this.DragLeave += new System.EventHandler(this.Resize_DragLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Resize_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pictureDrag4)).EndInit();
            this.panelLoading.ResumeLayout(false);
            this.panelLoading.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLoading)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxH;
        private System.Windows.Forms.TextBox txtBoxW;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnStartResize;
        private System.Windows.Forms.TextBox txtBoxVideoFilename;
        private System.Windows.Forms.Button BtnLoadVideo;
        private System.Windows.Forms.PictureBox pictureDrag4;
        private System.Windows.Forms.Panel panelLoading;
        private System.Windows.Forms.Label labelWait2;
        private System.Windows.Forms.PictureBox pictureLoading;
        private System.Windows.Forms.Label labelV;
        private System.Windows.Forms.Label labelVSize;
    }
}
