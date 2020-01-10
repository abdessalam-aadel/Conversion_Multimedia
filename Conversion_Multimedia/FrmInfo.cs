using System;
using System.Windows.Forms;

namespace Conversion_Multimedia
{
    public partial class FrmInfo : Form
    {
        public FrmInfo() => InitializeComponent();

        public void GetValue(string info) => rtxtBox.Text += info;

        // Handle event click for Button Exit ..
        private void BtnExit_Click(object sender, EventArgs e)
        {
            rtxtBox.Clear();
            this.Close();
        }
    }
}
