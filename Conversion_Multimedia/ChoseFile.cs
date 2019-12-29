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
        public string Types;
        public string TypesOutput;
        public string CommandFFmpegMiddle;

        public ChoseFile()
        {
            InitializeComponent();
        }

        // passing value of type convertion from Form to userControl (ChoseFile.cs)
        public string PassingTypeOfConversion
        {
            set { Types = value; }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            // Open file dialog and customize
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = "C:/";
            ofd.RestoreDirectory = true;
            ofd.Title = "Chose your file";

            #region Looking fo your type ...
            if (Types == "Extract sound from video")
            {
                ofd.Filter = "Videos files|*.mp4";
                ofd.DefaultExt = "mp4";
                TypesOutput = ".mp3";
                CommandFFmpegMiddle = " -vn -ar 44100 -ac 2 -ab 192k -f mp3 ";
            }

            else if (Types == ".wav to .mp3")
            {
                ofd.Filter = "Videos files|*.wav";
                ofd.DefaultExt = "wav";
                TypesOutput = ".mp3";
                CommandFFmpegMiddle = " -vn -ar 44100 -ac 2 -ab 192k -f mp3 ";
            }

            else if (Types == ".avi to .mpg")
            {
                ofd.Filter = "Videos files|*.avi";
                ofd.DefaultExt = "avi";
                TypesOutput = ".mpg";
                CommandFFmpegMiddle = " ";
            }

            else if (Types == ".mpg to .avi")
            {
                ofd.Filter = "Videos files|*.mpg";
                ofd.DefaultExt = "mpg";
                TypesOutput = ".avi";
                CommandFFmpegMiddle = " ";
            }

            else if (Types == ".avi to .flv")
            {
                ofd.Filter = "Videos files|*.avi";
                ofd.DefaultExt = "avi";
                TypesOutput = ".flv";
                CommandFFmpegMiddle = " -ab 56 -ar 44100 -b 200 -r 15 -s 320x240 -f flv ";
            }

            else if (Types == ".avi to .gif")
            {
                ofd.Filter = "Videos files|*.avi";
                ofd.DefaultExt = "avi";
                TypesOutput = ".gif";
                CommandFFmpegMiddle = " ";
            }

            else if (Types == ".avi to .dv")
            {
                ofd.Filter = "Videos files|*.avi";
                ofd.DefaultExt = "avi";
                TypesOutput = ".dv";
                CommandFFmpegMiddle = " -s pal -r pal -aspect 4:3 -ar 48000 -ac 2 ";
            }

            else if (Types == ".avi to .mpeg")
            {
                ofd.Filter = "Videos files|*.avi";
                ofd.DefaultExt = "avi";
                TypesOutput = ".mpeg";
                CommandFFmpegMiddle = " -target pal-dvd -ps 2000000000 -aspect 16:9 ";
            }

            else if (Types == ".avi to .mp4")
            {
                ofd.Filter = "Videos files|*.avi";
                ofd.DefaultExt = "avi";
                TypesOutput = ".mp4";
                CommandFFmpegMiddle = " ";
            }

            else
                MessageBox.Show("This méthode could not exist !");
            #endregion

            DialogResult result = ofd.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtboxFileName.Text = ofd.FileName;
                btnStart.Enabled = true;
                labelFilename.Text = Path.GetFileNameWithoutExtension(ofd.SafeFileName);
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                // change the cursor and disable button start
                this.Cursor = Cursors.WaitCursor;
                btnStart.Enabled = false;

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

                    string output = "output_" + labelFilename.Text.Replace(" ","_") + TypesOutput;
                    string ffmpeg;

                    // Start Condition : if you have win32 or win64
                    if (Environment.Is64BitOperatingSystem)
                        ffmpeg = @"tools\x64\bin\ffmpeg.exe"; // path of FFmpeg tools for win32
                    else
                        ffmpeg = @"tools\x32\bin\ffmpeg.exe"; // path of FFmpeg tools for win64

                    // Others method :
                    //process.StandardInput.WriteLine("wmic os get osarchitecture");

                    // Start Command line ...
                    // Fix issue : ffmpeg not working with filenames that have whitespace
                    // Add double quotes to input filenames
                    process.StandardInput.WriteLine(ffmpeg + " -i " + "\"" + input + "\"" + CommandFFmpegMiddle + output);
                    
                    // this command just for test
                    //process.StandardInput.WriteLine("ipconfig");

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
        }
    }
}
