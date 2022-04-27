namespace Bot.UniversalLibrary.Core.Interfaces;

/// <summary>
///     Base client class.
///     The client is responsible for interacting with the end platform.
/// </summary>
public interface IBot : IStartable, IStopable
{
    /// <summary>
    ///     Gets the current state of the bot.
    /// </summary>
    public Status State { get; }

    /// <summary>
    ///     Gets a list of clients that are responsible for interacting with the target platform.
    /// </summary>
    public IList<IClient> Clients { get; }
}