using System;
using System.Collections.Generic;
using System.Text;

namespace B4.PE2.TamsinJ.Domain.Services
{
    interface IConversionService
    {
        int HoursToDays(int hours);
        int DaysToHours(int days);
        int MinutesToHours(int minutes);
        int HoursToMinutes(int hours);
        int SecondsToMinutes(int seconds);
        int MinutesToSeconds(int minutes);
    }
}
