using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace JsonSerializer
{
    public class JsonFormatter
    {
        public static string Convert(object item)
        {
            StringBuilder sb = new StringBuilder();
            IEnumerable<PropertyInfo> props = item.GetType().GetProperties();
            if (!item.GetType().IsPrimitive && item.GetType() != typeof(string) && item.GetType() != typeof(DateTime))
            {
                bool isArray = typeof(IEnumerable).IsAssignableFrom(item.GetType()) ? true : false;
                if (isArray)
                    sb.Append($"[");
                else
                    sb.Append($"{{");

                if (!isArray)
                    foreach (var property in props)
                        if (property.PropertyType.IsPrimitive || property.PropertyType == typeof(string))
                            sb.Append($"\"{property.Name}\": \"{property.GetValue(item)}\", ");
                        else
                            sb.Append($"\"{property.Name}\": {Convert(property.GetValue(item))}, ");
                else
                    foreach (var i in item as IEnumerable)
                        if (i.GetType().IsPrimitive || i.GetType() == typeof(string))
                            sb.Append($"\"{i}\", ");
                        else
                            sb.Append($"{Convert(i)}, ");

                sb.Remove(sb.ToString().Length - 2, 2);

                if (isArray)
                    sb.Append($"]");
                else
                    sb.Append($"}}");
            }
            else
                sb.Append($"\"{item.ToString()}\"");

            return sb.ToString();
        }
    }
}
