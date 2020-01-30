using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Drawing;

namespace Conversion_Multimedia
{
    public partial class Others : UserControl
    {
        public string OptionsChecked;

        // passing value of type convertion from Form to userControl (ChoseFile.cs)
        public string SetOptionsIsChecked => OptionsChecked;
        // passing value of type convertion from Form to userControl (Others.cs)
        public Others() => InitializeComponent();

        // Customize Open file dialog 
        OpenFileDialog ofd = new OpenFileDialog
        {
            InitialDirectory = "C:/",
            RestoreDirectory = true,
            Title = "Chose your video file"
        };

        // Handle Event click of Button Get info : to Get information from a video file
        private void BtnGetInfo_Click(object sender, EventArgs e)
        {
            try
            {
                ofd.Filter = "Videos Files (*.mp4, *.avi, *.flv, *.wav, *.mpg, *.mpeg, *.mkv) | *.mp4; *.avi; *.flv; *.wav; *.mpg; *.mpeg; *.mkv";
                DialogResult result = ofd.ShowDialog();
                if (result == DialogResult.OK)
                    RunProcess(" -i " + "\"" + ofd.FileName + "\"");
                else
                    return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                ChangeToDefault();
            }
        }

        // Activate Drag & Drop in Others.cs
        private void Others_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
            pictureDrag1.Visible = true;
            BtnGetInfo.BackColor = Color.OrangeRed;
        }

        private void Others_DragLeave(object sender, EventArgs e)
        {
            pictureDrag1.Visible = false;
            BtnGetInfo.BackColor = SystemColors.Control;
        }

        private void Others_DragDrop(object sender, DragEventArgs e)
        {
            BtnGetInfo.BackColor = SystemColors.Control;
            pictureDrag1.Visible = false;
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            FileInfo finfo = new FileInfo(files[0]);
            string fileExtension = finfo.Extension;
            switch (fileExtension)
            {
                case ".mp4":
                case ".mov":
                case ".m4a":
                case ".3gp":
                case ".3g2":
                case ".mj2":
                    RunProcess(" -i " + "\"" + finfo.FullName + "\"");
                    break;
            }
        }

        // Run Process
        private void RunProcess(string Argument)
        {
            string ffmpeg;
            // Start Condition : if you have win32 or win64
            if (Environment.Is64BitOperatingSystem)
                ffmpeg = @"tools\x64\bin\ffmpeg.exe"; // path of FFmpeg tools for win32
            else
                ffmpeg = @"tools\x32\bin\ffmpeg.exe"; // path of FFmpeg tools for win64

            //create a process info
            ProcessStartInfo oInfo = new ProcessStartInfo(ffmpeg, Argument)
            {
                UseShellExecute = false,
                CreateNoWindow = true,
                RedirectStandardOutput = true,
                RedirectStandardError = true
            };
            //Create the output and streamreader to get the output
            string output = null; StreamReader srOutput = null;
            //try the process
            try
            {
                //run the process
                Process p = Process.Start(oInfo);
                p.WaitForExit();
                //get the output
                srOutput = p.StandardError;
                //put it in a string
                output = srOutput.ReadToEnd();
                p.Close();
            }
            catch (Exception)
            {
                output = string.Empty;
            }
            finally
            {
                //if we succeded, Dispose the streamreader
                srOutput?.Dispose();
            }
            FrmInfo frmInfo = new FrmInfo();
            frmInfo.GetValue(output);
            frmInfo.ShowDialog();
            ChangeToDefault();
        }
        
        // Change to default
        public void ChangeToDefault()
        {
            Cursor = DefaultCursor;
            ofd.FileName = "";
        }

        // -- Start -- Handle event Checked Changed for Radio Button
        private void RdBtnAddSub_CheckedChanged(object sender, EventArgs e)
        {
            if (RdBtnAddSub.Checked)
                OptionsChecked = "Add Subtitles";
        }
        private void RdBtnResize_CheckedChanged(object sender, EventArgs e)
        {
            if (RdBtnResize.Checked)
                OptionsChecked = "Resize";
        }
        private void RdBtnCrop_CheckedChanged(object sender, EventArgs e)
        {
            if (RdBtnCrop.Checked)
                OptionsChecked = "Crop";
        }
        // -- End -- Handle event Checked Changed for Radio Button
    }
}
