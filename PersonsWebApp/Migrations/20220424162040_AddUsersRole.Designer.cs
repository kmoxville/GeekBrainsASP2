﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PersonsWebApp.DAL;

#nullable disable

namespace PersonsWebApp.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20220424162040_AddUsersRole")]
    partial class AddUsersRole
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("PersonsWebApp.DAL.Entities.PersonEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("BirthdayDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Company")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("DeleteDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Persons");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BirthdayDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Company = "Quisque Ac Libero LLP",
                            DeleteDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "ligula@necluctus.edu",
                            FirstName = "Veda",
                            IsDeleted = false,
                            LastName = "Richmond"
                        },
                        new
                        {
                            Id = 2,
                            BirthdayDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Company = "Nulla Facilisi Foundation",
                            DeleteDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "feugiat.metus@penatibuset.org",
                            FirstName = "Demetria",
                            IsDeleted = false,
                            LastName = "Andrews"
                        },
                        new
                        {
                            Id = 3,
                            BirthdayDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Company = "Et Associates",
                            DeleteDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "neque.Sed.eget@non.co.uk",
                            FirstName = "Byron",
                            IsDeleted = false,
                            LastName = "Holmes"
                        },
                        new
                        {
                            Id = 4,
                            BirthdayDate = new DateTime(1999, 4, 24, 16, 20, 39, 893, DateTimeKind.Utc).AddTicks(3561),
                            Company = "Vel Institute",
                            DeleteDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "egestas.ligula@ultricesDuisvolutpat.ca",
                            FirstName = "Alexander",
                            IsDeleted = false,
                            LastName = "Cummings"
                        },
                        new
                        {
                            Id = 5,
                            BirthdayDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Company = "Eu Nibh Vulputate Company",
                            DeleteDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "justo.nec.ante@nonummyFusce.ca",
                            FirstName = "Melinda",
                            IsDeleted = false,
                            LastName = "Miles"
                        },
                        new
                        {
                            Id = 6,
                            BirthdayDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Company = "Nec Diam Incorporated",
                            DeleteDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "iaculis@afeugiat.edu",
                            FirstName = "Dustin",
                            IsDeleted = false,
                            LastName = "Beck"
                        },
                        new
                        {
                            Id = 7,
                            BirthdayDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Company = "Enim Corp.",
                            DeleteDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "ipsum@vulputatelacus.co.uk",
                            FirstName = "Ralph",
                            IsDeleted = false,
                            LastName = "Maddox"
                        },
                        new
                        {
                            Id = 8,
                            BirthdayDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Company = "Sodales At Velit Corp.",
                            DeleteDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "lectus.a.sollicitudin@nuncQuisque.com",
                            FirstName = "Levi",
                            IsDeleted = false,
                            LastName = "Zamora"
                        },
                        new
                        {
                            Id = 9,
                            BirthdayDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Company = "Id Mollis Nec LLC",
                            DeleteDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Phasellus@Craspellentesque.org",
                            FirstName = "Driscoll",
                            IsDeleted = false,
                            LastName = "Estrada"
                        },
                        new
                        {
                            Id = 10,
                            BirthdayDate = new DateTime(1963, 4, 24, 16, 20, 39, 893, DateTimeKind.Utc).AddTicks(3573),
                            Company = "Donec Tincidunt Donec Industries",
                            DeleteDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "lacus.Mauris@semper.ca",
                            FirstName = "Hiram",
                            IsDeleted = false,
                            LastName = "Mejia"
                        },
                        new
                        {
                            Id = 11,
                            BirthdayDate = new DateTime(1957, 4, 24, 16, 20, 39, 893, DateTimeKind.Utc).AddTicks(3574),
                            Company = "Lectus Justo Ltd",
                            DeleteDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Integer.vitae.nibh@nibh.co.uk",
                            FirstName = "Mason",
                            IsDeleted = false,
                            LastName = "Jefferson"
                        },
                        new
                        {
                            Id = 12,
                            BirthdayDate = new DateTime(1970, 4, 24, 16, 20, 39, 893, DateTimeKind.Utc).AddTicks(3575),
                            Company = "Tristique Ac Ltd",
                            DeleteDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "id@faucibusleoin.net",
                            FirstName = "Nigel",
                            IsDeleted = false,
                            LastName = "Rich"
                        },
                        new
                        {
                            Id = 13,
                            BirthdayDate = new DateTime(1964, 4, 24, 16, 20, 39, 893, DateTimeKind.Utc).AddTicks(3575),
                            Company = "Lacus Varius Et Associates",
                            DeleteDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "enim@ultricesDuisvolutpat.edu",
                            FirstName = "Tarik",
                            IsDeleted = false,
                            LastName = "Hughes"
                        },
                        new
                        {
                            Id = 14,
                            BirthdayDate = new DateTime(1993, 4, 24, 16, 20, 39, 893, DateTimeKind.Utc).AddTicks(3576),
                            Company = "Rhoncus Id Corporation",
                            DeleteDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Curabitur.ut.odio@anteMaecenasmi.co.uk",
                            FirstName = "Wallace",
                            IsDeleted = false,
                            LastName = "Gross"
                        },
                        new
                        {
                            Id = 15,
                            BirthdayDate = new DateTime(1963, 4, 24, 16, 20, 39, 893, DateTimeKind.Utc).AddTicks(3577),
                            Company = "Vivamus Corporation",
                            DeleteDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "magna.nec.quam@lobortis.net",
                            FirstName = "Arden",
                            IsDeleted = false,
                            LastName = "Rivers"
                        },
                        new
                        {
                            Id = 16,
                            BirthdayDate = new DateTime(1968, 4, 24, 16, 20, 39, 893, DateTimeKind.Utc).AddTicks(3578),
                            Company = "Imperdiet Dictum Magna Foundation",
                            DeleteDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "faucibus.Morbi.vehicula@ipsumdolor.edu",
                            FirstName = "Vincent",
                            IsDeleted = false,
                            LastName = "Fox"
                        },
                        new
                        {
                            Id = 17,
                            BirthdayDate = new DateTime(1995, 4, 24, 16, 20, 39, 893, DateTimeKind.Utc).AddTicks(3578),
                            Company = "Mattis Foundation",
                            DeleteDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "ac@scelerisquesedsapien.org",
                            FirstName = "Aphrodite",
                            IsDeleted = false,
                            LastName = "Randolph"
                        },
                        new
                        {
                            Id = 18,
                            BirthdayDate = new DateTime(1997, 4, 24, 16, 20, 39, 893, DateTimeKind.Utc).AddTicks(3579),
                            Company = "Rutrum Non Hendrerit Consulting",
                            DeleteDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "montes@scelerisque.edu",
                            FirstName = "Alisa",
                            IsDeleted = false,
                            LastName = "Riggs"
                        },
                        new
                        {
                            Id = 19,
                            BirthdayDate = new DateTime(1961, 4, 24, 16, 20, 39, 893, DateTimeKind.Utc).AddTicks(3580),
                            Company = "Ut LLC",
                            DeleteDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "velit.Quisque.varius@aliquetmolestie.net",
                            FirstName = "Jaime",
                            IsDeleted = false,
                            LastName = "Lott"
                        },
                        new
                        {
                            Id = 20,
                            BirthdayDate = new DateTime(1961, 4, 24, 16, 20, 39, 893, DateTimeKind.Utc).AddTicks(3581),
                            Company = "Curabitur Sed Tortor Ltd",
                            DeleteDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "arcu.eu.odio@congue.ca",
                            FirstName = "Jamalia",
                            IsDeleted = false,
                            LastName = "Buchanan"
                        },
                        new
                        {
                            Id = 21,
                            BirthdayDate = new DateTime(1979, 4, 24, 16, 20, 39, 893, DateTimeKind.Utc).AddTicks(3581),
                            Company = "In Inc.",
                            DeleteDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Integer.sem.elit@bibendumsedest.net",
                            FirstName = "Raya",
                            IsDeleted = false,
                            LastName = "Mckenzie"
                        },
                        new
                        {
                            Id = 22,
                            BirthdayDate = new DateTime(1974, 4, 24, 16, 20, 39, 893, DateTimeKind.Utc).AddTicks(3582),
                            Company = "Nec Foundation",
                            DeleteDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Cras.eget.nisi@Vestibulum.edu",
                            FirstName = "Dante",
                            IsDeleted = false,
                            LastName = "Blackwell"
                        },
                        new
                        {
                            Id = 23,
                            BirthdayDate = new DateTime(1962, 4, 24, 16, 20, 39, 893, DateTimeKind.Utc).AddTicks(3583),
                            Company = "Augue Scelerisque Institute",
                            DeleteDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "facilisis@doloregestas.co.uk",
                            FirstName = "Kato",
                            IsDeleted = false,
                            LastName = "Dickson"
                        },
                        new
                        {
                            Id = 24,
                            BirthdayDate = new DateTime(1993, 4, 24, 16, 20, 39, 893, DateTimeKind.Utc).AddTicks(3583),
                            Company = "Dui Augue Eu Limited",
                            DeleteDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "tincidunt@eget.edu",
                            FirstName = "Clio",
                            IsDeleted = false,
                            LastName = "Shaffer"
                        },
                        new
                        {
                            Id = 25,
                            BirthdayDate = new DateTime(1996, 4, 24, 16, 20, 39, 893, DateTimeKind.Utc).AddTicks(3584),
                            Company = "Enim Incorporated",
                            DeleteDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "magna@felisegetvarius.net",
                            FirstName = "Hamilton",
                            IsDeleted = false,
                            LastName = "Kidd"
                        },
                        new
                        {
                            Id = 26,
                            BirthdayDate = new DateTime(1974, 4, 24, 16, 20, 39, 893, DateTimeKind.Utc).AddTicks(3585),
                            Company = "Interdum Inc.",
                            DeleteDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Suspendisse.eleifend@Crasdolor.com",
                            FirstName = "Kerry",
                            IsDeleted = false,
                            LastName = "Oneil"
                        },
                        new
                        {
                            Id = 27,
                            BirthdayDate = new DateTime(1988, 4, 24, 16, 20, 39, 893, DateTimeKind.Utc).AddTicks(3586),
                            Company = "Facilisis Eget Ipsum Inc.",
                            DeleteDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "elit.pretium.et@malesuadafamesac.com",
                            FirstName = "Mohammad",
                            IsDeleted = false,
                            LastName = "Thompson"
                        },
                        new
                        {
                            Id = 28,
                            BirthdayDate = new DateTime(1987, 4, 24, 16, 20, 39, 893, DateTimeKind.Utc).AddTicks(3587),
                            Company = "Iaculis Quis Consulting",
                            DeleteDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "felis@conguea.org",
                            FirstName = "Vernon",
                            IsDeleted = false,
                            LastName = "Cardenas"
                        },
                        new
                        {
                            Id = 29,
                            BirthdayDate = new DateTime(1959, 4, 24, 16, 20, 39, 893, DateTimeKind.Utc).AddTicks(3587),
                            Company = "Integer Urna Institute",
                            DeleteDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Proin@feugiatnecdiam.org",
                            FirstName = "Murphy",
                            IsDeleted = false,
                            LastName = "Weaver"
                        },
                        new
                        {
                            Id = 30,
                            BirthdayDate = new DateTime(1983, 4, 24, 16, 20, 39, 893, DateTimeKind.Utc).AddTicks(3588),
                            Company = "Orci Industries",
                            DeleteDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "facilisis.facilisis.magna@loremutaliquam.net",
                            FirstName = "Xena",
                            IsDeleted = false,
                            LastName = "Hart"
                        },
                        new
                        {
                            Id = 31,
                            BirthdayDate = new DateTime(1992, 4, 24, 16, 20, 39, 893, DateTimeKind.Utc).AddTicks(3589),
                            Company = "Ante Foundation",
                            DeleteDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Proin.ultrices.Duis@lacuspede.com",
                            FirstName = "Ivor",
                            IsDeleted = false,
                            LastName = "Lara"
                        },
                        new
                        {
                            Id = 32,
                            BirthdayDate = new DateTime(1969, 4, 24, 16, 20, 39, 893, DateTimeKind.Utc).AddTicks(3589),
                            Company = "Eget Industries",
                            DeleteDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "et.magnis@Sed.edu",
                            FirstName = "Dana",
                            IsDeleted = false,
                            LastName = "Merritt"
                        },
                        new
                        {
                            Id = 33,
                            BirthdayDate = new DateTime(1977, 4, 24, 16, 20, 39, 893, DateTimeKind.Utc).AddTicks(3590),
                            Company = "Lorem Vehicula Et Foundation",
                            DeleteDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "elit.Nulla@magna.edu",
                            FirstName = "Brielle",
                            IsDeleted = false,
                            LastName = "Woodward"
                        },
                        new
                        {
                            Id = 34,
                            BirthdayDate = new DateTime(1973, 4, 24, 16, 20, 39, 893, DateTimeKind.Utc).AddTicks(3591),
                            Company = "Magna Suspendisse Consulting",
                            DeleteDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "et@nislsem.co.uk",
                            FirstName = "Hasad",
                            IsDeleted = false,
                            LastName = "Duran"
                        },
                        new
                        {
                            Id = 35,
                            BirthdayDate = new DateTime(1990, 4, 24, 16, 20, 39, 893, DateTimeKind.Utc).AddTicks(3591),
                            Company = "Eros Institute",
                            DeleteDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Proin.sed.turpis@imperdiet.co.uk",
                            FirstName = "Quamar",
                            IsDeleted = false,
                            LastName = "Moses"
                        },
                        new
                        {
                            Id = 36,
                            BirthdayDate = new DateTime(1964, 4, 24, 16, 20, 39, 893, DateTimeKind.Utc).AddTicks(3592),
                            Company = "Aenean Massa Consulting",
                            DeleteDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "nisl.sem.consequat@idnunc.co.uk",
                            FirstName = "Scarlet",
                            IsDeleted = false,
                            LastName = "Barlow"
                        },
                        new
                        {
                            Id = 37,
                            BirthdayDate = new DateTime(1975, 4, 24, 16, 20, 39, 893, DateTimeKind.Utc).AddTicks(3593),
                            Company = "Mauris Associates",
                            DeleteDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "urna@mauris.org",
                            FirstName = "Courtney",
                            IsDeleted = false,
                            LastName = "Foley"
                        },
                        new
                        {
                            Id = 38,
                            BirthdayDate = new DateTime(1982, 4, 24, 16, 20, 39, 893, DateTimeKind.Utc).AddTicks(3593),
                            Company = "Id Nunc Interdum LLC",
                            DeleteDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Cras@Nullam.org",
                            FirstName = "Kennedy",
                            IsDeleted = false,
                            LastName = "Shields"
                        },
                        new
                        {
                            Id = 39,
                            BirthdayDate = new DateTime(1992, 4, 24, 16, 20, 39, 893, DateTimeKind.Utc).AddTicks(3594),
                            Company = "Pellentesque Ultricies Associates",
                            DeleteDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "metus.sit@lorem.ca",
                            FirstName = "Eve",
                            IsDeleted = false,
                            LastName = "Maynard"
                        },
                        new
                        {
                            Id = 40,
                            BirthdayDate = new DateTime(1998, 4, 24, 16, 20, 39, 893, DateTimeKind.Utc).AddTicks(3595),
                            Company = "Nulla Tincidunt Industries",
                            DeleteDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Nullam@pretium.ca",
                            FirstName = "Debra",
                            IsDeleted = false,
                            LastName = "Ellis"
                        },
                        new
                        {
                            Id = 41,
                            BirthdayDate = new DateTime(1974, 4, 24, 16, 20, 39, 893, DateTimeKind.Utc).AddTicks(3596),
                            Company = "Id Consulting",
                            DeleteDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "ornare@at.net",
                            FirstName = "Vivian",
                            IsDeleted = false,
                            LastName = "Mcguire"
                        },
                        new
                        {
                            Id = 42,
                            BirthdayDate = new DateTime(1974, 4, 24, 16, 20, 39, 893, DateTimeKind.Utc).AddTicks(3596),
                            Company = "Netus Et Inc.",
                            DeleteDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "tempor.augue@purusNullam.com",
                            FirstName = "Jason",
                            IsDeleted = false,
                            LastName = "Mckinney"
                        },
                        new
                        {
                            Id = 43,
                            BirthdayDate = new DateTime(1961, 4, 24, 16, 20, 39, 893, DateTimeKind.Utc).AddTicks(3597),
                            Company = "Hendrerit Institute",
                            DeleteDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "fringilla@Proinsed.co.uk",
                            FirstName = "Patrick",
                            IsDeleted = false,
                            LastName = "Small"
                        },
                        new
                        {
                            Id = 44,
                            BirthdayDate = new DateTime(1967, 4, 24, 16, 20, 39, 893, DateTimeKind.Utc).AddTicks(3598),
                            Company = "Penatibus Corp.",
                            DeleteDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "scelerisque.scelerisque@velit.org",
                            FirstName = "Drew",
                            IsDeleted = false,
                            LastName = "Travis"
                        },
                        new
                        {
                            Id = 45,
                            BirthdayDate = new DateTime(1981, 4, 24, 16, 20, 39, 893, DateTimeKind.Utc).AddTicks(3598),
                            Company = "Quis Diam Pellentesque PC",
                            DeleteDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Suspendisse@aliquet.net",
                            FirstName = "Burke",
                            IsDeleted = false,
                            LastName = "Miller"
                        },
                        new
                        {
                            Id = 46,
                            BirthdayDate = new DateTime(1967, 4, 24, 16, 20, 39, 893, DateTimeKind.Utc).AddTicks(3599),
                            Company = "Lorem Ipsum Dolor Corp.",
                            DeleteDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Class.aptent.taciti@mauris.edu",
                            FirstName = "Ralph",
                            IsDeleted = false,
                            LastName = "Medina"
                        },
                        new
                        {
                            Id = 47,
                            BirthdayDate = new DateTime(1989, 4, 24, 16, 20, 39, 893, DateTimeKind.Utc).AddTicks(3600),
                            Company = "Euismod Est Arcu Institute",
                            DeleteDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "at.velit.Cras@aptenttacitisociosqu.net",
                            FirstName = "Alana",
                            IsDeleted = false,
                            LastName = "Madden"
                        },
                        new
                        {
                            Id = 48,
                            BirthdayDate = new DateTime(1985, 4, 24, 16, 20, 39, 893, DateTimeKind.Utc).AddTicks(3600),
                            Company = "Purus PC",
                            DeleteDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "magna.Duis@Phasellus.org",
                            FirstName = "Salvador",
                            IsDeleted = false,
                            LastName = "Cohen"
                        },
                        new
                        {
                            Id = 49,
                            BirthdayDate = new DateTime(1966, 4, 24, 16, 20, 39, 893, DateTimeKind.Utc).AddTicks(3601),
                            Company = "Lectus Justo Incorporated",
                            DeleteDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "adipiscing.Mauris.molestie@liberoduinec.ca",
                            FirstName = "Jenette",
                            IsDeleted = false,
                            LastName = "Dejesus"
                        },
                        new
                        {
                            Id = 50,
                            BirthdayDate = new DateTime(1998, 4, 24, 16, 20, 39, 893, DateTimeKind.Utc).AddTicks(3602),
                            Company = "Imperdiet Dictum LLP",
                            DeleteDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "massa.Vestibulum@lectuspede.ca",
                            FirstName = "Ramona",
                            IsDeleted = false,
                            LastName = "Gilliam"
                        });
                });

            modelBuilder.Entity("PersonsWebApp.DAL.Entities.UserEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DeleteDate")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
