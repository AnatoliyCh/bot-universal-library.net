namespace Bot.UniversalLibrary.Core.Interfaces;

/// <summary>
///     Command Interface.
/// </summary>
public interface ICommand
{
    /// <summary>
    ///     Run command.
    /// </summary>
    public void Execute();

    /// <summary>
    ///     Rollback command.
    /// </summary>
    public void Undo();
}