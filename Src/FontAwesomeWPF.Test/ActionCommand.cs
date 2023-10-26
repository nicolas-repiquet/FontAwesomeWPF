using System;
using System.Windows.Input;

namespace FontAwesomeWPF.Test;

public class ActionCommand : ICommand
{
	public ActionCommand(Action<object?> action)
	{
		_action = action;
	}

	private readonly Action<object?> _action;

	public bool CanExecute(object? parameter) => true;

	public void Execute(object? parameter)
	{
		_action(parameter);
	}

	public event EventHandler? CanExecuteChanged;
}