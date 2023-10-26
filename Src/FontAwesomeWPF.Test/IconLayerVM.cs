using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows.Media;

namespace FontAwesomeWPF.Test;

public class IconLayerVM : ViewModelBase
{
	public IconLayerVM(int index)
	{
		Index = index;
	}

	public int Index { get; }
	
	private bool _isVisible = true;
	public bool IsVisible
	{
		get => _isVisible;
		set => SetField(ref _isVisible, value);
	}

	public IEnumerable<IconSource> Sources
	{
		get => Solid.GetAll().Concat(Regular.GetAll()).Concat(Brands.GetAll());
	}

	private IconSource? _source;
	public IconSource? Source
	{
		get => _source;
		set => SetField(ref _source, value);
	}

	public IEnumerable<LayerMode> Modes
	{
		get
		{
			yield return LayerMode.Draw;
			yield return LayerMode.Mask;
		}
	}

	private LayerMode _mode = LayerMode.Draw;
	public LayerMode Mode
	{
		get => _mode;
		set => SetField(ref _mode, value);
	}

	public IEnumerable<Brush> Brushes
	{
		get
		{
			return typeof(System.Windows.Media.Brushes).GetProperties(BindingFlags.Public | BindingFlags.Static)
				.Where(e => e.PropertyType == typeof(SolidColorBrush))
				.Select(e => (Brush) e.GetValue(null));
		}
	}

	private Brush? _brush;
	public Brush? Brush
	{
		get => _brush;
		set => SetField(ref _brush, value);
	}

	private string _color;
	public string Color
	{
		get => _color;
		set
		{
			if (SetField(ref _color, value))
			{
				try
				{
					if (string.IsNullOrWhiteSpace(_color))
					{
						Brush = null;
					}
					else
					{
						var color = (Color)ColorConverter.ConvertFromString(_color);
						Brush = new SolidColorBrush(color);
					}
				}
				catch (Exception)
				{
					// oops
				}
			}
		}
	}

	private Pen? _pen;
	public Pen? Pen
	{
		get => _pen;
		set => SetField(ref _pen, value);
	}

	private double _opacity = 1.0;
	public double Opacity
	{
		get => _opacity;
		set => SetField(ref _opacity, value);
	}
	
	private double _scale = 1.0;
	public double Scale
	{
		get => _scale;
		set => SetField(ref _scale, value);
	}
	
	private double _offsetX = 0.0;
	public double OffsetX
	{
		get => _offsetX;
		set => SetField(ref _offsetX, value);
	}
		
	private double _offsetY = 0.0;
	public double OffsetY
	{
		get => _offsetY;
		set => SetField(ref _offsetY, value);
	}
	
	private double _rotation = 0.0;
	public double Rotation
	{
		get => _rotation;
		set => SetField(ref _rotation, value);
	}
}