using AirSmileWMS.Kernel.VOs;
using System.Collections.Generic;

namespace AirSmileWMS.Kernel.Models
{
    /// <summary>
    /// Продаваемый набор.
    /// </summary>
    public class Pack
    {
        /// <summary>
        /// Идентификатор для EF.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Изображение набора.
        /// </summary>
        public Image Image { get; set; }

        /// <summary>
        /// Наименование набора.
        /// </summary>
        public Name Name { get; set; }

        /// <summary>
        /// Артикул продавца.
        /// </summary>
        public SKU SellerSKU { get; set; }

        /// <summary>
        /// Артикул вб.
        /// </summary>
        public SKU WbSKU { get; set; }

        /// <summary>
        /// Баркод.
        /// </summary>
        public Barcode Barcode { get; set; }

        /// <summary>
        /// QR-код.
        /// </summary>
        public QR QR { get; set; }

        /// <summary>
        /// Сложность.
        /// </summary>
        public Amount Difficulty { get; set; }

        /// <summary>
        /// Задания на поставку по выбранному набору.
        /// </summary>
        public virtual ICollection<TaskToSupply> TasksToSupply { get; set; }
    }
}
