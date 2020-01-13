using System;
using System.Windows.Forms;
using System.Diagnostics;

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
                    this.Cursor = Cursors.WaitCursor;
                    string inputFileName = ofd.FileName;

                    // Start Condition : if you have win32 or win64
                    string ffmpeg;
                    if (Environment.Is64BitOperatingSystem)
                        ffmpeg = @"tools\x64\bin\ffmpeg.exe"; // path of FFmpeg tools for win32
                    else
                        ffmpeg = @"tools\x32\bin\ffmpeg.exe"; // path of FFmpeg tools for win64

                    Process p = this.process1;
                    p.StartInfo.UseShellExecute = false;
                    p.StartInfo.RedirectStandardOutput = true;
                    p.StartInfo.CreateNoWindow = true;
                    p.StartInfo.FileName = ffmpeg;
                    p.StartInfo.Arguments = " -i " + "\"" + inputFileName + "\"";
                    //p.StartInfo.Arguments = " -h"; // for testing ...
                    p.Start();
                    p.BeginOutputReadLine();
                    p.BeginErrorReadLine();
                    //Thread.Sleep(10000); // wait for the process to exit ...
                    MessageBox.Show("Waiting for the process to exit....");
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
                this.Cursor = DefaultCursor;
                FrmInfo frmInfo = new FrmInfo();
                frmInfo.GetValue(rtxtBoxInfo.Text);
                frmInfo.ShowDialog();
                ofd.FileName = "";
                rtxtBoxInfo.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void process1_ErrorDataReceived(object sender, DataReceivedEventArgs e)
        {
            rtxtBoxInfo.Text += e.Data + "\n";
            rtxtBoxInfo.Update();
        }
        // -- Start -- Handle event Checked Changed for checkbox
        private void CheckBoxCrop_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxCrop.Checked)
            {
                OptionsChecked = "Crop";
                CheckBoxResize.Enabled = false;
                CheckBoxSubtitles.Enabled = false;
            }
            else
            {
                OptionsChecked = "";
                CheckBoxResize.Enabled = true;
                CheckBoxSubtitles.Enabled = true;
            }
        }
        private void CheckBoxResize_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxResize.Checked)
            {
                OptionsChecked = "Resize";
                CheckBoxCrop.Enabled = false;
                CheckBoxSubtitles.Enabled = false;
            }
            else
            {
                OptionsChecked = "";
                CheckBoxCrop.Enabled = true;
                CheckBoxSubtitles.Enabled = true;
            }
        }
        private void CheckBoxSubtitles_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxSubtitles.Checked)
            {
                OptionsChecked = "Add Subtitles";
                CheckBoxCrop.Enabled = false;
                CheckBoxResize.Enabled = false;
            }
            else
            {
                OptionsChecked = "";
                CheckBoxCrop.Enabled = true;
                CheckBoxResize.Enabled = true;
            }
        }
        // -- End -- Handle event Checked Changed for checkbox
    }
}
