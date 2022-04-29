namespace Bot.UniversalLibrary.Infrastructure;

/// <summary>
///     Provides history as strings.
/// </summary>
public class StringHistory : Core.History<string>
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="StringHistory" /> class.
    /// </summary>
    /// <param name="history">New history collection.</param>
    /// <param name="maxHistoryCount">Maximum history length.</param>
    public StringHistory(Queue<string>? history = null, int? maxHistoryCount = null)
        : base(history, maxHistoryCount)
    {
    }
}