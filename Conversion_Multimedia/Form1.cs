using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Conversion_Multimedia
{
    public partial class ConversionMultimediaForm : Form
    {

        public ConversionMultimediaForm()
        {
            InitializeComponent();
            startConversion.BringToFront();
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBox.Text == "Extract sound from video")
            {
                choseFile1.BringToFront();
                comboBox.Visible = false;

            }

            else if (comboBox.Text == ".wav to .mp3")
            {
                choseFile1.BringToFront();
                comboBox.Visible = false;
            }

            else if (comboBox.Text == ".avi to .mpg")
            {
                choseFile1.BringToFront();
                comboBox.Visible = false;
            }

            else if (comboBox.Text == ".mpg to .avi")
            {
                choseFile1.BringToFront();
                comboBox.Visible = false;
            }

            else if (comboBox.Text == ".avi to .flv")
            {
                choseFile1.BringToFront();
                comboBox.Visible = false;
            }

            else if (comboBox.Text == ".avi to .gif")
            {
                choseFile1.BringToFront();
                comboBox.Visible = false;
            }

            else if (comboBox.Text == ".avi to .dv")
            {
                choseFile1.BringToFront();
                comboBox.Visible = false;
            }

            else if (comboBox.Text == ".avi to .mpeg")
            {
                choseFile1.BringToFront();
                comboBox.Visible = false;
            }

            else if (comboBox.Text == ".avi to .mp4")
            {
                choseFile1.BringToFront();
                comboBox.Visible = false;
            }

            else
                MessageBox.Show("This méthode could not exist !");
        }
    }
}
