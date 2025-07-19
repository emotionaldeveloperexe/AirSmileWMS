using AirSmileWMS.Kernel.VOs;

namespace AirSmileWMS.Kernel.Models
{
    /// <summary>
    /// Товар, учавствующий в выбранном наборе.
    /// </summary>
    public class UsingGood
    {
        /// <summary>
        /// Идентификатор для EF.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Идентификатор набора для EF.
        /// </summary>
        public int PackId { get; set; }

        /// <summary>
        /// Набор, в котором учавствует товар.
        /// </summary>
        public virtual Pack Pack { get; set; }

        /// <summary>
        /// Идентификатор товара для EF.
        /// </summary>
        public int GoodId { get; set; }

        /// <summary>
        /// Товар, который учавствует в наборе.
        /// </summary>
        public Good Good { get; set; }

        /// <summary>
        /// Количество.
        /// </summary>
        public Amount Count { get; set; }
    }
}
