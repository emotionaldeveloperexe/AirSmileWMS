using AirSmileWMS.Kernel.Services;

namespace AirSmileWMS.Kernel.VOs
{
    /// <summary>
    /// Хранит в себе путь до файла-изображения.
    /// </summary>
    public sealed class Image : VO<Image, string>
    {
        // Конструктор для EF.
        public Image() { }

        private Image(string value) : base(value) { }

        // Фабрика.
        public static implicit operator Image(string value) => new Image(value);

        protected override string Guard(string value) => Validate.Image(value);
    }
}
