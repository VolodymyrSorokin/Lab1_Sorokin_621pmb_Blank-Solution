using System;

namespace WindowsFormsApp
{
    partial class Form1
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
            this.userControl_Sorokin1 = new WindowsFormsControlLibrary.UserControl_Sorokin();
            this.textBoxDaysNumber = new System.Windows.Forms.TextBox(); // Измените имя на уникальное
            this.labelDaysNumber = new System.Windows.Forms.Label(); // Измените имя на уникальное
            this.SuspendLayout();
            // 
            // userControl_Sorokin1
            // 
            this.userControl_Sorokin1.EndDate = new DateTime(2024, 5, 30, 0, 0, 0, 0);
            this.userControl_Sorokin1.Location = new System.Drawing.Point(27, 57);
            this.userControl_Sorokin1.Name = "userControl_Sorokin1";
            this.userControl_Sorokin1.Size = new System.Drawing.Size(543, 265);
            this.userControl_Sorokin1.StartDate = new DateTime(2024, 5, 30, 0, 0, 0, 0);
            this.userControl_Sorokin1.TabIndex = 0;
            this.userControl_Sorokin1.DateRangeChanged += new EventHandler(this.userControl_Sorokin1_DateRangeChanged);
            // 
            // textBoxDaysNumber
            // 
            this.textBoxDaysNumber.Location = new System.Drawing.Point(125, 357);
            this.textBoxDaysNumber.Name = "textBoxDaysNumber"; // Убедитесь, что это имя уникально
            this.textBoxDaysNumber.Size = new System.Drawing.Size(100, 22);
            this.textBoxDaysNumber.TabIndex = 1;
            // 
            // labelDaysNumber
            // 
            this.labelDaysNumber.AutoSize = true;
            this.labelDaysNumber.Location = new System.Drawing.Point(67, 338);
            this.labelDaysNumber.Name = "labelDaysNumber"; // Убедитесь, что это имя уникально
            this.labelDaysNumber.Size = new System.Drawing.Size(230, 16);
            this.labelDaysNumber.TabIndex = 2;
            this.labelDaysNumber.Text = "Інтервал між двома датами у днях:";
            // 
            // Form1____
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelDaysNumber);
            this.Controls.Add(this.textBoxDaysNumber);
            this.Controls.Add(this.userControl_Sorokin1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private WindowsFormsControlLibrary.UserControl_Sorokin userControl_Sorokin1;
        private System.Windows.Forms.TextBox textBoxDaysNumber;
        private System.Windows.Forms.Label labelDaysNumber;
    }
}
