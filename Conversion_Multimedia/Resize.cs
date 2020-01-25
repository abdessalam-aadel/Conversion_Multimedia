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
        public bool ifChanged;

        public bool SetChanged
        {
            set => ifChanged = value;
        }

        // Customize Open file dialog 
        OpenFileDialog ofd = new OpenFileDialog
        {
            InitialDirectory = "C:/",
            RestoreDirectory = true,
            Title = "Chose your file"
        };

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
            else
                return;
        }

        // Handle event click of Button Resize ...
        private void BtnStartResize_Click(object sender, EventArgs e)
        {
            // condition if the width & height not empty
            if (txtBoxW.Text != "" && txtBoxH.Text != "")
            {
                try
                {
                    // uses an instance of the Process class to start a process
                    using (Process process = new Process())
                    {
                        // change the cursor and disable button start
                        Cursor = Cursors.WaitCursor;
                        BtnLoadVideo.Enabled = false;
                        BtnStartResize.Enabled = false;
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
                        ChangeToDefault();
                        MessageBox.Show("Your video have been resized successfully", "Success",
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
            else
                MessageBox.Show("Please enter your video size ... \n\t(width & height)");
        }

        // Start methode : Not Enter a Key String just a key number...
        private static void Not_KeyString(KeyPressEventArgs e)
        {
            if (e.KeyChar < 48 || e.KeyChar > 57)
            {
                // if you press the BACKSPACE key, the Handled property is set to false, 
                if (e.KeyChar == 8)
                    e.Handled = false;
                else
                    e.Handled = true;
            }   
        }

        // Start -- Handle event KeyPress ...
        private void txtBoxW_KeyPress(object sender, KeyPressEventArgs e) => Not_KeyString(e);
        private void txtBoxH_KeyPress(object sender, KeyPressEventArgs e) => Not_KeyString(e);
        // End -- Event KeyPress ...
        // Activate Drag and Drop in Resize ...
        private void Resize_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
            pictureDrag4.BringToFront();
            pictureDrag4.Visible = true;
        }
        private void Resize_DragDrop(object sender, DragEventArgs e)
        {
            pictureDrag4.Visible = false;
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
                case ".avi":
                case ".flv":
                case ".wav":
                    txtBoxVideoFilename.Text = finfo.FullName;
                    videoName = Path.GetFileNameWithoutExtension(finfo.Name);
                    videoType = finfo.Extension;
                    BtnStartResize.Enabled = true;
                    txtBoxW.Enabled = true;
                    txtBoxH.Enabled = true;
                    break;
            }
        }
        private void Resize_DragLeave(object sender, EventArgs e)
        {
            pictureDrag4.Visible = false;
        }
        // Handle Event Mouse Move
        private void Resize_MouseMove(object sender, MouseEventArgs e)
        {
            if (ifChanged)
                ChangeToDefault();
        }

        // Methode Change to default
        private void ChangeToDefault()
        {
            Cursor = DefaultCursor;
            txtBoxVideoFilename.Text = "Chose your video file ...";
            BtnLoadVideo.Enabled = true;
            BtnStartResize.Enabled = false;
            txtBoxW.Text = "";
            txtBoxH.Text = "";
            ofd.FileName = "";
            txtBoxW.Enabled = false;
            txtBoxH.Enabled = false;
            ifChanged = false;
            panelLoading.Visible = false;
        }
    }
}
