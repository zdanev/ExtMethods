namespace ExtMethods
{
    public static class HashExt
    {
        public static string CalcMD5Hash(this string input)
        {
            var md5 = System.Security.Cryptography.MD5.Create();
            
            byte[] hash = md5.ComputeHash(input.ToByteArray());
            
            return hash.ToHex();
        }
    }
}