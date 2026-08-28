using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LibrosAPI.Migrations
{
    /// <inheritdoc />
    public partial class MigracionInicial3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Libros",
                columns: new[] { "Id", "AnioPublicacion", "Autor", "Titulo" },
                values: new object[,]
                {
                    { 4, 1992, "Barrett Kaman", "Flexidy" },
                    { 5, 1992, "Perkin Kinkaid", "Tampflex" },
                    { 6, 2011, "Kyle Cowpe", "It" },
                    { 7, 1993, "Alfonse Kempson", "Bitwolf" },
                    { 8, 2001, "Lucia Pettinger", "Cardify" },
                    { 9, 1994, "Aldous Paty", "Bytecard" },
                    { 10, 1997, "Blair Leisman", "Redhold" },
                    { 11, 2006, "Adolphus Sneezum", "Matsoft" },
                    { 12, 2011, "Gualterio Teare", "Cardify" },
                    { 13, 1997, "Laverna Tuffs", "Subin" },
                    { 14, 2005, "Heath Rosier", "Duobam" },
                    { 15, 2003, "Darsie Biggam", "Rank" },
                    { 16, 1995, "Babara Jayme", "Cardify" },
                    { 17, 2012, "Izak Kingswoode", "Zaam-Dox" },
                    { 18, 1995, "Francine Brownbill", "Bigtax" },
                    { 19, 2012, "Donielle Monckton", "Tin" },
                    { 20, 2000, "Pavlov Shuttell", "Treeflex" },
                    { 21, 2009, "Moria Konmann", "Pannier" },
                    { 22, 2012, "Imelda Hartup", "Zathin" },
                    { 23, 1997, "Mitzi Rudkin", "Zaam-Dox" },
                    { 24, 2009, "Editha Piesing", "Biodex" },
                    { 25, 1987, "Ariella Leftley", "Fixflex" },
                    { 26, 1999, "Esme Felstead", "Subin" },
                    { 27, 1989, "Alethea Clayhill", "Latlux" },
                    { 28, 2004, "Nicoli Millott", "Fixflex" },
                    { 29, 1995, "Vanny Guyon", "Fintone" },
                    { 30, 1995, "Ebenezer Teml", "Tres-Zap" },
                    { 31, 1984, "Siusan Mathewson", "Quo Lux" },
                    { 32, 2010, "Agatha Bunn", "Bamity" },
                    { 33, 2008, "Kaylyn Villa", "Duobam" },
                    { 34, 2007, "Nelson Ingerfield", "Temp" },
                    { 35, 2012, "Van Charopen", "Transcof" },
                    { 36, 2001, "Mariele Bentley", "Latlux" },
                    { 37, 1987, "Dione Robarts", "Span" },
                    { 38, 1994, "Selma Ovitts", "Zoolab" },
                    { 39, 2009, "Hayyim Gilks", "Bigtax" },
                    { 40, 2001, "Bronnie Huygen", "Mat Lam Tam" },
                    { 41, 1989, "Cindra Postan", "Bamity" },
                    { 42, 2008, "Clea Vasilyev", "Zaam-Dox" },
                    { 43, 1993, "Emerson Pape", "Keylex" },
                    { 44, 2010, "Vanny Peepall", "Zontrax" },
                    { 45, 2001, "Carlen MacSkeagan", "Tampflex" },
                    { 46, 2000, "Nessi Mattisssen", "Pannier" },
                    { 47, 1995, "Jose Twiggins", "Domainer" },
                    { 48, 2003, "Corbett Colqueran", "Zaam-Dox" },
                    { 49, 2004, "Alene Ayris", "Matsoft" },
                    { 50, 1998, "Joceline Tancock", "Bamity" },
                    { 51, 1998, "Fred Prisk", "It" },
                    { 52, 2011, "Dexter Beggs", "Toughjoyfax" },
                    { 53, 2005, "Lorrie Tolossi", "Veribet" },
                    { 54, 2007, "Lucita Ebbutt", "Redhold" },
                    { 55, 2006, "Ignacio Casswell", "Treeflex" },
                    { 56, 2009, "Thedrick Abeau", "Wrapsafe" },
                    { 57, 2003, "Delbert MacGowan", "Cookley" },
                    { 58, 2006, "Carmela Frowen", "Overhold" },
                    { 59, 2003, "Eberhard Goldhawk", "Zamit" },
                    { 60, 1994, "Editha Cristol", "Mat Lam Tam" },
                    { 61, 2005, "Arin Genney", "Greenlam" },
                    { 62, 1988, "Titos Stranahan", "Bytecard" },
                    { 63, 1993, "Allissa Billington", "Zaam-Dox" },
                    { 64, 2006, "Ezmeralda O' Ronan", "Transcof" },
                    { 65, 2000, "Darla Laidler", "Duobam" },
                    { 66, 2009, "Joice Taffee", "Stim" },
                    { 67, 2013, "Candi Herion", "Zamit" },
                    { 68, 2010, "Nicolai Cornil", "Greenlam" },
                    { 69, 1996, "Emmye Tyrie", "Subin" },
                    { 70, 2010, "Obed Philippart", "Fintone" },
                    { 71, 1994, "Linnea Stiff", "Ronstring" },
                    { 72, 1997, "Axe Bartlomiej", "Asoka" },
                    { 73, 2006, "Carline Jedrachowicz", "Ronstring" },
                    { 74, 2008, "Merell Halsall", "Konklab" },
                    { 75, 2002, "Domenic Britcher", "Pannier" },
                    { 76, 2008, "Darn Jacmard", "Zamit" },
                    { 77, 1988, "Hillard Larsen", "Span" },
                    { 78, 2009, "Fabien Iacobucci", "Fix San" },
                    { 79, 2000, "Sauncho O'Leahy", "Duobam" },
                    { 80, 2000, "Padriac Colbridge", "Andalax" },
                    { 81, 1996, "Lynsey Scutching", "Zoolab" },
                    { 82, 1984, "Christos Cantopher", "Zamit" },
                    { 83, 1987, "Charil Stoacley", "Wrapsafe" },
                    { 84, 2013, "Maggi Lydiate", "Toughjoyfax" },
                    { 85, 1993, "Guido Humber", "Aerified" },
                    { 86, 2010, "Amitie Harston", "Lotstring" },
                    { 87, 2006, "Kimmie Shippey", "Voyatouch" },
                    { 88, 2008, "Theobald Sprosson", "Viva" },
                    { 89, 2006, "Jorge Ayerst", "Ventosanzap" },
                    { 90, 1993, "Elyn Bercevelo", "Fix San" },
                    { 91, 1996, "Cary Colam", "Viva" },
                    { 92, 1989, "Iorgos Tonepohl", "Aerified" },
                    { 93, 1999, "Otho Huntington", "Flexidy" },
                    { 94, 1995, "Gwenni Robard", "Duobam" },
                    { 95, 1954, "Floyd Powlesland", "Trippledex" },
                    { 96, 2004, "Reginauld Ragdale", "Aerified" },
                    { 97, 2004, "Arel Abeau", "Kanlam" },
                    { 98, 1984, "Jacinthe Barnshaw", "Zamit" },
                    { 99, 1994, "Ramsay Stenners", "Y-Solowarm" },
                    { 100, 2003, "Ferris Jandl", "Hatity" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Libros",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Libros",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Libros",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Libros",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Libros",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Libros",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Libros",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Libros",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Libros",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Libros",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Libros",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Libros",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Libros",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Libros",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Libros",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Libros",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Libros",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Libros",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Libros",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Libros",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Libros",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Libros",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Libros",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Libros",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Libros",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Libros",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Libros",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Libros",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Libros",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Libros",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Libros",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Libros",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Libros",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Libros",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Libros",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Libros",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Libros",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Libros",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Libros",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Libros",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Libros",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Libros",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Libros",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Libros",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Libros",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Libros",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Libros",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Libros",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Libros",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Libros",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Libros",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Libros",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Libros",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Libros",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Libros",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Libros",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Libros",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Libros",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Libros",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Libros",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Libros",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Libros",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Libros",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Libros",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Libros",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Libros",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Libros",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Libros",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Libros",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Libros",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Libros",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Libros",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Libros",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Libros",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Libros",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Libros",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Libros",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Libros",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Libros",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Libros",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Libros",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Libros",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Libros",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Libros",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Libros",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Libros",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Libros",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Libros",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Libros",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Libros",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Libros",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Libros",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Libros",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Libros",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Libros",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Libros",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Libros",
                keyColumn: "Id",
                keyValue: 100);
        }
    }
}
