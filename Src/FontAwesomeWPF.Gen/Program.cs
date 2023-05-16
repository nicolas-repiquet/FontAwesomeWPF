
using System.Text;
using System.Xml.Linq;

public enum Category
{
    Regular,
    Solid,
    Brands
}

public record Icon(string Name, int Width, int Height, string Data);

public static class Program
{
    private static string ToCamelCase(string name)
    {
        var sb = new StringBuilder();

        foreach (var part in name.Split('-'))
        {
            sb.Append(char.ToUpper(part[0]));

            if (part.Length > 1)
            {
                sb.Append(part.Substring(1).ToLower());
            }
        }

        if (!char.IsLetter(sb[0]))
        {
            sb.Insert(0, '_');
        }

        var s = sb.ToString();

        // conflicts with object.Equals
        if (s == "Equals")
        {
            return "Equals_";
        }

        return s;
    }

    private static void BuildCategory(string path, Category category)
    {
        var icons = new List<Icon>();

        foreach (var file in Directory.GetFiles($"{path}\\svgs\\{category}", "*.svg"))
        {
            using (var stream = File.OpenRead(file))
            {
                var xDocument = XDocument.Load(stream);
                var xSvg = xDocument.Root;

                var xViewBox = xSvg.Attribute("viewBox");
                var xPath = xSvg.Elements().First();
                var xData = xPath.Attribute("d");
                var viewBoxTokens = xViewBox.Value.Split(' ');

                var name = ToCamelCase(Path.GetFileNameWithoutExtension(file));
                var width = int.Parse(viewBoxTokens[2]);
                var height = int.Parse(viewBoxTokens[3]);
                var data = xData.Value;

                icons.Add(new Icon(name, width, height, data));
            }
        }
        
        using (var writer = File.CreateText($"..\\..\\..\\..\\FontAwesomeWPF\\{category}.gen.cs"))
        {
            writer.WriteLine("namespace FontAwesomeWPF;");
            writer.WriteLine();

            writer.WriteLine($"public partial class {category} {{");

            var chars = new Dictionary<char, int>();

            foreach (var icon in icons.OrderBy(e => e.Name))
            {
                foreach (var c in icon.Data)
                {
                    if (!chars.TryGetValue(c, out var count))
                    {
                        count = 0;
                    }

                    count++;

                    chars[c] = count;
                }

                writer.WriteLine(
                    $"    public static IconSource {icon.Name} {{ get; }} = new IconSource(\"{icon.Name}\", {icon.Width}, {icon.Height}, \"{icon.Data}\");");
            }

            writer.WriteLine("}");
        }
    }
    
    public static void Main(string[] args)
    {
        if (args.Length != 1)
        {
            Console.Error.WriteLine("FontAwesomeWPF.Gen.exe PATH_TO_THE_UNZIPPED_FONTAWESOME_DESKTOP_ARCHIVE");
        }

        var path = args[0];

        if (!Directory.Exists(path))
        {
            Console.Error.WriteLine("invalid path");
        }
        
        BuildCategory(path, Category.Solid);
        BuildCategory(path, Category.Regular);
        BuildCategory(path, Category.Brands);
    }
}
