using AirSmileWMS.Kernel.VOs;
using System.Collections.Generic;

namespace AirSmileWMS.Kernel.Models
{
    /// <summary>
    /// Пользователь/Сотрудник.
    /// </summary>
    public class User
    {
        /// <summary>
        /// Идентификатор для EF.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Имя сотрудника.
        /// </summary>
        public Name Name { get; set; }

        /// <summary>
        /// Роль сотрудника в компании (менеджер, кладовщик, упаковщик, туалет Ирины)
        /// </summary>
        public Name Role { get; set; }

        /// <summary>
        /// Код для входа в систему.
        /// </summary>
        public PIN Code { get; set; }

        /// <summary>
        /// Имеет ли сотрудник права администратора.
        /// </summary>
        public bool IsAdmin { get; set; }   

        /// <summary>
        /// Действия сотрудника в админке.
        /// </summary>
        public virtual ICollection<UserAction> Actions { get; set; }

        /// <summary>
        /// Задания сотрудника.
        /// </summary>
        public virtual ICollection<TaskFree> FreeTasks { get; set; }

        /// <summary>
        /// Задания сотрудника на сборку.
        /// </summary>
        public virtual ICollection<TaskToCollect> TasksToCollect { get; set; }

        /// <summary>
        /// Задания сотрудника на упаковку.
        /// </summary>
        public virtual ICollection<TaskToPack> TasksToPack { get; set; }
    }
}
