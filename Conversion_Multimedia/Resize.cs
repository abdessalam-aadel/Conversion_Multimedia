using System;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using System.Drawing;
using RunProcess_Kilya;

namespace Conversion_Multimedia
{
    public partial class Resize : UserControl
    {
        public Resize() => InitializeComponent();
        public string videoName, videoType;
        public bool ifChanged;
        public int width = 0, height = 0;

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
                EnableTxtAndBtn(true);
                SearchWH(ofd.FileName);
            }
            else
                return;
        }

        private void EnableTxtAndBtn(bool _enable)
        {
            BtnStartResize.Enabled = _enable;
            txtBoxW.Enabled = _enable;
            txtBoxH.Enabled = _enable;
        }

        // Handle event click of Button Resize ...
        private void BtnStartResize_Click(object sender, EventArgs e)
        {
            // condition if the width & height not empty
            if (txtBoxW.Text != "" && txtBoxH.Text != "")
            {
                try
                {
                    // change the cursor and disable button start
                    Cursor = Cursors.WaitCursor;
                    panelLoading.BringToFront();
                    panelLoading.Visible = true;

                    string inputVideo = txtBoxVideoFilename.Text;
                    string output = " output_" + videoName.Replace(" ", "_")
                                    + "_" + txtBoxW.Text + "x" + txtBoxH.Text
                                    + videoType;
                    run.RunFFmpeg("-y -i " + "\"" + inputVideo + "\""
                                + " -vf scale=" + txtBoxW.Text + ":" + txtBoxH.Text
                                + output, true);
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
                    EnableTxtAndBtn(true);
                    SearchWH(finfo.FullName);
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
            EnableTxtAndBtn(false);
            // Clear TxtBox & OFD
            txtBoxW.Text = "";
            txtBoxH.Text = "";
            ofd.FileName = "";
            ifChanged = false;
            panelLoading.Visible = false;
            labelVSize.ForeColor = Color.DimGray;
            labelVSize.Text = "...x...";
        }
        
        // Handel procedure Search width and height
        private void SearchWH(string path)
        {
           // use regular expression to search the width & height for video file
            string pattern = @"(\d{2,3})x(\d{2,3})"; // pattern of width & height
            // Run the process and return the information of video...
            string output = run.RunFFmpeg("-i " + "\"" + path + "\"", false);
            
            // Find matches
            Match m = Regex.Match(output, pattern);
            if (m.Success)
            {
                // separate with and height
                int.TryParse(m.Groups[1].Value, out width);
                int.TryParse(m.Groups[2].Value, out height);
                // Change Forecolor and write the value of: W & H
                labelVSize.ForeColor = Color.DimGray;
                labelVSize.Text = width + "x" + height;
            }
            else
            {
                width = 0;
                height = 0;
                labelVSize.ForeColor = Color.Red;
                labelVSize.Text = "Not Found !";
            }
        }
    }
}
