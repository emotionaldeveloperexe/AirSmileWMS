using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using AirSmileWMS.Kernel.VOs;

namespace AirSmileWMS.Kernel.Models
{
    /// <summary>
    /// Товар в списке покупок.
    /// </summary>
    public class GoodToBuy
    {
        /// <summary>
        /// Идентификатор товара для EF.
        /// </summary>
        [Key]
        [ForeignKey(nameof(Good))]
        public int GoodId { get; set; }

        /// <summary>
        /// Товар, который нужно купить.
        /// </summary>
        public virtual Good Good { get; set; }

        /// <summary>
        /// Сколько товара нужно купить.
        /// </summary>
        public Amount Count { get; set; }
    }
}
