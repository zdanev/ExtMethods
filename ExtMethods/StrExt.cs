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
    }
}