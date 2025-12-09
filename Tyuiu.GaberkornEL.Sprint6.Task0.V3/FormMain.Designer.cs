using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Tyuiu.GaberkornEL.Sprint6.Task0.V3
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
            buttonStrt_gel = new Button();
            pictureBox_gel = new PictureBox();
            groupBoxTask = new GroupBox();
            textBoxTask_gel = new TextBox();
            textBoxResult_gel = new TextBox();
            textBoxone_gel = new TextBox();
            textBoxd_gel = new TextBox();
            textBoxA_gel = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox_gel).BeginInit();
            groupBoxTask.SuspendLayout();
            SuspendLayout();
            // 
            // buttonStrt_gel
            // 
            buttonStrt_gel.Location = new Point(810, 413);
            buttonStrt_gel.Name = "buttonStrt_gel";
            buttonStrt_gel.Size = new Size(155, 75);
            buttonStrt_gel.TabIndex = 0;
            buttonStrt_gel.Text = "Выполнить";
            buttonStrt_gel.UseVisualStyleBackColor = true;
            buttonStrt_gel.Click += buttonfst_Click;
            // 
            // pictureBox_gel
            // 
            pictureBox_gel.Image = (System.Drawing.Image)resources.GetObject("pictureBox_gel.Image");
            pictureBox_gel.Location = new Point(758, 63);
            pictureBox_gel.Name = "pictureBox_gel";
            pictureBox_gel.Size = new Size(147, 83);
            pictureBox_gel.TabIndex = 3;
            pictureBox_gel.TabStop = false;
            // 
            // groupBoxTask
            // 
            groupBoxTask.Controls.Add(textBoxTask_gel);
            groupBoxTask.Controls.Add(pictureBox_gel);
            groupBoxTask.Location = new Point(52, 34);
            groupBoxTask.Name = "groupBoxTask";
            groupBoxTask.Size = new Size(930, 274);
            groupBoxTask.TabIndex = 2;
            groupBoxTask.TabStop = false;
            groupBoxTask.Text = "Условия";
            groupBoxTask.Enter += groupBoxTask_Enter;
            // 
            // textBoxTask_gel
            // 
            textBoxTask_gel.Location = new Point(27, 38);
            textBoxTask_gel.Multiline = true;
            textBoxTask_gel.Name = "textBoxTask_gel";
            textBoxTask_gel.ReadOnly = true;
            textBoxTask_gel.Size = new Size(695, 212);
            textBoxTask_gel.TabIndex = 2;
            textBoxTask_gel.Text = "Вариант 3\r\nДано выражение вычислить его значение при x = 3, результат вывести в TextBox. Округлить до трёх знаков после запятой. Графический интерфейс оформить по шаблону из лекции.";
            // 
            // textBoxResult_gel
            // 
            textBoxResult_gel.Location = new Point(810, 380);
            textBoxResult_gel.Name = "textBoxResult_gel";
            textBoxResult_gel.ReadOnly = true;
            textBoxResult_gel.Size = new Size(155, 27);
            textBoxResult_gel.TabIndex = 3;
            textBoxResult_gel.TextChanged += textBoxResult_gel_TextChanged;
            // 
            // textBoxone_gel
            // 
            textBoxone_gel.Location = new Point(70, 395);
            textBoxone_gel.Name = "textBoxone_gel";
            textBoxone_gel.Size = new Size(147, 27);
            textBoxone_gel.TabIndex = 4;
            textBoxone_gel.KeyPress += textBoxone_gel_KeyPress;
            // 
            // textBoxd_gel
            // 
            textBoxd_gel.Location = new Point(52, 314);
            textBoxd_gel.Name = "textBoxd_gel";
            textBoxd_gel.ReadOnly = true;
            textBoxd_gel.Size = new Size(125, 27);
            textBoxd_gel.TabIndex = 8;
            textBoxd_gel.Text = "Вводд данных";
            textBoxd_gel.TextChanged += textBoxd_gel_TextChanged;
            // 
            // textBoxA_gel
            // 
            textBoxA_gel.Location = new Point(70, 362);
            textBoxA_gel.Name = "textBoxA_gel";
            textBoxA_gel.ReadOnly = true;
            textBoxA_gel.Size = new Size(147, 27);
            textBoxA_gel.TabIndex = 9;
            textBoxA_gel.Text = "Переменная X";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1027, 548);
            Controls.Add(textBoxA_gel);
            Controls.Add(textBoxd_gel);
            Controls.Add(textBoxone_gel);
            Controls.Add(textBoxResult_gel);
            Controls.Add(groupBoxTask);
            Controls.Add(buttonStrt_gel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт6|Таск0|Вариант3|Габеркорн Е.Л.";
            Load += FormMain_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox_gel).EndInit();
            groupBoxTask.ResumeLayout(false);
            groupBoxTask.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonStrt_gel;
        private PictureBox pictureBox_gel;
        private GroupBox groupBoxTask;
        private TextBox textBoxResult_gel;
        private TextBox textBoxone_gel;
        private TextBox textBoxTask_gel;
        private TextBox textBoxd_gel;
        private TextBox textBoxA_gel;
    }
}