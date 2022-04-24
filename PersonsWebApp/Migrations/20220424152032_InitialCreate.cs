using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PersonsWebApp.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Persons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LastName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Company = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    BirthdayDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "BirthdayDate", "Company", "DeleteDate", "Email", "FirstName", "IsDeleted", "LastName" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Quisque Ac Libero LLP", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ligula@necluctus.edu", "Veda", false, "Richmond" },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nulla Facilisi Foundation", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "feugiat.metus@penatibuset.org", "Demetria", false, "Andrews" },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Et Associates", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "neque.Sed.eget@non.co.uk", "Byron", false, "Holmes" },
                    { 4, new DateTime(1999, 4, 24, 15, 20, 32, 874, DateTimeKind.Utc).AddTicks(3752), "Vel Institute", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "egestas.ligula@ultricesDuisvolutpat.ca", "Alexander", false, "Cummings" },
                    { 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eu Nibh Vulputate Company", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "justo.nec.ante@nonummyFusce.ca", "Melinda", false, "Miles" },
                    { 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nec Diam Incorporated", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "iaculis@afeugiat.edu", "Dustin", false, "Beck" },
                    { 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Enim Corp.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ipsum@vulputatelacus.co.uk", "Ralph", false, "Maddox" },
                    { 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sodales At Velit Corp.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "lectus.a.sollicitudin@nuncQuisque.com", "Levi", false, "Zamora" },
                    { 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Id Mollis Nec LLC", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Phasellus@Craspellentesque.org", "Driscoll", false, "Estrada" },
                    { 10, new DateTime(1963, 4, 24, 15, 20, 32, 874, DateTimeKind.Utc).AddTicks(3762), "Donec Tincidunt Donec Industries", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "lacus.Mauris@semper.ca", "Hiram", false, "Mejia" },
                    { 11, new DateTime(1957, 4, 24, 15, 20, 32, 874, DateTimeKind.Utc).AddTicks(3762), "Lectus Justo Ltd", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Integer.vitae.nibh@nibh.co.uk", "Mason", false, "Jefferson" },
                    { 12, new DateTime(1970, 4, 24, 15, 20, 32, 874, DateTimeKind.Utc).AddTicks(3763), "Tristique Ac Ltd", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "id@faucibusleoin.net", "Nigel", false, "Rich" },
                    { 13, new DateTime(1964, 4, 24, 15, 20, 32, 874, DateTimeKind.Utc).AddTicks(3764), "Lacus Varius Et Associates", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "enim@ultricesDuisvolutpat.edu", "Tarik", false, "Hughes" },
                    { 14, new DateTime(1993, 4, 24, 15, 20, 32, 874, DateTimeKind.Utc).AddTicks(3765), "Rhoncus Id Corporation", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Curabitur.ut.odio@anteMaecenasmi.co.uk", "Wallace", false, "Gross" },
                    { 15, new DateTime(1963, 4, 24, 15, 20, 32, 874, DateTimeKind.Utc).AddTicks(3766), "Vivamus Corporation", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "magna.nec.quam@lobortis.net", "Arden", false, "Rivers" },
                    { 16, new DateTime(1968, 4, 24, 15, 20, 32, 874, DateTimeKind.Utc).AddTicks(3766), "Imperdiet Dictum Magna Foundation", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "faucibus.Morbi.vehicula@ipsumdolor.edu", "Vincent", false, "Fox" },
                    { 17, new DateTime(1995, 4, 24, 15, 20, 32, 874, DateTimeKind.Utc).AddTicks(3767), "Mattis Foundation", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ac@scelerisquesedsapien.org", "Aphrodite", false, "Randolph" },
                    { 18, new DateTime(1997, 4, 24, 15, 20, 32, 874, DateTimeKind.Utc).AddTicks(3768), "Rutrum Non Hendrerit Consulting", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "montes@scelerisque.edu", "Alisa", false, "Riggs" },
                    { 19, new DateTime(1961, 4, 24, 15, 20, 32, 874, DateTimeKind.Utc).AddTicks(3769), "Ut LLC", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "velit.Quisque.varius@aliquetmolestie.net", "Jaime", false, "Lott" },
                    { 20, new DateTime(1961, 4, 24, 15, 20, 32, 874, DateTimeKind.Utc).AddTicks(3769), "Curabitur Sed Tortor Ltd", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "arcu.eu.odio@congue.ca", "Jamalia", false, "Buchanan" },
                    { 21, new DateTime(1979, 4, 24, 15, 20, 32, 874, DateTimeKind.Utc).AddTicks(3770), "In Inc.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Integer.sem.elit@bibendumsedest.net", "Raya", false, "Mckenzie" },
                    { 22, new DateTime(1974, 4, 24, 15, 20, 32, 874, DateTimeKind.Utc).AddTicks(3772), "Nec Foundation", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cras.eget.nisi@Vestibulum.edu", "Dante", false, "Blackwell" },
                    { 23, new DateTime(1962, 4, 24, 15, 20, 32, 874, DateTimeKind.Utc).AddTicks(3773), "Augue Scelerisque Institute", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "facilisis@doloregestas.co.uk", "Kato", false, "Dickson" },
                    { 24, new DateTime(1993, 4, 24, 15, 20, 32, 874, DateTimeKind.Utc).AddTicks(3773), "Dui Augue Eu Limited", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "tincidunt@eget.edu", "Clio", false, "Shaffer" },
                    { 25, new DateTime(1996, 4, 24, 15, 20, 32, 874, DateTimeKind.Utc).AddTicks(3774), "Enim Incorporated", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "magna@felisegetvarius.net", "Hamilton", false, "Kidd" },
                    { 26, new DateTime(1974, 4, 24, 15, 20, 32, 874, DateTimeKind.Utc).AddTicks(3775), "Interdum Inc.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Suspendisse.eleifend@Crasdolor.com", "Kerry", false, "Oneil" },
                    { 27, new DateTime(1988, 4, 24, 15, 20, 32, 874, DateTimeKind.Utc).AddTicks(3776), "Facilisis Eget Ipsum Inc.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "elit.pretium.et@malesuadafamesac.com", "Mohammad", false, "Thompson" },
                    { 28, new DateTime(1987, 4, 24, 15, 20, 32, 874, DateTimeKind.Utc).AddTicks(3776), "Iaculis Quis Consulting", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "felis@conguea.org", "Vernon", false, "Cardenas" },
                    { 29, new DateTime(1959, 4, 24, 15, 20, 32, 874, DateTimeKind.Utc).AddTicks(3777), "Integer Urna Institute", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Proin@feugiatnecdiam.org", "Murphy", false, "Weaver" },
                    { 30, new DateTime(1983, 4, 24, 15, 20, 32, 874, DateTimeKind.Utc).AddTicks(3778), "Orci Industries", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "facilisis.facilisis.magna@loremutaliquam.net", "Xena", false, "Hart" },
                    { 31, new DateTime(1992, 4, 24, 15, 20, 32, 874, DateTimeKind.Utc).AddTicks(3779), "Ante Foundation", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Proin.ultrices.Duis@lacuspede.com", "Ivor", false, "Lara" },
                    { 32, new DateTime(1969, 4, 24, 15, 20, 32, 874, DateTimeKind.Utc).AddTicks(3779), "Eget Industries", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "et.magnis@Sed.edu", "Dana", false, "Merritt" },
                    { 33, new DateTime(1977, 4, 24, 15, 20, 32, 874, DateTimeKind.Utc).AddTicks(3780), "Lorem Vehicula Et Foundation", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "elit.Nulla@magna.edu", "Brielle", false, "Woodward" },
                    { 34, new DateTime(1973, 4, 24, 15, 20, 32, 874, DateTimeKind.Utc).AddTicks(3781), "Magna Suspendisse Consulting", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "et@nislsem.co.uk", "Hasad", false, "Duran" },
                    { 35, new DateTime(1990, 4, 24, 15, 20, 32, 874, DateTimeKind.Utc).AddTicks(3782), "Eros Institute", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Proin.sed.turpis@imperdiet.co.uk", "Quamar", false, "Moses" },
                    { 36, new DateTime(1964, 4, 24, 15, 20, 32, 874, DateTimeKind.Utc).AddTicks(3782), "Aenean Massa Consulting", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "nisl.sem.consequat@idnunc.co.uk", "Scarlet", false, "Barlow" },
                    { 37, new DateTime(1975, 4, 24, 15, 20, 32, 874, DateTimeKind.Utc).AddTicks(3783), "Mauris Associates", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "urna@mauris.org", "Courtney", false, "Foley" },
                    { 38, new DateTime(1982, 4, 24, 15, 20, 32, 874, DateTimeKind.Utc).AddTicks(3784), "Id Nunc Interdum LLC", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cras@Nullam.org", "Kennedy", false, "Shields" },
                    { 39, new DateTime(1992, 4, 24, 15, 20, 32, 874, DateTimeKind.Utc).AddTicks(3785), "Pellentesque Ultricies Associates", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "metus.sit@lorem.ca", "Eve", false, "Maynard" },
                    { 40, new DateTime(1998, 4, 24, 15, 20, 32, 874, DateTimeKind.Utc).AddTicks(3785), "Nulla Tincidunt Industries", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nullam@pretium.ca", "Debra", false, "Ellis" },
                    { 41, new DateTime(1974, 4, 24, 15, 20, 32, 874, DateTimeKind.Utc).AddTicks(3786), "Id Consulting", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ornare@at.net", "Vivian", false, "Mcguire" },
                    { 42, new DateTime(1974, 4, 24, 15, 20, 32, 874, DateTimeKind.Utc).AddTicks(3787), "Netus Et Inc.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "tempor.augue@purusNullam.com", "Jason", false, "Mckinney" },
                    { 43, new DateTime(1961, 4, 24, 15, 20, 32, 874, DateTimeKind.Utc).AddTicks(3788), "Hendrerit Institute", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "fringilla@Proinsed.co.uk", "Patrick", false, "Small" },
                    { 44, new DateTime(1967, 4, 24, 15, 20, 32, 874, DateTimeKind.Utc).AddTicks(3788), "Penatibus Corp.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "scelerisque.scelerisque@velit.org", "Drew", false, "Travis" },
                    { 45, new DateTime(1981, 4, 24, 15, 20, 32, 874, DateTimeKind.Utc).AddTicks(3789), "Quis Diam Pellentesque PC", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Suspendisse@aliquet.net", "Burke", false, "Miller" },
                    { 46, new DateTime(1967, 4, 24, 15, 20, 32, 874, DateTimeKind.Utc).AddTicks(3790), "Lorem Ipsum Dolor Corp.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Class.aptent.taciti@mauris.edu", "Ralph", false, "Medina" },
                    { 47, new DateTime(1989, 4, 24, 15, 20, 32, 874, DateTimeKind.Utc).AddTicks(3790), "Euismod Est Arcu Institute", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "at.velit.Cras@aptenttacitisociosqu.net", "Alana", false, "Madden" },
                    { 48, new DateTime(1985, 4, 24, 15, 20, 32, 874, DateTimeKind.Utc).AddTicks(3791), "Purus PC", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "magna.Duis@Phasellus.org", "Salvador", false, "Cohen" },
                    { 49, new DateTime(1966, 4, 24, 15, 20, 32, 874, DateTimeKind.Utc).AddTicks(3792), "Lectus Justo Incorporated", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "adipiscing.Mauris.molestie@liberoduinec.ca", "Jenette", false, "Dejesus" },
                    { 50, new DateTime(1998, 4, 24, 15, 20, 32, 874, DateTimeKind.Utc).AddTicks(3792), "Imperdiet Dictum LLP", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "massa.Vestibulum@lectuspede.ca", "Ramona", false, "Gilliam" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Persons");
        }
    }
}
