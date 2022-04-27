using Bot.UniversalLibrary.Core.Interfaces;

namespace Bot.UniversalLibrary.Core;

/// <summary>
///     Base abstract client class.
/// </summary>
public abstract class Client : IClient
{
    /// <summary>
    ///     Client launch.
    /// </summary>
    public abstract void Start();

    /// <summary>
    ///     Client stop.
    /// </summary>
    public abstract void Stop();
}