using System;

class WeekdayInDutch()
{
    int Year;
    int Month;
    int Day;
    public WeekdayInDutch(int year, int month, int day) : this() //why ': this()' ????
    {
        Day = day;
        Month = month;
        Year = year;

        GetDate(year, month, day);
    }

    public static void GetDate(int year, int month, int day)
    {
        var culture = new System.Globalization.CultureInfo("nl-NL");
        var _day = culture.DateTimeFormat.GetDayName(DateTime.Today.DayOfWeek);
        Console.WriteLine();
    }
}

class Program
{
    public static void Main(string[] args)
    {
        WeekdayInDutch(1970, 9, 21);
        WeekdayInDutch(1945, 9, 2);
        WeekdayInDutch(2001, 9, 11);
    }
}

