using System;
using HelperLibrary;

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
        displayOneLine($"{DateTimeHelper.EndOfMonthPlus45Days(uneDate).ToShortDateString()};"); // fin du mois + 45 jours 
        displayOneLine($"{DateTimeHelper.FourtyFiveDaysplusEndOfTheMonth(uneDate).ToShortDateString()}"); //  45 jours + fin du mois
        displayOneLine($" Best date is : {DateTimeHelper.BestDate(uneDate).ToShortDateString()}");
        display("");
      }

      display("Press any key to exit:");
      Console.ReadKey();
    }
  }
}