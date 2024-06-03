using System;
using System.Windows.Forms;
using WindowsFormsControlLibrary;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        private UserControl_Sorokin userControl_Sorokin;

        public Form1()
        {
            InitializeComponent();
            // Подписка на событие DateRangeChanged
            this.userControl_Sorokin1.DateRangeChanged += new EventHandler(this.userControl_Sorokin1_DateRangeChanged);
        }

        private void userControl_Sorokin1_DateRangeChanged(object sender, EventArgs e)
        {
            // Вычисление разницы между датами
            TimeSpan interval = userControl_Sorokin1.EndDate - userControl_Sorokin1.StartDate;

            // Отображение разницы в textBoxDaysNumber
            textBoxDaysNumber.Text = interval.TotalDays.ToString();
        }
    }
}
