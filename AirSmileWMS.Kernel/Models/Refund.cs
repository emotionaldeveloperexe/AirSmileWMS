using AirSmileWMS.Kernel.VOs;
using System;

namespace AirSmileWMS.Kernel.Models
{
    /// <summary>
    /// Возврат товара.
    /// </summary>
    public class Refund
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
        /// Товар к возврату.
        /// </summary>
        public virtual Good Good { get; set; }

        /// <summary>
        /// Сколько товара ушло.
        /// </summary>
        public Amount Count { get; set; }

        /// <summary>
        /// Дата возврата.
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Описание (пришел не тот товар, брак, случайно добавили количество больше фактического)
        /// </summary>
        public Description Description { get; set; }
    }
}
