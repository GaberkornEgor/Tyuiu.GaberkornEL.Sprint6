using System;
using System.Windows.Forms;
using Tyuiu.GaberkornEL.Sprint6.Task1.V24.Lib;

namespace Tyuiu.GaberkornEL.Sprint6.Task1.V24
{
    public partial class FormMain : Form
    {
        private DataService ds = new DataService();

        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonDone_GEL_Click(object sender, EventArgs e)
        {
            try
            {
                int startValue = Convert.ToInt32(textBoxVarStart_GEL.Text);
                int stopValue = Convert.ToInt32(textBoxVarStop_GEL.Text);

                if (startValue > stopValue)
                {
                    MessageBox.Show("Начальное значение должно быть меньше конечного!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                double[] valueArray = ds.GetMassFunction(startValue, stopValue);

                textBoxRes_GEL.Clear();

                textBoxRes_GEL.AppendText("+----------+----------+" + Environment.NewLine);
                textBoxRes_GEL.AppendText("|    X     |    f(x)   |" + Environment.NewLine);
                textBoxRes_GEL.AppendText("+----------+----------+" + Environment.NewLine);

                int x = startValue;
                foreach (double value in valueArray)
                {
                    string strLine = string.Format("|{0,10}|{1,10:F2}|", x, value);
                    textBoxRes_GEL.AppendText(strLine + Environment.NewLine);
                    x++;
                }

                textBoxRes_GEL.AppendText("+----------+----------+" + Environment.NewLine);
            }
            catch (FormatException)
            {
                MessageBox.Show("Введите целые числа в поля начала и конца шага!", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_GEL_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент группы АСОиУб-25-1 Габеркорн Егор Леонидович",
                "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}