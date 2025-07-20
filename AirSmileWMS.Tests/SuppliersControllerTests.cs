using AirSmileWMS.Kernel.Controller;
using AirSmileWMS.Kernel.DTOs;
using AirSmileWMS.Kernel.Db;
using AirSmileWMS.Kernel.Models;

namespace AirSmileWMS.Tests
{
    /// <summary>
    /// Интеграционные тесты для контроллера поставщиков.
    /// Все тесты работают с реальной БД.
    /// Перед и после каждого теста таблица очищается.
    /// </summary>
    public class SuppliersIntegrationTests : IDisposable
    {
        private readonly SuppliersController _controller;

        public SuppliersIntegrationTests()
        {
            _controller = new SuppliersController();
            ClearSuppliers();
        }

        /// <summary>
        /// Очистка таблицы поставщиков (перед и после каждого теста).
        /// </summary>
        private void ClearSuppliers()
        {
            using (var db = new Context())
            {
                db.Suppliers.RemoveRange(db.Suppliers);
                db.SaveChanges();
            }
        }

        [Fact(DisplayName = "Создание поставщика")]
        public void Create_ShouldAddSupplier()
        {
            var dto = new SupplierDTO { Name = "Alpha" };
            _controller.Create(dto);

            var all = _controller.GetAll().ToList();
            Assert.Single(all);
            Assert.Equal("Alpha", all[0].Name);
        }

        [Fact(DisplayName = "Получение пустого списка поставщиков")]
        public void GetAll_ShouldReturnEmpty_WhenNoSuppliers()
        {
            var all = _controller.GetAll();
            Assert.Empty(all);
        }

        [Fact(DisplayName = "Редактирование поставщика")]
        public void Update_ShouldChangeSupplierFields()
        {
            var dto = new SupplierDTO { Name = "Alpha" };
            _controller.Create(dto);
            var id = _controller.GetAll().First().Id;

            var updateDto = new SupplierDTO
            {
                Name = "Updated",
                IsHasSKUsInfo = true,
                IsHasLinksInfo = true
            };
            _controller.Update(id, updateDto);

            var supplier = _controller.GetAll().First();
            Assert.Equal("Updated", supplier.Name);
            Assert.True(supplier.IsHasSKUsInfo);
            Assert.True(supplier.IsHasLinksInfo);
        }

        [Fact(DisplayName = "Удаление поставщика")]
        public void Delete_ShouldRemoveSupplier()
        {
            var dto = new SupplierDTO { Name = "Alpha" };
            _controller.Create(dto);
            var id = _controller.GetAll().First().Id;

            _controller.Delete(id);

            Assert.Empty(_controller.GetAll());
        }

        [Fact(DisplayName = "Удаление поставщика с приходами должно выбросить исключение")]
        public void Delete_ShouldThrow_WhenSupplierHasComes()
        {
            var controller = new SuppliersController();
            var supplier = new Supplier
            {
                Name = "Test Supplier",
                IsHasSKUsInfo = true,
                IsHasLinksInfo = false
            };

            using (var db = new Context())
            {
                // Сохраняем поставщика
                db.Suppliers.Add(supplier);
                db.SaveChanges();

                // Сохраняем категорию, чтобы не было FK ошибки
                var category = new Category { Name = "Test" };
                db.Categories.Add(category);
                db.SaveChanges();

                // Создаём товар, привязанный к категории
                var good = new Good
                {
                    CategoryId = category.Id,
                    Image = "C:\\AirSmileWMS\\TestFiles\\smartboy.jpeg",
                    Name = "Test Good",
                    NeedCount = 0,
                    Count = 0
                };
                db.Goods.Add(good);
                db.SaveChanges();

                // Добавляем приход
                db.Comes.Add(new Come
                {
                    SupplierId = supplier.Id,
                    GoodId = good.Id,
                    Count = 5,
                    Date = DateTime.Now
                });
                db.SaveChanges();
            }

            // Проверяем, что удаление выбрасывает исключение
            Assert.Throws<InvalidOperationException>(() => controller.Delete(supplier.Id));
        }

        [Fact(DisplayName = "Обновление несуществующего поставщика должно выбросить исключение")]
        public void Update_ShouldThrow_WhenSupplierNotFound()
        {
            var dto = new SupplierDTO { Name = "NotExist" };

            Assert.Throws<InvalidOperationException>(() => _controller.Update(9999, dto));
        }

        [Fact(DisplayName = "Удаление несуществующего поставщика должно выбросить исключение")]
        public void Delete_ShouldThrow_WhenSupplierNotFound()
        {
            Assert.Throws<InvalidOperationException>(() => _controller.Delete(9999));
        }

        public void Dispose()
        {
            ClearSuppliers();
        }
    }
}