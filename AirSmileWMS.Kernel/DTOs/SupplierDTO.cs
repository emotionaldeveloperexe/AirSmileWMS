namespace AirSmileWMS.Kernel.DTOs
{
    /// <summary>
    /// Контейнер для создания/редактирования поставщика.
    /// </summary>
    public class SupplierDTO
    {
        /// <summary>
        /// Наименование поставщика.
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Есть ли у поставщика артикулы.
        /// </summary>
        public bool IsHasSKUsInfo { get; set; } = false;

        /// <summary>
        /// Есть ли у поставщика ссылки на товар.
        /// </summary>
        public bool IsHasLinksInfo { get; set; } = false;
    }
}
