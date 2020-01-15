using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;

namespace Conversion_Multimedia
{
    public partial class ChoseFile : UserControl
    {
        public string Types, TypesOutput, CommandFFmpegMiddle, ImagesOutput;

        // Customize Open file dialog 
        OpenFileDialog ofd = new OpenFileDialog
        {
            InitialDirectory = "C:/",
            RestoreDirectory = true,
            Title = "Chose your file"
        };

        public ChoseFile() => InitializeComponent();

        // passing value of type convertion from Form to userControl (ChoseFile.cs)
        public string PassingTypeOfConversion
        {
            set => Types = value;
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            #region Looking fo your type ...
            switch (Types)
            {
                case "Extract sound from video":
                    ofd.Filter = "Videos files (*.mp4, *.avi, *.flv, *.wav ) | *.mp4; *.avi; *.flv; *.wav";
                    ofd.DefaultExt = "mp4";
                    TypesOutput = ".mp3";
                    CommandFFmpegMiddle = " -vn -ar 44100 -ac 2 -ab 192k -f mp3 ";
                    break;
                case ".avi to .mpg":
                    AviMethode();
                    TypesOutput = ".mpg";
                    break;
                case ".mpg to .avi":
                    ofd.Filter = "Videos files (*.mpg) | *.mpg";
                    TypesOutput = ".avi";
                    CommandFFmpegMiddle = " ";
                    break;
                case ".avi to .flv":
                    ofd.Filter = "Videos files (*.avi) | *.avi";
                    TypesOutput = ".flv";
                    CommandFFmpegMiddle = " -ab 56 -ar 44100 -b 200 -r 15 -s 320x240 -f flv ";
                    break;
                case ".avi to .gif":
                    AviMethode();
                    TypesOutput = ".gif";
                    break;
                case ".avi to .dv":
                    ofd.Filter = "Videos files (*.avi) | *.avi";
                    TypesOutput = ".dv";
                    CommandFFmpegMiddle = " -s pal -r pal -aspect 4:3 -ar 48000 -ac 2 ";
                    break;
                case ".avi to .mpeg":
                    ofd.Filter = "Videos files (*.avi) | *.avi";
                    TypesOutput = ".mpeg";
                    CommandFFmpegMiddle = " -target pal-dvd -ps 2000000000 -aspect 16:9 ";
                    break;
                case ".wav or .avi to .mp4":
                    ofd.Filter = "Videos files (*.wav, *.avi) | *.wav; *.avi";
                    TypesOutput = ".mp4";
                    CommandFFmpegMiddle = " ";
                    break;
                case ".mkv to .mp4":
                    ofd.Filter = "Videos files (*.mkv) | *.mkv";
                    TypesOutput = ".mp4";
                    CommandFFmpegMiddle = " -codec copy ";
                    break;
                case "Convert a Video to X Images":
                    ofd.Filter = "Videos files (*.mp4, *.mov, *.m4a, *.3gp, *.3g2, *.mj2, *.avi, *.flv, *.wav) | *.mp4; *.mov; *.m4a; *.3gp; *.3g2; *.mj2; *.avi; *.flv; *.wav";
                    TypesOutput = ".jpg";
                    ImagesOutput = "%d";
                    CommandFFmpegMiddle = " ";
                    break;
                case "Compress .avi to VCD mpeg2":
                    ofd.Filter = "Videos files (*.avi) | *.avi";
                    TypesOutput = ".mpg";
                    CommandFFmpegMiddle = " -target ntsc-vcd ";
                    break;
                case ".webp to .png":
                    ofd.Filter = "Images files (*.webp) | *.webp";
                    TypesOutput = ".png";
                    CommandFFmpegMiddle = " ";
                    break;
                case "JPEG & PNG compression quality":
                    ofd.Filter = "Images files (*.jpg, *.png) | *.jpg; *.png";
                    TypesOutput = ".jpg";
                    CommandFFmpegMiddle = " -compression_level 100 ";
                    break;
                case "Change Bitrate to 10MB":
                    ofd.Filter = "Videos files (*.mp4) | *.mp4";
                    TypesOutput = ".mp4";
                    CommandFFmpegMiddle = " -b:v 10M ";
                    break;
                default:
                    MessageBox.Show("This méthode could not exist !");
                    return;
            }
            #endregion

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

        private void BtnStart_Click(object sender, EventArgs e)
        {
            try
            {
                // change the cursor and disable button start
                this.Cursor = Cursors.WaitCursor;
                BtnStart.Enabled = false;

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
                    string input = txtboxFileName.Text; 

                    string output = "output_" + labelFilename.Text.Replace(" ","_") + ImagesOutput + TypesOutput;
                    string ffmpeg;

                    // Start Condition : if you have win32 or win64
                    if (Environment.Is64BitOperatingSystem)
                        ffmpeg = @"tools\x64\bin\ffmpeg.exe"; // path of FFmpeg tools for win32
                    else
                        ffmpeg = @"tools\x32\bin\ffmpeg.exe"; // path of FFmpeg tools for win64

                    // Start Command line ...
                    // Fix issue : ffmpeg not working with filenames that have whitespace
                    // Add double quotes to input filenames
                    process.StandardInput.WriteLine(ffmpeg + " -i " + "\"" + input + "\"" + CommandFFmpegMiddle + output);
                    // Restart value of ImagesOutput
                    ImagesOutput = "";
                    // Flush & Close StandarInput
                    process.StandardInput.Flush();
                    process.StandardInput.Close();

                    // Wait for Exit
                    process.WaitForExit();

                    // Return the result of cmd
                    string resultCmd = process.StandardOutput.ReadToEnd();

                    #region Replace Location and Colored
                    string pattern = @"\w:(\\.+)*>";;
                    Match match = Regex.Match(resultCmd, pattern);
                    if (match.Success)
                    {
                        string oldvalueS = match.Value;
                        rtxtboxCmd.Text = resultCmd.Replace(oldvalueS, "kilya@Desktop $ ");

                        // Selection color kilya@Desktop $ 
                        string txtToSearch = "kilya@Desktop $ ";

                        int start = 0;
                        int end = rtxtboxCmd.Text.LastIndexOf(txtToSearch);
                        while (start < end)
                        {
                            rtxtboxCmd.Find(txtToSearch, start, rtxtboxCmd.TextLength, RichTextBoxFinds.MatchCase);
                            // Set the highlight color as DarkOrange
                            rtxtboxCmd.SelectionColor = Color.DarkOrange;
                            start = rtxtboxCmd.Text.IndexOf(txtToSearch,start)+1;
                        }
                    }
                    else
                        rtxtboxCmd.Text = "Nothing to show !!";
                    #endregion

                    // Close The Process
                    process.Close();
                }
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
            this.Cursor = DefaultCursor;
            txtboxFileName.Text = "Chose your file ...";
            labelFilename.Text = "...";
            ofd.FileName = "";
        }

        // Méthode .AVI
        private void AviMethode()
        {
            ofd.Filter = "Videos files (*.avi) | *.avi";
            CommandFFmpegMiddle = " ";
        }
    }
}
