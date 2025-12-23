using System;
using System.Windows.Forms;
using Tyuiu.GaberkornEL.Sprint6.Task3.V17.Lib;

namespace Tyuiu.GaberkornEL.Sprint6.Task3.V17
{
    public partial class FormMain : Form
    {
        DataService ds = new DataService();

        int[,] mtrx = new int[5, 5] {
            {22, 32, -16, 24, 27},
            {3, -20, 24, -20, 25},
            {21, 17, -8, -19, 17},
            {8, 22, 28, 27, 19},
            {11, 20, 12, 7, 29},
        };

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

            int rows = mtrx.GetUpperBound(0) + 1;
            int columns = mtrx.Length / rows;

            dataGridViewTask_GEL.ColumnCount = columns;
            dataGridViewTask_GEL.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewTask_GEL.Columns[i].Width = 50;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewTask_GEL.Rows[i].Cells[j].Value = mtrx[i, j];
                }
            }
        }

        private void buttonRun_GEL_Click(object sender, EventArgs e)
        {
            int[,] res = ds.Calculate(mtrx);

            int rows = res.GetUpperBound(0) + 1;
            int columns = res.Length / rows;

            dataGridViewResult_GEL.ColumnCount = columns;
            dataGridViewResult_GEL.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewResult_GEL.Columns[i].Width = 50;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewResult_GEL.Rows[i].Cells[j].Value = res[i, j];
                }
            }
        }

        private void buttonInfo_GEL_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнил студент группы АСОиУб-25-1 Габеркорн Егор Леонидович",
                "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}