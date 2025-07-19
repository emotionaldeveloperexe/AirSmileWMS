using AirSmileWMS.Kernel.Services;

namespace AirSmileWMS.Kernel.VOs
{
    /// <summary>
    /// Хранит в себе путь до файла с QR-кодом.
    /// </summary>
    public sealed class QR : VO<QR, string>
    {
        // Конструктор для EF.
        public QR() { }

        private QR(string value) : base(value) { }

        // Фабрика.
        public static implicit operator QR(string value) => new QR(value);

        protected override string Guard(string value) => Validate.QR(value);
    }
}
