using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.IO;

namespace Conversion_Multimedia
{
    public partial class AddSubtitles : UserControl
    {
        public string videoType, currentDir, subName;
        public string videoName = "";
        public bool ifChanged;
        public bool SetChanged
        {
            set => ifChanged = value;
        }

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
            ofd.Filter = "Subtitles files (*.srt, *.ass) | *.srt; *.ass";
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
                // Or use System.Reflection
                // currentDir = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
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
                // uses an instance of the Process class to start a process
                using (Process process = new Process())
                {
                    // change the cursor and disable button start
                    Cursor = Cursors.WaitCursor;
                    BtnStartAdd.Enabled = false;
                    panelLoading.Visible = true;

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
                    ChangeToDefault();
                    MessageBox.Show("Your subtitles has been added successfully", "Success",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                ChangeToDefault();
            }
        }

        // Activate Drag and Drop in AddSubtitles User control ...
        private void AddSubtitles_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
            pictureDrag5.BringToFront();
            pictureDrag5.Visible = true;
        }
        private void AddSubtitles_DragDrop(object sender, DragEventArgs e)
        {
            pictureDrag5.Visible = false;
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
                    txtBoxVideoFilename.Text = finfo.FullName;
                    txtBoxSubFilename.Enabled = true;
                    BtnLoadSub.Enabled = true;
                    videoName = Path.GetFileNameWithoutExtension(finfo.FullName);
                    videoType = fileExtension;
                    break;
                case ".srt":
                case ".ass":
                    if (videoName != "")
                    {
                        txtBoxSubFilename.Text = finfo.FullName;
                        BtnStartAdd.Enabled = true;
                        BtnLoadSub.Enabled = false;
                        BtnLoadVideo.Enabled = false;
                        subName = finfo.Name;
                        string subSourcePath = finfo.DirectoryName;
                        currentDir = AppDomain.CurrentDomain.BaseDirectory;
                        string sourceFile = finfo.FullName;
                        string destFile = Path.Combine(currentDir, subName);
                        File.Copy(sourceFile, destFile, true);
                        AllowDrop = false;
                        break;
                    }
                    else
                        break;
            }
        }

        private void AddSubtitles_DragLeave(object sender, EventArgs e)
        {
            pictureDrag5.Visible = false;
        }

        // Handle Event Mouse Move
        private void AddSubtitles_MouseMove(object sender, MouseEventArgs e)
        {
            if (ifChanged)
                ChangeToDefault();
        }

        // Methode Change to default
        private void ChangeToDefault()
        {
            Cursor = DefaultCursor;
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
                    MessageBox.Show(ioex.Message);
                }
            }
            AllowDrop = true;
            ifChanged = false;
            videoName = "";
            panelLoading.Visible = false;
        }
    }
}
