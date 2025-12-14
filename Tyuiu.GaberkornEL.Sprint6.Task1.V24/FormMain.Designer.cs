
namespace Tyuiu.GaberkornEL.Sprint6.Task1.V24
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxTask_GEL = new System.Windows.Forms.GroupBox();
            this.textBoxTask_GEL = new System.Windows.Forms.TextBox();
            this.groupBoxRes_GEL = new System.Windows.Forms.GroupBox();
            this.labelRes_GEL = new System.Windows.Forms.Label();
            this.textBoxRes_GEL = new System.Windows.Forms.TextBox();
            this.groupBoxInput_GEL = new System.Windows.Forms.GroupBox();
            this.labelVarStop_GEL = new System.Windows.Forms.Label();
            this.labelInputVarStart_GEL = new System.Windows.Forms.Label();
            this.textBoxVarStop_GEL = new System.Windows.Forms.TextBox();
            this.textBoxVarStart_GEL = new System.Windows.Forms.TextBox();
            this.buttonHelp_GEL = new System.Windows.Forms.Button();
            this.buttonDone_GEL = new System.Windows.Forms.Button();
            this.groupBoxTask_GEL.SuspendLayout();
            this.groupBoxRes_GEL.SuspendLayout();
            this.groupBoxInput_GEL.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTask_GEL
            // 
            this.groupBoxTask_GEL.Controls.Add(this.textBoxTask_GEL);
            this.groupBoxTask_GEL.Location = new System.Drawing.Point(13, 14);
            this.groupBoxTask_GEL.Name = "groupBoxTask_GEL";
            this.groupBoxTask_GEL.Size = new System.Drawing.Size(523, 255);
            this.groupBoxTask_GEL.TabIndex = 0;
            this.groupBoxTask_GEL.TabStop = false;
            this.groupBoxTask_GEL.Text = "Условие";
            // 
            // textBoxTask_GEL
            // 
            this.textBoxTask_GEL.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBoxTask_GEL.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxTask_GEL.Location = new System.Drawing.Point(7, 22);
            this.textBoxTask_GEL.Multiline = true;
            this.textBoxTask_GEL.Name = "textBoxTask_GEL";
            this.textBoxTask_GEL.Size = new System.Drawing.Size(491, 63);
            this.textBoxTask_GEL.TabIndex = 0;
            this.textBoxTask_GEL.Text = "Протаулировать функцию (Sin(x))/(x + 1,7) - Cos(x) * 4x - 6 на заданном диапазоне" +
    ".\r\nРезультат вывести в виде таблицы.";
            this.textBoxTask_GEL.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // groupBoxRes_GEL
            // 
            this.groupBoxRes_GEL.Controls.Add(this.labelRes_GEL);
            this.groupBoxRes_GEL.Controls.Add(this.textBoxRes_GEL);
            this.groupBoxRes_GEL.Location = new System.Drawing.Point(542, 14);
            this.groupBoxRes_GEL.Name = "groupBoxRes_GEL";
            this.groupBoxRes_GEL.Size = new System.Drawing.Size(246, 323);
            this.groupBoxRes_GEL.TabIndex = 1;
            this.groupBoxRes_GEL.TabStop = false;
            this.groupBoxRes_GEL.Text = "Вывод данных:";
            // 
            // labelRes_GEL
            // 
            this.labelRes_GEL.AutoSize = true;
            this.labelRes_GEL.Location = new System.Drawing.Point(7, 22);
            this.labelRes_GEL.Name = "labelRes_GEL";
            this.labelRes_GEL.Size = new System.Drawing.Size(80, 17);
            this.labelRes_GEL.TabIndex = 1;
            this.labelRes_GEL.Text = "Результат:";
            // 
            // textBoxRes_GEL
            // 
            this.textBoxRes_GEL.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxRes_GEL.Location = new System.Drawing.Point(8, 42);
            this.textBoxRes_GEL.Multiline = true;
            this.textBoxRes_GEL.Name = "textBoxRes_GEL";
            this.textBoxRes_GEL.ReadOnly = true;
            this.textBoxRes_GEL.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxRes_GEL.Size = new System.Drawing.Size(233, 276);
            this.textBoxRes_GEL.TabIndex = 0;
            this.textBoxRes_GEL.TextChanged += new System.EventHandler(this.textBoxRes_GEL_TextChanged);
            // 
            // groupBoxInput_GEL
            // 
            this.groupBoxInput_GEL.Controls.Add(this.labelVarStop_GEL);
            this.groupBoxInput_GEL.Controls.Add(this.labelInputVarStart_GEL);
            this.groupBoxInput_GEL.Controls.Add(this.textBoxVarStop_GEL);
            this.groupBoxInput_GEL.Controls.Add(this.textBoxVarStart_GEL);
            this.groupBoxInput_GEL.Location = new System.Drawing.Point(13, 276);
            this.groupBoxInput_GEL.Name = "groupBoxInput_GEL";
            this.groupBoxInput_GEL.Size = new System.Drawing.Size(301, 75);
            this.groupBoxInput_GEL.TabIndex = 2;
            this.groupBoxInput_GEL.TabStop = false;
            this.groupBoxInput_GEL.Text = "Ввод данных:";
            // 
            // labelVarStop_GEL
            // 
            this.labelVarStop_GEL.AutoSize = true;
            this.labelVarStop_GEL.Location = new System.Drawing.Point(153, 21);
            this.labelVarStop_GEL.Name = "labelVarStop_GEL";
            this.labelVarStop_GEL.Size = new System.Drawing.Size(89, 17);
            this.labelVarStop_GEL.TabIndex = 3;
            this.labelVarStop_GEL.Text = "Конец шага:";
            // 
            // labelInputVarStart_GEL
            // 
            this.labelInputVarStart_GEL.AutoSize = true;
            this.labelInputVarStart_GEL.Location = new System.Drawing.Point(6, 24);
            this.labelInputVarStart_GEL.Name = "labelInputVarStart_GEL";
            this.labelInputVarStart_GEL.Size = new System.Drawing.Size(87, 17);
            this.labelInputVarStart_GEL.TabIndex = 2;
            this.labelInputVarStart_GEL.Text = "Старт шага:";
            // 
            // textBoxVarStop_GEL
            // 
            this.textBoxVarStop_GEL.Location = new System.Drawing.Point(153, 44);
            this.textBoxVarStop_GEL.Name = "textBoxVarStop_GEL";
            this.textBoxVarStop_GEL.Size = new System.Drawing.Size(142, 22);
            this.textBoxVarStop_GEL.TabIndex = 1;
            this.textBoxVarStop_GEL.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBoxVarStart_GEL
            // 
            this.textBoxVarStart_GEL.Location = new System.Drawing.Point(6, 44);
            this.textBoxVarStart_GEL.Name = "textBoxVarStart_GEL";
            this.textBoxVarStart_GEL.Size = new System.Drawing.Size(142, 22);
            this.textBoxVarStart_GEL.TabIndex = 0;
            this.textBoxVarStart_GEL.TextChanged += new System.EventHandler(this.textBoxVarStart_GEL_TextChanged);
            // 
            // buttonHelp_GEL
            // 
            this.buttonHelp_GEL.Location = new System.Drawing.Point(320, 276);
            this.buttonHelp_GEL.Name = "buttonHelp_GEL";
            this.buttonHelp_GEL.Size = new System.Drawing.Size(81, 75);
            this.buttonHelp_GEL.TabIndex = 3;
            this.buttonHelp_GEL.Text = "Справка";
            this.buttonHelp_GEL.UseVisualStyleBackColor = true;
            this.buttonHelp_GEL.Click += new System.EventHandler(this.buttonHelp_GEL_Click);
            // 
            // buttonDone_GEL
            // 
            this.buttonDone_GEL.Location = new System.Drawing.Point(407, 276);
            this.buttonDone_GEL.Name = "buttonDone_GEL";
            this.buttonDone_GEL.Size = new System.Drawing.Size(129, 75);
            this.buttonDone_GEL.TabIndex = 4;
            this.buttonDone_GEL.Text = "Выполнить";
            this.buttonDone_GEL.UseVisualStyleBackColor = true;
            this.buttonDone_GEL.Click += new System.EventHandler(this.buttonDone_GEL_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 354);
            this.Controls.Add(this.buttonDone_GEL);
            this.Controls.Add(this.buttonHelp_GEL);
            this.Controls.Add(this.groupBoxInput_GEL);
            this.Controls.Add(this.groupBoxRes_GEL);
            this.Controls.Add(this.groupBoxTask_GEL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 1 | Вариант 24 | Габеркорн Е. Л.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxTask_GEL.ResumeLayout(false);
            this.groupBoxTask_GEL.PerformLayout();
            this.groupBoxRes_GEL.ResumeLayout(false);
            this.groupBoxRes_GEL.PerformLayout();
            this.groupBoxInput_GEL.ResumeLayout(false);
            this.groupBoxInput_GEL.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_GEL;
        private System.Windows.Forms.GroupBox groupBoxRes_GEL;
        private System.Windows.Forms.GroupBox groupBoxInput_GEL;
        private System.Windows.Forms.TextBox textBoxVarStop_GEL;
        private System.Windows.Forms.TextBox textBoxVarStart_GEL;
        private System.Windows.Forms.Button buttonHelp_GEL;
        private System.Windows.Forms.Button buttonDone_GEL;
        private System.Windows.Forms.TextBox textBoxRes_GEL;
        private System.Windows.Forms.TextBox textBoxTask_GEL;
        private System.Windows.Forms.Label labelInputVarStart_GEL;
        private System.Windows.Forms.Label labelRes_GEL;
        private System.Windows.Forms.Label labelVarStop_GEL;
    }
}