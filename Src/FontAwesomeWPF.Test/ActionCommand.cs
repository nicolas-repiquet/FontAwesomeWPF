using System;
using System.Windows.Input;

namespace FontAwesomeWPF.Test;

public class ActionCommand : ICommand
{
	public ActionCommand(Action action)
	{
		_action = action;
	}

	private readonly Action _action;

	public bool CanExecute(object? parameter) => true;

	public void Execute(object? parameter)
	{
		_action();
	}

	public event EventHandler? CanExecuteChanged;
}