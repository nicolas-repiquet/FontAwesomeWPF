using System;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Xml.Linq;

namespace FontAwesomeWPF.Test;

public class IconVM : ViewModelBase
{
	public IconLayerVM Layer0 { get; } = new IconLayerVM(0);
	public IconLayerVM Layer1 { get; } = new IconLayerVM(1);
	public IconLayerVM Layer2 { get; } = new IconLayerVM(2);

	private double _size = 32;
	public double Size
	{
		get => _size;
		set => SetField(ref _size, value);
	}

	public IconVM()
	{
		PropertyChanged += OnAnyPropertyChanged;
		Layer0.PropertyChanged += OnAnyPropertyChanged;
		Layer1.PropertyChanged += OnAnyPropertyChanged;
		Layer2.PropertyChanged += OnAnyPropertyChanged;
	}

	private void OnAnyPropertyChanged(object? sender, PropertyChangedEventArgs e)
	{
		if (sender != this || e.PropertyName != nameof(Xaml))
		{
			OnPropertyChanged(nameof(Xaml));
		}
	}

	private void SetLayerAttributes(XElement element, IconLayerVM layer)
	{
		if (!layer.IsVisible || layer.Source == null)
		{
			return;
		}

		if (layer.Mode == LayerMode.Draw &&
		    ((layer.Brush == null && layer.Pen == null) || layer.Opacity <= 0 || layer.Scale <= 0))
		{
			return;
		}

		if (layer.Mode == LayerMode.Mask && layer.Scale <= 0)
		{
			return;
		}

		if (Solid.GetAll().Contains(layer.Source))
		{
			element.Add(new XAttribute($"Source{layer.Index}", $"{{x:Static fa:Solid.{layer.Source.Name}}}"));
		}
		else if (Regular.GetAll().Contains(layer.Source))
		{
			element.Add(new XAttribute($"Source{layer.Index}", $"{{x:Static fa:Regular.{layer.Source.Name}}}"));
		}
		else if (Brands.GetAll().Contains(layer.Source))
		{
			element.Add(new XAttribute($"Source{layer.Index}", $"{{x:Static fa:Brands.{layer.Source.Name}}}"));
		}

		if (layer.Mode == LayerMode.Draw)
		{
			if (layer.Brush is SolidColorBrush brush)
			{
				var color = brush.Color;

				element.Add(new XAttribute($"Brush{layer.Index}", $"#{color.R:X2}{color.G:X2}{color.B:X2}"));
			}

			if (layer.Opacity != 1)
			{
				element.Add(new XAttribute($"Opacity{layer.Index}",
					Math.Round(layer.Opacity, 2).ToString(CultureInfo.InvariantCulture)));
			}
		}
		else // mask
		{
			element.Add(new XAttribute($"Mode{layer.Index}", "Mask"));
		}

		if (layer.Scale != 1)
		{
			element.Add(new XAttribute($"Scale{layer.Index}", Math.Round(layer.Scale, 2).ToString(CultureInfo.InvariantCulture)));
		}
		
		if (layer.OffsetX != 0)
		{
			element.Add(new XAttribute($"OffsetX{layer.Index}", Math.Round(layer.OffsetX, 2).ToString(CultureInfo.InvariantCulture)));
		}

		if (layer.OffsetY != 0)
		{
			element.Add(new XAttribute($"OffsetY{layer.Index}",
				Math.Round(layer.OffsetY, 2).ToString(CultureInfo.InvariantCulture)));
		}

		if (layer.Rotation != 0)
		{
			element.Add(new XAttribute($"Rotation{layer.Index}", Math.Round(layer.Rotation, 2).ToString(CultureInfo.InvariantCulture)));
		}
	}

	public string Xaml
	{
		get
		{
			var element = new XElement("Icon");

			if (Size != 32)
			{
				element.Add(
					new XAttribute("Width", Math.Round(Size, 2).ToString(CultureInfo.InvariantCulture)),
					new XAttribute("Height", Math.Round(Size, 2).ToString(CultureInfo.InvariantCulture))
				);
			}

			SetLayerAttributes(element, Layer0);
			SetLayerAttributes(element, Layer1);
			SetLayerAttributes(element, Layer2);

			// (-_-)
			return element.ToString().Replace("<Icon ", "<fa:Icon ");
		}
	}

	private void CopyXaml()
	{
		Clipboard.SetText(Xaml);
	}

	public ICommand CopyXamlCommand => new ActionCommand(CopyXaml);
}