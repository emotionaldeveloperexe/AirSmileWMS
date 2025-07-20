using System;
using System.Linq;
using System.Collections.Generic;
using AirSmileWMS.Kernel.Constants;
using AirSmileWMS.Kernel.Db;
using AirSmileWMS.Kernel.DTOs;
using AirSmileWMS.Kernel.Models;

namespace AirSmileWMS.Kernel.Services
{
    /// <summary>
    /// Здесь вся логика работы с поставщиками.
    /// </summary>
    internal class SupplierService
    {
        public IEnumerable<Supplier> GetAll()
        {
            using (var db = new Db.Context())
                return db.Suppliers.ToList();
        }

        public void CreateSupplier(SupplierDTO supplierDTO)
        {
            using (var db = new Context())
            using (var transaction = db.Database.BeginTransaction())
            {
                try
                {
                    var supplier = new Supplier
                    {
                        Name = supplierDTO.Name,
                        IsHasSKUsInfo = supplierDTO.IsHasSKUsInfo,
                        IsHasLinksInfo = supplierDTO.IsHasLinksInfo
                    };

                    db.Suppliers.Add(supplier);
                    db.SaveChanges();
                    transaction.Commit();
                }
                catch
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }

        public void UpdateSupplier(int id, SupplierDTO supplierDto)
        {
            using (var db = new Context())
            using (var transaction = db.Database.BeginTransaction())
            {
                try
                {
                    var supplier = FindSupplier(db, id);
                    supplier.Name = supplierDto.Name;
                    supplier.IsHasLinksInfo = supplierDto.IsHasLinksInfo;
                    supplier.IsHasSKUsInfo = supplierDto.IsHasSKUsInfo;

                    db.SaveChanges();
                    transaction.Commit();
                }
                catch
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }

        public void DeleteSupplier(int id)
        {
            using (var db = new Context())
            using (var transaction = db.Database.BeginTransaction())
            {
                try
                {
                    var supplier = FindSupplier(db, id);

                    // Если у поставщика есть приходы, удалять нельзя.
                    if (supplier.Comes.Any())
                        throw new InvalidOperationException(ExceptionMessages.INVALID_DELETE_SUPPLIER);

                    db.Suppliers.Remove(supplier);
                    db.SaveChanges();

                    transaction.Commit();
                }
                catch
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }

        private Supplier FindSupplier(Context db, int id)
        {
            var supplier = db.Suppliers.Find(id);

            return supplier ?? throw new InvalidOperationException(ExceptionMessages.SUPPLIER_NOT_FOUND);
        }
    }
}
