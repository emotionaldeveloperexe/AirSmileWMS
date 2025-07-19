using AirSmileWMS.Kernel.Services;

namespace AirSmileWMS.Kernel.VOs
{
    /// <summary>
    /// Ссылка.
    /// </summary>
    public sealed class Link : VO<Link, string>
    {
        // Конструктор для EF.
        public Link() { }

        private Link(string value) : base(value) { }

        // Фабрика.
        public static implicit operator Link(string value) => new Link(value);

        protected override string Guard(string value) => Validate.Link(value);
    }
}
