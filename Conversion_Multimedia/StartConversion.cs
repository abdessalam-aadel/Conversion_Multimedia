using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Conversion_Multimedia
{
    public partial class StartConversion : UserControl
    {
        public StartConversion() => InitializeComponent();

        // Methode to pass data from user control to the Form
        public TypeOfConversion SelectedTypes => (TypeOfConversion)ComboBoxTypes.SelectedItem;

        private void StartConversion_Load(object sender, EventArgs e)
        {
            // Add Data source from list
            List<TypeOfConversion> list = new List<TypeOfConversion>();
            string[] typesConversion = new string[] 
            {
                "Extract sound from video" ,
                ".avi to .mpg",
                ".mpg to .avi",
                ".avi to .flv",
                ".avi to .gif",
                ".avi to .dv",
                ".avi to .mpeg",
                ".wav or .avi to .mp4",
                ".mkv to .mp4",
                "Convert a Video to X Images",
                "Compress .avi to VCD mpeg2",
                ".webp to .png",
                "JPEG compression quality",
                "PNG compression quality"
            };
            for (int i = 0; i < typesConversion.Length; i++)
            {
                list.Add(new TypeOfConversion() { ID = i+1, TypeOutput = typesConversion[i] });
            }
            ComboBoxTypes.DataSource = list;
            ComboBoxTypes.ValueMember = "ID";
            ComboBoxTypes.DisplayMember = "TypeOutput";
        }
    }
}
