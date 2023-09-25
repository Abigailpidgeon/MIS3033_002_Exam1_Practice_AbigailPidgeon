using Microsoft.EntityFrameworkCore;

namespace a
{
    public class StudentDB : DbContext
    {
        public DbSet<Student> StuTbl { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder opt)
        {
            opt.UseSqlite("Data Source = stu0925.db");
        }
    }
}
