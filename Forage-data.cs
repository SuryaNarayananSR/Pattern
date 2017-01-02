using System;
using System.Drawing;
using System.Windows.Forms;

namespace Patern
{
    public partial class Forage_data : Form
    {
        String source;
        String dest;
        public Forage_data()
        {
            InitializeComponent();
            this.Icon = new Icon("C:/Users/104752/documents/visual studio 2012/Projects/Patern/Patern/Data+Mining.ico");
        }

        private void frgData_Click(object sender, EventArgs e)
        {
            try
            {
                source = srcPath.Text.Replace("\\","\\\\");
                dest = desPath.Text.Replace("\\", "\\\\");
                Forage get = new Forage(source, dest);
                get.obtain();
                //Closing the files
                get.destroy();

                MessageBox.Show("Success");
            }
            catch(Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Form Exception : " + ex);
            }
        }

        private void srcPath_TextChanged(object sender, EventArgs e)
        {
            srcTip.SetToolTip(srcPath, "Sample Loaction :- 'C:\\math.xml'");
        }

        private void desPath_TextChanged(object sender, EventArgs e)
        {
            desTip.SetToolTip(desPath, "Sample Loaction :- 'C:\\output.txt");
        }

        private void about_Click(object sender, EventArgs e)
        {
            About abj = new About();
            abj.Show();
        }
    }
}
