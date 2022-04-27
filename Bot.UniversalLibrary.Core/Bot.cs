using Bot.UniversalLibrary.Core.Interfaces;

namespace Bot.UniversalLibrary.Core;

/// <summary>
///     Bot state types.
/// </summary>
public enum Status
{
    /// <summary>
    ///     Represents a running bot.
    /// </summary>
    On,

    /// <summary>
    ///     Represents a stopped bot.
    /// </summary>
    Off
}

/// <summary>
///     Base abstract bot class.
/// </summary>
public abstract class Bot : IBot
{
    /// <summary>
    ///     Gets or sets the current state of the bot.
    /// </summary>
    public Status BotState { get; protected set; } = Status.Off;

    /// <summary>
    ///     Bot launch.
    /// </summary>
    public void Start()
    {
        BotState = Status.On;
    }

    /// <summary>
    ///     Bot stop.
    /// </summary>
    public void Stop()
    {
        BotState = Status.Off;
    }
}