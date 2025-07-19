using AirSmileWMS.Kernel.VOs;
using System;

namespace AirSmileWMS.Kernel.Models
{
    /// <summary>
    /// Задание со свободным описанием (класс Task уже есть)
    /// </summary>
    public class TaskFree
    {
        /// <summary>
        /// Идентификатор для EF.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Описание задания.
        /// </summary>
        public Description Description { get; set; }

        /// <summary>
        /// Идентификатор сотрудника для EF.
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// Исполнитель.
        /// </summary>
        public virtual User User { get; set; }

        /// <summary>
        /// Дата и время создания.
        /// </summary>
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Дата и время начала выполнения.
        /// </summary>
        public DateTime? StartedAt { get; set; }

        /// <summary>
        /// Дата и время выполнения.
        /// </summary>
        public DateTime? CompletedAt { get; set; }
    }
}
