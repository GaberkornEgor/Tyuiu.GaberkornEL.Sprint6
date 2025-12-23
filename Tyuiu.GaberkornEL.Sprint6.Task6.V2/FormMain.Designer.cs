namespace Tyuiu.GaberkornEL.Sprint6.Task6.V2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));

            this.panelOne_GEL = new Panel();
            this.buttonDone_GEL = new Button();
            this.buttonFile_GEL = new Button();
            this.buttonReference_GEL = new Button();
            this.groupBoxOne_GEL = new GroupBox();
            this.textBoxTask_GEL = new TextBox();

            this.panelTwo_GEL = new Panel();
            this.groupBoxTwo_GEL = new GroupBox();
            this.textBoxInput_GEL = new TextBox();

            this.panelThree_GEL = new Panel();
            this.groupBoxThree_GEL = new GroupBox();
            this.textBoxResult_GEL = new TextBox();

            this.splitterOne_GEL = new Splitter();
            this.openFileDialog_GEL = new OpenFileDialog();
            this.toolTip_GEL = new ToolTip(this.components);

            this.panelOne_GEL.SuspendLayout();
            this.groupBoxOne_GEL.SuspendLayout();
            this.panelTwo_GEL.SuspendLayout();
            this.groupBoxTwo_GEL.SuspendLayout();
            this.panelThree_GEL.SuspendLayout();
            this.groupBoxThree_GEL.SuspendLayout();
            this.SuspendLayout();

            // panelOne_GEL
            this.panelOne_GEL.Controls.Add(this.buttonDone_GEL);
            this.panelOne_GEL.Controls.Add(this.buttonFile_GEL);
            this.panelOne_GEL.Controls.Add(this.buttonReference_GEL);
            this.panelOne_GEL.Controls.Add(this.groupBoxOne_GEL);
            this.panelOne_GEL.Dock = DockStyle.Top;
            this.panelOne_GEL.Location = new System.Drawing.Point(0, 0);
            this.panelOne_GEL.Name = "panelOne_GEL";
            this.panelOne_GEL.Size = new System.Drawing.Size(784, 150);
            this.panelOne_GEL.TabIndex = 0;

            // buttonDone_GEL
            this.buttonDone_GEL.Enabled = false;
            this.buttonDone_GEL.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.buttonDone_GEL.Location = new System.Drawing.Point(98, 13);
            this.buttonDone_GEL.Name = "buttonDone_GEL";
            this.buttonDone_GEL.Size = new System.Drawing.Size(100, 50);
            this.buttonDone_GEL.TabIndex = 5;
            this.buttonDone_GEL.Text = "Выполнить";
            this.toolTip_GEL.SetToolTip(this.buttonDone_GEL, "Обработать файл по условию");
            this.buttonDone_GEL.UseVisualStyleBackColor = true;
            this.buttonDone_GEL.Click += new System.EventHandler(this.buttonDone_GEL_Click);

            // buttonFile_GEL
            this.buttonFile_GEL.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.buttonFile_GEL.Location = new System.Drawing.Point(12, 13);
            this.buttonFile_GEL.Name = "buttonFile_GEL";
            this.buttonFile_GEL.Size = new System.Drawing.Size(80, 50);
            this.buttonFile_GEL.TabIndex = 4;
            this.buttonFile_GEL.Text = "Открыть файл";
            this.buttonFile_GEL.UseVisualStyleBackColor = true;
            this.buttonFile_GEL.Click += new System.EventHandler(this.buttonFile_GEL_Click);

            // buttonReference_GEL
            this.buttonReference_GEL.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.buttonReference_GEL.Location = new System.Drawing.Point(692, 13);
            this.buttonReference_GEL.Name = "buttonReference_GEL";
            this.buttonReference_GEL.Size = new System.Drawing.Size(80, 50);
            this.buttonReference_GEL.TabIndex = 3;
            this.buttonReference_GEL.Text = "Справка";
            this.buttonReference_GEL.UseVisualStyleBackColor = true;
            this.buttonReference_GEL.Click += new System.EventHandler(this.buttonReference_GEL_Click);

            // groupBoxOne_GEL
            this.groupBoxOne_GEL.Controls.Add(this.textBoxTask_GEL);
            this.groupBoxOne_GEL.Dock = DockStyle.Bottom;
            this.groupBoxOne_GEL.Location = new System.Drawing.Point(0, 69);
            this.groupBoxOne_GEL.Name = "groupBoxOne_GEL";
            this.groupBoxOne_GEL.Size = new System.Drawing.Size(784, 81);
            this.groupBoxOne_GEL.TabIndex = 0;
            this.groupBoxOne_GEL.TabStop = false;
            this.groupBoxOne_GEL.Text = "Условие:";

            // textBoxTask_GEL
            this.textBoxTask_GEL.Dock = DockStyle.Fill;
            this.textBoxTask_GEL.BorderStyle = BorderStyle.None;
            this.textBoxTask_GEL.Multiline = true;
            this.textBoxTask_GEL.Location = new System.Drawing.Point(3, 19);
            this.textBoxTask_GEL.Name = "textBoxTask_GEL";
            this.textBoxTask_GEL.ReadOnly = true;
            this.textBoxTask_GEL.Size = new System.Drawing.Size(778, 59);
            this.textBoxTask_GEL.TabIndex = 1;
            this.textBoxTask_GEL.Text = "Из данного файла получить строку, содержащую все слова, в которых есть подстрока \"**\".";

            // panelTwo_GEL
            this.panelTwo_GEL.Controls.Add(this.groupBoxTwo_GEL);
            this.panelTwo_GEL.Dock = DockStyle.Left;
            this.panelTwo_GEL.Location = new System.Drawing.Point(0, 150);
            this.panelTwo_GEL.Name = "panelTwo_GEL";
            this.panelTwo_GEL.Size = new System.Drawing.Size(375, 311);
            this.panelTwo_GEL.TabIndex = 1;

            // groupBoxTwo_GEL
            this.groupBoxTwo_GEL.Controls.Add(this.textBoxInput_GEL);
            this.groupBoxTwo_GEL.Dock = DockStyle.Fill;
            this.groupBoxTwo_GEL.Location = new System.Drawing.Point(0, 0);
            this.groupBoxTwo_GEL.Name = "groupBoxTwo_GEL";
            this.groupBoxTwo_GEL.Size = new System.Drawing.Size(375, 311);
            this.groupBoxTwo_GEL.TabIndex = 0;
            this.groupBoxTwo_GEL.TabStop = false;
            this.groupBoxTwo_GEL.Text = "Ввод:";

            // textBoxInput_GEL
            this.textBoxInput_GEL.Dock = DockStyle.Fill;
            this.textBoxInput_GEL.BorderStyle = BorderStyle.FixedSingle;
            this.textBoxInput_GEL.Location = new System.Drawing.Point(3, 19);
            this.textBoxInput_GEL.Multiline = true;
            this.textBoxInput_GEL.Name = "textBoxInput_GEL";
            this.textBoxInput_GEL.ReadOnly = true;
            this.textBoxInput_GEL.ScrollBars = ScrollBars.Vertical;
            this.textBoxInput_GEL.Size = new System.Drawing.Size(369, 289);
            this.textBoxInput_GEL.TabIndex = 0;

            // panelThree_GEL
            this.panelThree_GEL.Controls.Add(this.groupBoxThree_GEL);
            this.panelThree_GEL.Controls.Add(this.splitterOne_GEL);
            this.panelThree_GEL.Dock = DockStyle.Fill;
            this.panelThree_GEL.Location = new System.Drawing.Point(375, 150);
            this.panelThree_GEL.Name = "panelThree_GEL";
            this.panelThree_GEL.Size = new System.Drawing.Size(409, 311);
            this.panelThree_GEL.TabIndex = 2;

            // groupBoxThree_GEL
            this.groupBoxThree_GEL.Controls.Add(this.textBoxResult_GEL);
            this.groupBoxThree_GEL.Dock = DockStyle.Fill;
            this.groupBoxThree_GEL.Location = new System.Drawing.Point(3, 0);
            this.groupBoxThree_GEL.Name = "groupBoxThree_GEL";
            this.groupBoxThree_GEL.Size = new System.Drawing.Size(406, 311);
            this.groupBoxThree_GEL.TabIndex = 1;
            this.groupBoxThree_GEL.TabStop = false;
            this.groupBoxThree_GEL.Text = "Вывод:";

            // textBoxResult_GEL
            this.textBoxResult_GEL.Dock = DockStyle.Fill;
            this.textBoxResult_GEL.BorderStyle = BorderStyle.FixedSingle;
            this.textBoxResult_GEL.Location = new System.Drawing.Point(3, 19);
            this.textBoxResult_GEL.Multiline = true;
            this.textBoxResult_GEL.Name = "textBoxResult_GEL";
            this.textBoxResult_GEL.ReadOnly = true;
            this.textBoxResult_GEL.ScrollBars = ScrollBars.Vertical;
            this.textBoxResult_GEL.Size = new System.Drawing.Size(400, 289);
            this.textBoxResult_GEL.TabIndex = 1;

            // splitterOne_GEL
            this.splitterOne_GEL.Location = new System.Drawing.Point(0, 0);
            this.splitterOne_GEL.Name = "splitterOne_GEL";
            this.splitterOne_GEL.Size = new System.Drawing.Size(3, 311);
            this.splitterOne_GEL.TabIndex = 0;

            // FormMain
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.panelThree_GEL);
            this.Controls.Add(this.panelTwo_GEL);
            this.Controls.Add(this.panelOne_GEL);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "FormMain";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Спринт #6 | Задание #6 | Вариант #2 | Габеркорн Е. Л. | АСОиУб-25-1";

            this.panelOne_GEL.ResumeLayout(false);
            this.groupBoxOne_GEL.ResumeLayout(false);
            this.groupBoxOne_GEL.PerformLayout();
            this.panelTwo_GEL.ResumeLayout(false);
            this.groupBoxTwo_GEL.ResumeLayout(false);
            this.groupBoxTwo_GEL.PerformLayout();
            this.panelThree_GEL.ResumeLayout(false);
            this.groupBoxThree_GEL.ResumeLayout(false);
            this.groupBoxThree_GEL.PerformLayout();
            this.ResumeLayout(false);
        }

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