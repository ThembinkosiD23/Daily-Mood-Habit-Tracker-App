using System.ComponentModel.DataAnnotations;
using static System.Net.Mime.MediaTypeNames;

internal class Program

{
    // static because your methods are static
    static List<DailyLog> DailyLogs = new List<DailyLog>();
    public static void AddDailyLog()
    {
        DateTime today = DateTime.Now;
        Console.WriteLine($"Add today's log. Date: {today}");

        Console.WriteLine("How was your mood today? (Happy, Tired, Stressed, Relaxed, Excited): ");
        string Mood = Console.ReadLine();

        Console.WriteLine("Did you exercise today? (yes/no): ");
        string Exercise = Console.ReadLine();

        Console.WriteLine("Did you meditate today? (yes/no): ");
        string Meditate = Console.ReadLine();

        Console.WriteLine("How many hours of sleep did you get?: ");
        string HoursOfSleep = Console.ReadLine();

        // CREATE THE OBJECT
        DailyLog log = new DailyLog();
        log.Mood = Mood;
        log.Exercise = Exercise;
        log.Meditate = Meditate;
        log.HoursOfSleep = HoursOfSleep;
        log.logDate = today;

        // ADD TO LIST
        DailyLogs.Add(log);

        // Save Logs to a Text File
        string path = "C:\\Users\\ThembinkosiDladla\\OneDrive - Prosus-Naspers\\Desktop\\LEARN25\\C#\\Fundamentals\\Projects\\Daily Mood & Habit Tracker App\\Logs\\dailylogs.txt";
        if (string.IsNullOrEmpty(path))
        {
            Console.WriteLine("INVALID PATH");
        }
        else
        {
            using (StreamWriter writer = new StreamWriter(path, true))
            {
                writer.WriteLine($"{today}: \n |Mood: {Mood}|Exercise: {Exercise}|Meditate: {Meditate}|Hours Of Sleep: {HoursOfSleep}");
            }
        }
        Console.WriteLine($"\nLog saved for {today}");

    }

    public static void ViewPastLogs()
    {
        //read the logs from the tex file and display them
        string path = "C:\\Users\\ThembinkosiDladla\\OneDrive - Prosus-Naspers\\Desktop\\LEARN25\\C#\\Fundamentals\\Projects\\Daily Mood & Habit Tracker App\\Logs\\dailylogs.txt";

        if (File.Exists(path))
        {
            using (StreamReader reader = new StreamReader(path))
            {
                string content = reader.ReadToEnd();
                Console.WriteLine("\n=== Your Past Logs ===");

                if (string.IsNullOrWhiteSpace(content))
                {
                    Console.WriteLine("No logs found.");
                }
                else
                {
                    Console.WriteLine(content);
                }
            }
        }
        else
        {
            Console.WriteLine("File not found!");
        }

        Console.WriteLine("\nPress ENTER to return to the menu...");
        Console.ReadLine();
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
            Console.WriteLine("Press ENTER to return to the menu...");
            Console.ReadLine();
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
    public DateTime logDate {  get; set; }
}