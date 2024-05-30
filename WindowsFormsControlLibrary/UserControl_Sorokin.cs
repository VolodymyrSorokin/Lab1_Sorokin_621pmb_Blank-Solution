using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsControlLibrary
{
    [ToolboxBitmap(@"D:\Vlad\ВступУкр\МлБак\4_Семестр\Архитектура и проектирование ПО_NET\
                    Lab1_Sorokin_621pmb_Blank Solution\WindowsFormsControlLibrary\UserControl_Sorokin.ico")]
    [DisplayName("User Control Sorokin")]
    public partial class UserControl_Sorokin: UserControl
    {
        private MonthCalendar monthCalendarStart;
        private MonthCalendar monthCalendarEnd;

        public UserControl_Sorokin()
        {
            InitializeComponent();
            InitializeCalendars();
        }

        private void InitializeCalendars()
        {
            this.monthCalendarStart.MaxSelectionCount = 1;
            this.monthCalendarEnd.MaxSelectionCount = 1;
        }

        [Category("Date Range")]
        [Description("Gets or sets the start date of the range.")]
        public DateTime StartDate
        {
            get { return monthCalendarStart.SelectionStart; }
            set { monthCalendarStart.SelectionStart = value; }
        }

        [Category("Date Range")]
        [Description("Gets or sets the end date of the range.")]
        public DateTime EndDate
        {
            get { return monthCalendarEnd.SelectionStart; }
            set { monthCalendarEnd.SelectionStart = value; }
        }

        [Category("Action")]
        [Description("Fires when the date range is changed.")]
        public event EventHandler DateRangeChanged;

        protected virtual void OnDateRangeChanged(EventArgs e)
        {
            DateRangeChanged?.Invoke(this, e);
        }

        private void MonthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            OnDateRangeChanged(EventArgs.Empty);
        }
    }
}
