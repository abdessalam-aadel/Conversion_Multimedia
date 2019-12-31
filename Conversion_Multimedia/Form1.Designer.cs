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
            this.btnBack = new System.Windows.Forms.Button();
            this.btnLetsGo = new System.Windows.Forms.Button();
            this.labelOfTypes = new System.Windows.Forms.Label();
            this.choseFile1 = new Conversion_Multimedia.ChoseFile();
            this.startConversion1 = new Conversion_Multimedia.StartConversion();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.Control;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Location = new System.Drawing.Point(26, 142);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(58, 21);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Visible = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
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
            this.labelOfTypes.Location = new System.Drawing.Point(124, 144);
            this.labelOfTypes.Name = "labelOfTypes";
            this.labelOfTypes.Size = new System.Drawing.Size(20, 16);
            this.labelOfTypes.TabIndex = 8;
            this.labelOfTypes.Text = "...";
            this.labelOfTypes.Visible = false;
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
            this.ClientSize = new System.Drawing.Size(444, 172);
            this.Controls.Add(this.choseFile1);
            this.Controls.Add(this.startConversion1);
            this.Controls.Add(this.labelOfTypes);
            this.Controls.Add(this.btnLetsGo);
            this.Controls.Add(this.btnBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "ConversionMultimediaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conversion Multimedia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnLetsGo;
        private System.Windows.Forms.Label labelOfTypes;
        private StartConversion startConversion1;
        private ChoseFile choseFile1;
    }
}

