using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

namespace Conversion_Multimedia
{
    public partial class AddSubtitles : UserControl
    {
        public string videoName, videoType, currentDir, subName;
        
        public AddSubtitles() => InitializeComponent();

        // Customize Open file dialog 
        OpenFileDialog ofd = new OpenFileDialog
        {
            InitialDirectory = "C:/",
            RestoreDirectory = true,
            Title = "Chose your file"
        };

        // Handle event click Button Load video ...
        private void BtnLoadVideo_Click(object sender, EventArgs e)
        {
            ofd.Filter = "Videos files (*.mp4, *.mov, *.m4a, *.3gp, *.3g2, *.mj2) | *.mp4; *.mov; *.m4a; *.3gp; *.3g2; *.mj2";
            DialogResult result = ofd.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtBoxVideoFilename.Text = ofd.FileName;
                txtBoxSubFilename.Enabled = true;
                BtnLoadSub.Enabled = true;
                videoName = Path.GetFileNameWithoutExtension(ofd.SafeFileName);
                videoType = Path.GetExtension(ofd.SafeFileName);
            }
            else
                return;
        }

        // Handle event click Button Load Subtitles ...
        private void BtnLoadSub_Click(object sender, EventArgs e)
        {
            ofd.FileName = ""; // Clear open file dialog FileName
            ofd.Filter = "Subtitles files (*.srt) | *.srt";
            DialogResult result = ofd.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtBoxSubFilename.Text = ofd.FileName;
                BtnStartAdd.Enabled = true;
                BtnLoadSub.Enabled = false;
                BtnLoadVideo.Enabled = false;
                // Copy Subtitle file to Assembly directory ...
                subName = ofd.SafeFileName;
                string subSourcePath = Path.GetDirectoryName(ofd.FileName);
                // Get current Directory of file Execution
                currentDir = AppDomain.CurrentDomain.BaseDirectory;
                //Or currentDir = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
                // Use Path class to manipulate file and directory paths.
                string sourceFile = Path.Combine(subSourcePath, subName);
                string destFile = Path.Combine(currentDir, subName);
                // To copy a file to another location and 
                // overwrite the destination file if it already exists.
                File.Copy(sourceFile, destFile, true);
            }
            else
                return;
        }

        // Handle event click Button Start Add Subtitles to video ...
        private void BtnStartAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // change the cursor and disable button start
                this.Cursor = Cursors.WaitCursor;
                BtnStartAdd.Enabled = false;
                // uses an instance of the Process class to start a process
                using (Process process = new Process())
                {
                    process.StartInfo.UseShellExecute = false;
                    // run the cmd process
                    process.StartInfo.FileName = "cmd.exe";
                    // Given that is started without a window
                    process.StartInfo.CreateNoWindow = true;

                    // uses the redirected input-output
                    process.StartInfo.RedirectStandardInput = true;
                    process.StartInfo.RedirectStandardOutput = true;

                    // Start process
                    process.Start();

                    // Declare variable input and output of FFmpeg tools
                    string inputVideo = txtBoxVideoFilename.Text;
                    string inputSubtitle = txtBoxSubFilename.Text;

                    string output = " output_" + videoName.Replace(" ", "_") + videoType;
                    string ffmpeg;

                    // Start Condition : if you have win32 or win64
                    if (Environment.Is64BitOperatingSystem)
                        ffmpeg = @"tools\x64\bin\ffmpeg.exe"; // path of FFmpeg tools for win32
                    else
                        ffmpeg = @"tools\x32\bin\ffmpeg.exe"; // path of FFmpeg tools for win64

                    // Start Command line ...
                    process.StandardInput.WriteLine(ffmpeg + " -i " + "\"" + inputVideo + "\"" 
                        + " -vf subtitles=" + subName
                        + output);
                    
                    // Flush & Close StandarInput
                    process.StandardInput.Flush();
                    process.StandardInput.Close();

                    // Wait for Exit
                    process.WaitForExit();

                    // Close The Process
                    process.Close();
                }
                ChangeToDefault();
                MessageBox.Show("Your subtitles has been added successfully", "Success",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                ChangeToDefault();
            }
        }

        // Methode Change to default
        private void ChangeToDefault()
        {
            this.Cursor = DefaultCursor;
            txtBoxVideoFilename.Text = "Chose your video file ...";
            txtBoxSubFilename.Text = "Chose your subtitle ...";
            txtBoxSubFilename.Enabled = false;
            BtnLoadVideo.Enabled = true;
            BtnLoadSub.Enabled = false;
            BtnStartAdd.Enabled = false;
            ofd.FileName = "";
            // Delete Subtitle file ...
            string subLocation = currentDir + subName;
            if (File.Exists(subLocation))
            {
                try
                {
                    File.Delete(subLocation);
                }
                catch (IOException ioex)
                {
                    Console.WriteLine(ioex.Message);
                }
            }
        }
    }
}
