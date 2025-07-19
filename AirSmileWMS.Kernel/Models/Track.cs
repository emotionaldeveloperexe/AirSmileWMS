using AirSmileWMS.Kernel.VOs;
using System.Collections.Generic;

namespace AirSmileWMS.Kernel.Models
{
    /// <summary>
    /// Отслеживание товара. Менеджеры добавляют сюда товар, которому нужно особое внимание.
    /// </summary>
    public class Track
    {
        /// <summary>
        /// Идентификатор для EF.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Идентификатор товара для EF.
        /// </summary>
        public int GoodId { get; set; }

        /// <summary>
        /// Отслеживаемый товар.
        /// </summary>
        public virtual Good Good { get; set; }

        /// <summary>
        /// Описание, что нужно сделать с товаром (проверить остатки/наличие у поставщиков/продажи и т. д.)
        /// </summary>
        public Description Description { get; set; }

        /// <summary>
        /// Состав.
        /// </summary>
        public virtual ICollection<UsingGood> UsingGoods { get; set; }
    }
}
