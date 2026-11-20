namespace LogAnalyzer.Core;

public record LogEntry(DateTime Time, LogLevel Level, string Message);