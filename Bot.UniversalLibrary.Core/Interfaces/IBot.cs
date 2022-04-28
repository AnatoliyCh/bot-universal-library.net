namespace Bot.UniversalLibrary.Core.Interfaces;

/// <summary>
///     Entity state types.
/// </summary>
public enum Status
{
    /// <summary>
    ///     Represents a running entity.
    /// </summary>
    On,

    /// <summary>
    ///     Represents a stopped entity.
    /// </summary>
    Off
}

/// <summary>
///     Basic bot interface.
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