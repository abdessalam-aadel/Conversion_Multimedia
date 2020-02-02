using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.Drawing;

namespace Conversion_Multimedia
{
    public partial class ConversionMultimediaForm : Form
    {
        public string OthersOptions;
        public bool ifChanged;

        public ConversionMultimediaForm()
        {
            InitializeComponent();
            startConversion1.BringToFront();
        }
        // passing value : type of conversion
        public string GetPassingTypeOfConversion() { return labelOfTypes.Text; }
        // passing value : Others options (crop,resize, or add subtitle)
        public string GetOthersOptions() { return OthersOptions; }
        // passing value : for ifChanged (if you click in button 'BackToHome' or 'Back' : ifChanged = true;)
        public bool GetChanged() { return ifChanged; }

        // Handle event click Button Let's Go
        private void btnLetsGo_Click(object sender, EventArgs e)
        {
            try
            {
                labelOfTypes.Text = startConversion1.SelectedTypes.TypeOutput;
                // passing data from form to userControl (ChoseFile.cs) ...
                choseFile1.PassingTypeOfConversion = GetPassingTypeOfConversion();

                // Methode Bring to front
                BringToFrontAndBack();
                // Change Cursor
                ChangeCursor(10);
            }
            catch (Exception)
            {
                // Show message Error !!
                MessageBox.Show("Please chose your conversion type ...",
                            "Error Message",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation);
            }
        }

        // Handle Methode Bring to front and return button back visible ...
        private void BringToFrontAndBack()
        {
            choseFile1.BringToFront();
            btnLetsGo.Visible = false;
            BtnBackHome.Visible = true;
            labelOfTypes.Visible = true;
            BtnOthers.Visible = false;
            ifChanged = false;
        }

        // Handle Event click of Button Others Conversion ...
        private void BtnOthers_Click(object sender, EventArgs e)
        {
            others1.BringToFront();
            btnLetsGo.Visible = false;
            labelOfTypes.Visible = false;
            BtnBackHome.Visible = true;
            BtnOthers.Visible = false;
            BtnNext.Visible = true;
            ifChanged = false;
        }

        // Handle Event click of Button Back to Home ...
        private void BtnBackHome_Click(object sender, EventArgs e)
        {
            startConversion1.BringToFront();
            BtnBackHome.Visible = false;
            btnLetsGo.Visible = true;
            labelOfTypes.Visible = false;
            BtnOthers.Visible = true;
            BtnNext.Visible = false;
            BtnBack.Visible = false;
            ifChanged = true;
            choseFile1.SetChanged = GetChanged();
            crop1.SetChanged = GetChanged();
            addSubtitles1.SetChanged = GetChanged();
            resize1.SetChanged = GetChanged();
        }

        // Handle Event click of Button Back ...
        private void BtnBack_Click(object sender, EventArgs e)
        {
            others1.BringToFront();
            BtnBack.Visible = false;
            BtnNext.Visible = true;
            ifChanged = true;
            crop1.SetChanged = GetChanged();
            addSubtitles1.SetChanged = GetChanged();
            resize1.SetChanged = GetChanged();
        }

        // Handle Event click of Button Next ...
        private void BtnNext_Click(object sender, EventArgs e)
        {
            OthersOptions = others1.SetOptionsIsChecked;
            ifChanged = false;
            ChangeCursor(0);
            switch (OthersOptions)
            {
                case "Crop":
                    crop1.BringToFront();
                    VisibleButton();
                    break;
                case "Resize":
                    resize1.BringToFront();
                    VisibleButton();
                    break;
                case "Add Subtitles":
                    addSubtitles1.BringToFront();
                    VisibleButton();
                    break;
                default:
                    MessageBox.Show("\t Nothing ! \nPlease check your option ...");
                    return;
            }
        }

        // Methode Visible Button
        public void VisibleButton()
        {
            BtnBack.Visible = true;
            BtnNext.Visible = false;
        }

        // -- Minimize Form Main win you press Escape in keyboard --
        private void ConversionMultimediaForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
                WindowState = FormWindowState.Minimized;
        }

        private void linkGit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/abdessalam-aadel/Conversion_Multimedia");
        }

        // Center the mouse over a control like choseFile1 (userControl) 
        public void ChangeCursor(int i)
        {
            Point p = new Point((choseFile1.Left + choseFile1.Right) / 2, (choseFile1.Top + choseFile1.Bottom) / 2 - i);
            Point pcenter = choseFile1.Parent.PointToScreen(p);
            Cursor.Position = pcenter;
        }
    }
}
