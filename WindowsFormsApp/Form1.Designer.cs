namespace WindowsFormsApp
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.userControl_Sorokin1 = new WindowsFormsControlLibrary.UserControl_Sorokin();
            this.SuspendLayout();
            // 
            // userControl_Sorokin1
            // 
            this.userControl_Sorokin1.EndDate = new System.DateTime(2024, 5, 30, 0, 0, 0, 0);
            this.userControl_Sorokin1.Location = new System.Drawing.Point(27, 57);
            this.userControl_Sorokin1.Name = "userControl_Sorokin1";
            this.userControl_Sorokin1.Size = new System.Drawing.Size(543, 265);
            this.userControl_Sorokin1.StartDate = new System.DateTime(2024, 5, 30, 0, 0, 0, 0);
            this.userControl_Sorokin1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.userControl_Sorokin1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private WindowsFormsControlLibrary.UserControl_Sorokin userControl_Sorokin1;
    }
}

