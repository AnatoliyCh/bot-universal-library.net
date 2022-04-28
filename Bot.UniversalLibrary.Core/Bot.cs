using Bot.UniversalLibrary.Core.Interfaces;

namespace Bot.UniversalLibrary.Core;

/// <summary>
///     Base abstract bot class.
/// </summary>
public abstract class Bot : IBot
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="Bot" /> class.
    /// </summary>
    protected Bot()
    {
        State = Status.Off;
        Clients = new List<IClient>();
    }

    /// <summary>
    ///     Initializes a new instance of the <see cref="Bot" /> class.
    /// </summary>
    /// <param name="clients">List of bot clients (example: telegram, discord).</param>
    protected Bot(IList<IClient> clients)
    {
        State = Status.Off;
        Clients = clients ?? throw new ArgumentNullException(nameof(clients));
    }

    /// <summary>
    ///     Gets or sets the current state of the bot.
    /// </summary>
    public Status State { get; protected set; }

    /// <summary>
    ///     Gets or sets a list of clients that are responsible for interacting with the target platform.
    /// </summary>
    public IList<IClient> Clients { get; protected set; }

    /// <summary>
    ///     Bot launch.
    /// </summary>
    public virtual void Start()
    {
        State = Status.On;
        foreach (var client in Clients) client.Start();
    }

    /// <summary>
    ///     Bot stop.
    /// </summary>
    public virtual void Stop()
    {
        State = Status.Off;
        foreach (var client in Clients) client.Stop();
    }
}