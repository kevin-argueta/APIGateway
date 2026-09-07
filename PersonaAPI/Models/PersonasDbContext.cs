using Microsoft.EntityFrameworkCore;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PersonaAPI.Models
{
    public class PersonasDbContext(DbContextOptions options) : DbContext(options)
    {
        public DbSet<Persona> Personas { get; set; }
    }
}
