namespace Bot.UniversalLibrary.Core.Interfaces;

/// <summary>
///     Bot client, responsible for interacting with the end platform.
/// </summary>
/// <typeparam name="THistory">Type of objects in the queue.</typeparam>
public interface IClient<THistory> : IStartable, IStopable
{
    /// <summary>
    ///     Gets the client's history.
    /// </summary>
    public Queue<THistory> History { get; }

    /// <summary>
    ///     Adds an object to the end of the History.
    /// </summary>
    /// <param name="historyItem">New history entry.</param>
    public void AddToHistory(THistory historyItem);
}

/// <summary>
///     Bot client, responsible for interacting with the end platform.
/// </summary>
public interface IClient : IClient<string>
{
}