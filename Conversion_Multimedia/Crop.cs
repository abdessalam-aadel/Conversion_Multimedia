using System;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;

namespace Conversion_Multimedia
{
    public partial class Crop : UserControl
    {
        public Crop() => InitializeComponent();

        public string videoName, videoType;

        // Customize Open file dialog 
        OpenFileDialog ofd = new OpenFileDialog
        {
            InitialDirectory = "C:/",
            RestoreDirectory = true,
            Title = "Chose your file"
        };

        // Start methode : Not Enter a Key String just a key number...
        private static void Not_KeyString(KeyPressEventArgs e)
        {
            if (e.KeyChar < 48 || e.KeyChar > 57)
                e.Handled = true;
        }
        // Start -- Handle event KeyPress ...
        private void txtBoxX_KeyPress(object sender, KeyPressEventArgs e) => Not_KeyString(e);
        private void txtBoxY_KeyPress(object sender, KeyPressEventArgs e) => Not_KeyString(e);
        private void txtBoxW_KeyPress(object sender, KeyPressEventArgs e) => Not_KeyString(e);
        private void txtBoxH_KeyPress(object sender, KeyPressEventArgs e) => Not_KeyString(e);
        // End -- Event KeyPress ...

        private void BtnLoadVideo_Click(object sender, EventArgs e)
        {
            ofd.Filter = "Videos files (*.mp4, *.mov, *.m4a, *.3gp, *.3g2, *.mj2, *.avi, *.flv, *.wav) | *.mp4; *.mov; *.m4a; *.3gp; *.3g2; *.mj2; *.avi; *.flv; *.wav";
            DialogResult result = ofd.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtBoxVideoFilename.Text = ofd.FileName;
                videoName = Path.GetFileNameWithoutExtension(ofd.SafeFileName); // Get File name without extension
                videoType = Path.GetExtension(ofd.SafeFileName); // Get File Extension
                EnabledBtnAndTxt();
            }
        }
        // Methode Enabled button and textbox
        public void EnabledBtnAndTxt()
        {
            btnStartCrop.Enabled = true;
            txtBoxW.Enabled = true;
            txtBoxH.Enabled = true;
            txtBoxX.Enabled = true;
            txtBoxY.Enabled = true;
        }

        // Handle event click Button Start Crop ...
        private void btnStartCrop_Click(object sender, EventArgs e)
        {
            if (txtBoxW.Text != "" && txtBoxH.Text != "" && txtBoxX.Text != "" && txtBoxY.Text != "")
            {
                try
                {
                    // change the cursor and disable button start
                    this.Cursor = Cursors.WaitCursor;
                    BtnLoadVideo.Enabled = false;
                    btnStartCrop.Enabled = false;
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
                                        + "_Croped"
                                        + videoType;
                        string ffmpeg;

                        // Start Condition : if you have win32 or win64
                        if (Environment.Is64BitOperatingSystem)
                            ffmpeg = @"tools\x64\bin\ffmpeg.exe"; // path of FFmpeg tools for win32
                        else
                            ffmpeg = @"tools\x32\bin\ffmpeg.exe"; // path of FFmpeg tools for win64

                        // Start Command line ...
                        process.StandardInput.WriteLine(ffmpeg + " -i " + "\"" + inputVideo + "\""
                            + " -filter:v " + "\"" + "crop = " 
                            + txtBoxW.Text + ":" + txtBoxH.Text + ":" + txtBoxX.Text + ":" + txtBoxY.Text + "\""
                            + " -c:a copy" + output);

                        // Flush & Close StandarInput
                        process.StandardInput.Flush();
                        process.StandardInput.Close();

                        // Wait for Exit
                        process.WaitForExit();

                        // Close The Process
                        process.Close();
                    }
                    ChangeToDefault();
                    MessageBox.Show("Your video have been croped successfully", "Success",
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
                MessageBox.Show("Please enter your video size ... \n\t(width & height)\nAnd enter starting position ...\n\t(x , y)");
        }

        // Methode Change to default
        private void ChangeToDefault()
        {
            this.Cursor = DefaultCursor;
            txtBoxVideoFilename.Text = "Chose your video file ...";
            BtnLoadVideo.Enabled = true;
            btnStartCrop.Enabled = false;
            txtBoxW.Enabled = false;
            txtBoxH.Enabled = false;
            txtBoxX.Enabled = false;
            txtBoxY.Enabled = false;
            txtBoxW.Text = "";
            txtBoxH.Text = "";
            txtBoxX.Text = "";
            txtBoxY.Text = "";
            ofd.FileName = "";
        }
    }
}
