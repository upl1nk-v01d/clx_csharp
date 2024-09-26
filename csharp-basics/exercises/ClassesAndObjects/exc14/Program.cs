using System.Globalization;

class WeekdayInDutch()
{
    public static string GetDate(int year, int month, int day)
    {
        DateTime date = new DateTime(year, month, day);
        CultureInfo culture = new CultureInfo("nl-NL");

        string weekdayNameInDutch = date.ToString("dddd", culture);

        return weekdayNameInDutch;
    }
}

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(WeekdayInDutch.GetDate(1970, 9, 21));
        Console.WriteLine(WeekdayInDutch.GetDate(1945, 9, 2));
        Console.WriteLine(WeekdayInDutch.GetDate(2001, 9, 11));
    }
}