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
                {
                    Cursor = Cursors.WaitCursor;
                    string inputFileName = ofd.FileName;

                    // Start Condition : if you have win32 or win64
                    string ffmpeg;
                    if (Environment.Is64BitOperatingSystem)
                        ffmpeg = @"tools\x64\bin\ffmpeg.exe"; // path of FFmpeg tools for win32
                    else
                        ffmpeg = @"tools\x32\bin\ffmpeg.exe"; // path of FFmpeg tools for win64

                    Process p = process1;
                    p.StartInfo.FileName = ffmpeg;
                    p.StartInfo.Arguments = " -i " + "\"" + inputFileName + "\"";
                    //p.StartInfo.Arguments = " -h"; // for testing ...
                    p.Start();
                    p.BeginOutputReadLine();
                    p.BeginErrorReadLine();
                    //Thread.Sleep(10000); // wait for the process to exit ...
                    MessageBox.Show("Waiting 5 seconde for the process to exit....\n\t   And click OK");
                    p.WaitForExit();
                    if (p.HasExited)
                    {
                        p.CancelErrorRead();
                        p.CancelOutputRead();
                        p.Close();
                    }
                }
                else
                    return;
                FrmInfo frmInfo = new FrmInfo();
                frmInfo.GetValue(rtxtBoxInfo.Text);
                frmInfo.ShowDialog();
                ChangeToDefault();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                ChangeToDefault();
            }
        }

        private void process1_ErrorDataReceived(object sender, DataReceivedEventArgs e)
        {
            rtxtBoxInfo.Text += e.Data + "\n";
            rtxtBoxInfo.Update();
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
                    Cursor = Cursors.WaitCursor;
                    string inputFileName = finfo.FullName;

                    // Start Condition : if you have win32 or win64
                    string ffmpeg;
                    if (Environment.Is64BitOperatingSystem)
                        ffmpeg = @"tools\x64\bin\ffmpeg.exe"; // path of FFmpeg tools for win32
                    else
                        ffmpeg = @"tools\x32\bin\ffmpeg.exe"; // path of FFmpeg tools for win64

                    Process p = process1;
                    p.StartInfo.FileName = ffmpeg;
                    p.StartInfo.Arguments = " -i " + "\"" + inputFileName + "\"";
                    //p.StartInfo.Arguments = " -h"; // for testing ...
                    p.Start();
                    p.BeginOutputReadLine();
                    p.BeginErrorReadLine();
                    //Thread.Sleep(10000); // wait for the process to exit ...
                    MessageBox.Show("Waiting 5 seconde for the process to exit....\n\t   And click OK");
                    p.WaitForExit();
                    if (p.HasExited)
                    {
                        p.CancelErrorRead();
                        p.CancelOutputRead();
                        p.Close();
                    }
                    
                    else
                        return;
                    FrmInfo frmInfo = new FrmInfo();
                    frmInfo.GetValue(rtxtBoxInfo.Text);
                    frmInfo.ShowDialog();
                    ChangeToDefault();
                    break;
            }
        }

        // Change to default
        public void ChangeToDefault()
        {
            Cursor = DefaultCursor;
            ofd.FileName = "";
            rtxtBoxInfo.Clear();
        }

        // -- Start -- Handle event Checked Changed for Radio Button
        private void RdBtnAddSub_CheckedChanged(object sender, EventArgs e)
        {
            if (RdBtnAddSub.Checked)
                OptionsChecked = "Add Subtitles";
            else
                OptionsChecked = "";
        }
        private void RdBtnResize_CheckedChanged(object sender, EventArgs e)
        {
            if (RdBtnResize.Checked)
                OptionsChecked = "Resize";
            else
                OptionsChecked = "";
        }
        private void RdBtnCrop_CheckedChanged(object sender, EventArgs e)
        {
            if (RdBtnCrop.Checked)
                OptionsChecked = "Crop";
            else
                OptionsChecked = "";
        }
        // -- End -- Handle event Checked Changed for Radio Button
    }
}
