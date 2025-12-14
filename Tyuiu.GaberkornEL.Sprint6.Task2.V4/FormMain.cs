using Tyuiu.GaberkornEL.Sprint6.Task2.V4.Lib;
namespace Tyuiu.GaberkornEL.Sprint6.Task2.V4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        DataService ds = new DataService();
        private void button_Go_Click(object sender, EventArgs e)
        {
            try
            {
                int start = Convert.ToInt32(textBox_Start.Text);
                int stop = Convert.ToInt32(textBox_Stop.Text);

                int len = ds.GetMassFunction(start, stop).Length;
                double[] value = new double[len];
                value = ds.GetMassFunction(start, stop);
                this.chart1.Titles.Add("Ãðàôèê ôóíêöèè");
                this.chart1.ChartAreas[0].AxisX.Title = "Îñü ÎÕ";
                this.chart1.ChartAreas[0].AxisY.Title = "Îñü ÎY";

                for (int i = 0; i < len; i++)
                {
                    this.dataGridView1.Rows.Add(Convert.ToString(start), Convert.ToString(value[i]));
                    this.chart1.Series[0].Points.AddXY(start, value[i]);
                    start++;
                }





            }
            catch
            {
                MessageBox.Show("Ошибка", "ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_Spr_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнил студент АСОиУб-25-1 Габеркорн Егор Леонидович", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}