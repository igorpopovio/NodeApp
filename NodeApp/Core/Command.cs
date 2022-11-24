namespace NodeApp.Core;

using System;
using System.Windows.Input;

class Command : ICommand
{
    private readonly Action _action;

    public event EventHandler? CanExecuteChanged;

    public Command(Action action)
    {
        _action = action;
    }

    public bool CanExecute(object? parameter) => true;

    public void Execute(object? parameter) => _action();
}
