using AirSmileWMS.Kernel.VOs;
using System.Collections.Generic;

namespace AirSmileWMS.Kernel.Models
{
    /// <summary>
    /// Коробка, которая учавствует в поставке.
    /// </summary>
    public class Box
    {
        /// <summary>
        /// Идентификатор для EF.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Номер коробки в рамках поставки.
        /// </summary>
        public Barcode Number { get; set; }

        /// <summary>
        /// Готовые задания, которые лежат в выбранной коробке.
        /// </summary>
        public virtual ICollection<ReadyTask> ReadyTasks { get; set; }
    }
}
