using System;
using System.Windows.Media;

namespace FontAwesomeWPF
{

    public record IconSource(string Name, int Width, int Height, string Data)
    {
        private PathGeometry? _pathGeometry;

        internal PathGeometry GetPathGeometry()
        {
            if (_pathGeometry == null)
            {
                var scaleX = 512.0 / Width;
                var scaleY = 512.0 / Height;
                var scale = Math.Min(scaleX, scaleY);

                var scaledWidth = Width * scale;
                var scaledHeight = Height * scale;

                var offsetX = (512 - scaledWidth) / 2 - 256;
                var offsetY = (512 - scaledHeight) / 2 - 256;

                var transform = new MatrixTransform(scale, 0, 0, scale, offsetX, offsetY);

                var figures = PathFigureCollection.Parse(Data);

                _pathGeometry = new PathGeometry(figures, FillRule.Nonzero, transform);

                _pathGeometry.Freeze();
            }

            return _pathGeometry;
        }
    }

}