using Microsoft.EntityFrameworkCore;
using WordProjetoVideo.Models;

namespace WordProjetoVideo.Data
{
    public class AppDbContext : DbContext
    {


        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {            
        }

        public DbSet<Documento> Documentos { get; set; }

    }
}
