namespace Bot.UniversalLibrary.Infrastructure;

/// <summary>
///     Implements an empty command.
/// </summary>
public class NoCommand : Core.Command
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="NoCommand" /> class.
    /// </summary>
    public NoCommand()
        : base(string.Empty)
    {
    }

    /// <summary>
    ///     Run command.
    /// </summary>
    public override void Execute()
    {
    }

    /// <summary>
    ///     Rollback command.
    /// </summary>
    public override void Undo()
    {
    }
}