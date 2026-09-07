using PersonaAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace PersonaAPI.Tests;

public class Setup
{
    public static PersonasDbContext GetDatabaseContext()
    {
        var options = new DbContextOptionsBuilder<PersonasDbContext>()
            .UseInMemoryDatabase(Guid.NewGuid().ToString())
            .Options;

        var context = new PersonasDbContext(options);
        context.Database.EnsureCreated();
        return context;
    }
}