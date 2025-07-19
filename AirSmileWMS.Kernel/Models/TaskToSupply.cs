using System;

namespace AirSmileWMS.Kernel.Models
{
    /// <summary>
    /// Задание на поставку.
    /// </summary>
    public class TaskToSupply
    {
        /// <summary>
        /// Идентификатор для EF.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Идентификатор набора для EF.
        /// </summary>
        public int PackId { get; set; }

        /// <summary>
        /// Набор, который учавствует в задании.
        /// </summary>
        public virtual Pack Pack { get; set; }

        /// <summary>
        /// Идентификатор поставки для EF.
        /// </summary>
        public int SupplyId { get; set; }

        /// <summary>
        /// поставка, на которую идет выбранный набор.
        /// </summary>
        public virtual Supply Supply { get; set; }

        /// <summary>
        /// Дата создания задания на поставку.
        /// </summary>
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Задание на сборку выбранного задания на поставку.
        /// </summary>
        public virtual TaskToCollect TaskToCollect { get; set; }

        /// <summary>
        /// Задание на упаковку выбранного задания на поставку.
        /// </summary>
        public virtual TaskToPack TaskToPack { get; set; }

        /// <summary>
        /// Готовность задания на поставку.
        /// </summary>
        public virtual ReadyTask ReadyTask { get; set; }
    }
}
