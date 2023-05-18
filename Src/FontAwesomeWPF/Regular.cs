using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace FontAwesomeWPF
{

    public partial class Regular
    {
        public static IEnumerable<IconSource> GetAll()
        {
            foreach (var property in typeof(Regular).GetProperties(BindingFlags.Public | BindingFlags.Static)
                         .Where(e => e.PropertyType == typeof(IconSource)))
            {
                yield return (IconSource) property.GetValue(null)!;
            }
        }
    }
}