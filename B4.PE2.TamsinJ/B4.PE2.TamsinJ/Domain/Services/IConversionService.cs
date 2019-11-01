using System;
using System.Collections.Generic;
using System.Text;

namespace B4.PE2.TamsinJ.Domain.Services
{
    interface IConversionService
    {
        double HoursToDays(int hours);
        int DaysToHours(int days);
        double MinutesToHours(int minutes);
        int HoursToMinutes(int hours);
        double SecondsToMinutes(int seconds);
        int MinutesToSeconds(int minutes);
    }
}
