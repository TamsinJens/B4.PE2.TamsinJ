using B4.PE2.TamsinJ.Domain.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace B4.PE2.TamsinJ
{
    class ConversionService : IConversionService
    {
        public int DaysToHours(int days)
        {
            return days * 24;
        }

        public double HoursToDays(int hours)
        {
            return hours / 24;
        }

        public int HoursToMinutes(int hours)
        {
            return hours * 60;
        }

        public double MinutesToHours(int minutes)
        {
            return minutes / 60;
        }

        public int MinutesToSeconds(int minutes)
        {
            return minutes * 60;
        }

        public double SecondsToMinutes(int seconds)
        {
            return seconds / 60;
        }
    }
}
