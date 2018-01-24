using System.Collections.Generic;

namespace ExtMethods
{
    public static class ReflectionExt
    {
        public static object Set(this object o, string propertyName, object value)
        {
            var type = o.GetType();
            var pi = type.GetProperty(propertyName);
            pi.SetValue(o, value);

            return o;
        }

        public static object Call(this object o, string methodName, params object[] args)
        {
            var type = o.GetType();
            var mi = type.GetMethod(methodName);
            mi.Invoke(o, args);

            return o;
        }

        public static Dictionary<string, object> ToDictionary(this object o)
        {
            var dict = new Dictionary<string, object>();
            
            var type = o.GetType();
            foreach (var pi in type.GetProperties())
            {
                var value = pi.GetValue(o);
                dict.Add(pi.Name, value);
            }

            return dict;
        }
    }
}