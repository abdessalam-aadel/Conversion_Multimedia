using System;
using System.Windows.Forms;

namespace Conversion_Multimedia
{
    public partial class ConversionMultimediaForm : Form
    {
        public string Types, OthersOptions;

        public ConversionMultimediaForm()
        {
            InitializeComponent();
            startConversion1.BringToFront();
        }

        public string GetPassingTypeOfConversion() { return labelOfTypes.Text; }

        public string GetOthersOptions() { return OthersOptions; }

        // Handle event click Button Let's Go
        private void btnLetsGo_Click(object sender, EventArgs e)
        {
            try
            {
                Types = startConversion1.SelectedTypes.TypeOutput;
                labelOfTypes.Text = Types;
                // passing data from form to userControl (ChoseFile.cs) ...
                choseFile1.PassingTypeOfConversion = GetPassingTypeOfConversion();

                // Methode Bring to front
                BringToFrontAndBack();
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
        }

        // Handle Event click of Button Back ...
        private void BtnBack_Click(object sender, EventArgs e)
        {
            others1.BringToFront();
            BtnBack.Visible = false;
            BtnNext.Visible = true;
        }

        // Handle Event click of Button Next ...
        private void BtnNext_Click(object sender, EventArgs e)
        {
            OthersOptions = others1.SetOptionsIsChecked;
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
                    MessageBox.Show("Nothing ! \nPlease check your option ...");
                    return;
            }
        }

        // Methode Visible Button
        public void VisibleButton()
        {
            BtnBack.Visible = true;
            BtnNext.Visible = false;
        }

        // -- win you press Escape in keyboard --
        private void ConversionMultimediaForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
                WindowState = FormWindowState.Minimized;
        }
    }
}
