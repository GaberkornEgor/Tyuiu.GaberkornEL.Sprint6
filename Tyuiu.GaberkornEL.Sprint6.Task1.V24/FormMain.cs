using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.GaberkornEL.Sprint6.Task1.V24.Lib;
namespace Tyuiu.GaberkornEL.Sprint6.Task1.V24
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        DataService ds = new DataService();
        private void buttonDone_GEL_Click(object sender, EventArgs e)
        {
            try
            {
                int startValue = Convert.ToInt32(textBoxVarStart_GEL.Text);
                int stopValue = Convert.ToInt32(textBoxVarStop_GEL.Text);

                string strLine;

                int len = ds.GetMassFunction(startValue, stopValue).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startValue, stopValue);
                textBoxRes_GEL.Text = "";
                textBoxRes_GEL.AppendText("+----------+----------+" + Environment.NewLine);
                textBoxRes_GEL.AppendText("|    X     |   f(x)   |" + Environment.NewLine);
                textBoxRes_GEL.AppendText("+----------+----------+" + Environment.NewLine);

                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = String.Format("|{0,5:d}     |  {1, 5:f2}   |", startValue, valueArray[i]);
                    textBoxRes_GEL.AppendText(strLine + Environment.NewLine);
                    startValue++;
                }

                textBoxRes_GEL.AppendText("+----------+----------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_GEL_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнин студентом группы АСОиУБ-25-1 Габеркорн Егор Леонидович", "Сообщение", MessageBoxButtons.OK);
        }

        private void textBoxVarStart_GEL_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxRes_GEL_TextChanged(object sender, EventArgs e)
        {

        }
    }
}