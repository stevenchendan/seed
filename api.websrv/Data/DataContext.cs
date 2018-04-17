using api.websrv.Models;
using Microsoft.EntityFrameworkCore;
namespace api.websrv.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) {}

        public DbSet<Value> Values { get; set; }
    }
}