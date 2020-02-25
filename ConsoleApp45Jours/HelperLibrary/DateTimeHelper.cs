using System;

namespace HelperLibrary
{
  public static class DateTimeHelper
  {
    public static DateTime EndOfMonthPlus45Days(DateTime date)
    {
      DateTime endOfTheMonth = EndOfMonth(date);
      return endOfTheMonth.AddDays(45);
    }

    public static DateTime FourtyFiveDaysplusEndOfTheMonth(DateTime date)
    {
      DateTime datePlus45 = date.AddDays(45);
      DateTime endOfTheMonth = EndOfMonth(datePlus45);
      return endOfTheMonth;
    }

    public static DateTime EndOfMonth(DateTime date)
    {
      return new DateTime(date.Year, date.Month, DateTime.DaysInMonth(date.Year, date.Month));
    }

    public static DateTime BestDate(DateTime oneDate)
    {
      DateTime firstDate = EndOfMonthPlus45Days(oneDate);
      DateTime secondDate = FourtyFiveDaysplusEndOfTheMonth(oneDate);
      return firstDate <= secondDate ? firstDate : secondDate;
    }
  }
}
