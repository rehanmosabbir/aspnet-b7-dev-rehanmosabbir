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
            StringBuilder stringBuilder = new StringBuilder();
            IEnumerable<PropertyInfo> properties = item.GetType().GetProperties();
            if (!item.GetType().IsPrimitive && item.GetType() != typeof(string) && item.GetType() != typeof(DateTime))
            {
                bool isArray = typeof(IEnumerable).IsAssignableFrom(item.GetType()) ? true : false;
                if (isArray)
                    stringBuilder.Append($"[");
                else
                    stringBuilder.Append($"{{");

                if (!isArray)
                    foreach (var property in properties)
                        if (property.PropertyType.IsPrimitive || property.PropertyType == typeof(string))
                            stringBuilder.Append($"\"{property.Name}\": \"{property.GetValue(item)}\", ");
                        else
                            stringBuilder.Append($"\"{property.Name}\": {Convert(property.GetValue(item))}, ");
                else
                    foreach (var i in item as IEnumerable)
                        if (i.GetType().IsPrimitive || i.GetType() == typeof(string))
                            stringBuilder.Append($"\"{i}\", ");
                        else
                            stringBuilder.Append($"{Convert(i)}, ");

                stringBuilder.Remove(stringBuilder.ToString().Length - 2, 2);

                if (isArray)
                    stringBuilder.Append($"]");
                else
                    stringBuilder.Append($"}}");
            }
            else
                stringBuilder.Append($"\"{item.ToString()}\"");

            return stringBuilder.ToString();
        }
    }
}
