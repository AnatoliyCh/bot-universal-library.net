namespace Bot.UniversalLibrary.Core.Interfaces;

/// <summary>
///     Essence history.
/// </summary>
/// <typeparam name="THistory">History object type.</typeparam>
public interface IHistory<THistory>
{
    /// <summary>
    ///     Gets the client's history.
    /// </summary>
    public Queue<THistory> History { get; }
}