using System;

namespace AirSmileWMS.Kernel.Models
{
    /// <summary>
    /// Задание на сборку.
    /// </summary>
    public class TaskToCollect
    {
        /// <summary>
        /// Идентификатор для EF.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Идентификатор задания на поставку для EF.
        /// </summary>
        public int TaskToSupplyId { get; set; }

        /// <summary>
        /// Задание на поставку для сборки.
        /// </summary>
        public virtual TaskToSupply TaskToSupply { get; set; }

        /// <summary>
        /// Идентификатор сотрудника для EF.
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// Исполнитель.
        /// </summary>
        public virtual User User { get; set; }

        /// <summary>
        /// Дата и время начала сборки.
        /// </summary>
        public DateTime? StartedAt { get; set; }

        /// <summary>
        /// Дата и время завершения сборки.
        /// </summary>
        public DateTime? CompletedAt { get; set; }
    }
}
