using Microsoft.EntityFrameworkCore;
using SanalVeriTabanıCrud.Models;

namespace SanalVeriTabanıCrud.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {

        }
        //Tekil ----> çoğul(listeler)
        //AppDbContext _context = new AppDbContext(); _context.Personels
        public DbSet<Personel> Personels { get; set; }
    }
}
