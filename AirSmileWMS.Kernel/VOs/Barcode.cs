using AirSmileWMS.Kernel.Services;

namespace AirSmileWMS.Kernel.VOs
{
    /// <summary>
    /// Баркод.
    /// </summary>
    public sealed class Barcode : VO<Barcode, string>
    {
        // Конструктор для EF.
        public Barcode() { }

        private Barcode(string value) : base(value) { }

        // Фабрика.
        public static implicit operator Barcode(string value) => new Barcode(value);

        protected override string Guard(string value) => Validate.Barcode(value);
    }
}
