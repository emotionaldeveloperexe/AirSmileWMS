using AirSmileWMS.Kernel.VOs;
using System;

namespace AirSmileWMS.Kernel.Models
{
    /// <summary>
    /// Действие сотрудника (такое имя потому что класс Action уже есть)
    /// </summary>
    public class UserAction
    {
        /// <summary>
        /// Идентификатор для EF.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Идентификатор сотрудника для EF.
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// Сотрудник, который совершил действие.
        /// </summary>
        public virtual User User { get; set; }

        /// <summary>
        /// Описание действия.
        /// </summary>
        public Description Description { get; set; }

        /// <summary>
        /// Дата и время действия.
        /// </summary>
        public DateTime Date { get; set; }
    }
}
