using System.Linq;
using System.Windows;
using System.Windows.Media;

namespace FontAwesomeWPF
{

    public class Icon : FrameworkElement
    {
        private const double DefaultSize = 32;
        private const double MaskMargin = 1000;

        #region Background

        public static readonly DependencyProperty BackgroundProperty = DependencyProperty.Register(
            nameof(Background), typeof(Brush), typeof(Icon),
            new FrameworkPropertyMetadata(default(Brush?), FrameworkPropertyMetadataOptions.AffectsRender));

        public Brush? Background
        {
            get { return (Brush?) GetValue(BackgroundProperty); }
            set { SetValue(BackgroundProperty, value); }
        }

        #endregion

        #region IsVisible0

        public static readonly DependencyProperty IsVisible0Property = DependencyProperty.Register(
            nameof(IsVisible0), typeof(bool), typeof(Icon),
            new FrameworkPropertyMetadata(true, FrameworkPropertyMetadataOptions.AffectsRender));

        public bool IsVisible0
        {
            get { return (bool) GetValue(IsVisible0Property); }
            set { SetValue(IsVisible0Property, value); }
        }

        #endregion

        #region Source0

        public static readonly DependencyProperty Source0Property = DependencyProperty.Register(
            nameof(Source0), typeof(IconSource), typeof(Icon),
            new FrameworkPropertyMetadata(default(IconSource?), FrameworkPropertyMetadataOptions.AffectsRender));

        public IconSource? Source0
        {
            get { return (IconSource?) GetValue(Source0Property); }
            set { SetValue(Source0Property, value); }
        }

        #endregion

        #region Brush0

        public static readonly DependencyProperty Brush0Property = DependencyProperty.Register(
            nameof(Brush0), typeof(Brush), typeof(Icon),
            new FrameworkPropertyMetadata(default(Brush?), FrameworkPropertyMetadataOptions.AffectsRender));

        public Brush? Brush0
        {
            get { return (Brush?) GetValue(Brush0Property); }
            set { SetValue(Brush0Property, value); }
        }

        #endregion

        #region Pen0

        public static readonly DependencyProperty Pen0Property = DependencyProperty.Register(
            nameof(Pen0), typeof(Pen), typeof(Icon),
            new FrameworkPropertyMetadata(default(Pen?), FrameworkPropertyMetadataOptions.AffectsRender));

        public Pen? Pen0
        {
            get { return (Pen?) GetValue(Pen0Property); }
            set { SetValue(Pen0Property, value); }
        }

        #endregion

        #region Opacity0

        public static readonly DependencyProperty Opacity0Property = DependencyProperty.Register(
            nameof(Opacity0), typeof(double), typeof(Icon),
            new FrameworkPropertyMetadata(1.0, FrameworkPropertyMetadataOptions.AffectsRender));

        public double Opacity0
        {
            get { return (double) GetValue(Opacity0Property); }
            set { SetValue(Opacity0Property, value); }
        }

        #endregion

        #region Scale0

        public static readonly DependencyProperty Scale0Property = DependencyProperty.Register(
            nameof(Scale0), typeof(double), typeof(Icon),
            new FrameworkPropertyMetadata(1.0, FrameworkPropertyMetadataOptions.AffectsRender));

        public double Scale0
        {
            get { return (double) GetValue(Scale0Property); }
            set { SetValue(Scale0Property, value); }
        }

        #endregion

        #region OffsetX0

        public static readonly DependencyProperty OffsetX0Property = DependencyProperty.Register(
            nameof(OffsetX0), typeof(double), typeof(Icon),
            new FrameworkPropertyMetadata(0.0, FrameworkPropertyMetadataOptions.AffectsRender));

        public double OffsetX0
        {
            get { return (double) GetValue(OffsetX0Property); }
            set { SetValue(OffsetX0Property, value); }
        }

        #endregion

        #region OffsetY0

        public static readonly DependencyProperty OffsetY0Property = DependencyProperty.Register(
            nameof(OffsetY0), typeof(double), typeof(Icon),
            new FrameworkPropertyMetadata(0.0, FrameworkPropertyMetadataOptions.AffectsRender));

        public double OffsetY0
        {
            get { return (double) GetValue(OffsetY0Property); }
            set { SetValue(OffsetY0Property, value); }
        }

        #endregion

        #region Rotation0

        public static readonly DependencyProperty Rotation0Property = DependencyProperty.Register(
            nameof(Rotation0), typeof(double), typeof(Icon),
            new FrameworkPropertyMetadata(0.0, FrameworkPropertyMetadataOptions.AffectsRender));

        public double Rotation0
        {
            get { return (double) GetValue(Rotation0Property); }
            set { SetValue(Rotation0Property, value); }
        }

        #endregion

        #region Mode0

        public static readonly DependencyProperty Mode0Property = DependencyProperty.Register(
            nameof(Mode0), typeof(LayerMode), typeof(Icon),
            new FrameworkPropertyMetadata(LayerMode.Draw, FrameworkPropertyMetadataOptions.AffectsRender));

        public LayerMode Mode0
        {
            get { return (LayerMode) GetValue(Mode0Property); }
            set { SetValue(Mode0Property, value); }
        }

        #endregion

        #region IsVisible1

        public static readonly DependencyProperty IsVisible1Property = DependencyProperty.Register(
            nameof(IsVisible1), typeof(bool), typeof(Icon),
            new FrameworkPropertyMetadata(true, FrameworkPropertyMetadataOptions.AffectsRender));

        public bool IsVisible1
        {
            get { return (bool) GetValue(IsVisible1Property); }
            set { SetValue(IsVisible1Property, value); }
        }

        #endregion

        #region Source1

        public static readonly DependencyProperty Source1Property = DependencyProperty.Register(
            nameof(Source1), typeof(IconSource), typeof(Icon),
            new FrameworkPropertyMetadata(default(IconSource?), FrameworkPropertyMetadataOptions.AffectsRender));

        public IconSource? Source1
        {
            get { return (IconSource?) GetValue(Source1Property); }
            set { SetValue(Source1Property, value); }
        }

        #endregion

        #region Brush1

        public static readonly DependencyProperty Brush1Property = DependencyProperty.Register(
            nameof(Brush1), typeof(Brush), typeof(Icon),
            new FrameworkPropertyMetadata(default(Brush?), FrameworkPropertyMetadataOptions.AffectsRender));

        public Brush? Brush1
        {
            get { return (Brush?) GetValue(Brush1Property); }
            set { SetValue(Brush1Property, value); }
        }

        #endregion

        #region Pen1

        public static readonly DependencyProperty Pen1Property = DependencyProperty.Register(
            nameof(Pen1), typeof(Pen), typeof(Icon),
            new FrameworkPropertyMetadata(default(Pen?), FrameworkPropertyMetadataOptions.AffectsRender));

        public Pen? Pen1
        {
            get { return (Pen?) GetValue(Pen1Property); }
            set { SetValue(Pen1Property, value); }
        }

        #endregion

        #region Opacity1

        public static readonly DependencyProperty Opacity1Property = DependencyProperty.Register(
            nameof(Opacity1), typeof(double), typeof(Icon),
            new FrameworkPropertyMetadata(1.0, FrameworkPropertyMetadataOptions.AffectsRender));

        public double Opacity1
        {
            get { return (double) GetValue(Opacity1Property); }
            set { SetValue(Opacity1Property, value); }
        }

        #endregion

        #region Scale1

        public static readonly DependencyProperty Scale1Property = DependencyProperty.Register(
            nameof(Scale1), typeof(double), typeof(Icon),
            new FrameworkPropertyMetadata(1.0, FrameworkPropertyMetadataOptions.AffectsRender));

        public double Scale1
        {
            get { return (double) GetValue(Scale1Property); }
            set { SetValue(Scale1Property, value); }
        }

        #endregion

        #region OffsetX1

        public static readonly DependencyProperty OffsetX1Property = DependencyProperty.Register(
            nameof(OffsetX1), typeof(double), typeof(Icon),
            new FrameworkPropertyMetadata(0.0, FrameworkPropertyMetadataOptions.AffectsRender));

        public double OffsetX1
        {
            get { return (double) GetValue(OffsetX1Property); }
            set { SetValue(OffsetX1Property, value); }
        }

        #endregion

        #region OffsetY1

        public static readonly DependencyProperty OffsetY1Property = DependencyProperty.Register(
            nameof(OffsetY1), typeof(double), typeof(Icon),
            new FrameworkPropertyMetadata(0.0, FrameworkPropertyMetadataOptions.AffectsRender));

        public double OffsetY1
        {
            get { return (double) GetValue(OffsetY1Property); }
            set { SetValue(OffsetY1Property, value); }
        }

        #endregion

        #region Rotation1

        public static readonly DependencyProperty Rotation1Property = DependencyProperty.Register(
            nameof(Rotation1), typeof(double), typeof(Icon),
            new FrameworkPropertyMetadata(0.0, FrameworkPropertyMetadataOptions.AffectsRender));

        public double Rotation1
        {
            get { return (double) GetValue(Rotation1Property); }
            set { SetValue(Rotation1Property, value); }
        }

        #endregion

        #region Mode1

        public static readonly DependencyProperty Mode1Property = DependencyProperty.Register(
            nameof(Mode1), typeof(LayerMode), typeof(Icon),
            new FrameworkPropertyMetadata(LayerMode.Draw, FrameworkPropertyMetadataOptions.AffectsRender));

        public LayerMode Mode1
        {
            get { return (LayerMode) GetValue(Mode1Property); }
            set { SetValue(Mode1Property, value); }
        }

        #endregion

        #region IsVisible2

        public static readonly DependencyProperty IsVisible2Property = DependencyProperty.Register(
            nameof(IsVisible2), typeof(bool), typeof(Icon),
            new FrameworkPropertyMetadata(true, FrameworkPropertyMetadataOptions.AffectsRender));

        public bool IsVisible2
        {
            get { return (bool) GetValue(IsVisible2Property); }
            set { SetValue(IsVisible2Property, value); }
        }

        #endregion

        #region Source2

        public static readonly DependencyProperty Source2Property = DependencyProperty.Register(
            nameof(Source2), typeof(IconSource), typeof(Icon),
            new FrameworkPropertyMetadata(default(IconSource?), FrameworkPropertyMetadataOptions.AffectsRender));

        public IconSource? Source2
        {
            get { return (IconSource?) GetValue(Source2Property); }
            set { SetValue(Source2Property, value); }
        }

        #endregion

        #region Brush2

        public static readonly DependencyProperty Brush2Property = DependencyProperty.Register(
            nameof(Brush2), typeof(Brush), typeof(Icon),
            new FrameworkPropertyMetadata(default(Brush?), FrameworkPropertyMetadataOptions.AffectsRender));

        public Brush? Brush2
        {
            get { return (Brush?) GetValue(Brush2Property); }
            set { SetValue(Brush2Property, value); }
        }

        #endregion

        #region Pen2

        public static readonly DependencyProperty Pen2Property = DependencyProperty.Register(
            nameof(Pen2), typeof(Pen), typeof(Icon),
            new FrameworkPropertyMetadata(default(Pen?), FrameworkPropertyMetadataOptions.AffectsRender));

        public Pen? Pen2
        {
            get { return (Pen?) GetValue(Pen2Property); }
            set { SetValue(Pen2Property, value); }
        }

        #endregion

        #region Opacity2

        public static readonly DependencyProperty Opacity2Property = DependencyProperty.Register(
            nameof(Opacity2), typeof(double), typeof(Icon),
            new FrameworkPropertyMetadata(1.0, FrameworkPropertyMetadataOptions.AffectsRender));

        public double Opacity2
        {
            get { return (double) GetValue(Opacity2Property); }
            set { SetValue(Opacity2Property, value); }
        }

        #endregion

        #region Scale2

        public static readonly DependencyProperty Scale2Property = DependencyProperty.Register(
            nameof(Scale2), typeof(double), typeof(Icon),
            new FrameworkPropertyMetadata(1.0, FrameworkPropertyMetadataOptions.AffectsRender));

        public double Scale2
        {
            get { return (double) GetValue(Scale2Property); }
            set { SetValue(Scale2Property, value); }
        }

        #endregion

        #region OffsetX2

        public static readonly DependencyProperty OffsetX2Property = DependencyProperty.Register(
            nameof(OffsetX2), typeof(double), typeof(Icon),
            new FrameworkPropertyMetadata(0.0, FrameworkPropertyMetadataOptions.AffectsRender));

        public double OffsetX2
        {
            get { return (double) GetValue(OffsetX2Property); }
            set { SetValue(OffsetX2Property, value); }
        }

        #endregion

        #region OffsetY2

        public static readonly DependencyProperty OffsetY2Property = DependencyProperty.Register(
            nameof(OffsetY2), typeof(double), typeof(Icon),
            new FrameworkPropertyMetadata(0.0, FrameworkPropertyMetadataOptions.AffectsRender));

        public double OffsetY2
        {
            get { return (double) GetValue(OffsetY2Property); }
            set { SetValue(OffsetY2Property, value); }
        }

        #endregion

        #region Rotation2

        public static readonly DependencyProperty Rotation2Property = DependencyProperty.Register(
            nameof(Rotation2), typeof(double), typeof(Icon),
            new FrameworkPropertyMetadata(0.0, FrameworkPropertyMetadataOptions.AffectsRender));

        public double Rotation2
        {
            get { return (double) GetValue(Rotation2Property); }
            set { SetValue(Rotation2Property, value); }
        }

        #endregion

        #region Mode2

        public static readonly DependencyProperty Mode2Property = DependencyProperty.Register(
            nameof(Mode2), typeof(LayerMode), typeof(Icon),
            new FrameworkPropertyMetadata(LayerMode.Draw, FrameworkPropertyMetadataOptions.AffectsRender));

        public LayerMode Mode2
        {
            get { return (LayerMode) GetValue(Mode2Property); }
            set { SetValue(Mode2Property, value); }
        }

        #endregion

        public Icon()
        {
            Width = DefaultSize;
            Height = DefaultSize;
            Background = Brushes.Transparent;
        }

        private record IconLayer(bool IsVisible, IconSource? Source, Brush? Brush, Pen? Pen, double Opacity,
            double Scale, double OffsetX, double OffsetY, double Rotation, LayerMode Mode)
        {
            public bool IsValidMask => IsVisible && Mode == LayerMode.Mask && Source != null && Scale > 0;

            public bool IsValidDraw => IsVisible && Mode == LayerMode.Draw && Source != null &&
                                       (Brush != null || Pen != null) && Opacity > 0 && Scale > 0;

            public Geometry GetGeometry(Size iconSize)
            {
                var geometry = new GeometryGroup();

                if (Source != null)
                {
                    geometry.Children.Add(Source.GetPathGeometry());
                }

                var m = Matrix.Identity;

                m.Scale(
                    iconSize.Width / 512 * Scale,
                    iconSize.Height / 512 * Scale
                );

                m.Rotate(Rotation);

                m.Translate(iconSize.Width / 2 * (1 + OffsetX), iconSize.Height / 2 * (1 + OffsetY));

                geometry.Transform = new MatrixTransform(m);

                geometry.Freeze();

                return geometry;
            }

            public void Draw(DrawingContext drawingContext, Size iconSize)
            {
                if (Opacity < 1)
                {
                    drawingContext.PushOpacity(Opacity);
                }

                drawingContext.DrawGeometry(Brush, Pen, GetGeometry(iconSize));

                if (Opacity < 1)
                {
                    drawingContext.Pop();
                }
            }
        }

        protected override void OnRender(DrawingContext drawingContext)
        {
            if (Background != null)
            {
                drawingContext.DrawRectangle(Background, null, new Rect(new Point(0, 0), RenderSize));
            }

            IconLayer layer0 = new IconLayer(IsVisible0, Source0, Brush0, Pen0, Opacity0, Scale0, OffsetX0, OffsetY0,
                Rotation0, Mode0);
            IconLayer layer1 = new IconLayer(IsVisible1, Source1, Brush1, Pen1, Opacity1, Scale1, OffsetX1, OffsetY1,
                Rotation1, Mode1);
            IconLayer layer2 = new IconLayer(IsVisible2, Source2, Brush2, Pen2, Opacity2, Scale2, OffsetX2, OffsetY2,
                Rotation2, Mode2);

            IconLayer[] layers = new[] {layer0, layer1, layer2};

            GeometryGroup? mask = null;

            if (layers.Any(e => e.IsValidMask))
            {
                mask = new GeometryGroup();

                mask.Children.Add(new RectangleGeometry(new Rect(
                    -MaskMargin, -MaskMargin,
                    RenderSize.Width + MaskMargin * 2,
                    RenderSize.Height + MaskMargin * 2
                )));

                foreach (var layer in layers.Where(e => e.IsValidMask))
                {
                    mask.Children.Add(layer.GetGeometry(RenderSize));
                }

                drawingContext.PushClip(mask);
            }

            foreach (var layer in layers.Where(e => e.IsValidDraw))
            {
                layer.Draw(drawingContext, RenderSize);
            }

            if (mask != null)
            {
                drawingContext.Pop(); // mask
            }

        }
    }

}