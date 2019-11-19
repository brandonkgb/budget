using Microsoft.EntityFrameworkCore;
using budget.Models;

namespace budget.Data
{
    public class CategoryContext : DbContext
    {
        public CategoryContext(DbContextOptions<CategoryContext> options) : base(options)
        {
        }

        public DbSet<Category> CategoryItems { get; set; }
    }
}