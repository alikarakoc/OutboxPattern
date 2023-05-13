using Microsoft.EntityFrameworkCore;
using OutboxPattern.Domain.Entities;

namespace OutboxPattern.Infrastructure.Persistence
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public virtual DbSet<Outbox> Outbox { get; set; }
        public virtual DbSet<User> Users { get; set; }
    }
}
