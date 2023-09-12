namespace Dates;

public class Date
{
    public void DisplayDateTime()
    {
        Console.WriteLine("\nDate Time");
        var dateTime1 = new DateTime(2023, 08, 14, 23, 50, 27);
        var dateTime2 = DateTime.Parse("2022/12/22 23:50:27");
        var dateTime3 = DateTime.Now;
        var dateTime4 = DateTime.Today;

        Console.WriteLine($"Example 01: {dateTime1}");
        Console.WriteLine($"Example 02: {dateTime2}");
        Console.WriteLine($"Example 03: {dateTime3}");
        Console.WriteLine($"Example 04: {dateTime4}");  

        Console.WriteLine($"Example 05: {dateTime1.ToString("yyyy/MM/dd")}");
        Console.WriteLine($"Example 06: {dateTime1.ToString("yyyy-MM-dd")}");
        Console.WriteLine($"Example 07: {dateTime1.ToString("yyyy-MM-dd HH:mm:ss")}");

        Console.WriteLine("\nDate Time Offset");
        var dateOffset = new DateTimeOffset(DateTime.Now, new TimeSpan(-3, 0, 0));
        
        Console.WriteLine($"Example 01: {dateOffset.LocalDateTime}");
        Console.WriteLine($"Example 02: {dateOffset.UtcDateTime}");
        Console.WriteLine($"Example 03: {DateTimeOffset.Now}");
        Console.WriteLine($"Example 04: {DateTimeOffset.UtcNow}");
    }

    public void SubtractDates()
    {
        Console.WriteLine("\nSubtract Dates");
        var date1 = DateTime.Now;
        var date2 = DateTime.Parse("2023-01-01");
        var difference = date1.Subtract(date2);

        Console.WriteLine($"Total Days: {(int)difference.TotalDays}");
        Console.WriteLine($"Total Hours: {(int)difference.TotalHours}");
    }

    public void AddDaysMonthsYears()
    {
        Console.WriteLine("\nAdd Days, Months and Years");
        var date = DateTime.Now;

        Console.WriteLine($"Date: {date.ToString("MM-dd-yyyy")}");
        Console.WriteLine($"Add Days: {date.AddDays(3).ToString("MM-dd-yyyy")}");
        Console.WriteLine($"Add Months: {date.AddMonths(1).ToString("MM-dd-yyyy")}");
        Console.WriteLine($"Add Years: {date.AddYears(1).ToString("MM-dd-yyyy")}");
    }

    public void AddHoursMinutesSeconds()
    {
        Console.WriteLine("\nAdd Hours, Minutes and Seconds");
        var time = DateTime.Now;

        Console.WriteLine($"Time: {time.ToString("HH:mm:ss")}");
        Console.WriteLine($"Add Hours: {time.AddHours(1).ToString("HH:mm:ss")}");
        Console.WriteLine($"Add Minutes: {time.AddMinutes(10).ToString("HH:mm:ss")}");
        Console.WriteLine($"Add Seconds: {time.AddSeconds(10).ToString("HH:mm:ss")}");
    }

    public void RetrieveDayOfWeek()
    {
        Console.WriteLine("\nRetrieve Day of Week");
        var dayOfWeek = DateTime.Now;

        Console.WriteLine($"Date Time: {dayOfWeek}");
        Console.WriteLine($"Day of Week: {dayOfWeek.DayOfWeek}");
    }

    public void ExtractDateOnly()
    {
        Console.WriteLine("\nDate Only");
        var dateOnly = DateOnly.Parse("2022-02-01");

        Console.WriteLine($"Example 01: {dateOnly}");
        Console.WriteLine($"Example 02: {dateOnly.ToString("yyyy/MM/dd")}");
    }

    public void ExtractTimeOnly()
    {
        Console.WriteLine("\nTime Only");
        var timeOnly1 = new TimeOnly(23,01,23,450);
        var timeOnly2 = TimeOnly.Parse("23:01:23");

        Console.WriteLine($"Example 01: {timeOnly1}");
        Console.WriteLine($"Example 02: {timeOnly2}");
        Console.WriteLine($"Example 03: {timeOnly1.ToString("HH:mm:ss")}");
        Console.WriteLine($"Example 04: {timeOnly1.ToString("HH:mm:ss:fff")}\n");
    }
}