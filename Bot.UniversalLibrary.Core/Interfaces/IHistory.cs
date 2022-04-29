namespace Bot.UniversalLibrary.Core.Interfaces;

/// <summary>
///     Essence history.
/// </summary>
/// <typeparam name="T">History object type.</typeparam>
public interface IHistory<T>
{
    /// <summary>
    ///     Adds a new history entry.
    /// </summary>
    /// <param name="history">New entry in history.</param>
    public void Push(T history);

    /// <summary>
    ///     Retrieves a record from the beginning of the history.
    /// </summary>
    /// <returns>Newest entry.</returns>
    public T Pop();

    /// <summary>
    ///     Clear the history.
    /// </summary>
    public void Clear();

    /// <summary>
    ///     Returns history.
    /// </summary>
    /// <returns>Collection history.</returns>
    public IEnumerable<T> GetHistory();
}