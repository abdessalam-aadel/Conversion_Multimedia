namespace Conversion_Multimedia
{
    partial class Crop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Crop));
            this.txtBoxX = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxY = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxH = new System.Windows.Forms.TextBox();
            this.txtBoxW = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBoxVideoFilename = new System.Windows.Forms.TextBox();
            this.BtnLoadVideo = new System.Windows.Forms.Button();
            this.btnStartCrop = new System.Windows.Forms.Button();
            this.pictureDrag2 = new System.Windows.Forms.PictureBox();
            this.panelLoading = new System.Windows.Forms.Panel();
            this.labelWait2 = new System.Windows.Forms.Label();
            this.pictureLoading = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDrag2)).BeginInit();
            this.panelLoading.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLoading)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBoxX
            // 
            this.txtBoxX.Enabled = false;
            this.txtBoxX.Location = new System.Drawing.Point(38, 72);
            this.txtBoxX.Name = "txtBoxX";
            this.txtBoxX.ShortcutsEnabled = false;
            this.txtBoxX.Size = new System.Drawing.Size(114, 20);
            this.txtBoxX.TabIndex = 9;
            this.txtBoxX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxX_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "X :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Y :";
            // 
            // txtBoxY
            // 
            this.txtBoxY.Enabled = false;
            this.txtBoxY.Location = new System.Drawing.Point(38, 101);
            this.txtBoxY.Name = "txtBoxY";
            this.txtBoxY.ShortcutsEnabled = false;
            this.txtBoxY.Size = new System.Drawing.Size(114, 20);
            this.txtBoxY.TabIndex = 10;
            this.txtBoxY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxY_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(163, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Width :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(163, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Height :";
            // 
            // txtBoxH
            // 
            this.txtBoxH.Enabled = false;
            this.txtBoxH.Location = new System.Drawing.Point(211, 100);
            this.txtBoxH.Name = "txtBoxH";
            this.txtBoxH.ShortcutsEnabled = false;
            this.txtBoxH.Size = new System.Drawing.Size(114, 20);
            this.txtBoxH.TabIndex = 12;
            this.txtBoxH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxH_KeyPress);
            // 
            // txtBoxW
            // 
            this.txtBoxW.Enabled = false;
            this.txtBoxW.Location = new System.Drawing.Point(211, 71);
            this.txtBoxW.Name = "txtBoxW";
            this.txtBoxW.ShortcutsEnabled = false;
            this.txtBoxW.Size = new System.Drawing.Size(114, 20);
            this.txtBoxW.TabIndex = 11;
            this.txtBoxW.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxW_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.OrangeRed;
            this.label5.Location = new System.Drawing.Point(98, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(224, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Crop from the top left corner";
            // 
            // txtBoxVideoFilename
            // 
            this.txtBoxVideoFilename.Location = new System.Drawing.Point(15, 41);
            this.txtBoxVideoFilename.Name = "txtBoxVideoFilename";
            this.txtBoxVideoFilename.ReadOnly = true;
            this.txtBoxVideoFilename.Size = new System.Drawing.Size(310, 20);
            this.txtBoxVideoFilename.TabIndex = 0;
            this.txtBoxVideoFilename.TabStop = false;
            this.txtBoxVideoFilename.Text = "Chose your video file ...";
            // 
            // BtnLoadVideo
            // 
            this.BtnLoadVideo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLoadVideo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLoadVideo.Location = new System.Drawing.Point(331, 40);
            this.BtnLoadVideo.Name = "BtnLoadVideo";
            this.BtnLoadVideo.Size = new System.Drawing.Size(75, 22);
            this.BtnLoadVideo.TabIndex = 0;
            this.BtnLoadVideo.TabStop = false;
            this.BtnLoadVideo.Text = "...";
            this.BtnLoadVideo.UseVisualStyleBackColor = true;
            this.BtnLoadVideo.Click += new System.EventHandler(this.BtnLoadVideo_Click);
            // 
            // btnStartCrop
            // 
            this.btnStartCrop.BackColor = System.Drawing.Color.SeaGreen;
            this.btnStartCrop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStartCrop.Enabled = false;
            this.btnStartCrop.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnStartCrop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartCrop.ForeColor = System.Drawing.Color.White;
            this.btnStartCrop.Location = new System.Drawing.Point(331, 71);
            this.btnStartCrop.Name = "btnStartCrop";
            this.btnStartCrop.Size = new System.Drawing.Size(75, 49);
            this.btnStartCrop.TabIndex = 13;
            this.btnStartCrop.Text = "Start";
            this.btnStartCrop.UseVisualStyleBackColor = false;
            this.btnStartCrop.Click += new System.EventHandler(this.btnStartCrop_Click);
            // 
            // pictureDrag2
            // 
            this.pictureDrag2.BackColor = System.Drawing.Color.Transparent;
            this.pictureDrag2.Image = ((System.Drawing.Image)(resources.GetObject("pictureDrag2.Image")));
            this.pictureDrag2.Location = new System.Drawing.Point(0, 33);
            this.pictureDrag2.Name = "pictureDrag2";
            this.pictureDrag2.Size = new System.Drawing.Size(420, 89);
            this.pictureDrag2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureDrag2.TabIndex = 25;
            this.pictureDrag2.TabStop = false;
            this.pictureDrag2.Visible = false;
            // 
            // panelLoading
            // 
            this.panelLoading.Controls.Add(this.labelWait2);
            this.panelLoading.Controls.Add(this.pictureLoading);
            this.panelLoading.Location = new System.Drawing.Point(0, 29);
            this.panelLoading.Name = "panelLoading";
            this.panelLoading.Size = new System.Drawing.Size(420, 95);
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
            // Crop
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBoxVideoFilename);
            this.Controls.Add(this.txtBoxY);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxX);
            this.Controls.Add(this.txtBoxH);
            this.Controls.Add(this.txtBoxW);
            this.Controls.Add(this.btnStartCrop);
            this.Controls.Add(this.BtnLoadVideo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureDrag2);
            this.Controls.Add(this.panelLoading);
            this.Name = "Crop";
            this.Size = new System.Drawing.Size(420, 124);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Crop_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Crop_DragEnter);
            this.DragLeave += new System.EventHandler(this.Crop_DragLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Crop_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pictureDrag2)).EndInit();
            this.panelLoading.ResumeLayout(false);
            this.panelLoading.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLoading)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxY;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxH;
        private System.Windows.Forms.TextBox txtBoxW;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBoxVideoFilename;
        private System.Windows.Forms.Button BtnLoadVideo;
        private System.Windows.Forms.Button btnStartCrop;
        private System.Windows.Forms.PictureBox pictureDrag2;
        private System.Windows.Forms.Panel panelLoading;
        private System.Windows.Forms.Label labelWait2;
        private System.Windows.Forms.PictureBox pictureLoading;
    }
}
