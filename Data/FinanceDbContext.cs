using Blazor_With_DI_and_Looping_Registration.Data.Data_Set_Models;
using Microsoft.EntityFrameworkCore;

namespace Blazor_With_DI_and_Looping_Registration.Data
{
    public class FinanceDbContext : DbContext
    {
        public FinanceDbContext(DbContextOptions<FinanceDbContext> options)  : base(options) {}

        public DbSet<Investor> Investors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
    }
}
