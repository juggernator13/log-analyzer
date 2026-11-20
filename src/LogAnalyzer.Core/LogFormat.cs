using System.Globalization;

namespace LogAnalyzer.Core;

public static class LogFormat
{
    private const string TimeFormat = "yyyy-MM-dd HH:mm:ss";

    public static string Format(LogEntry entry)
    {
        string time = entry.Time.ToString(TimeFormat, CultureInfo.InvariantCulture);
        var level = entry.Level.ToString().ToUpperInvariant();
        return $"{time} [{level}] {entry.Message}";
    }
}