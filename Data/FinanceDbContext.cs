using Blazor_With_DI_and_Looping_Registration.Data.Data_Set_Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace Blazor_With_DI_and_Looping_Registration.Data
{
    public class FinanceDbContext : DbContext
    {
        public FinanceDbContext(DbContextOptions<FinanceDbContext> options)  : base(options) {}

        public DbSet<Investor> Investors { get; set; }
        public DbSet<ExpenseTransaction> Expenses { get; set; }
        public DbSet<IncomeTransaction> Incomes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
            optionsBuilder.EnableSensitiveDataLogging();
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Investor>()
                .HasMany<IncomeTransaction>(i => i.Income);
            modelBuilder.Entity<Investor>()
                .HasMany<ExpenseTransaction>(i => i.Expenses);

            base.OnModelCreating(modelBuilder);
        }
    }
}
