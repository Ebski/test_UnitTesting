using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestHandin2
{
    public class DaysInMonth
    {
        public int getNumDaysinMonth(int month, int year)
        {
            try
            {
                int days = 0;

                if (month < 1 || month > 12) throw new ArgumentOutOfRangeException("Month has to be between 1 and 12");
                if (year < 0 || year > int.MaxValue - 1) throw new ArgumentOutOfRangeException("Year has to be between 0 and maxInt");

                if (month == 2 && isLeapYear(year)) days = 29;
                if (month == 2 && !isLeapYear(year)) days = 28;
                if (month != 2) days = daysInMonth(month);

                return days;
            } catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
                return 0;
            }
        }

        private bool isLeapYear(int year)
        {
            if (year % 400 == 0) return true;
            else if (year % 4 == 0 & year % 100 == 0) return false;
            else if (year % 4 == 0) return true;
            else return false;
        }

        private int daysInMonth(int month)
        {
            int days = 0;

            switch (month)
            {
                case 1:
                    days = 31;
                    break;
                case 3:
                    days = 31;
                    break;
                case 4:
                    days = 30;
                    break;
                case 5:
                    days = 31;
                    break;
                case 6:
                    days = 30;
                    break;
                case 7:
                    days = 31;
                    break;
                case 8:
                    days = 31;
                    break;
                case 9:
                    days = 30;
                    break;
                case 10:
                    days = 31;
                    break;
                case 11:
                    days = 30;
                    break;
                case 12:
                    days = 31;
                    break;
            }
            return days;
        }
    }
}
