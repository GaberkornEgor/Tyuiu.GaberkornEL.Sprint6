using System;
using System.Windows.Forms;

namespace Tyuiu.GaberkornEL.Sprint6.Task6.V2
{
    public partial class FormAbout : Form
    {
        public FormAbout()
        {
            InitializeComponent();
        }

        private void buttonDone_GEL_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}