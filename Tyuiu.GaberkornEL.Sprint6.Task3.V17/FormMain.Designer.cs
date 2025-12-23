using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Tyuiu.GaberkornEL.Sprint6.Task3.V17
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.groupBoxTask_GEL = new GroupBox();
            this.dataGridViewTask_GEL = new DataGridView();
            this.textBoxTask_GEL = new TextBox();
            this.groupBoxOutput_GEL = new GroupBox();
            this.dataGridViewResult_GEL = new DataGridView();
            this.labelResult_GEL = new Label();
            this.buttonInfo_GEL = new Button();
            this.buttonRun_GEL = new Button();

            this.groupBoxTask_GEL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTask_GEL)).BeginInit();
            this.groupBoxOutput_GEL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_GEL)).BeginInit();
            this.SuspendLayout();

            // groupBoxTask_GEL
            this.groupBoxTask_GEL.Controls.Add(this.dataGridViewTask_GEL);
            this.groupBoxTask_GEL.Controls.Add(this.textBoxTask_GEL);
            this.groupBoxTask_GEL.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTask_GEL.Name = "groupBoxTask_GEL";
            this.groupBoxTask_GEL.Size = new System.Drawing.Size(475, 438);
            this.groupBoxTask_GEL.TabIndex = 0;
            this.groupBoxTask_GEL.TabStop = false;
            this.groupBoxTask_GEL.Text = "Исходная матрица";

            // dataGridViewTask_GEL
            this.dataGridViewTask_GEL.AllowUserToAddRows = false;
            this.dataGridViewTask_GEL.AllowUserToDeleteRows = false;
            this.dataGridViewTask_GEL.ColumnHeadersVisible = false;
            this.dataGridViewTask_GEL.RowHeadersVisible = false;
            this.dataGridViewTask_GEL.Location = new System.Drawing.Point(225, 91);
            this.dataGridViewTask_GEL.Name = "dataGridViewTask_GEL";
            this.dataGridViewTask_GEL.ReadOnly = true;
            this.dataGridViewTask_GEL.Size = new System.Drawing.Size(225, 169);
            this.dataGridViewTask_GEL.TabIndex = 1;

            // textBoxTask_GEL (условие задачи)
            this.textBoxTask_GEL.Location = new System.Drawing.Point(6, 26);
            this.textBoxTask_GEL.Multiline = true;
            this.textBoxTask_GEL.Name = "textBoxTask_GEL";
            this.textBoxTask_GEL.ReadOnly = true;
            this.textBoxTask_GEL.ScrollBars = ScrollBars.Vertical;
            this.textBoxTask_GEL.Size = new System.Drawing.Size(464, 262);
            this.textBoxTask_GEL.TabIndex = 0;
            this.textBoxTask_GEL.Text = "Дана матрица. Обработать её по условию задания.";

            // groupBoxOutput_GEL
            this.groupBoxOutput_GEL.Controls.Add(this.dataGridViewResult_GEL);
            this.groupBoxOutput_GEL.Controls.Add(this.labelResult_GEL);
            this.groupBoxOutput_GEL.Location = new System.Drawing.Point(493, 12);
            this.groupBoxOutput_GEL.Name = "groupBoxOutput_GEL";
            this.groupBoxOutput_GEL.Size = new System.Drawing.Size(460, 377);
            this.groupBoxOutput_GEL.TabIndex = 1;
            this.groupBoxOutput_GEL.TabStop = false;
            this.groupBoxOutput_GEL.Text = "Результат";

            // dataGridViewResult_GEL
            this.dataGridViewResult_GEL.AllowUserToAddRows = false;
            this.dataGridViewResult_GEL.AllowUserToDeleteRows = false;
            this.dataGridViewResult_GEL.ColumnHeadersVisible = false;
            this.dataGridViewResult_GEL.RowHeadersVisible = false;
            this.dataGridViewResult_GEL.Location = new System.Drawing.Point(6, 56);
            this.dataGridViewResult_GEL.Name = "dataGridViewResult_GEL";
            this.dataGridViewResult_GEL.ReadOnly = true;
            this.dataGridViewResult_GEL.Size = new System.Drawing.Size(228, 188);
            this.dataGridViewResult_GEL.TabIndex = 1;

            // labelResult_GEL
            this.labelResult_GEL.AutoSize = true;
            this.labelResult_GEL.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelResult_GEL.Location = new System.Drawing.Point(6, 23);
            this.labelResult_GEL.Name = "labelResult_GEL";
            this.labelResult_GEL.Size = new System.Drawing.Size(78, 23);
            this.labelResult_GEL.TabIndex = 0;
            this.labelResult_GEL.Text = "Результат:";

            // buttonInfo_GEL
            this.buttonInfo_GEL.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.buttonInfo_GEL.Location = new System.Drawing.Point(717, 395);
            this.buttonInfo_GEL.Name = "buttonInfo_GEL";
            this.buttonInfo_GEL.Size = new System.Drawing.Size(65, 55);
            this.buttonInfo_GEL.TabIndex = 2;
            this.buttonInfo_GEL.Text = "?";
            this.buttonInfo_GEL.UseVisualStyleBackColor = true;
            this.buttonInfo_GEL.Click += new System.EventHandler(this.buttonInfo_GEL_Click);

            // buttonRun_GEL
            this.buttonRun_GEL.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.buttonRun_GEL.Location = new System.Drawing.Point(788, 395);
            this.buttonRun_GEL.Name = "buttonRun_GEL";
            this.buttonRun_GEL.Size = new System.Drawing.Size(165, 55);
            this.buttonRun_GEL.TabIndex = 3;
            this.buttonRun_GEL.Text = "Выполнить";
            this.buttonRun_GEL.UseVisualStyleBackColor = true;
            this.buttonRun_GEL.Click += new System.EventHandler(this.buttonRun_GEL_Click);

            // FormMain
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 462);
            this.Controls.Add(this.buttonRun_GEL);
            this.Controls.Add(this.buttonInfo_GEL);
            this.Controls.Add(this.groupBoxOutput_GEL);
            this.Controls.Add(this.groupBoxTask_GEL);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Sprint #6 | Task #3 | V17 | Габеркорн Е. Л. | АСОиУб-25-1";

            this.groupBoxTask_GEL.ResumeLayout(false);
            this.groupBoxTask_GEL.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTask_GEL)).EndInit();
            this.groupBoxOutput_GEL.ResumeLayout(false);
            this.groupBoxOutput_GEL.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_GEL)).EndInit();
            this.ResumeLayout(false);
        }

        private GroupBox groupBoxTask_GEL;
        private DataGridView dataGridViewTask_GEL;
        private TextBox textBoxTask_GEL;
        private GroupBox groupBoxOutput_GEL;
        private DataGridView dataGridViewResult_GEL;
        private Label labelResult_GEL;
        private Button buttonInfo_GEL;
        private Button buttonRun_GEL;
    }
}