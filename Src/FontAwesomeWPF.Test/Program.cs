using System;
using System.Windows;
using System.Windows.Media;

namespace FontAwesomeWPF.Test;

public static class Program
{
	[STAThread]
	public static void Main(string[] args)
	{
		var icon = new IconVM();

		icon.Layer0.Source = Solid.Cat;
		icon.Layer0.Brush = Brushes.Salmon;
		
		var application = new Application();
		var window = new MainWindow();
		window.DataContext = icon;
		application.Run(window);
	}
}