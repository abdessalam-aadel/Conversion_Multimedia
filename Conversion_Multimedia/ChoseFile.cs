using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Conversion_Multimedia
{
    public partial class ChoseFile : UserControl
    {
        public ChoseFile()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Videos files|*.mp4";
            ofd.DefaultExt = "mp4";
            ofd.InitialDirectory = "C:/";
            ofd.RestoreDirectory = true;
            ofd.Title = "Chose your file";
            DialogResult result = ofd.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtboxFileName.Text = ofd.FileName;
                btnStart.Enabled = true;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            btnStart.Enabled = false;
            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.RedirectStandardInput = true;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.UseShellExecute = false;
            process.Start();
            process.StandardInput.WriteLine("ffmpeg -i "
                + txtboxFileName.Text 
                +" output_"
                +DateTime.Now.DayOfYear.ToString()
                +".avi");
            process.StandardInput.Flush();
            process.StandardInput.Close();
            process.WaitForExit();
            rtxtboxCmd.Text = process.StandardOutput.ReadToEnd();
            this.Cursor = DefaultCursor;

        }
    }
}
