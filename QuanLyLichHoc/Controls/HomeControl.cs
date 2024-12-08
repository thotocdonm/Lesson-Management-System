using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyLichHoc.Controls
{
    public partial class HomeControl : UserControl

        
    {

        int day, month, year;
        public HomeControl()
        {
            InitializeComponent();
            displayDays();
        }


        private void displayDays()
        {
            DateTime now = DateTime.Now;

            DateTime startOfWeek = now.AddDays(-(int)now.DayOfWeek);
            day = startOfWeek.Day;
            month = startOfWeek.Month;
            year = startOfWeek.Year;

            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            LABELDATE.Text = $"{monthname} {year}";


            dayContainer.Controls.Clear();


            for (int i = 0; i < 7; i++)
            {
                HomeControlDay hcday = new HomeControlDay();
                hcday.days($"{startOfWeek.Day}/{startOfWeek.Month}");
                dayContainer.Controls.Add(hcday);


                startOfWeek = startOfWeek.AddDays(1);
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            dayContainer.Controls.Clear();


            DateTime currentDate = new DateTime(year, month, day).AddDays(-7);

            month = currentDate.Month;
            year = currentDate.Year;
            day = currentDate.Day;

            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            LABELDATE.Text = monthname + " " + year;

            int daysToShow = 7;
            int currentDay = day;
            int currentMonth = month;
            int currentYear = year;


            for (int i = 0; i < daysToShow; i++)
            {
                if (currentDay > DateTime.DaysInMonth(currentYear, currentMonth))
                {
                    currentDay = 1;
                    currentMonth++;
                    if (currentMonth > 12)
                    {
                        currentMonth = 1;
                        currentYear++;
                    }
                }

                HomeControlDay hcday = new HomeControlDay();
                hcday.days($"{currentDay}/{currentMonth}");
                dayContainer.Controls.Add(hcday);

                currentDay++;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            dayContainer.Controls.Clear();

            DateTime currentDate = new DateTime(year, month, day).AddDays(7);

            month = currentDate.Month;
            year = currentDate.Year;
            day = currentDate.Day;

            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            LABELDATE.Text = monthname + " " + year;

            int daysInMonth = DateTime.DaysInMonth(year, month);

            int daysToShow = 7;
            int currentDay = day;
            int currentMonth = month;
            int currentYear = year;

            for (int i = 0; i < daysToShow; i++)
            {
                if (currentDay > DateTime.DaysInMonth(currentYear, currentMonth))
                {
                    currentDay = 1; 
                    currentMonth++;
                    if (currentMonth > 12) 
                    {
                        currentMonth = 1;
                        currentYear++;
                    }
                }

                HomeControlDay hcday = new HomeControlDay();
                hcday.days($"{currentDay}/{currentMonth}"); 
                dayContainer.Controls.Add(hcday);

                currentDay++; 
            }
        }
        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
