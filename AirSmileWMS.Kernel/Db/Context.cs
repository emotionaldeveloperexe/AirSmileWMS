using AirSmileWMS.Kernel.Models;
using AirSmileWMS.Kernel.VOs;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace AirSmileWMS.Kernel.Db
{
    /// <summary>
    /// База данных.
    /// </summary>
    public class Context : DbContext
    {
        public Context() : base("WMSConnection") { }

        #region Таблицы БД
        public DbSet<Box> Boxes { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Come> Comes { get; set; }
        public DbSet<Direction> Directions { get; set; }
        public DbSet<Good> Goods { get; set; }
        public DbSet<GoodToBuy> GoodsToBuy { get; set; }
        public DbSet<Pack> Packs { get; set; }
        public DbSet<ReadyTask> ReadyTasks { get; set; }
        public DbSet<Refund> Refunds { get; set; }
        public DbSet<Source> Sources { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Supply> Supplies { get; set; }
        public DbSet<TaskFree> FreeTasks { get; set; }
        public DbSet<TaskToCollect> TasksToCollect { get; set; }
        public DbSet<TaskToPack> TasksToPack { get; set; }
        public DbSet<TaskToSupply> TasksToSupply { get; set; }
        public DbSet<Track> Tracks { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserAction> UserActions { get; set; }
        public DbSet<UsingGood> UsingGoods { get; set; }
        #endregion

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Убираем множественные имена таблиц (Boxes → Box)
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            // Настройка VO как ComplexType (EF6 будет хранить только Value)
            modelBuilder.ComplexType<Amount>();
            modelBuilder.ComplexType<Barcode>();
            modelBuilder.ComplexType<Description>();
            modelBuilder.ComplexType<Image>();
            modelBuilder.ComplexType<Link>();
            modelBuilder.ComplexType<Name>();
            modelBuilder.ComplexType<PIN>();
            modelBuilder.ComplexType<QR>();
            modelBuilder.ComplexType<SKU>();

            // TaskToSupply → ReadyTask (один-к-одному, TaskToSupply главный)
            modelBuilder.Entity<TaskToSupply>()
                .HasOptional(t => t.ReadyTask)
                .WithRequired(r => r.TaskToSupply);

            // TaskToSupply → TaskToCollect (один-к-одному, TaskToSupply главный)
            modelBuilder.Entity<TaskToSupply>()
                .HasOptional(t => t.TaskToCollect)
                .WithRequired(c => c.TaskToSupply);

            // TaskToSupply → TaskToPack (один-к-одному, TaskToSupply главный)
            modelBuilder.Entity<TaskToSupply>()
                .HasOptional(t => t.TaskToPack)
                .WithRequired(p => p.TaskToSupply);
        }
    }
}
