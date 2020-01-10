using System;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace Conversion_Multimedia
{
    public partial class Resize : UserControl
    {
        public Resize() => InitializeComponent();
        public string videoName, videoType;

        // Customize Open file dialog 
        OpenFileDialog ofd = new OpenFileDialog
        {
            InitialDirectory = "C:/",
            RestoreDirectory = true,
            Title = "Chose your file"
        };
        
        // Handle event click of Button Resize ...
        private void BtnStartResize_Click(object sender, EventArgs e)
        {
            // condition if the width & height not empty
            if (txtBoxW.Text != "" && txtBoxH.Text != "")
            {
                try
                {
                    // change the cursor and disable button start
                    this.Cursor = Cursors.WaitCursor;
                    BtnLoadVideo.Enabled = false;
                    BtnStartResize.Enabled = false;
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
                        string output = " output_" + videoName.Replace(" ", "_") 
                                        + "_" + txtBoxW.Text + "x" + txtBoxH.Text
                                        + videoType;
                        string ffmpeg;

                        // Start Condition : if you have win32 or win64
                        if (Environment.Is64BitOperatingSystem)
                            ffmpeg = @"tools\x64\bin\ffmpeg.exe"; // path of FFmpeg tools for win32
                        else
                            ffmpeg = @"tools\x32\bin\ffmpeg.exe"; // path of FFmpeg tools for win64

                        // Start Command line ...
                        process.StandardInput.WriteLine(ffmpeg + " -i " + "\"" + inputVideo + "\""
                            + " -vf scale=" + txtBoxW.Text + ":" + txtBoxH.Text
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
                    MessageBox.Show("Your video have been resized successfully", "Success",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    ChangeToDefault();
                }
            }
            else
                MessageBox.Show("Please enter your video size ... \n\t(width & height)");
        }

        // Methode Change to default
        private void ChangeToDefault()
        {
            this.Cursor = DefaultCursor;
            txtBoxVideoFilename.Text = "Chose your video file ...";
            BtnLoadVideo.Enabled = true;
            BtnStartResize.Enabled = true;
            txtBoxW.Text = "";
            txtBoxH.Text = "";
            ofd.FileName = "";
            txtBoxW.Enabled = false;
            txtBoxH.Enabled = false;
        }

        // Start methode : Not Enter a Key String just a key number...
        private static void Not_KeyString(KeyPressEventArgs e)
        {
            if (e.KeyChar < 48 || e.KeyChar > 57)
                e.Handled = true;
        }

        // Start -- Handle event KeyPress ...
        private void txtBoxW_KeyPress(object sender, KeyPressEventArgs e) => Not_KeyString(e);
        private void txtBoxH_KeyPress(object sender, KeyPressEventArgs e) => Not_KeyString(e);
        // End -- Event KeyPress ...

        // Handle event click Button Load a video file ...
        private void BtnLoadVideo_Click(object sender, EventArgs e)
        {
            ofd.Filter = "Videos files (*.mp4, *.mov, *.m4a, *.3gp, *.3g2, *.mj2, *.avi, *.flv, *.wav) | *.mp4; *.mov; *.m4a; *.3gp; *.3g2; *.mj2; *.avi; *.flv; *.wav";
            DialogResult result = ofd.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtBoxVideoFilename.Text = ofd.FileName;
                videoName = Path.GetFileNameWithoutExtension(ofd.SafeFileName); // Get File name without extension
                videoType = Path.GetExtension(ofd.SafeFileName); // Get File Extension
                BtnStartResize.Enabled = true;
                txtBoxW.Enabled = true;
                txtBoxH.Enabled = true;
            }
        }
    }
}
