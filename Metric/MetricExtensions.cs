namespace Metric
{
    public static class MetricExtensions
    {
        public static int Kilo(this int value)
        {
            return value * 1000;
        }

        public static int Mega(this int value)
        {
            return value * 1000.Kilo();
        }

        public static long Giga(this int value)
        {
            return Giga((long) value);
        }

        public static long Giga(this long value)
        {
            return value * 1000.Mega();
        }

        public static long Tera(this int value)
        {
            return Tera((long) value);
        }

        public static long Tera(this long value)
        {
            return value * 1000L.Giga();
        }

        public static long Peta(this int value)
        {
            return Peta((long)value);
        }

        private static long Peta(this long value)
        {
            return value * 1000L.Tera();
        }

        public static long Exa(this int value)
        {
            return Exa((long) value);
        }
        private static long Exa(this long value)
        {
            return value * 1000L.Peta();
        }
    }
}