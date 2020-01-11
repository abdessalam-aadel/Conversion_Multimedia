namespace Conversion_Multimedia
{
    partial class ConversionMultimediaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConversionMultimediaForm));
            this.BtnBackHome = new System.Windows.Forms.Button();
            this.btnLetsGo = new System.Windows.Forms.Button();
            this.labelOfTypes = new System.Windows.Forms.Label();
            this.BtnOthers = new System.Windows.Forms.Button();
            this.BtnNext = new System.Windows.Forms.Button();
            this.BtnBack = new System.Windows.Forms.Button();
            this.labelFooter1 = new System.Windows.Forms.Label();
            this.labelFooter2 = new System.Windows.Forms.Label();
            this.addSubtitles1 = new Conversion_Multimedia.AddSubtitles();
            this.resize1 = new Conversion_Multimedia.Resize();
            this.crop1 = new Conversion_Multimedia.Crop();
            this.others1 = new Conversion_Multimedia.Others();
            this.choseFile1 = new Conversion_Multimedia.ChoseFile();
            this.startConversion1 = new Conversion_Multimedia.StartConversion();
            this.SuspendLayout();
            // 
            // BtnBackHome
            // 
            this.BtnBackHome.BackColor = System.Drawing.SystemColors.Control;
            this.BtnBackHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBackHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBackHome.Location = new System.Drawing.Point(10, 142);
            this.BtnBackHome.Name = "BtnBackHome";
            this.BtnBackHome.Size = new System.Drawing.Size(90, 21);
            this.BtnBackHome.TabIndex = 0;
            this.BtnBackHome.Text = "Back to Home";
            this.BtnBackHome.UseVisualStyleBackColor = false;
            this.BtnBackHome.Visible = false;
            this.BtnBackHome.Click += new System.EventHandler(this.BtnBackHome_Click);
            // 
            // btnLetsGo
            // 
            this.btnLetsGo.BackColor = System.Drawing.SystemColors.Control;
            this.btnLetsGo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLetsGo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLetsGo.Location = new System.Drawing.Point(171, 141);
            this.btnLetsGo.Name = "btnLetsGo";
            this.btnLetsGo.Size = new System.Drawing.Size(103, 21);
            this.btnLetsGo.TabIndex = 7;
            this.btnLetsGo.Text = "Let\'s Go";
            this.btnLetsGo.UseVisualStyleBackColor = false;
            this.btnLetsGo.Click += new System.EventHandler(this.btnLetsGo_Click);
            // 
            // labelOfTypes
            // 
            this.labelOfTypes.AutoSize = true;
            this.labelOfTypes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOfTypes.ForeColor = System.Drawing.Color.OrangeRed;
            this.labelOfTypes.Location = new System.Drawing.Point(149, 144);
            this.labelOfTypes.Name = "labelOfTypes";
            this.labelOfTypes.Size = new System.Drawing.Size(20, 16);
            this.labelOfTypes.TabIndex = 8;
            this.labelOfTypes.Text = "...";
            this.labelOfTypes.Visible = false;
            // 
            // BtnOthers
            // 
            this.BtnOthers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnOthers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOthers.ForeColor = System.Drawing.Color.Teal;
            this.BtnOthers.Location = new System.Drawing.Point(280, 140);
            this.BtnOthers.Name = "BtnOthers";
            this.BtnOthers.Size = new System.Drawing.Size(74, 23);
            this.BtnOthers.TabIndex = 11;
            this.BtnOthers.Text = "Others ...";
            this.BtnOthers.UseVisualStyleBackColor = true;
            this.BtnOthers.Click += new System.EventHandler(this.BtnOthers_Click);
            // 
            // BtnNext
            // 
            this.BtnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNext.ForeColor = System.Drawing.Color.Green;
            this.BtnNext.Location = new System.Drawing.Point(360, 140);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Size = new System.Drawing.Size(75, 23);
            this.BtnNext.TabIndex = 13;
            this.BtnNext.Text = "Next";
            this.BtnNext.UseVisualStyleBackColor = true;
            this.BtnNext.Visible = false;
            this.BtnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // BtnBack
            // 
            this.BtnBack.BackColor = System.Drawing.SystemColors.Control;
            this.BtnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBack.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.BtnBack.Location = new System.Drawing.Point(106, 142);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(44, 21);
            this.BtnBack.TabIndex = 17;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = false;
            this.BtnBack.Visible = false;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // labelFooter1
            // 
            this.labelFooter1.AutoSize = true;
            this.labelFooter1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFooter1.ForeColor = System.Drawing.Color.DimGray;
            this.labelFooter1.Location = new System.Drawing.Point(3, 172);
            this.labelFooter1.Name = "labelFooter1";
            this.labelFooter1.Size = new System.Drawing.Size(155, 13);
            this.labelFooter1.TabIndex = 18;
            this.labelFooter1.Text = "© 2020 Conversion Multimedia.";
            // 
            // labelFooter2
            // 
            this.labelFooter2.AutoSize = true;
            this.labelFooter2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFooter2.ForeColor = System.Drawing.Color.DimGray;
            this.labelFooter2.Location = new System.Drawing.Point(336, 172);
            this.labelFooter2.Name = "labelFooter2";
            this.labelFooter2.Size = new System.Drawing.Size(105, 13);
            this.labelFooter2.TabIndex = 19;
            this.labelFooter2.Text = "Abdessalam AADEL.";
            // 
            // addSubtitles1
            // 
            this.addSubtitles1.Location = new System.Drawing.Point(10, 10);
            this.addSubtitles1.Name = "addSubtitles1";
            this.addSubtitles1.Size = new System.Drawing.Size(420, 124);
            this.addSubtitles1.TabIndex = 16;
            // 
            // resize1
            // 
            this.resize1.Location = new System.Drawing.Point(10, 10);
            this.resize1.Name = "resize1";
            this.resize1.Size = new System.Drawing.Size(420, 124);
            this.resize1.TabIndex = 15;
            // 
            // crop1
            // 
            this.crop1.Location = new System.Drawing.Point(10, 10);
            this.crop1.Name = "crop1";
            this.crop1.Size = new System.Drawing.Size(420, 124);
            this.crop1.TabIndex = 14;
            // 
            // others1
            // 
            this.others1.Location = new System.Drawing.Point(12, 10);
            this.others1.Name = "others1";
            this.others1.Size = new System.Drawing.Size(420, 124);
            this.others1.TabIndex = 12;
            // 
            // choseFile1
            // 
            this.choseFile1.Location = new System.Drawing.Point(12, 11);
            this.choseFile1.Name = "choseFile1";
            this.choseFile1.Size = new System.Drawing.Size(420, 124);
            this.choseFile1.TabIndex = 10;
            // 
            // startConversion1
            // 
            this.startConversion1.Location = new System.Drawing.Point(12, 11);
            this.startConversion1.Name = "startConversion1";
            this.startConversion1.Size = new System.Drawing.Size(420, 124);
            this.startConversion1.TabIndex = 9;
            // 
            // ConversionMultimediaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 188);
            this.Controls.Add(this.labelFooter2);
            this.Controls.Add(this.labelFooter1);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.addSubtitles1);
            this.Controls.Add(this.resize1);
            this.Controls.Add(this.crop1);
            this.Controls.Add(this.BtnNext);
            this.Controls.Add(this.others1);
            this.Controls.Add(this.BtnOthers);
            this.Controls.Add(this.choseFile1);
            this.Controls.Add(this.startConversion1);
            this.Controls.Add(this.labelOfTypes);
            this.Controls.Add(this.btnLetsGo);
            this.Controls.Add(this.BtnBackHome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "ConversionMultimediaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conversion Multimedia";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ConversionMultimediaForm_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnBackHome;
        private System.Windows.Forms.Button btnLetsGo;
        private System.Windows.Forms.Label labelOfTypes;
        private StartConversion startConversion1;
        private ChoseFile choseFile1;
        private System.Windows.Forms.Button BtnOthers;
        private Others others1;
        private System.Windows.Forms.Button BtnNext;
        private Crop crop1;
        private Resize resize1;
        private AddSubtitles addSubtitles1;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Label labelFooter1;
        private System.Windows.Forms.Label labelFooter2;
    }
}

