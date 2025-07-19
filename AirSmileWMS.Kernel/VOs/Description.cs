using AirSmileWMS.Kernel.Services;

namespace AirSmileWMS.Kernel.VOs
{
    /// <summary>
    /// Описание.
    /// </summary>
    public sealed class Description : VO<Description, string>
    {
        // Конструктор для EF.
        public Description() { }

        private Description(string value) : base(value) { }

        // Фабрика.
        public static implicit operator Description(string value) => new Description(value);

        protected override string Guard(string value) => Validate.Description(value);
    }
}
