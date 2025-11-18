using System.ComponentModel.DataAnnotations;

internal class Program
{
    List<DailyLog> DailyLogs = new List<DailyLog>();
    public void AddDailyLog()
    {

    }
     public void ViewPastLogs()
    {

    }
    public void AnalaysWeek()
    {

    }
    public void Exits()
    {

    }
    public void Option(string option)
    {

        switch (option) {
            case "1":
                AddDailyLog();
            break;
            case "2":
               ViewPastLogs();
                break;
            case "3":
                AnalaysWeek();
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
    public void DisplayMenu()
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
    }
}

class DailyLog
{
    public string mood;
    public string exercise;
    public string meditate;
    public string hoursOfSleep;
}