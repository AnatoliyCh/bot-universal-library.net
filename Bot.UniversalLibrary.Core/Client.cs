using Bot.UniversalLibrary.Core.Interfaces;

namespace Bot.UniversalLibrary.Core;

/// <summary>
///     Base abstract client class.
///     Responsible for interaction with the end platform.
/// </summary>
public abstract class Client : IClient, IHistory<string>
{
    /// <summary>
    ///     Maximum customer history length.
    /// </summary>
    private readonly int? maxHistoryCount;

    /// <summary>
    ///     Initializes a new instance of the <see cref="Client" /> class.
    /// </summary>
    protected Client()
    {
        State = Status.Off;
        History = new Queue<string>();
    }

    /// <summary>
    ///     Initializes a new instance of the <see cref="Client" /> class.
    /// </summary>
    /// <param name="history">Customer activity history.</param>
    /// <param name="maxHistoryCount">Maximum customer history length.</param>
    protected Client(Queue<string> history, int? maxHistoryCount = null)
    {
        State = Status.Off;
        this.maxHistoryCount = maxHistoryCount;
        History = history ?? throw new ArgumentNullException(nameof(history));
    }

    /// <summary>
    ///     Gets or sets the current state of the client.
    /// </summary>
    public Status State { get; protected set; }

    /// <summary>
    ///     Client launch.
    /// </summary>
    public virtual void Start()
    {
        State = Status.On;
    }

    /// <summary>
    ///     Client stop.
    /// </summary>
    public virtual void Stop()
    {
        State = Status.Off;
    }

    /// <summary>
    ///     Gets or sets the client's history.
    /// </summary>
    public Queue<string> History { get; protected set; }

    /// <summary>
    ///     Adds an object to the end of the History.
    /// </summary>
    /// <param name="historyItem">New history entry.</param>
    protected virtual void AddToHistory(string historyItem)
    {
        History.Enqueue(historyItem);
        if (History.Count > maxHistoryCount) History.Dequeue();
    }
}