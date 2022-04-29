using Bot.UniversalLibrary.Core.Interfaces;

namespace Bot.UniversalLibrary.Core;

/// <summary>
///     Base abstract client class.
///     Responsible for interaction with the end platform.
/// </summary>
public abstract class Client : IClient, IHistorable<string>
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="Client" /> class.
    /// </summary>
    /// <param name="history">Customer activity history.</param>
    protected Client(IHistory<string> history)
    {
        State = Status.Off;
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
    public IHistory<string> History { get; protected set; }
}