class Program
{
    private static string ReturnDayName(int day)
    {
        return Enum.GetName(typeof(DayOfWeek),day);
    }

    public static void Main(string[] args)
    {
        Console.Clear();

        string weekDay = ReturnDayName(0); //return Sunday

        Console.WriteLine(weekDay);
    }
}