using AirSmileWMS.Kernel.VOs;
using System;
using System.Collections.Generic;

namespace AirSmileWMS.Kernel.Models
{
    /// <summary>
    /// Поставка (от нас)
    /// </summary>
    public class Supply
    {
        /// <summary>
        /// Идентификатор для EF.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Идентификатор направления для EF.
        /// </summary>
        public int DirectionId { get; set; }

        /// <summary>
        /// Направление.
        /// </summary>
        public virtual Direction Direction { get; set; }

        /// <summary>
        /// Номер поставки.
        /// </summary>
        public Barcode Number { get; set; }

        /// <summary>
        /// Дата поставки.
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Задания по выбранной поставке.
        /// </summary>
        public virtual ICollection<TaskToSupply> TasksToSupply { get; set; }
    }
}
