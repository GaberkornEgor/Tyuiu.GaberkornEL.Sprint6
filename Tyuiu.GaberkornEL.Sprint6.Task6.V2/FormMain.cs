using Tyuiu.GaberkornEL.Sprint6.Task6.V2.Lib;
namespace Tyuiu.GaberkornEL.Sprint6.Task6.V2
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        string openFilePath;
        DataService ds = new DataService();

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            openFileDialog_GEL.ShowDialog();
            openFilePath = openFileDialog_GEL.FileName;
            textBoxInput_GEL.Text = File.ReadAllText(openFilePath);
            groupBoxTwo_GEL.Text = groupBoxTwo_GEL.Text + " " + openFileDialog_GEL.FileName;
            buttonDone_GEL.Enabled = true;
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            string str = "**";
            textBoxResult_GEL.Text = ds.CollectTextFromFile(str, openFilePath);
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            FormAbout_GEL formAbout = new FormAbout_GEL();
            formAbout.ShowDialog();
        }
    }
}