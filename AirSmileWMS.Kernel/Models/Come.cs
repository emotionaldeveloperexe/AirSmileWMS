using AirSmileWMS.Kernel.VOs;
using System;

namespace AirSmileWMS.Kernel.Models
{
    /// <summary>
    /// Приход товара.
    /// </summary>
    public class Come
    {
        /// <summary>
        /// Идентификатор для EF.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Идентификатор поставщика для EF.
        /// </summary>
        public int SupplierId { get; set; }

        /// <summary>
        /// Поставщик.
        /// </summary>
        public virtual Supplier Supplier { get; set; }

        /// <summary>
        /// Идентификатор товара для EF.
        /// </summary>
        public int GoodId { get; set; }

        /// <summary>
        /// Товар, который поступил.
        /// </summary>
        public virtual Good Good { get; set; }

        /// <summary>
        /// Сколько товара пришло.
        /// </summary>
        public Amount Count { get; set; }

        /// <summary>
        /// Дата прихода.
        /// </summary>
        public DateTime Date { get; set; }
    }
}
