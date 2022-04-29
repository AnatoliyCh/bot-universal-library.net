using Bot.UniversalLibrary.Core.Interfaces;

namespace Bot.UniversalLibrary.Core;

/// <summary>
///     Base abstract command class.
/// </summary>
public abstract class Command : ICommand
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="Command" /> class.
    /// </summary>
    /// <param name="name">Command name.</param>
    protected Command(string name)
    {
        Name = name ?? throw new ArgumentNullException(nameof(name));
    }

    /// <summary>
    ///     Gets command name.
    /// </summary>
    public string Name { get; }

    /// <summary>
    ///     Run command.
    /// </summary>
    public abstract void Execute();

    /// <summary>
    ///     Rollback command.
    /// </summary>
    public abstract void Undo();
}