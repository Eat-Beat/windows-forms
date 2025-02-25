﻿using System.Globalization;

namespace Eat_Beat.Forms
{
    public partial class CalendarPopup : Form
    {
        public static int _year, _month;
        private ucDay _selectedUcDay = null;

        FormLogin formLogin;
        public CalendarPopup(FormLogin formLogin)
        {
            InitializeComponent();
            this.formLogin = formLogin;
        }



        private void showDays(int month, int year)
        {
            flowLayoutPanel1.Controls.Clear();
            _month = month;
            _year = year;

            String monthName = new DateTimeFormatInfo().GetMonthName(month);
            labelMonth.Text = monthName.ToUpper() + " " + year;
            DateTime startOfTheMonth = new DateTime(year, month, 1);
            int day = DateTime.DaysInMonth(year, month);
            int week = Convert.ToInt32(startOfTheMonth.DayOfWeek.ToString("d"));
            for (int i = 0; i < week; i++)                                                  // i=1
            {
                ucDay uc = new ucDay("", this);
                flowLayoutPanel1.Controls.Add(uc);
            }
            for (int i = 1; i <= day; i++)
            {
                ucDay uc = new ucDay(i + "", this);
                flowLayoutPanel1.Controls.Add(uc);
            }
        }

        private void CalendarPopup_Load(object sender, EventArgs e)
        {
            showDays(DateTime.Now.Month, DateTime.Now.Year);
        }

        private void roundedButtonBackToMusician_Click(object sender, EventArgs e)
        {
            formLogin.LoadFormIntoPanel("FormOpenMusician", true);
        }

        public void SetSelectedUcDay(ucDay newSelectedUcDay)
        {
            if (_selectedUcDay != null)
            {
                _selectedUcDay.Deselect(); // Deselect the previously selected ucDay
            }

            _selectedUcDay = newSelectedUcDay; // Update the selected ucDay
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            _month += 1;
            if (_month < 12)
            {
                _month = 12;
                _year += 1;
                showDays(_month, _year);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            _month -= 1;
            if (_month > 1)
            {
                _month = 12;
                _year -= 1;
                showDays(_month, _year);
            }
        }
    }
}
