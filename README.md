# FontAwesomeWPF

Simple library to bring FontAwesome icons in your WPF application.

Font Awesome version : 6.4.0 Free

# Usage

Install the nuget package _NicolasRepiquet.FontAwesomeWPF_.

Add the namespace to your _XAML_ file, and use the _Icon_ control.


````xaml

<Window
    ...
    xmlns:fa="clr-namespace:FontAwesomeWPF;assembly=FontAwesomeWPF"
    ...
    />

...

    <fa:Icon Source0="{x:Static fa:Solid.Cat}" Brush0="#ffaa00">

````

# How it works

The _Icon_ control contains three optional layers. Each of these layer can be used to show a FontAwesome icon.

The way the layer is shown it controlled by various parameters (replace I with the layer index [0..2]) :

| Name       | Type       | Description                          |
|------------|------------|--------------------------------------|
| IsVisibleI  | bool       | Show or hide the layer               |
| ModeI       | LayerMode  | Layer can be drawn or used as a mask |
| SourceI     | IconSource | Geometry to use for this layer       |
| BrushI      | Brush      | Brush used to fill the geometry      |
| PenI        | Pen        | Pen used to stroke the geometry      |
| OpacityI    | double     | [0..1] Opacity of the layer          |
| ScaleI      | double     | Factor to scale the geometry with    |
| OffsetXI    | double     | Add an horizontal offset to the layer. 1 unit = 1/2 of the icon width |
| OffsetYI    | double     | Add a vertical offset to the layer. 1 unit = 1/2 of the icon height   |
| RotationI   | double     | Rotate the geometry (in degree) |


# Test

The sources also contains a small application (_FontAwesomeWPF.Test_) to play with the various settings.