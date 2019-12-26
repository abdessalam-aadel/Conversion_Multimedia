using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Conversion_Multimedia
{
    public partial class ChoseFile : UserControl
    {

        public ChoseFile()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            // Open file dialog and customize
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Videos files|*.mp4";
            ofd.DefaultExt = "mp4";
            ofd.InitialDirectory = "C:/";
            ofd.RestoreDirectory = true;
            ofd.Title = "Chose your file";
            DialogResult result = ofd.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtboxFileName.Text = ofd.FileName;
                btnStart.Enabled = true;
                labelFilename.Text = ofd.SafeFileName;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                // change the cursor and disable butto start
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

                    //use the redirected input -output
                    process.StartInfo.RedirectStandardInput = true;
                    process.StartInfo.RedirectStandardOutput = true;

                    // Start process
                    process.Start();

                    // Declare variable input and output of FFmpeg tools
                    string input = txtboxFileName.Text;
                    string output = "output_" + labelFilename.Text.Replace(".mp4", "") + ".avi";

                    // path of FFmpeg tools
                    string ffmpeg = @"tools\x32\bin\ffmpeg.exe";


                    // Start Command line ...
                    process.StandardInput.WriteLine(ffmpeg + " -i " + input + " " + output);
                    //process.StandardInput.WriteLine("ipconfig");




                    process.StandardInput.Flush();
                    process.StandardInput.Close();
                    //process.BeginOutputReadLine();
                    process.WaitForExit();

                    // the result of cmd
                    string resultCmd = process.StandardOutput.ReadToEnd();

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
                            // Set the highlight color as red
                            rtxtboxCmd.SelectionColor = Color.DarkOrange;
                            start = rtxtboxCmd.Text.IndexOf(txtToSearch,start)+1;
                        }
                    }
                    else
                        rtxtboxCmd.Text = "Nothing to show !!";
                    process.Close();
                }
                ChangeToDefault();
            }
            catch (Exception ex)
            {
                MessageBox.Show("The following exception was raised: \n" + ex.Message);
                ChangeToDefault();
            }
        }

        // Methode change to default
        private void ChangeToDefault()
        {
            this.Cursor = DefaultCursor;
            txtboxFileName.Text = "Chose your file ...";
            labelFilename.Text = "...";
        }
    }
}
