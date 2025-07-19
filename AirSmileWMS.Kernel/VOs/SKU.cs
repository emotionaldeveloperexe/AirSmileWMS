using AirSmileWMS.Kernel.Services;

namespace AirSmileWMS.Kernel.VOs
{
    /// <summary>
    /// Артикул.
    /// </summary>
    public sealed class SKU : VO<SKU, string>
    {
        // Конструктор для EF.
        public SKU() { }

        private SKU(string value) : base(value) { }

        // Фабрика.
        public static implicit operator SKU(string value) => new SKU(value);

        protected override string Guard(string value) => Validate.SKU(value);
    }
}
