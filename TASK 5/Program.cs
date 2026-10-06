namespace TASK_5;

class Program
{
    static void Main(string[] args)
    {
        DateTime birthDate = new DateTime(2005, 04, 17);
        DateTime currentDate = DateTime.Now;

        TimeSpan ageSpan = currentDate - birthDate;
        int ageInYears = (int)(ageSpan.TotalDays / 365.2425);
        DateTime dateAfterTenDays = birthDate.AddDays(10);

        Console.WriteLine($"Birthdate: {birthDate:d}");
        Console.WriteLine($"Current date and time: {currentDate}");
        Console.WriteLine($"Age: {ageInYears} years");
        Console.WriteLine($"Birthdate plus 10 days: {dateAfterTenDays:d}");
    }
}
