using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
    //Контекст базы данных
    public class TestTask1DBContext : DbContext
    {
        public DbSet<FileLine> FileLines { get; set; }

        private const string _connectionString = 
            "Server=FUNKYMONK\\SQLEXPRESS;Database=TestTask1;Trusted_Connection=True;TrustServerCertificate=True;";

        //Конфигурация контекста с указанием строки подключения
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Явное указание столбца с первичным ключом
            modelBuilder.Entity<FileLine>(fileLine =>
            {
                fileLine.HasKey(fl => fl.Id);
            });
        }
    }
}
