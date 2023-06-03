namespace MultiLogger;

public static class Logger
{
    public const string LogPath = "log.txt";

    public static void WriteLine(string log)
    {
        Console.WriteLine(DateTime.Now + log);
        File.AppendAllText(LogPath, DateTime.Now +log + '\n');
    }

    public static void Write(string log)
    {
        Console.Write(DateTime.Now + log);
        File.AppendAllText(LogPath, DateTime.Now + log);
    }
}