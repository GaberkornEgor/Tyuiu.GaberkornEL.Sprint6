namespace Tyuiu.GaberkornEL.Sprint6.Task2.V4
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button_Go = new Button();
            button_Spr = new Button();
            textBox_Stop = new TextBox();
            textBox_Start = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            label6 = new Label();
            label5 = new Label();
            dataGridView1 = new DataGridView();
            Column_X = new DataGridViewTextBoxColumn();
            Column_FX = new DataGridViewTextBoxColumn();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button_Go
            // 
            button_Go.BackColor = Color.Green;
            button_Go.FlatStyle = FlatStyle.Flat;
            button_Go.Font = new Font("Cooper Black", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_Go.ForeColor = SystemColors.ControlText;
            button_Go.Location = new Point(1252, 606);
            button_Go.Name = "button_Go";
            button_Go.Size = new Size(146, 86);
            button_Go.TabIndex = 16;
            button_Go.Text = "ВЫПОЛНИТЬ";
            button_Go.UseVisualStyleBackColor = false;
            button_Go.Click += button_Go_Click;
            // 
            // button_Spr
            // 
            button_Spr.BackColor = Color.FromArgb(192, 192, 0);
            button_Spr.Location = new Point(1078, 643);
            button_Spr.Name = "button_Spr";
            button_Spr.Size = new Size(114, 49);
            button_Spr.TabIndex = 15;
            button_Spr.Text = "Справка";
            button_Spr.UseVisualStyleBackColor = false;
            button_Spr.Click += button_Spr_Click;
            // 
            // textBox_Stop
            // 
            textBox_Stop.Font = new Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBox_Stop.Location = new Point(174, 660);
            textBox_Stop.Name = "textBox_Stop";
            textBox_Stop.Size = new Size(100, 30);
            textBox_Stop.TabIndex = 14;
            // 
            // textBox_Start
            // 
            textBox_Start.Font = new Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBox_Start.Location = new Point(24, 660);
            textBox_Start.Name = "textBox_Start";
            textBox_Start.Size = new Size(100, 30);
            textBox_Start.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(174, 606);
            label2.Name = "label2";
            label2.Size = new Size(120, 22);
            label2.TabIndex = 12;
            label2.Text = "Конец шага:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(24, 584);
            label1.Name = "label1";
            label1.Size = new Size(120, 44);
            label1.TabIndex = 11;
            label1.Text = "Ввод данных\r\nСтарт шага:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Consolas", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.Location = new Point(12, 21);
            label3.Name = "label3";
            label3.Size = new Size(103, 28);
            label3.TabIndex = 17;
            label3.Text = "Условие";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label6.Location = new Point(696, 9);
            label6.Name = "label6";
            label6.Size = new Size(110, 22);
            label6.TabIndex = 19;
            label6.Text = "Результат:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label5.Location = new Point(696, 49);
            label5.Name = "label5";
            label5.Size = new Size(130, 22);
            label5.TabIndex = 18;
            label5.Text = "Вывод данных";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column_X, Column_FX });
            dataGridView1.Location = new Point(681, 95);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(240, 433);
            dataGridView1.TabIndex = 20;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Column_X
            // 
            Column_X.HeaderText = "X";
            Column_X.Name = "Column_X";
            // 
            // Column_FX
            // 
            Column_FX.HeaderText = "F(X)";
            Column_FX.Name = "Column_FX";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(948, 107);
            chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart1.Series.Add(series1);
            chart1.Size = new Size(470, 421);
            chart1.TabIndex = 21;
            chart1.Text = "chart1";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 78);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(651, 220);
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1439, 721);
            Controls.Add(pictureBox1);
            Controls.Add(chart1);
            Controls.Add(dataGridView1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(button_Go);
            Controls.Add(button_Spr);
            Controls.Add(textBox_Stop);
            Controls.Add(textBox_Start);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_Go;
        private Button button_Spr;
        private TextBox textBox_Stop;
        private TextBox textBox_Start;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label label6;
        private Label label5;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column_X;
        private DataGridViewTextBoxColumn Column_FX;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private PictureBox pictureBox1;
    }
}