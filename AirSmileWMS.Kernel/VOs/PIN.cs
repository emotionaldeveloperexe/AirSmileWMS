using AirSmileWMS.Kernel.Services;

namespace AirSmileWMS.Kernel.VOs
{
    /// <summary>
    /// ПИН-код.
    /// </summary>
    public sealed class PIN : VO<PIN, string>
    {
        // Конструктор для EF.
        public PIN() { }

        private PIN(string value) : base(value) { }

        // Фабрика.
        public static implicit operator PIN(string value) => new PIN(value);

        protected override string Guard(string value) => Validate.PIN(value);
    }
}
