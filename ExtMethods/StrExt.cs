using System.Globalization;

namespace ExtMethods
{
    public static class StrExt
    {
        public static string FormatWith(this string format, params object[] args)
        {
            return string.Format(format, args);
        }

        public static string Left(this string s, int n)
        {
            return s.Substring(0, n);
        }

        public static string Right(this string s, int n)
        {
            return s.Substring(s.Length - n, n);
        }

        public static byte[] ToByteArray(this string s)
        {
            return System.Text.Encoding.ASCII.GetBytes(s);            
        }

        public static string ToTitleCase(this string s)
        {
            if (string.IsNullOrEmpty(s)) return s;

            TextInfo ti = new CultureInfo("en-US",false).TextInfo;
            return ti.ToTitleCase(s);
        }

        public static string ToPascalCase(this string s)
        {
            if (string.IsNullOrEmpty(s)) return s;

            return s.ToTitleCase().Replace(" ", "");
        }

        public static string ToCamelCase(this string s)
        {
            if (string.IsNullOrEmpty(s)) return s;

            s = s.ToPascalCase();

            return s.Substring(0, 1).ToLower() + s.Substring(1);
        }

        public static string ToKabobCase(this string s)
        {
            if (string.IsNullOrEmpty(s)) return s;

            return s.ToLower().Replace(" ", "-");
        }
    }
}