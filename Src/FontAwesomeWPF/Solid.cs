

using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace FontAwesomeWPF
{

    public partial class Solid
    {
        public static IEnumerable<IconSource> GetAll()
        {
            foreach (var property in typeof(Solid).GetProperties(BindingFlags.Public | BindingFlags.Static)
                         .Where(e => e.PropertyType == typeof(IconSource)))
            {
                yield return (IconSource) property.GetValue(null)!;
            }
        }
    }

}