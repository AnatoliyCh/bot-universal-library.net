namespace Bot.UniversalLibrary.Core.Interfaces;

/// <summary>
///     Responsible for interaction with the end platform.
/// </summary>
public interface IClient : IStartable, IStopable
{
    /// <summary>
    ///     Gets the current state of the client.
    /// </summary>
    public Status State { get; }
}