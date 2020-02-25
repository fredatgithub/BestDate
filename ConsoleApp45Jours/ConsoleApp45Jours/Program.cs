using System;

namespace ConsoleApp45Jours
{
  internal class Program
  {
    private static void Main()
    {
      Action<string> display = Console.WriteLine;
      Action<string> displayOneLine = Console.Write;
      DateTime uneDate = DateTime.Now;
      for (int i = 1; i <= 29; i++)
      {
        uneDate = new DateTime(2020, 2, i);
        displayOneLine($"{uneDate.ToShortDateString()};");
        displayOneLine($"{EndOfMonthPlus45Days(uneDate).ToShortDateString()};"); // fin du mois + 45 jours 
        displayOneLine($"{FourtyFiveDaysplusEndOfTheMonth(uneDate).ToShortDateString()}"); //  45 jours + fin du mois
        displayOneLine($" Best date is : {BestDate(uneDate).ToShortDateString()}");
        display("");
      }

      display("Press any key to exit:");
      Console.ReadKey();
    }

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