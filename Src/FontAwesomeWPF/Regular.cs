﻿using System.Reflection;

namespace FontAwesomeWPF;

public partial class Regular : IIconCategory
{
    public static IEnumerable<IconSource> GetAll()
    {
        foreach (var property in typeof(Solid).GetProperties(BindingFlags.Public | BindingFlags.Static)
                     .Where(e => e.PropertyType == typeof(IconSource)))
        {
            yield return (IconSource)property.GetValue(null)!;
        }
    }
}