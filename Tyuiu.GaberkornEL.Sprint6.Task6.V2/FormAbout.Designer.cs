using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Tyuiu.GaberkornEL.Sprint6.Task6.V2
{
    partial class FormAbout_GEL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout_GEL));
            textBoxInfo_GEL = new TextBox();
            pictureBoxOne_GEL = new PictureBox();
            buttonDone_GEL = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxOne_GEL).BeginInit();
            SuspendLayout();
            // 
            // textBoxInfo_GEL
            // 
            textBoxInfo_GEL.BorderStyle = BorderStyle.None;
            textBoxInfo_GEL.Location = new Point(184, 12);
            textBoxInfo_GEL.Multiline = true;
            textBoxInfo_GEL.Name = "textBoxInfo_GEL";
            textBoxInfo_GEL.ReadOnly = true;
            textBoxInfo_GEL.Size = new Size(368, 161);
            textBoxInfo_GEL.TabIndex = 0;
            textBoxInfo_GEL.Text = resources.GetString("textBoxInfo_GEL.Text");
            // 
            // pictureBoxOne_GEL
            // 
            pictureBoxOne_GEL.Image = Properties.Resources.p_DSC0978_kopia__2_;
            pictureBoxOne_GEL.Location = new Point(12, 12);
            pictureBoxOne_GEL.Name = "pictureBoxOne_GEL";
            pictureBoxOne_GEL.Size = new Size(166, 198);
            pictureBoxOne_GEL.TabIndex = 1;
            pictureBoxOne_GEL.TabStop = false;
            // 
            // buttonDone_SNM
            // 
            buttonDone_GEL.Location = new Point(500, 187);
            buttonDone_GEL.Name = "buttonDone_SNM";
            buttonDone_GEL.Size = new Size(75, 23);
            buttonDone_GEL.TabIndex = 2;
            buttonDone_GEL.Text = "ОК";
            buttonDone_GEL.UseVisualStyleBackColor = true;
            buttonDone_GEL.Click += buttonDone_GEL_Click;
            // 
            // FormAbout_SNM
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(587, 222);
            Controls.Add(buttonDone_GEL);
            Controls.Add(pictureBoxOne_GEL);
            Controls.Add(textBoxInfo_GEL);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MinimizeBox = false;
            Name = "FormAbout_SNM";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)pictureBoxOne_GEL).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxInfo_GEL;
        private PictureBox pictureBoxOne_GEL;
        private Button buttonDone_GEL;
    }
}