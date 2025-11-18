using System.ComponentModel.DataAnnotations;

internal class Program

{
    // static because your methods are static
    static List<DailyLog> DailyLogs = new List<DailyLog>();
    public static void AddDailyLog()
    {

    }
     public static void ViewPastLogs()
    {

    }
    public static void AnalyseMyWeek()
    {

    }
    public static void Exit()
    {
        Console.WriteLine("Goodbye!");
        Environment.Exit(0);
    }
    public static void Option(string option)
    {
        switch (option)
        {
            case "1":
                AddDailyLog();
                break;
            case "2":
                ViewPastLogs();
                break;
            case "3":
                AnalyseMyWeek();
                break;
            case "4":
                Exit();
                break;
            default:
                Console.WriteLine("Invalid Input!");
                break;
        }
    }
    public static void DisplayMenu()
    {
        while (true)
        {
            Console.WriteLine("\nPlease enter your choice: ");
            Console.WriteLine("1. Add the daily log");
            Console.WriteLine("2. View Past logs");
            Console.WriteLine("3. Analyse My Week");
            Console.WriteLine("4. Exit");

            string option = Console.ReadLine();

            if (!string.IsNullOrEmpty(option))
            {
                Option(option);
            }
            else
            {
                Console.WriteLine("You didn't put any option. Please select from the menu.");
            }
        }
    }
    private static void Main(string[] args)
    {
        Console.WriteLine("---------------WELCOME TO--------------- \n ------Daily Mood & Habit Tracker------");
        DisplayMenu();
    }
}

class DailyLog
{
    public string Mood { get; set; }
    public string Exercise { get; set; }
    public string Meditate { get; set; }
    public string HoursOfSleep { get; set; }
}