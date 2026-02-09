using FinalProjectWebApiV0._2.Model;
using Microsoft.EntityFrameworkCore;

namespace FinalProjectWebApiV0._2.LocalDb
{
    public class AppDb:DbContext
    {
        public AppDb(DbContextOptions<AppDb> op):base(op)
        {
            
        }

        public DbSet<Student> SDetails { get; set; }
    }
}
