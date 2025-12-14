using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Tyuiu.GaberkornEL.Sprint6.Task3.V17
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            groupBoxTask_GEL = new GroupBox();
            dataGridViewTask_GEL = new DataGridView();
            textBoxTask_GEL = new TextBox();
            groupBoxOutput_GEL = new GroupBox();
            dataGridViewResult_GEL = new DataGridView();
            labelResult_GEL = new Label();
            buttonInfo_GEL = new Button();
            buttonRun_GEL = new Button();
            groupBoxTask_GEL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTask_GEL).BeginInit();
            groupBoxOutput_GEL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_GEL).BeginInit();
            SuspendLayout();
            // 
            // groupBoxTask_GEL
            // 
            groupBoxTask_GEL.Controls.Add(dataGridViewTask_GEL);
            groupBoxTask_GEL.Controls.Add(textBoxTask_GEL);
            groupBoxTask_GEL.Location = new Point(12, 0);
            groupBoxTask_GEL.Name = "groupBoxTask_GEL";
            groupBoxTask_GEL.Size = new Size(475, 438);
            groupBoxTask_GEL.TabIndex = 0;
            groupBoxTask_GEL.TabStop = false;
            groupBoxTask_GEL.Text = "Условие";
            // 
            // dataGridViewTask_GEL
            // 
            dataGridViewTask_GEL.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTask_GEL.ColumnHeadersVisible = false;
            dataGridViewTask_GEL.Location = new Point(225, 91);
            dataGridViewTask_GEL.Name = "dataGridViewTask_GEL";
            dataGridViewTask_GEL.ReadOnly = true;
            dataGridViewTask_GEL.RowHeadersVisible = false;
            dataGridViewTask_GEL.RowHeadersWidth = 51;
            dataGridViewTask_GEL.Size = new Size(225, 169);
            dataGridViewTask_GEL.TabIndex = 1;
            // 
            // textBoxTask_GEL
            // 
            textBoxTask_GEL.Location = new Point(6, 26);
            textBoxTask_GEL.Multiline = true;
            textBoxTask_GEL.Name = "textBoxTask_GEL";
            textBoxTask_GEL.Size = new Size(464, 262);
            textBoxTask_GEL.TabIndex = 0;
            textBoxTask_GEL.Text = resources.GetString("textBoxTask_GEL.Text");
            // 
            // groupBoxOutput_GEL
            // 
            groupBoxOutput_GEL.Controls.Add(dataGridViewResult_GEL);
            groupBoxOutput_GEL.Controls.Add(labelResult_GEL);
            groupBoxOutput_GEL.Location = new Point(493, 0);
            groupBoxOutput_GEL.Name = "groupBoxOutput_GEL";
            groupBoxOutput_GEL.Size = new Size(460, 377);
            groupBoxOutput_GEL.TabIndex = 1;
            groupBoxOutput_GEL.TabStop = false;
            groupBoxOutput_GEL.Text = "Вывод данных";
            // 
            // dataGridViewResult_GEL
            // 
            dataGridViewResult_GEL.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResult_GEL.ColumnHeadersVisible = false;
            dataGridViewResult_GEL.Location = new Point(6, 56);
            dataGridViewResult_GEL.Name = "dataGridViewResult_GEL";
            dataGridViewResult_GEL.ReadOnly = true;
            dataGridViewResult_GEL.RowHeadersVisible = false;
            dataGridViewResult_GEL.RowHeadersWidth = 51;
            dataGridViewResult_GEL.Size = new Size(228, 188);
            dataGridViewResult_GEL.TabIndex = 1;
            // 
            // labelResult_GEL
            // 
            labelResult_GEL.AutoSize = true;
            labelResult_GEL.Location = new Point(6, 23);
            labelResult_GEL.Name = "labelResult_GEL";
            labelResult_GEL.Size = new Size(78, 20);
            labelResult_GEL.TabIndex = 0;
            labelResult_GEL.Text = "Результат:";
            // 
            // buttonInfo_GEL
            // 
            buttonInfo_GEL.Location = new Point(717, 383);
            buttonInfo_GEL.Name = "buttonInfo_GEL";
            buttonInfo_GEL.Size = new Size(65, 55);
            buttonInfo_GEL.TabIndex = 2;
            buttonInfo_GEL.Text = "?";
            buttonInfo_GEL.UseVisualStyleBackColor = true;
            buttonInfo_GEL.Click += buttonInfo_GEL_Click;
            // 
            // buttonRun_GEL
            // 
            buttonRun_GEL.Location = new Point(788, 383);
            buttonRun_GEL.Name = "buttonRun_GEL";
            buttonRun_GEL.Size = new Size(165, 55);
            buttonRun_GEL.TabIndex = 3;
            buttonRun_GEL.Text = "Выполнить";
            buttonRun_GEL.UseVisualStyleBackColor = true;
            buttonRun_GEL.Click += buttonRun_GEL_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(965, 450);
            Controls.Add(buttonRun_GEL);
            Controls.Add(buttonInfo_GEL);
            Controls.Add(groupBoxOutput_GEL);
            Controls.Add(groupBoxTask_GEL);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 2 | Вариант 17 | Габеркорн Е.Л.";
            Load += FormMain_Load;
            groupBoxTask_GEL.ResumeLayout(false);
            groupBoxTask_GEL.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTask_GEL).EndInit();
            groupBoxOutput_GEL.ResumeLayout(false);
            groupBoxOutput_GEL.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_GEL).EndInit();
            ResumeLayout(false);
        }

        #endregion

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