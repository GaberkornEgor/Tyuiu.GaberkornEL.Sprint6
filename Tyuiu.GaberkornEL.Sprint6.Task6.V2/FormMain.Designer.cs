using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Tyuiu.GaberkornEL.Sprint6.Task6.V2
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            panelOne_GEL = new Panel();
            buttonDone_GEL = new Button();
            buttonFile_GEL = new Button();
            buttonReference_GEL = new Button();
            groupBoxOne_GEL = new GroupBox();
            textBoxTask_GEL = new TextBox();
            panelTwo_GEL = new Panel();
            groupBoxTwo_GEL = new GroupBox();
            textBoxInput_GEL = new TextBox();
            panelThree_GEL = new Panel();
            groupBoxThree_GEL = new GroupBox();
            textBoxResult_GEL = new TextBox();
            splitterOne_GEL = new Splitter();
            openFileDialog_GEL = new OpenFileDialog();
            toolTip_GEL = new ToolTip(components);
            panelOne_GEL.SuspendLayout();
            groupBoxOne_GEL.SuspendLayout();
            panelTwo_GEL.SuspendLayout();
            groupBoxTwo_GEL.SuspendLayout();
            panelThree_GEL.SuspendLayout();
            groupBoxThree_GEL.SuspendLayout();
            SuspendLayout();
            // 
            // panelOne_GEL
            // 
            panelOne_GEL.Controls.Add(buttonDone_GEL);
            panelOne_GEL.Controls.Add(buttonFile_GEL);
            panelOne_GEL.Controls.Add(buttonReference_GEL);
            panelOne_GEL.Controls.Add(groupBoxOne_GEL);
            panelOne_GEL.Dock = DockStyle.Top;
            panelOne_GEL.Location = new Point(0, 0);
            panelOne_GEL.Name = "panelOne_GEL";
            panelOne_GEL.Size = new Size(784, 150);
            panelOne_GEL.TabIndex = 0;
            // 
            // buttonDone_GEL
            // 
            buttonDone_GEL.Location = new Point(98, 13);
            buttonDone_GEL.Name = "buttonDone_GEL";
            buttonDone_GEL.Size = new Size(80, 50);
            buttonDone_GEL.TabIndex = 5;
            buttonDone_GEL.Text = "выполнить";
            toolTip_GEL.SetToolTip(buttonDone_GEL, "Открыть файл\r\nВыберите нужный файл для обработки");
            buttonDone_GEL.UseVisualStyleBackColor = true;
            buttonDone_GEL.Click += buttonDone_Click;
            // 
            // buttonFile_GEL
            // 
            buttonFile_GEL.Location = new Point(12, 12);
            buttonFile_GEL.Name = "buttonFile_SNM";
            buttonFile_GEL.Size = new Size(80, 50);
            buttonFile_GEL.TabIndex = 4;
            buttonFile_GEL.Text = "открыть файл";
            buttonFile_GEL.UseVisualStyleBackColor = true;
            buttonFile_GEL.Click += buttonOpenFile_Click;
            // 
            // buttonReference_GEL
            // 
            buttonReference_GEL.Location = new Point(692, 13);
            buttonReference_GEL.Name = "buttonReference_GEL";
            buttonReference_GEL.Size = new Size(80, 50);
            buttonReference_GEL.TabIndex = 3;
            buttonReference_GEL.Text = "помощь";
            buttonReference_GEL.UseVisualStyleBackColor = true;
            buttonReference_GEL.Click += buttonHelp_Click;
            // 
            // groupBoxOne_GEL
            // 
            groupBoxOne_GEL.Controls.Add(textBoxTask_GEL);
            groupBoxOne_GEL.Dock = DockStyle.Bottom;
            groupBoxOne_GEL.Location = new Point(0, 69);
            groupBoxOne_GEL.Name = "groupBoxOne_GEL";
            groupBoxOne_GEL.Size = new Size(784, 81);
            groupBoxOne_GEL.TabIndex = 0;
            groupBoxOne_GEL.TabStop = false;
            groupBoxOne_GEL.Text = "Условие:";
            // 
            // textBoxTask_GEL
            // 
            textBoxTask_GEL.BorderStyle = BorderStyle.None;
            textBoxTask_GEL.Dock = DockStyle.Fill;
            textBoxTask_GEL.Location = new Point(3, 19);
            textBoxTask_GEL.Multiline = true;
            textBoxTask_GEL.Name = "textBoxTask_GEL";
            textBoxTask_GEL.ReadOnly = true;
            textBoxTask_GEL.Size = new Size(778, 59);
            textBoxTask_GEL.TabIndex = 1;
            textBoxTask_GEL.Text = resources.GetString("textBoxTask_GEL.Text");
            // 
            // panelTwo_GEL
            // 
            panelTwo_GEL.Controls.Add(groupBoxTwo_GEL);
            panelTwo_GEL.Dock = DockStyle.Left;
            panelTwo_GEL.Location = new Point(0, 150);
            panelTwo_GEL.Name = "panelTwo_GEL";
            panelTwo_GEL.Size = new Size(375, 311);
            panelTwo_GEL.TabIndex = 1;
            // 
            // groupBoxTwo_GEL
            // 
            groupBoxTwo_GEL.Controls.Add(textBoxInput_GEL);
            groupBoxTwo_GEL.Dock = DockStyle.Fill;
            groupBoxTwo_GEL.Location = new Point(0, 0);
            groupBoxTwo_GEL.Name = "groupBoxTwo_GEL";
            groupBoxTwo_GEL.Size = new Size(375, 311);
            groupBoxTwo_GEL.TabIndex = 0;
            groupBoxTwo_GEL.TabStop = false;
            groupBoxTwo_GEL.Text = "Ввод:";
            // 
            // textBoxInput_GEL
            // 
            textBoxInput_GEL.BorderStyle = BorderStyle.None;
            textBoxInput_GEL.Location = new Point(3, 49);
            textBoxInput_GEL.Multiline = true;
            textBoxInput_GEL.Name = "textBoxInput_GEL";
            textBoxInput_GEL.ReadOnly = true;
            textBoxInput_GEL.ScrollBars = ScrollBars.Vertical;
            textBoxInput_GEL.Size = new Size(369, 259);
            textBoxInput_GEL.TabIndex = 0;
            // 
            // panelThree_GEL
            // 
            panelThree_GEL.Controls.Add(groupBoxThree_GEL);
            panelThree_GEL.Controls.Add(splitterOne_GEL);
            panelThree_GEL.Dock = DockStyle.Fill;
            panelThree_GEL.Location = new Point(375, 150);
            panelThree_GEL.Name = "panelThree_GEL";
            panelThree_GEL.Size = new Size(409, 311);
            panelThree_GEL.TabIndex = 2;
            // 
            // groupBoxThree_GEL
            // 
            groupBoxThree_GEL.Controls.Add(textBoxResult_GEL);
            groupBoxThree_GEL.Dock = DockStyle.Fill;
            groupBoxThree_GEL.Location = new Point(3, 0);
            groupBoxThree_GEL.Name = "groupBoxThree_GEL";
            groupBoxThree_GEL.Size = new Size(406, 311);
            groupBoxThree_GEL.TabIndex = 1;
            groupBoxThree_GEL.TabStop = false;
            groupBoxThree_GEL.Text = "Вывод:";
            // 
            // textBoxResult_GEL
            // 
            textBoxResult_GEL.BorderStyle = BorderStyle.None;
            textBoxResult_GEL.Dock = DockStyle.Fill;
            textBoxResult_GEL.Location = new Point(3, 19);
            textBoxResult_GEL.Multiline = true;
            textBoxResult_GEL.Name = "textBoxResult_GEL";
            textBoxResult_GEL.ReadOnly = true;
            textBoxResult_GEL.ScrollBars = ScrollBars.Vertical;
            textBoxResult_GEL.Size = new Size(400, 289);
            textBoxResult_GEL.TabIndex = 1;
            // 
            // splitterOne_GEL
            // 
            splitterOne_GEL.Location = new Point(0, 0);
            splitterOne_GEL.Name = "splitterOne_GEL";
            splitterOne_GEL.Size = new Size(3, 311);
            splitterOne_GEL.TabIndex = 0;
            splitterOne_GEL.TabStop = false;
            // 
            // toolTip_GEL
            // 
            toolTip_GEL.ToolTipIcon = ToolTipIcon.Info;
            toolTip_GEL.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 461);
            Controls.Add(panelThree_GEL);
            Controls.Add(panelTwo_GEL);
            Controls.Add(panelOne_GEL);
            MinimumSize = new Size(800, 400);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 6 | Вариант 2 | Габеркорн Е.Л.";
            panelOne_GEL.ResumeLayout(false);
            groupBoxOne_GEL.ResumeLayout(false);
            groupBoxOne_GEL.PerformLayout();
            panelTwo_GEL.ResumeLayout(false);
            groupBoxTwo_GEL.ResumeLayout(false);
            groupBoxTwo_GEL.PerformLayout();
            panelThree_GEL.ResumeLayout(false);
            groupBoxThree_GEL.ResumeLayout(false);
            groupBoxThree_GEL.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelOne_GEL;
        private Panel panelTwo_GEL;
        private Panel panelThree_GEL;
        private Splitter splitterOne_GEL;
        private GroupBox groupBoxOne_GEL;
        private GroupBox groupBoxTwo_GEL;
        private GroupBox groupBoxThree_GEL;
        private TextBox textBoxTask_GEL;
        private TextBox textBoxInput_GEL;
        private TextBox textBoxResult_GEL;
        private Button buttonDone_GEL;
        private Button buttonFile_GEL;
        private Button buttonReference_GEL;
        private OpenFileDialog openFileDialog_GEL;
        private ToolTip toolTip_GEL;
    }
}