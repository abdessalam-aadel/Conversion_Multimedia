namespace Conversion_Multimedia
{
    partial class StartConversion
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
            this.labelChose = new System.Windows.Forms.Label();
            this.ComboBoxTypes = new System.Windows.Forms.ComboBox();
            this.labelStart = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // labelChose
            // 
            this.labelChose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelChose.AutoSize = true;
            this.labelChose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChose.Location = new System.Drawing.Point(141, 58);
            this.labelChose.Name = "labelChose";
            this.labelChose.Size = new System.Drawing.Size(138, 16);
            this.labelChose.TabIndex = 0;
            this.labelChose.Text = "Chose your methode :";
            // 
            // ComboBoxTypes
            // 
            this.ComboBoxTypes.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.ComboBoxTypes.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ComboBoxTypes.Location = new System.Drawing.Point(116, 93);
            this.ComboBoxTypes.MaxDropDownItems = 10;
            this.ComboBoxTypes.Name = "ComboBoxTypes";
            this.ComboBoxTypes.Size = new System.Drawing.Size(188, 21);
            this.ComboBoxTypes.TabIndex = 0;
            this.ComboBoxTypes.TabStop = false;
            // 
            // labelStart
            // 
            this.labelStart.AutoSize = true;
            this.labelStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStart.ForeColor = System.Drawing.Color.OrangeRed;
            this.labelStart.Location = new System.Drawing.Point(119, 26);
            this.labelStart.Name = "labelStart";
            this.labelStart.Size = new System.Drawing.Size(182, 20);
            this.labelStart.TabIndex = 8;
            this.labelStart.Text = "Start your Conversion";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Location = new System.Drawing.Point(19, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(13, 88);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Location = new System.Drawing.Point(32, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(13, 88);
            this.panel2.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkGray;
            this.panel3.Location = new System.Drawing.Point(45, 26);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(13, 88);
            this.panel3.TabIndex = 11;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Silver;
            this.panel4.Location = new System.Drawing.Point(58, 26);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(13, 88);
            this.panel4.TabIndex = 12;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DimGray;
            this.panel5.Location = new System.Drawing.Point(389, 26);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(13, 88);
            this.panel5.TabIndex = 16;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Gray;
            this.panel6.Location = new System.Drawing.Point(376, 26);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(13, 88);
            this.panel6.TabIndex = 15;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.DarkGray;
            this.panel7.Location = new System.Drawing.Point(363, 26);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(13, 88);
            this.panel7.TabIndex = 14;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Silver;
            this.panel8.Location = new System.Drawing.Point(350, 26);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(13, 88);
            this.panel8.TabIndex = 13;
            // 
            // StartConversion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelStart);
            this.Controls.Add(this.ComboBoxTypes);
            this.Controls.Add(this.labelChose);
            this.Name = "StartConversion";
            this.Size = new System.Drawing.Size(420, 124);
            this.Load += new System.EventHandler(this.StartConversion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelChose;
        private System.Windows.Forms.ComboBox ComboBoxTypes;
        private System.Windows.Forms.Label labelStart;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
    }
}
