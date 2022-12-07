using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractalzFrontend.Client
{
    public static class Extensions
    {
        public static IDictionary<string, object> ToDictionary(this object source)
        {
            return source.ToDictionary<object>();
        }

        public static IDictionary<string, object> ToDictionary<T>(this object source)
        {
            if (source == null)
                ThrowExceptionWhenSourceArgumentIsNull();

            var dictionary = new Dictionary<string, object>();
            foreach (PropertyDescriptor property in TypeDescriptor.GetProperties(source))
                AddPropertyToDictionary<object>(property, source, dictionary);

            return dictionary;
        }

        private static void AddPropertyToDictionary<T>(PropertyDescriptor property, object source, Dictionary<string, object> dictionary)
        {
            object value = property.GetValue(source);
            if (IsOfType(value)|| IsOfTypeNull(value))
                dictionary.Add(property.Name, value);
        }

        private static bool IsOfType(object value)
        {
            return value is object;
        }
        private static bool IsOfTypeNull(object value)
        {
            return value is null;
        }

        private static void ThrowExceptionWhenSourceArgumentIsNull()
        {
            throw new ArgumentNullException("source", "Unable to convert object to a dictionary. The source object is null.");
        }
    }
}
