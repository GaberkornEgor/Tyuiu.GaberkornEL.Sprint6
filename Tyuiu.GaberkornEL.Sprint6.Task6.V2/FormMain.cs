using System;
using System.IO;
using System.Windows.Forms;
using Tyuiu.GaberkornEL.Sprint6.Task6.V2.Lib;

namespace Tyuiu.GaberkornEL.Sprint6.Task6.V2
{
    public partial class FormMain : Form
    {
        private string openFilePath;
        private DataService ds = new DataService();

        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonFile_GEL_Click(object sender, EventArgs e)
        {
            openFileDialog_GEL.Filter = "Текстовые файлы|*.txt|Все файлы|*.*";
            openFileDialog_GEL.Title = "Выберите файл для обработки";

            if (openFileDialog_GEL.ShowDialog() == DialogResult.OK)
            {
                openFilePath = openFileDialog_GEL.FileName;
                textBoxInput_GEL.Text = File.ReadAllText(openFilePath);
                groupBoxTwo_GEL.Text = "Ввод: " + Path.GetFileName(openFilePath);
                buttonDone_GEL.Enabled = true;
            }
        }

        private void buttonDone_GEL_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(openFilePath))
            {
                MessageBox.Show("Сначала откройте файл!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string str = "**";
            textBoxResult_GEL.Text = ds.CollectTextFromFile(openFilePath);
        }

        private void buttonReference_GEL_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }
}