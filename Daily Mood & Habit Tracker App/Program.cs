using System.ComponentModel.DataAnnotations;

internal class Program
{
    List<DailyLog> DailyLogs = new List<DailyLog>();
    public static void AddDailyLog()
    {

    }
     public static void ViewPastLogs()
    {

    }
    public static void AnalyzeWeek()
    {

    }
    public static void Exits()
    {

    }
    public static void Option(string option)
    {

        switch (option) {
            case "1":
                AddDailyLog();
            break;
            case "2":
               ViewPastLogs();
                break;
            case "3":
                AnalyzeWeek();
                break;
            case "4":
                   Exits();
            break;
            default:
                Console.WriteLine("Invalid Input!");
                DisplayMenu();
                break;
        }
    }
    public static void DisplayMenu()
    {
        Console.WriteLine("Please enter your choose: ");
        Console.WriteLine("1. Add the daily log. ");
        Console.WriteLine("2. View Past logs. ");
        Console.WriteLine("3. Analyse My Week ");
        Console.WriteLine("4. Exits");
        string option = Console.ReadLine();
        if (!String.IsNullOrEmpty(option))
        {
            Option(option);
        }
        else
            Console.WriteLine("You didn't put any Option, Please select option from the above.");

    }
    private static void Main(string[] args)
    {
        Console.WriteLine("---------------WELCOME TO--------------- \n ------Daily Mood & Habit Tracker------");
        Displ
    }
}

class DailyLog
{
    string mood { get; set; }
    string exercise { get; set; }
    string meditate { get; set; }
    string hoursOfSleep { get; set; }
}