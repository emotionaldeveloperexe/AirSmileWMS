using AirSmileWMS.Kernel.VOs;
using System.Collections.Generic;

namespace AirSmileWMS.Kernel.Models
{
    /// <summary>
    /// Категория товара.
    /// </summary>
    public class Category
    {
        /// <summary>
        /// Идентификатор для EF.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Название категории.
        /// </summary>
        public Name Name { get; set; }

        /// <summary>
        /// Товары, которые принадлежат выбранной категории.
        /// </summary>
        public virtual ICollection<Good> Goods { get; set; }
    }
}
