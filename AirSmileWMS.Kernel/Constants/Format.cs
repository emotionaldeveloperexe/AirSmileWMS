using System.Text.RegularExpressions;

namespace AirSmileWMS.Kernel.Constants
{
    /// <summary>
    /// Здесь хранятся валидные форматы бизнес типов.
    /// </summary>
    public static class Format
    {
        public static readonly Regex Image = new Regex(@"^[\w,\s\-\\\/:]+\.((jpe?g|png|gif|bmp|webp|tiff|ico))\z", RegexOptions.Compiled | RegexOptions.IgnoreCase | RegexOptions.CultureInvariant);
        public static readonly Regex QR = new Regex(@"^[\w,\s\-\\\/:]+\.((jpe?g|png|gif|bmp|webp|tiff|ico|svg|pdf))\z", RegexOptions.Compiled | RegexOptions.IgnoreCase | RegexOptions.CultureInvariant);
        public static readonly Regex Barcode = new Regex(@"^\d+$", RegexOptions.Compiled | RegexOptions.IgnoreCase | RegexOptions.CultureInvariant);
        public static readonly Regex PIN = new Regex(@"^\d{4}$", RegexOptions.Compiled | RegexOptions.IgnoreCase | RegexOptions.CultureInvariant);
    }
}
