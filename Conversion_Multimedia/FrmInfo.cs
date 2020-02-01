using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Conversion_Multimedia
{
    public partial class FrmInfo : Form
    {
        public FrmInfo() => InitializeComponent();

        public void GetValue(string info)
        {
            #region Replace Location
            string pattern = @"\w:(\\.+)*>(?!&)";
            Match match = Regex.Match(info, pattern);
            if (match.Success)
            {
                rtxtBox.Text = info.Replace(match.Value, "► ");
            }
            else
                rtxtBox.Text = info;
            #endregion
        }

        // Handle event click for Button Exit ..
        private void BtnExit_Click(object sender, EventArgs e)
        {
            rtxtBox.Clear();
            this.Close();
        }
    }
}
