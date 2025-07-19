namespace AirSmileWMS.Kernel.Models
{
    /// <summary>
    /// Готовое задание на поставку.
    /// </summary>
    public class ReadyTask
    {
        /// <summary>
        /// Идентификатор для EF.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Идентификатор задания на поставку для EF.
        /// </summary>
        public int TaskToSupplyId { get; set; }

        /// <summary>
        /// Задание на поставку, которое должно было быть готово.
        /// </summary>
        public virtual TaskToSupply TaskToSupply { get; set; }

        /// <summary>
        /// Идентификатор коробки для EF.
        /// </summary>
        public int BoxId { get; set; }

        /// <summary>
        /// Коробка, в которой лежит выбранное задание.
        /// </summary>
        public virtual Box Box { get; set; }    
    }
}
