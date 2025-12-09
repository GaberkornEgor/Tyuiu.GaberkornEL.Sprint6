using Tyuiu.GaberkornEL.Sprint6.Task0.V3.Lib;
namespace Tyuiu.GaberkornEL.Sprint6.Task0.V3
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

        private void buttonfst_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                textBoxResult_gel.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxone_gel.Text)));
            }
            catch
            {
                MessageBox.Show("Неверно введены данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void textBoxone_gel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != '.') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }


        private void textBoxd_gel_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBoxTask_Enter(object sender, EventArgs e)
        {

        }

        private void textBoxResult_gel_TextChanged(object sender, EventArgs e)
        {

        }
    }
}