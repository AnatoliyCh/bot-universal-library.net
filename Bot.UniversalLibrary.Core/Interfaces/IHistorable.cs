namespace Bot.UniversalLibrary.Core.Interfaces;

/// <summary>
///     Entity has a history.
/// </summary>
/// <typeparam name="THistory">History object type.</typeparam>
internal interface IHistorable<THistory>
{
    /// <summary>
    ///     Gets the history object.
    /// </summary>
    public IHistory<THistory> History { get; }
}