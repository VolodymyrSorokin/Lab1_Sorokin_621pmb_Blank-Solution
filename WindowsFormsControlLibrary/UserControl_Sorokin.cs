using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsControlLibrary
{
    [ToolboxBitmap(@"D:\Vlad\ВступУкр\МлБак\4_Семестр\Архитектура и проектирование ПО_NET\Lab1_Sorokin_621pmb_Blank Solution\WindowsFormsControlLibrary\UserControl_Sorokin.ico")]
    [DisplayName("User Control Sorokin")]
    public partial class UserControl_Sorokin : UserControl
    {
        private MonthCalendar monthCalendarStart;
        private MonthCalendar monthCalendarEnd;
        private TextBox intervalTextBox;

        public UserControl_Sorokin()
        {
            InitializeComponent();
            InitializeCalendars();
            SetInitialDates();
        }

        private void InitializeCalendars()
        {
            this.monthCalendarStart.MaxSelectionCount = 1;
            this.monthCalendarEnd.MaxSelectionCount = 1;
        }

        private void SetInitialDates()
        {
            this.monthCalendarStart.SetDate(DateTime.Now);
            this.monthCalendarEnd.SetDate(DateTime.Now.AddDays(7));
        }

        [Category("Date Range")]
        [Description("Gets or sets the start date of the range.")]
        public DateTime StartDate
        {
            get { return monthCalendarStart.SelectionStart; }
            set { monthCalendarStart.SetDate(value); }
        }

        [Category("Date Range")]
        [Description("Gets or sets the end date of the range.")]
        public DateTime EndDate
        {
            get { return monthCalendarEnd.SelectionStart; }
            set { monthCalendarEnd.SetDate(value); }
        }

        [Category("Action")]
        [Description("Fires when the date range is changed.")]
        public event EventHandler DateRangeChanged;

        protected virtual void OnDateRangeChanged(EventArgs e)
        {
            DateRangeChanged?.Invoke(this, e);
            UpdateIntervalTextBox();
        }

        private void MonthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            OnDateRangeChanged(EventArgs.Empty);
        }

        private void UpdateIntervalTextBox()
        {
            TimeSpan interval = EndDate - StartDate;
            intervalTextBox.Text = $"Інтервал часу оновлено. Новий інтервал: {interval.Days} днів";
        }

        private void InitializeComponent()
        {
            this.monthCalendarStart = new MonthCalendar();
            this.monthCalendarEnd = new MonthCalendar();
            this.intervalTextBox = new TextBox();
            this.SuspendLayout();

            // 
            // monthCalendarStart
            // 
            this.monthCalendarStart.Location = new Point(10, 10);
            this.monthCalendarStart.Name = "monthCalendarStart";
            this.monthCalendarStart.TabIndex = 0;
            this.monthCalendarStart.DateChanged += new DateRangeEventHandler(this.MonthCalendar_DateChanged);

            // 
            // monthCalendarEnd
            // 
            this.monthCalendarEnd.Location = new Point(250, 10);
            this.monthCalendarEnd.Name = "monthCalendarEnd";
            this.monthCalendarEnd.TabIndex = 1;
            this.monthCalendarEnd.DateChanged += new DateRangeEventHandler(this.MonthCalendar_DateChanged);

            // 
            // intervalTextBox
            // 
            this.intervalTextBox.Location = new Point(10, 180);
            this.intervalTextBox.Name = "intervalTextBox";
            this.intervalTextBox.ReadOnly = true;
            this.intervalTextBox.TabIndex = 2;

            // 
            // UserControl_Sorokin
            // 
            this.Controls.Add(this.monthCalendarStart);
            this.Controls.Add(this.monthCalendarEnd);
            this.Controls.Add(this.intervalTextBox);
            this.Name = "UserControl_Sorokin";
            this.Size = new Size(500, 200);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}