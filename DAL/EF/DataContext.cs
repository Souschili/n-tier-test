using BAL.Models;
using Microsoft.EntityFrameworkCore;

namespace DAL.EF
{
    public class DataContext:DbContext
    {
        public DbSet<Data> Datas { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

    }
}
