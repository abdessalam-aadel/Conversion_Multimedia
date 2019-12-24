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
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.progressBar1 = new Conversion_Multimedia.ProgressBar();
            this.choseFile1 = new Conversion_Multimedia.ChoseFile();
            this.startConversion = new Conversion_Multimedia.StartConversion();
            this.SuspendLayout();
            // 
            // comboBox
            // 
            this.comboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Items.AddRange(new object[] {
            "Extract sound from video",
            ".wav to .mp3",
            ".avi to .mpg",
            ".mpg to .avi",
            ".avi to .flv",
            ".avi to .gif",
            ".avi to .dv",
            ".avi to .mpeg",
            ".avi to .mp4"});
            this.comboBox.Location = new System.Drawing.Point(135, 196);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(178, 21);
            this.comboBox.TabIndex = 4;
            this.comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(14, 6);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(420, 183);
            this.progressBar1.TabIndex = 7;
            // 
            // choseFile1
            // 
            this.choseFile1.Location = new System.Drawing.Point(14, 6);
            this.choseFile1.Name = "choseFile1";
            this.choseFile1.Size = new System.Drawing.Size(420, 183);
            this.choseFile1.TabIndex = 6;
            // 
            // startConversion
            // 
            this.startConversion.Location = new System.Drawing.Point(14, 7);
            this.startConversion.Name = "startConversion";
            this.startConversion.Size = new System.Drawing.Size(420, 183);
            this.startConversion.TabIndex = 5;
            // 
            // ConversionMultimediaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 230);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.choseFile1);
            this.Controls.Add(this.startConversion);
            this.Controls.Add(this.comboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "ConversionMultimediaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conversion Multimedia";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox;
        private StartConversion startConversion;
        private ChoseFile choseFile1;
        private ProgressBar progressBar1;
    }
}

