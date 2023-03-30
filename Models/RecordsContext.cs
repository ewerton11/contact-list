using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace RecordsApi.Models 
{
    public class RecordsContext : DbContext
    {
        public RecordsContext(DbContextOptions<RecordsContext> options)
        : base(options)
        {
        }

        public DbSet<RecordsItem> RecordsItems { get; set; } = null!;
    }
}