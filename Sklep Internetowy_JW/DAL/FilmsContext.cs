using Microsoft.EntityFrameworkCore;
using Sklep_Internetowy_JW.Models;

namespace Sklep_Internetowy_JW.DAL
{
    public class FilmsContext : DbContext
    {
        public DbSet<FilmsContext> Films { get; set; }
        public DbSet<Category> Categories{ get; set; }
        public FilmsContext(DbContextOptions options) : base(options)
        {
        }
    }
}
