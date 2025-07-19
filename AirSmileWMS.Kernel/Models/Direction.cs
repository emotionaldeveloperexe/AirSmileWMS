using AirSmileWMS.Kernel.VOs;
using System.Collections.Generic;

namespace AirSmileWMS.Kernel.Models
{
    /// <summary>
    /// Направление.
    /// </summary>
    public class Direction
    {
        /// <summary>
        /// Идентификатор для EF.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Название направления.
        /// </summary>
        public Name Name { get; set; }

        /// <summary>
        /// Признак, является ли это направлением на склад.
        /// </summary>
        public bool IsStock { get; set; }

        /// <summary>
        /// Поставки по выбранному направлению.
        /// </summary>
        public virtual ICollection<Supply> Supplies { get; set; }
    }
}
