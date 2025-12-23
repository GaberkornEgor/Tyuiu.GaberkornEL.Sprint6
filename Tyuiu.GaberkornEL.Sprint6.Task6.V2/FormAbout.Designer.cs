namespace Tyuiu.GaberkornEL.Sprint6.Task6.V2
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));

            this.textBoxInfo_GEL = new TextBox();
            this.pictureBoxOne_GEL = new PictureBox();
            this.buttonDone_GEL = new Button();

            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOne_GEL)).BeginInit();
            this.SuspendLayout();

            // textBoxInfo_GEL
            this.textBoxInfo_GEL.Location = new System.Drawing.Point(184, 12);
            this.textBoxInfo_GEL.Multiline = true;
            this.textBoxInfo_GEL.Name = "textBoxInfo_GEL";
            this.textBoxInfo_GEL.ReadOnly = true;
            this.textBoxInfo_GEL.Size = new System.Drawing.Size(368, 161);
            this.textBoxInfo_GEL.TabIndex = 0;
            this.textBoxInfo_GEL.Text = "Задание выполнил:\r\nСтудент группы АСОиУб-25-1\r\nГаберкорн Егор Леонидович\r\n\r\nСпринт #6 | Задание #6 | Вариант #2";

            // pictureBoxOne_GEL
            this.pictureBoxOne_GEL.Image = Properties.Resources.p_DSC0978_kopia__2_; // оставь свою фотку
            this.pictureBoxOne_GEL.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxOne_GEL.Name = "pictureBoxOne_GEL";
            this.pictureBoxOne_GEL.Size = new System.Drawing.Size(166, 198);
            this.pictureBoxOne_GEL.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pictureBoxOne_GEL.TabIndex = 1;
            this.pictureBoxOne_GEL.TabStop = false;

            // buttonDone_GEL
            this.buttonDone_GEL.Location = new System.Drawing.Point(477, 187);
            this.buttonDone_GEL.Name = "buttonDone_GEL";
            this.buttonDone_GEL.Size = new System.Drawing.Size(75, 30);
            this.buttonDone_GEL.TabIndex = 2;
            this.buttonDone_GEL.Text = "ОК";
            this.buttonDone_GEL.UseVisualStyleBackColor = true;
            this.buttonDone_GEL.Click += new System.EventHandler(this.buttonDone_GEL_Click);

            // FormAbout
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 222);
            this.Controls.Add(this.buttonDone_GEL);
            this.Controls.Add(this.pictureBoxOne_GEL);
            this.Controls.Add(this.textBoxInfo_GEL);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout";
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "О программе";

            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOne_GEL)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private TextBox textBoxInfo_GEL;
        private PictureBox pictureBoxOne_GEL;
        private Button buttonDone_GEL;
    }
}