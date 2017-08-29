namespace ExtMethods
{
    public static class NumExt
    {
        public static double PercentOf(this double part, double whole)
        {
            return whole == 0 ? 0 : 100.0 * part / whole; 
        }
    }
}