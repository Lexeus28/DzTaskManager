using Microsoft.EntityFrameworkCore;
namespace DzTaskManager
{
    public class TaskDBContext : DbContext
    {
        public DbSet<UserTask> Tasks { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=TaskManagerDB.db");
        }
    }
}