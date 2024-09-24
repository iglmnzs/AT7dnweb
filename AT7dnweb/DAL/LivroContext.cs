using AT7dnweb.Models;
using Microsoft.EntityFrameworkCore;

namespace AT7dnweb.DAL
{
    public class LivroContext : DbContext
    {
        public LivroContext(DbContextOptions<LivroContext> options)
            : base(options)
        {
        }

        public DbSet<Livro> Livros { get; set; }
    }
}
