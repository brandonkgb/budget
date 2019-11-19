using Microsoft.EntityFrameworkCore;
using budget.Models;

namespace budget.Data
{
    public class BudgetContext : DbContext
    {
        public BudgetContext(DbContextOptions<BudgetContext> options) : base(options)
        {
        }

        public DbSet<BudgetItem> BudgetItems { get; set; }
    }
}