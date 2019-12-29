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
        public TypeOfConversion SelectedTypes
        {
            get { return (TypeOfConversion)ComboBoxTypes.SelectedItem; }
        }

        // Others methode to pass data from user control to this Form
        // you can Apply Delegate methode ...

        private void StartConversion_Load(object sender, EventArgs e)
        {
            // Add Data source from list
            List<TypeOfConversion> list = new List<TypeOfConversion>();
            list.Add(new TypeOfConversion() { ID = 1, TypeOutput = "Extract sound from video" });
            list.Add(new TypeOfConversion() { ID = 2, TypeOutput = ".wav to .mp3" });
            list.Add(new TypeOfConversion() { ID = 3, TypeOutput = ".avi to .mpg" });
            list.Add(new TypeOfConversion() { ID = 4, TypeOutput = ".mpg to .avi" });
            list.Add(new TypeOfConversion() { ID = 5, TypeOutput = ".avi to .flv" });
            list.Add(new TypeOfConversion() { ID = 6, TypeOutput = ".avi to .gif" });
            list.Add(new TypeOfConversion() { ID = 7, TypeOutput = ".avi to .dv" });
            list.Add(new TypeOfConversion() { ID = 8, TypeOutput = ".avi to .mpeg" });
            list.Add(new TypeOfConversion() { ID = 9, TypeOutput = ".avi to .mp4" });

            ComboBoxTypes.DataSource = list;
            ComboBoxTypes.ValueMember = "ID";
            ComboBoxTypes.DisplayMember = "TypeOutput";
        }
    }
}
