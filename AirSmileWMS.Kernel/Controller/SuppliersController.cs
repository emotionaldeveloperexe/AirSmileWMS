using System.Collections.Generic;
using AirSmileWMS.Kernel.DTOs;
using AirSmileWMS.Kernel.Models;
using AirSmileWMS.Kernel.Services;

namespace AirSmileWMS.Kernel.Controller
{
    /// <summary>
    /// Контроллер для работы с поставщиками.
    /// </summary>
    public class SuppliersController
    {
        private readonly SupplierService _service;

        public SuppliersController() => _service = new SupplierService();

        /// <summary>
        /// Получить всех поставщиков из БД.
        /// </summary>
        public IEnumerable<Supplier> GetAll() => _service.GetAll();

        /// <summary>
        /// Добавить нового поставщика.
        /// </summary>
        public void Create(SupplierDTO supplier) => _service.CreateSupplier(supplier);

        /// <summary>
        /// Редактировать выбранного поставщика.
        /// </summary>
        public void Update(int supplierId, SupplierDTO supplier) => _service.UpdateSupplier(supplierId, supplier);

        /// <summary>
        /// Удалить выбранного поставщика.
        /// </summary>
        public void Delete(int supplierId) => _service.DeleteSupplier(supplierId);
    }
}
