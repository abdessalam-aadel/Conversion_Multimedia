using System;
using System.Windows.Forms;

namespace Conversion_Multimedia
{
    public partial class ConversionMultimediaForm : Form
    {
        public string Types;

        public ConversionMultimediaForm()
        {
            InitializeComponent();
            startConversion1.BringToFront();
        }
        
        public string PassingTypeOfConversion
        {
            get { return labelOfTypes.Text; }
        }

        private void btnLetsGo_Click(object sender, EventArgs e)
        {
            try
            {
                Types = startConversion1.SelectedTypes.TypeOutput;
                labelOfTypes.Text = Types;
                // passing data from form to userControl (ChoseFile.cs) ...
                choseFile1.PassingTypeOfConversion = PassingTypeOfConversion;

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
            btnBack.Visible = true;
            labelOfTypes.Visible = true;
        }

        // Handle Event click of Button Back
        private void btnBack_Click(object sender, EventArgs e)
        {
            startConversion1.BringToFront();
            btnBack.Visible = false;
            btnLetsGo.Visible = true;
            labelOfTypes.Visible = false;
        }
    }
}
