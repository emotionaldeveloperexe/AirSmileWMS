using AirSmileWMS.Kernel.VOs;

namespace AirSmileWMS.Kernel.Models
{
    /// <summary>
    /// Источник товара.
    /// </summary>
    public class Source
    {
        /// <summary>
        /// Идентификатор для EF.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Идентификатор товара для EF.
        /// </summary>
        public int GoodId { get; set; }

        /// <summary>
        /// Товар выбранного источника.
        /// </summary>
        public virtual Good Good { get; set; }

        /// <summary>
        /// Идентификатор поставщика для EF.
        /// </summary>
        public int SupplierId { get; set; }

        /// <summary>
        /// Поставщик.
        /// </summary>
        public virtual Supplier Supplier { get; set; }

        /// <summary>
        /// Артикул поставщика (если есть)
        /// </summary>
        public SKU SKU { get; set; }

        /// <summary>
        /// Ссылка на товар (если есть)
        /// </summary>
        public Link Link { get; set; }
    }
}
