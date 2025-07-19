using AirSmileWMS.Kernel.Services;

namespace AirSmileWMS.Kernel.VOs
{
    /// <summary>
    /// Имя/Наименование/Название. 
    /// </summary>
    public sealed class Name : VO<Name, string>
    {
        // Конструктор для EF.
        public Name() { }

        private Name(string value) : base(value) { }

        // Фабрика.
        public static implicit operator Name(string value) => new Name(value);

        protected override string Guard(string value) => Validate.Name(value);
    }
}
