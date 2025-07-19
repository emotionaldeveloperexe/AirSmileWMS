using AirSmileWMS.Kernel.VOs;
using System.Collections.Generic;

namespace AirSmileWMS.Kernel.Models
{
    /// <summary>
    /// Товар.
    /// </summary>
    public class Good
    {
        /// <summary>
        /// Идентификатор для EF.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Идентификатор категории для EF.
        /// </summary>
        public int CategoryId { get; set; }

        /// <summary>
        /// Категория товара.
        /// </summary>
        public virtual Category Category { get; set; }

        /// <summary>
        /// Изображение товара.
        /// </summary>
        public Image Image { get; set; }

        /// <summary>
        /// Наименование товара.
        /// </summary>
        public Name Name { get; set; }

        /// <summary>
        /// Потребность.
        /// </summary>
        public Amount NeedCount { get; set; }

        /// <summary>
        /// Остаток.
        /// </summary>
        public Amount Count { get; set; }

        /// <summary>
        /// Отслеживания по выбранному товару. Допускается несколько отслеживаний.
        /// </summary>
        public virtual ICollection<Track> Tracks { get; set; }

        /// <summary>
        /// Наличие товара в списке покупок.
        /// </summary>
        public virtual GoodToBuy IsNeedInBuy { get; set; }

        /// <summary>
        /// Приходы выбранного товара.
        /// </summary>
        public virtual ICollection<Come> Comes { get; set; }

        /// <summary>
        /// Возвраты товара.
        /// </summary>
        public virtual ICollection<Refund> Refunds { get; set; }

        /// <summary>
        /// Источники выбранного товара.
        /// </summary>
        public virtual ICollection<Source> Sources { get; set; }

        /// <summary>
        /// Наборы, в которых учавствует товар.
        /// </summary>
        public ICollection<UsingGood> Usings { get; set; }
    }
}
