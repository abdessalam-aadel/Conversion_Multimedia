using System;
using System.IO;
using System.Windows.Forms;
using RunProcess_Kilya;

namespace Conversion_Multimedia
{
    public partial class Crop : UserControl
    {
        public Crop() => InitializeComponent();

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

        public RunProcess run = new RunProcess();

        // handle Button Load
        private void BtnLoadVideo_Click(object sender, EventArgs e)
        {
            ofd.Filter = "Videos files (*.mp4, *.mov, *.m4a, *.3gp, *.3g2, *.mj2, *.avi, *.flv, *.wav) | *.mp4; *.mov; *.m4a; *.3gp; *.3g2; *.mj2; *.avi; *.flv; *.wav";
            DialogResult result = ofd.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtBoxVideoFilename.Text = ofd.FileName;
                videoName = Path.GetFileNameWithoutExtension(ofd.SafeFileName); // Get File name without extension
                videoType = Path.GetExtension(ofd.SafeFileName); // Get File Extension
                EnabledBtnAndTxt(true);
            }
            else
                return;
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
        private void txtBoxX_KeyPress(object sender, KeyPressEventArgs e) => Not_KeyString(e);
        private void txtBoxY_KeyPress(object sender, KeyPressEventArgs e) => Not_KeyString(e);
        private void txtBoxW_KeyPress(object sender, KeyPressEventArgs e) => Not_KeyString(e);
        private void txtBoxH_KeyPress(object sender, KeyPressEventArgs e) => Not_KeyString(e);
        // End -- Event KeyPress ...
        
        // Methode Enabled button and textbox
        public void EnabledBtnAndTxt(bool _enable)
        {
            btnStartCrop.Enabled = _enable;
            txtBoxW.Enabled = _enable;
            txtBoxH.Enabled = _enable;
            txtBoxX.Enabled = _enable;
            txtBoxY.Enabled = _enable;
        }

        // Handle event click Button Start Crop ...
        private void btnStartCrop_Click(object sender, EventArgs e)
        {
            if (txtBoxW.Text != "" && txtBoxH.Text != "" && txtBoxX.Text != "" && txtBoxY.Text != "")
            {
                try
                {
                    // change the cursor and disable button start
                    Cursor = Cursors.WaitCursor;
                    panelLoading.BringToFront();
                    panelLoading.Visible = true;

                    // Declare variable input and output of FFmpeg tools
                    string inputVideo = txtBoxVideoFilename.Text;
                    string output = " output_" + videoName.Replace(" ", "_")
                                    + "_Croped"
                                    + videoType;

                    run.RunFFmpeg("-y -i " + "\"" + inputVideo + "\""
                        + " -filter:v " + "\"" + "crop = "
                        + txtBoxW.Text + ":" + txtBoxH.Text + ":" + txtBoxX.Text + ":" + txtBoxY.Text + "\""
                        + " -c:a copy" + output,true);
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
        
        // Activate Drag and Drop in Crop ...
        private void Crop_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
            pictureDrag2.BringToFront();
            pictureDrag2.Visible = true;
        }
        private void Crop_DragDrop(object sender, DragEventArgs e)
        {
            pictureDrag2.Visible = false;
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
                    videoType = fileExtension;
                    EnabledBtnAndTxt(true);
                    break;
            }
        }
        private void Crop_DragLeave(object sender, EventArgs e)
        {
            pictureDrag2.Visible = false;
        }

        // Handle Event Mouse Move
        private void Crop_MouseMove(object sender, MouseEventArgs e)
        {
            if (ifChanged)
                ChangeToDefault();
        }

        // Methode Change to default
        private void ChangeToDefault()
        {
            Cursor = DefaultCursor;
            txtBoxVideoFilename.Text = "Chose your video file ...";
            // Disable Button Start crop & TexBox
            EnabledBtnAndTxt(false);
            // Clear TextBox
            txtBoxW.Text = "";
            txtBoxH.Text = "";
            txtBoxX.Text = "";
            txtBoxY.Text = "";
            // Clear FileName of Open file dialog
            ofd.FileName = "";
            ifChanged = false;
            panelLoading.Visible = false;
        }
    }
}
