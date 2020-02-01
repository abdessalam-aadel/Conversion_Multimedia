using System;
using System.Drawing;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Threading;
using System.IO;
using System.Collections.Generic;
using RunProcess_Kilya;

namespace Conversion_Multimedia
{
    public partial class ChoseFile : UserControl
    {
        public string Types, TypesOutput, CommandFFmpegMiddle, ImagesOutput;
        public bool ifChanged;
        public List<string> fileExtension = new List<string>();
        // passing value of type convertion from Form to userControl (ChoseFile.cs)
        public string PassingTypeOfConversion
        {
            set => Types = value;
        }
        // Set value ifChanged
        public bool SetChanged
        {
            set => ifChanged = value;
        }
        public ChoseFile() => InitializeComponent();

        // Customize Open file dialog 
        OpenFileDialog ofd = new OpenFileDialog
        {
            InitialDirectory = "C:/",
            RestoreDirectory = true,
            Title = "Chose your file"
        };

        public RunProcess run = new RunProcess();

        // Handle Button Load
        private void BtnLoad_Click(object sender, EventArgs e)
        {
            LookingFor_yourType();
            DialogResult result = ofd.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtboxFileName.Text = ofd.FileName;
                BtnStart.Enabled = true;
                labelFilename.Text = Path.GetFileNameWithoutExtension(ofd.SafeFileName);
                if (Types == "JPEG & PNG compression quality" && Path.GetExtension(ofd.FileName) == ".png")
                    TypesOutput = ".png";
            }
            else
                return;
        }
        
        // handle Methode Looking for your type
        public void LookingFor_yourType()
        {
            switch (Types)
            {
                case "Extract sound from video":
                    ofd.Filter = "Videos files (*.mp4, *.avi, *.flv, *.wav) | *.mp4; *.avi; *.flv; *.wav";
                    fileExtension.Clear();
                    fileExtension.Add(".mp4");
                    fileExtension.Add(".avi");
                    fileExtension.Add(".flv");
                    fileExtension.Add(".wav");
                    TypesOutput = ".mp3";
                    CommandFFmpegMiddle = " -vn -ar 44100 -ac 2 -ab 192k -f mp3 ";
                    break;
                case ".avi to .mpg":
                    AviMethode();
                    TypesOutput = ".mpg";
                    break;
                case ".mpg to .avi":
                    ofd.Filter = "Videos files (*.mpg) | *.mpg";
                    fileExtension.Clear();
                    fileExtension.Add(".mpg");
                    TypesOutput = ".avi";
                    CommandFFmpegMiddle = " ";
                    break;
                case ".avi to .flv":
                    ofd.Filter = "Videos files (*.avi) | *.avi";
                    fileExtension.Clear();
                    fileExtension.Add(".mpg");
                    TypesOutput = ".flv";
                    fileExtension.Add(".avi");
                    CommandFFmpegMiddle = " -ab 56 -ar 44100 -b 200 -r 15 -s 320x240 -f flv ";
                    break;
                case ".avi to .gif":
                    AviMethode();
                    TypesOutput = ".gif";
                    break;
                case ".avi to .dv":
                    ofd.Filter = "Videos files (*.avi) | *.avi";
                    fileExtension.Clear();
                    fileExtension.Add(".avi");
                    TypesOutput = ".dv";
                    CommandFFmpegMiddle = " -s pal -r pal -aspect 4:3 -ar 48000 -ac 2 ";
                    break;
                case ".avi to .mpeg":
                    ofd.Filter = "Videos files (*.avi) | *.avi";
                    fileExtension.Clear();
                    fileExtension.Add(".avi");
                    TypesOutput = ".mpeg";
                    CommandFFmpegMiddle = " -target pal-dvd -ps 2000000000 -aspect 16:9 ";
                    break;
                case ".wav or .avi to .mp4":
                    ofd.Filter = "Videos files (*.wav, *.avi) | *.wav; *.avi";
                    fileExtension.Clear();
                    fileExtension.Add(".wav");
                    fileExtension.Add(".avi");
                    TypesOutput = ".mp4";
                    CommandFFmpegMiddle = " ";
                    break;
                case ".mkv to .mp4":
                    ofd.Filter = "Videos files (*.mkv) | *.mkv";
                    fileExtension.Clear();
                    fileExtension.Add(".mkv");
                    TypesOutput = ".mp4";
                    CommandFFmpegMiddle = " -codec copy ";
                    break;
                case "Convert a Video to X Images":
                    ofd.Filter = "Videos files (*.mp4, *.mov, *.m4a, *.3gp, *.3g2, *.mj2, *.avi, *.flv, *.wav) | *.mp4; *.mov; *.m4a; *.3gp; *.3g2; *.mj2; *.avi; *.flv; *.wav";
                    fileExtension.Clear();
                    fileExtension.Add(".mp4");
                    fileExtension.Add(".mov");
                    fileExtension.Add(".m4a");
                    fileExtension.Add(".3gp");
                    fileExtension.Add(".3g2");
                    fileExtension.Add(".mj2");
                    fileExtension.Add(".avi");
                    fileExtension.Add(".flv");
                    fileExtension.Add(".wav");
                    TypesOutput = ".jpg";
                    ImagesOutput = "%d";
                    CommandFFmpegMiddle = " ";
                    break;
                case "Compress .avi to VCD mpeg2":
                    ofd.Filter = "Videos files (*.avi) | *.avi";
                    fileExtension.Clear();
                    fileExtension.Add(".avi");
                    TypesOutput = ".mpg";
                    CommandFFmpegMiddle = " -target ntsc-vcd ";
                    break;
                case ".webp to .png":
                    ofd.Filter = "Images files (*.webp) | *.webp";
                    fileExtension.Clear();
                    fileExtension.Add(".webp");
                    TypesOutput = ".png";
                    CommandFFmpegMiddle = " ";
                    break;
                case "JPEG & PNG compression quality":
                    ofd.Filter = "Images files (*.jpg, *.png) | *.jpg; *.png";
                    fileExtension.Clear();
                    fileExtension.Add(".jpg");
                    fileExtension.Add(".png");
                    TypesOutput = ".jpg";
                    CommandFFmpegMiddle = " -compression_level 100 ";
                    break;
                case "Change Bitrate to 10MB":
                    ofd.Filter = "Videos files (*.mp4) | *.mp4";
                    fileExtension.Clear();
                    fileExtension.Add(".mp4");
                    TypesOutput = ".mp4";
                    CommandFFmpegMiddle = " -b:v 10M ";
                    break;
                default:
                    MessageBox.Show("This méthode could not exist !");
                    return;
            }
        }

        // Activate Drag and Drop in Chosefile ...
        private void ChoseFile_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
            rtxtboxCmd.BackColor = Color.FromArgb(253,249,240);
            pictureDrag3.Visible = true;
        }
        private void ChoseFile_DragDrop(object sender, DragEventArgs e)
        {
            rtxtboxCmd.BackColor = Color.DarkSlateGray;
            pictureDrag3.Visible = false;
            LookingFor_yourType();
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            FileInfo finfo = new FileInfo(files[0]);
            foreach (var item in fileExtension)
            {
                if (item == finfo.Extension)
                {
                    txtboxFileName.Text = finfo.FullName;
                    BtnStart.Enabled = true;
                    labelFilename.Text = Path.GetFileNameWithoutExtension(finfo.Name);
                    if (Types == "JPEG & PNG compression quality" && finfo.Extension == ".png")
                        TypesOutput = ".png";
                }
            }
        }
        private void ChoseFile_DragLeave(object sender, EventArgs e)
        {
            rtxtboxCmd.BackColor = Color.DarkSlateGray;
            pictureDrag3.Visible = false;
        }
        // Handle Event Mouse Move
        private void ChoseFile_MouseMove(object sender, MouseEventArgs e)
        {
            if (ifChanged)
            {
                ChangeToDefault();
                rtxtboxCmd.Text = "";
            }
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            try
            {
                // change the cursor and disable button start
                Cursor = Cursors.WaitCursor;
                panelLoading.Visible = true;
                // Declare variable input and output of FFmpeg tools
                string input = txtboxFileName.Text;
                string output = "output_"
                                + labelFilename.Text.Replace(" ", "_").Replace(".", "-")
                                + ImagesOutput
                                + TypesOutput;
                // FFmpeg : override output file if exists with -y
                string resultCmd = run.RunCmd(" -y -i " + "\"" + input + "\"" + CommandFFmpegMiddle + output 
                                                + " 2>&1 | findstr .*", true);
                Thread.Sleep(500);
                run.RunFFmpeg("-y -i " + "\"" + input + "\"" + CommandFFmpegMiddle + output, true);
                ImagesOutput = "";

                #region Replace Location and Colored
                string pattern = @"\w:(\\.+)*>(?!&)";
                Match match = Regex.Match(resultCmd, pattern);
                if (match.Success)
                {
                    string oldvalueS = match.Value;
                    string newValue = "Abdessalam(•̀_•́)Kilya $ ";
                    rtxtboxCmd.Text = resultCmd.Replace(oldvalueS, newValue);
                    // Selection color
                    int start = 0;
                    int end = rtxtboxCmd.Text.LastIndexOf(newValue);
                    while (start < end)
                    {
                        rtxtboxCmd.Find(newValue, start, rtxtboxCmd.TextLength, RichTextBoxFinds.MatchCase);
                        // Set the highlight color as DarkOrange
                        rtxtboxCmd.SelectionColor = Color.DarkOrange;
                        start = rtxtboxCmd.Text.IndexOf(newValue, start) + 1;
                    }
                }
                else
                    rtxtboxCmd.Text = resultCmd;
                #endregion
                ChangeToDefault();
                MessageBox.Show("Your conversion is completed successfully", "Success",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("The following exception was raised: \n" + ex.Message,
                            "Error Message",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                ChangeToDefault();
            }
        }

        // Methode Change to default
        private void ChangeToDefault()
        {
            Cursor = DefaultCursor;
            BtnStart.Enabled = false;
            txtboxFileName.Text = "Chose your file ...";
            labelFilename.Text = "...";
            ofd.FileName = "";
            ifChanged = false;
            panelLoading.Visible = false;
        }

        // Méthode .AVI
        private void AviMethode()
        {
            ofd.Filter = "Videos files (*.avi) | *.avi";
            fileExtension.Clear();
            fileExtension.Add(".avi");
            CommandFFmpegMiddle = " ";
        }
    }
}
