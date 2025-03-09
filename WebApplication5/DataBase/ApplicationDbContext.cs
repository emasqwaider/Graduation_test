using Microsoft.EntityFrameworkCore;
using WebApplication5.Models;

namespace WebApplication5.DataBase
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Student> Student { get; set; }

    }
}
