using Microsoft.EntityFrameworkCore;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LibrosAPI.Models
{
    public class LibrosDbContext(DbContextOptions options) : DbContext(options)
    {
        public DbSet<Libro> Libros { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           /* base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Libro>().HasData(
           new Libro
           {
               Id = 1,
               Titulo = "Cien años de soledad",
               Autor = "Gabriel García Márquez",
               AnioPublicacion = 1967
           },
           new Libro
           {
               Id = 2,
               Titulo = "Don Quijote de la Mancha",
               Autor = "Miguel de Cervantes",
               AnioPublicacion = 1605
           },
           new Libro
           {
               Id = 3,
               Titulo = "El amor en los tiempos del cólera",
               Autor = "Gabriel García Márquez",
               AnioPublicacion = 1985
           },
                    new Libro { Id = 4, Titulo = "Flexidy", Autor = "Barrett Kaman", AnioPublicacion = 1992 },
new Libro { Id = 5, Titulo = "Tampflex", Autor = "Perkin Kinkaid", AnioPublicacion = 1992 },
new Libro { Id = 6, Titulo = "It", Autor = "Kyle Cowpe", AnioPublicacion = 2011 },
new Libro { Id = 7, Titulo = "Bitwolf", Autor = "Alfonse Kempson", AnioPublicacion = 1993 },
new Libro { Id = 8, Titulo = "Cardify", Autor = "Lucia Pettinger", AnioPublicacion = 2001 },
new Libro { Id = 9, Titulo = "Bytecard", Autor = "Aldous Paty", AnioPublicacion = 1994 },
new Libro { Id = 10, Titulo = "Redhold", Autor = "Blair Leisman", AnioPublicacion = 1997 },
new Libro { Id = 11, Titulo = "Matsoft", Autor = "Adolphus Sneezum", AnioPublicacion = 2006 },
new Libro { Id = 12, Titulo = "Cardify", Autor = "Gualterio Teare", AnioPublicacion = 2011 },
new Libro { Id = 13, Titulo = "Subin", Autor = "Laverna Tuffs", AnioPublicacion = 1997 },
new Libro { Id = 14, Titulo = "Duobam", Autor = "Heath Rosier", AnioPublicacion = 2005 },
new Libro { Id = 15, Titulo = "Rank", Autor = "Darsie Biggam", AnioPublicacion = 2003 },
new Libro { Id = 16, Titulo = "Cardify", Autor = "Babara Jayme", AnioPublicacion = 1995 },
new Libro { Id = 17, Titulo = "Zaam-Dox", Autor = "Izak Kingswoode", AnioPublicacion = 2012 },
new Libro { Id = 18, Titulo = "Bigtax", Autor = "Francine Brownbill", AnioPublicacion = 1995 },
new Libro { Id = 19, Titulo = "Tin", Autor = "Donielle Monckton", AnioPublicacion = 2012 },
new Libro { Id = 20, Titulo = "Treeflex", Autor = "Pavlov Shuttell", AnioPublicacion = 2000 },
new Libro { Id = 21, Titulo = "Pannier", Autor = "Moria Konmann", AnioPublicacion = 2009 },
new Libro { Id = 22, Titulo = "Zathin", Autor = "Imelda Hartup", AnioPublicacion = 2012 },
new Libro { Id = 23, Titulo = "Zaam-Dox", Autor = "Mitzi Rudkin", AnioPublicacion = 1997 },
new Libro { Id = 24, Titulo = "Biodex", Autor = "Editha Piesing", AnioPublicacion = 2009 },
new Libro { Id = 25, Titulo = "Fixflex", Autor = "Ariella Leftley", AnioPublicacion = 1987 },
new Libro { Id = 26, Titulo = "Subin", Autor = "Esme Felstead", AnioPublicacion = 1999 },
new Libro { Id = 27, Titulo = "Latlux", Autor = "Alethea Clayhill", AnioPublicacion = 1989 },
new Libro { Id = 28, Titulo = "Fixflex", Autor = "Nicoli Millott", AnioPublicacion = 2004 },
new Libro { Id = 29, Titulo = "Fintone", Autor = "Vanny Guyon", AnioPublicacion = 1995 },
new Libro { Id = 30, Titulo = "Tres-Zap", Autor = "Ebenezer Teml", AnioPublicacion = 1995 },
new Libro { Id = 31, Titulo = "Quo Lux", Autor = "Siusan Mathewson", AnioPublicacion = 1984 },
new Libro { Id = 32, Titulo = "Bamity", Autor = "Agatha Bunn", AnioPublicacion = 2010 },
new Libro { Id = 33, Titulo = "Duobam", Autor = "Kaylyn Villa", AnioPublicacion = 2008 },
new Libro { Id = 34, Titulo = "Temp", Autor = "Nelson Ingerfield", AnioPublicacion = 2007 },
new Libro { Id = 35, Titulo = "Transcof", Autor = "Van Charopen", AnioPublicacion = 2012 },
new Libro { Id = 36, Titulo = "Latlux", Autor = "Mariele Bentley", AnioPublicacion = 2001 },
new Libro { Id = 37, Titulo = "Span", Autor = "Dione Robarts", AnioPublicacion = 1987 },
new Libro { Id = 38, Titulo = "Zoolab", Autor = "Selma Ovitts", AnioPublicacion = 1994 },
new Libro { Id = 39, Titulo = "Bigtax", Autor = "Hayyim Gilks", AnioPublicacion = 2009 },
new Libro { Id = 40, Titulo = "Mat Lam Tam", Autor = "Bronnie Huygen", AnioPublicacion = 2001 },
new Libro { Id = 41, Titulo = "Bamity", Autor = "Cindra Postan", AnioPublicacion = 1989 },
new Libro { Id = 42, Titulo = "Zaam-Dox", Autor = "Clea Vasilyev", AnioPublicacion = 2008 },
new Libro { Id = 43, Titulo = "Keylex", Autor = "Emerson Pape", AnioPublicacion = 1993 },
new Libro { Id = 44, Titulo = "Zontrax", Autor = "Vanny Peepall", AnioPublicacion = 2010 },
new Libro { Id = 45, Titulo = "Tampflex", Autor = "Carlen MacSkeagan", AnioPublicacion = 2001 },
new Libro { Id = 46, Titulo = "Pannier", Autor = "Nessi Mattisssen", AnioPublicacion = 2000 },
new Libro { Id = 47, Titulo = "Domainer", Autor = "Jose Twiggins", AnioPublicacion = 1995 },
new Libro { Id = 48, Titulo = "Zaam-Dox", Autor = "Corbett Colqueran", AnioPublicacion = 2003 },
new Libro { Id = 49, Titulo = "Matsoft", Autor = "Alene Ayris", AnioPublicacion = 2004 },
new Libro { Id = 50, Titulo = "Bamity", Autor = "Joceline Tancock", AnioPublicacion = 1998 },
new Libro { Id = 51, Titulo = "It", Autor = "Fred Prisk", AnioPublicacion = 1998 },
new Libro { Id = 52, Titulo = "Toughjoyfax", Autor = "Dexter Beggs", AnioPublicacion = 2011 },
new Libro { Id = 53, Titulo = "Veribet", Autor = "Lorrie Tolossi", AnioPublicacion = 2005 },
new Libro { Id = 54, Titulo = "Redhold", Autor = "Lucita Ebbutt", AnioPublicacion = 2007 },
new Libro { Id = 55, Titulo = "Treeflex", Autor = "Ignacio Casswell", AnioPublicacion = 2006 },
new Libro { Id = 56, Titulo = "Wrapsafe", Autor = "Thedrick Abeau", AnioPublicacion = 2009 },
new Libro { Id = 57, Titulo = "Cookley", Autor = "Delbert MacGowan", AnioPublicacion = 2003 },
new Libro { Id = 58, Titulo = "Overhold", Autor = "Carmela Frowen", AnioPublicacion = 2006 },
new Libro { Id = 59, Titulo = "Zamit", Autor = "Eberhard Goldhawk", AnioPublicacion = 2003 },
new Libro { Id = 60, Titulo = "Mat Lam Tam", Autor = "Editha Cristol", AnioPublicacion = 1994 },
new Libro { Id = 61, Titulo = "Greenlam", Autor = "Arin Genney", AnioPublicacion = 2005 },
new Libro { Id = 62, Titulo = "Bytecard", Autor = "Titos Stranahan", AnioPublicacion = 1988 },
new Libro { Id = 63, Titulo = "Zaam-Dox", Autor = "Allissa Billington", AnioPublicacion = 1993 },
new Libro { Id = 64, Titulo = "Transcof", Autor = "Ezmeralda O' Ronan", AnioPublicacion = 2006 },
new Libro { Id = 65, Titulo = "Duobam", Autor = "Darla Laidler", AnioPublicacion = 2000 },
new Libro { Id = 66, Titulo = "Stim", Autor = "Joice Taffee", AnioPublicacion = 2009 },
new Libro { Id = 67, Titulo = "Zamit", Autor = "Candi Herion", AnioPublicacion = 2013 },
new Libro { Id = 68, Titulo = "Greenlam", Autor = "Nicolai Cornil", AnioPublicacion = 2010 },
new Libro { Id = 69, Titulo = "Subin", Autor = "Emmye Tyrie", AnioPublicacion = 1996 },
new Libro { Id = 70, Titulo = "Fintone", Autor = "Obed Philippart", AnioPublicacion = 2010 },
new Libro { Id = 71, Titulo = "Ronstring", Autor = "Linnea Stiff", AnioPublicacion = 1994 },
new Libro { Id = 72, Titulo = "Asoka", Autor = "Axe Bartlomiej", AnioPublicacion = 1997 },
new Libro { Id = 73, Titulo = "Ronstring", Autor = "Carline Jedrachowicz", AnioPublicacion = 2006 },
new Libro { Id = 74, Titulo = "Konklab", Autor = "Merell Halsall", AnioPublicacion = 2008 },
new Libro { Id = 75, Titulo = "Pannier", Autor = "Domenic Britcher", AnioPublicacion = 2002 },
new Libro { Id = 76, Titulo = "Zamit", Autor = "Darn Jacmard", AnioPublicacion = 2008 },
new Libro { Id = 77, Titulo = "Span", Autor = "Hillard Larsen", AnioPublicacion = 1988 },
new Libro { Id = 78, Titulo = "Fix San", Autor = "Fabien Iacobucci", AnioPublicacion = 2009 },
new Libro { Id = 79, Titulo = "Duobam", Autor = "Sauncho O'Leahy", AnioPublicacion = 2000 },
new Libro { Id = 80, Titulo = "Andalax", Autor = "Padriac Colbridge", AnioPublicacion = 2000 },
new Libro { Id = 81, Titulo = "Zoolab", Autor = "Lynsey Scutching", AnioPublicacion = 1996 },
new Libro { Id = 82, Titulo = "Zamit", Autor = "Christos Cantopher", AnioPublicacion = 1984 },
new Libro { Id = 83, Titulo = "Wrapsafe", Autor = "Charil Stoacley", AnioPublicacion = 1987 },
new Libro { Id = 84, Titulo = "Toughjoyfax", Autor = "Maggi Lydiate", AnioPublicacion = 2013 },
new Libro { Id = 85, Titulo = "Aerified", Autor = "Guido Humber", AnioPublicacion = 1993 },
new Libro { Id = 86, Titulo = "Lotstring", Autor = "Amitie Harston", AnioPublicacion = 2010 },
new Libro { Id = 87, Titulo = "Voyatouch", Autor = "Kimmie Shippey", AnioPublicacion = 2006 },
new Libro { Id = 88, Titulo = "Viva", Autor = "Theobald Sprosson", AnioPublicacion = 2008 },
new Libro { Id = 89, Titulo = "Ventosanzap", Autor = "Jorge Ayerst", AnioPublicacion = 2006 },
new Libro { Id = 90, Titulo = "Fix San", Autor = "Elyn Bercevelo", AnioPublicacion = 1993 },
new Libro { Id = 91, Titulo = "Viva", Autor = "Cary Colam", AnioPublicacion = 1996 },
new Libro { Id = 92, Titulo = "Aerified", Autor = "Iorgos Tonepohl", AnioPublicacion = 1989 },
new Libro { Id = 93, Titulo = "Flexidy", Autor = "Otho Huntington", AnioPublicacion = 1999 },
new Libro { Id = 94, Titulo = "Duobam", Autor = "Gwenni Robard", AnioPublicacion = 1995 },
new Libro { Id = 95, Titulo = "Trippledex", Autor = "Floyd Powlesland", AnioPublicacion = 1954 },
new Libro { Id = 96, Titulo = "Aerified", Autor = "Reginauld Ragdale", AnioPublicacion = 2004 },
new Libro { Id = 97, Titulo = "Kanlam", Autor = "Arel Abeau", AnioPublicacion = 2004 },
new Libro { Id = 98, Titulo = "Zamit", Autor = "Jacinthe Barnshaw", AnioPublicacion = 1984 },
new Libro { Id = 99, Titulo = "Y-Solowarm", Autor = "Ramsay Stenners", AnioPublicacion = 1994 },
new Libro { Id = 100, Titulo = "Hatity", Autor = "Ferris Jandl", AnioPublicacion = 2003 }
       );*/
        }
    }
}

