using System.Text;

namespace ExtMethods
{
    public static class HexExt
    {
        public static string ToHex(this byte[] input)
        {
            var sb = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                sb.Append(input[i].ToString("X2"));
            }

            return sb.ToString();
        }

        public static string ToHex(this string input)
        {
            return input.ToByteArray().ToHex();
        }
    }
}