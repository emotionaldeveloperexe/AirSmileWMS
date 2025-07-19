using AirSmileWMS.Kernel.VOs;
using System.Collections.Generic;

namespace AirSmileWMS.Kernel.Models
{
    /// <summary>
    /// Поставщик.
    /// </summary>
    public class Supplier
    {
        /// <summary>
        /// Идентификатор для EF.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Наименование поставщика.
        /// </summary>
        public Name Name { get; set; }

        /// <summary>
        /// Есть ли у поставщика артикулы.
        /// </summary>
        public bool IsHasSKUsInfo { get; set; }

        /// <summary>
        /// Есть ли у поставщика ссылки на товар.
        /// </summary>
        public bool IsHasLinksInfo { get; set; }

        /// <summary>
        /// Приходы от поставщика.
        /// </summary>
        public virtual ICollection<Come> Comes { get; set; }

        /// <summary>
        /// Возвраты поставщику.
        /// </summary>
        public virtual ICollection<Refund> Refunds { get; set; }

        /// <summary>
        /// Товары, которые предоставляет поставщик.
        /// </summary>
        public virtual ICollection<Source> Sources { get; set; }
    }
}
