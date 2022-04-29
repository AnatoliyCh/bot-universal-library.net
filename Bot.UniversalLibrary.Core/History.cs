using Bot.UniversalLibrary.Core.Interfaces;

namespace Bot.UniversalLibrary.Core;

/// <summary>
///     Base abstract history class.
/// </summary>
/// <typeparam name="T">History object type.</typeparam>
public abstract class History<T> : IHistory<T>
{
    private readonly Queue<T> history;

    /// <summary>
    ///     Initializes a new instance of the <see cref="History{T}" /> class.
    /// </summary>
    /// <param name="history">New history collection.</param>
    /// <param name="maxHistoryCount">Maximum history length.</param>
    protected History(Queue<T>? history = null, int? maxHistoryCount = 32)
    {
        this.history = history ?? (maxHistoryCount is not null ? new Queue<T>((int)maxHistoryCount) : new Queue<T>());
        MaxHistoryCount = maxHistoryCount;
    }

    /// <summary>
    ///     Gets maximum customer history length.
    /// </summary>
    public int? MaxHistoryCount { get; }

    /// <summary>
    ///     Adds a new entry to the end of the story.
    /// </summary>
    /// <param name="history">New entry in history.</param>
    public virtual void Push(T history)
    {
        if (this.history.Count == MaxHistoryCount) this.history.Dequeue();
        this.history.Enqueue(history);
    }

    /// <summary>
    ///     Retrieves a record from the beginning of the history.
    /// </summary>
    /// <returns>Newest entry.</returns>
    public virtual T Pop()
    {
        return history.Dequeue();
    }

    /// <summary>
    ///     Clear queue.
    /// </summary>
    public virtual void Clear()
    {
        history.Clear();
    }

    /// <summary>
    ///     Returns history.
    /// </summary>
    /// <returns>Collection history.</returns>
    public IEnumerable<T> GetHistory()
    {
        return history;
    }
}