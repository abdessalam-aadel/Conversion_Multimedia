using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Conversion_Multimedia
{
    public partial class StartConversion : UserControl
    {
        public StartConversion()
        {
            InitializeComponent();
        }

        // Methode to pass data from user control to the Form
        public TypeOfConversion SelectedTypes => (TypeOfConversion)ComboBoxTypes.SelectedItem;

        private void StartConversion_Load(object sender, EventArgs e)
        {
            // Add Data source from list
            List<TypeOfConversion> list = new List<TypeOfConversion>();
            list.Add(new TypeOfConversion() { ID = 1, TypeOutput = "Extract sound from video" });
            list.Add(new TypeOfConversion() { ID = 2, TypeOutput = ".avi to .mpg" });
            list.Add(new TypeOfConversion() { ID = 3, TypeOutput = ".mpg to .avi" });
            list.Add(new TypeOfConversion() { ID = 4, TypeOutput = ".avi to .flv" });
            list.Add(new TypeOfConversion() { ID = 5, TypeOutput = ".avi to .gif" });
            list.Add(new TypeOfConversion() { ID = 6, TypeOutput = ".avi to .dv" });
            list.Add(new TypeOfConversion() { ID = 7, TypeOutput = ".avi to .mpeg" });
            list.Add(new TypeOfConversion() { ID = 8, TypeOutput = ".wav or .avi to .mp4" });
            list.Add(new TypeOfConversion() { ID = 9, TypeOutput = ".mkv to .mp4" });
            list.Add(new TypeOfConversion() { ID = 10, TypeOutput = "Convert a Video to X Images" });
            list.Add(new TypeOfConversion() { ID = 11, TypeOutput = "Compress .avi to VCD mpeg2" });
            list.Add(new TypeOfConversion() { ID = 12, TypeOutput = ".webp to .png" });
            list.Add(new TypeOfConversion() { ID = 13, TypeOutput = "JPEG compression quality" });
            list.Add(new TypeOfConversion() { ID = 14, TypeOutput = "PNG compression quality" });

            ComboBoxTypes.DataSource = list;
            ComboBoxTypes.ValueMember = "ID";
            ComboBoxTypes.DisplayMember = "TypeOutput";
        }
    }
}
