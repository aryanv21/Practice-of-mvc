using Microsoft.EntityFrameworkCore;
using Practice_of_mvc.Models.Entities;

namespace Practice_of_mvc.Data
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options): base(options)
        {
            
        }

        public DbSet<Student> Students {  get; set; } 
    }
}
