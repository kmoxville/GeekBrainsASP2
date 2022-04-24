using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PersonsWebApp.Migrations
{
    public partial class AddUsersRole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Role",
                table: "Users",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 4,
                column: "BirthdayDate",
                value: new DateTime(1999, 4, 24, 16, 20, 39, 893, DateTimeKind.Utc).AddTicks(3561));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 10,
                column: "BirthdayDate",
                value: new DateTime(1963, 4, 24, 16, 20, 39, 893, DateTimeKind.Utc).AddTicks(3573));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 11,
                column: "BirthdayDate",
                value: new DateTime(1957, 4, 24, 16, 20, 39, 893, DateTimeKind.Utc).AddTicks(3574));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 12,
                column: "BirthdayDate",
                value: new DateTime(1970, 4, 24, 16, 20, 39, 893, DateTimeKind.Utc).AddTicks(3575));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 13,
                column: "BirthdayDate",
                value: new DateTime(1964, 4, 24, 16, 20, 39, 893, DateTimeKind.Utc).AddTicks(3575));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 14,
                column: "BirthdayDate",
                value: new DateTime(1993, 4, 24, 16, 20, 39, 893, DateTimeKind.Utc).AddTicks(3576));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 15,
                column: "BirthdayDate",
                value: new DateTime(1963, 4, 24, 16, 20, 39, 893, DateTimeKind.Utc).AddTicks(3577));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 16,
                column: "BirthdayDate",
                value: new DateTime(1968, 4, 24, 16, 20, 39, 893, DateTimeKind.Utc).AddTicks(3578));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 17,
                column: "BirthdayDate",
                value: new DateTime(1995, 4, 24, 16, 20, 39, 893, DateTimeKind.Utc).AddTicks(3578));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 18,
                column: "BirthdayDate",
                value: new DateTime(1997, 4, 24, 16, 20, 39, 893, DateTimeKind.Utc).AddTicks(3579));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 19,
                column: "BirthdayDate",
                value: new DateTime(1961, 4, 24, 16, 20, 39, 893, DateTimeKind.Utc).AddTicks(3580));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 20,
                column: "BirthdayDate",
                value: new DateTime(1961, 4, 24, 16, 20, 39, 893, DateTimeKind.Utc).AddTicks(3581));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 21,
                column: "BirthdayDate",
                value: new DateTime(1979, 4, 24, 16, 20, 39, 893, DateTimeKind.Utc).AddTicks(3581));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 22,
                column: "BirthdayDate",
                value: new DateTime(1974, 4, 24, 16, 20, 39, 893, DateTimeKind.Utc).AddTicks(3582));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 23,
                column: "BirthdayDate",
                value: new DateTime(1962, 4, 24, 16, 20, 39, 893, DateTimeKind.Utc).AddTicks(3583));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 24,
                column: "BirthdayDate",
                value: new DateTime(1993, 4, 24, 16, 20, 39, 893, DateTimeKind.Utc).AddTicks(3583));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 25,
                column: "BirthdayDate",
                value: new DateTime(1996, 4, 24, 16, 20, 39, 893, DateTimeKind.Utc).AddTicks(3584));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 26,
                column: "BirthdayDate",
                value: new DateTime(1974, 4, 24, 16, 20, 39, 893, DateTimeKind.Utc).AddTicks(3585));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 27,
                column: "BirthdayDate",
                value: new DateTime(1988, 4, 24, 16, 20, 39, 893, DateTimeKind.Utc).AddTicks(3586));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 28,
                column: "BirthdayDate",
                value: new DateTime(1987, 4, 24, 16, 20, 39, 893, DateTimeKind.Utc).AddTicks(3587));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 29,
                column: "BirthdayDate",
                value: new DateTime(1959, 4, 24, 16, 20, 39, 893, DateTimeKind.Utc).AddTicks(3587));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 30,
                column: "BirthdayDate",
                value: new DateTime(1983, 4, 24, 16, 20, 39, 893, DateTimeKind.Utc).AddTicks(3588));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 31,
                column: "BirthdayDate",
                value: new DateTime(1992, 4, 24, 16, 20, 39, 893, DateTimeKind.Utc).AddTicks(3589));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 32,
                column: "BirthdayDate",
                value: new DateTime(1969, 4, 24, 16, 20, 39, 893, DateTimeKind.Utc).AddTicks(3589));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 33,
                column: "BirthdayDate",
                value: new DateTime(1977, 4, 24, 16, 20, 39, 893, DateTimeKind.Utc).AddTicks(3590));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 34,
                column: "BirthdayDate",
                value: new DateTime(1973, 4, 24, 16, 20, 39, 893, DateTimeKind.Utc).AddTicks(3591));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 35,
                column: "BirthdayDate",
                value: new DateTime(1990, 4, 24, 16, 20, 39, 893, DateTimeKind.Utc).AddTicks(3591));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 36,
                column: "BirthdayDate",
                value: new DateTime(1964, 4, 24, 16, 20, 39, 893, DateTimeKind.Utc).AddTicks(3592));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 37,
                column: "BirthdayDate",
                value: new DateTime(1975, 4, 24, 16, 20, 39, 893, DateTimeKind.Utc).AddTicks(3593));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 38,
                column: "BirthdayDate",
                value: new DateTime(1982, 4, 24, 16, 20, 39, 893, DateTimeKind.Utc).AddTicks(3593));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 39,
                column: "BirthdayDate",
                value: new DateTime(1992, 4, 24, 16, 20, 39, 893, DateTimeKind.Utc).AddTicks(3594));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 40,
                column: "BirthdayDate",
                value: new DateTime(1998, 4, 24, 16, 20, 39, 893, DateTimeKind.Utc).AddTicks(3595));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 41,
                column: "BirthdayDate",
                value: new DateTime(1974, 4, 24, 16, 20, 39, 893, DateTimeKind.Utc).AddTicks(3596));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 42,
                column: "BirthdayDate",
                value: new DateTime(1974, 4, 24, 16, 20, 39, 893, DateTimeKind.Utc).AddTicks(3596));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 43,
                column: "BirthdayDate",
                value: new DateTime(1961, 4, 24, 16, 20, 39, 893, DateTimeKind.Utc).AddTicks(3597));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 44,
                column: "BirthdayDate",
                value: new DateTime(1967, 4, 24, 16, 20, 39, 893, DateTimeKind.Utc).AddTicks(3598));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 45,
                column: "BirthdayDate",
                value: new DateTime(1981, 4, 24, 16, 20, 39, 893, DateTimeKind.Utc).AddTicks(3598));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 46,
                column: "BirthdayDate",
                value: new DateTime(1967, 4, 24, 16, 20, 39, 893, DateTimeKind.Utc).AddTicks(3599));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 47,
                column: "BirthdayDate",
                value: new DateTime(1989, 4, 24, 16, 20, 39, 893, DateTimeKind.Utc).AddTicks(3600));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 48,
                column: "BirthdayDate",
                value: new DateTime(1985, 4, 24, 16, 20, 39, 893, DateTimeKind.Utc).AddTicks(3600));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 49,
                column: "BirthdayDate",
                value: new DateTime(1966, 4, 24, 16, 20, 39, 893, DateTimeKind.Utc).AddTicks(3601));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 50,
                column: "BirthdayDate",
                value: new DateTime(1998, 4, 24, 16, 20, 39, 893, DateTimeKind.Utc).AddTicks(3602));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Role",
                table: "Users");

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 4,
                column: "BirthdayDate",
                value: new DateTime(1999, 4, 24, 15, 27, 35, 160, DateTimeKind.Utc).AddTicks(2318));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 10,
                column: "BirthdayDate",
                value: new DateTime(1963, 4, 24, 15, 27, 35, 160, DateTimeKind.Utc).AddTicks(2323));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 11,
                column: "BirthdayDate",
                value: new DateTime(1957, 4, 24, 15, 27, 35, 160, DateTimeKind.Utc).AddTicks(2324));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 12,
                column: "BirthdayDate",
                value: new DateTime(1970, 4, 24, 15, 27, 35, 160, DateTimeKind.Utc).AddTicks(2325));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 13,
                column: "BirthdayDate",
                value: new DateTime(1964, 4, 24, 15, 27, 35, 160, DateTimeKind.Utc).AddTicks(2326));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 14,
                column: "BirthdayDate",
                value: new DateTime(1993, 4, 24, 15, 27, 35, 160, DateTimeKind.Utc).AddTicks(2327));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 15,
                column: "BirthdayDate",
                value: new DateTime(1963, 4, 24, 15, 27, 35, 160, DateTimeKind.Utc).AddTicks(2328));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 16,
                column: "BirthdayDate",
                value: new DateTime(1968, 4, 24, 15, 27, 35, 160, DateTimeKind.Utc).AddTicks(2328));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 17,
                column: "BirthdayDate",
                value: new DateTime(1995, 4, 24, 15, 27, 35, 160, DateTimeKind.Utc).AddTicks(2329));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 18,
                column: "BirthdayDate",
                value: new DateTime(1997, 4, 24, 15, 27, 35, 160, DateTimeKind.Utc).AddTicks(2330));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 19,
                column: "BirthdayDate",
                value: new DateTime(1961, 4, 24, 15, 27, 35, 160, DateTimeKind.Utc).AddTicks(2331));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 20,
                column: "BirthdayDate",
                value: new DateTime(1961, 4, 24, 15, 27, 35, 160, DateTimeKind.Utc).AddTicks(2331));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 21,
                column: "BirthdayDate",
                value: new DateTime(1979, 4, 24, 15, 27, 35, 160, DateTimeKind.Utc).AddTicks(2332));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 22,
                column: "BirthdayDate",
                value: new DateTime(1974, 4, 24, 15, 27, 35, 160, DateTimeKind.Utc).AddTicks(2333));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 23,
                column: "BirthdayDate",
                value: new DateTime(1962, 4, 24, 15, 27, 35, 160, DateTimeKind.Utc).AddTicks(2334));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 24,
                column: "BirthdayDate",
                value: new DateTime(1993, 4, 24, 15, 27, 35, 160, DateTimeKind.Utc).AddTicks(2334));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 25,
                column: "BirthdayDate",
                value: new DateTime(1996, 4, 24, 15, 27, 35, 160, DateTimeKind.Utc).AddTicks(2335));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 26,
                column: "BirthdayDate",
                value: new DateTime(1974, 4, 24, 15, 27, 35, 160, DateTimeKind.Utc).AddTicks(2336));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 27,
                column: "BirthdayDate",
                value: new DateTime(1988, 4, 24, 15, 27, 35, 160, DateTimeKind.Utc).AddTicks(2337));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 28,
                column: "BirthdayDate",
                value: new DateTime(1987, 4, 24, 15, 27, 35, 160, DateTimeKind.Utc).AddTicks(2338));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 29,
                column: "BirthdayDate",
                value: new DateTime(1959, 4, 24, 15, 27, 35, 160, DateTimeKind.Utc).AddTicks(2339));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 30,
                column: "BirthdayDate",
                value: new DateTime(1983, 4, 24, 15, 27, 35, 160, DateTimeKind.Utc).AddTicks(2339));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 31,
                column: "BirthdayDate",
                value: new DateTime(1992, 4, 24, 15, 27, 35, 160, DateTimeKind.Utc).AddTicks(2340));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 32,
                column: "BirthdayDate",
                value: new DateTime(1969, 4, 24, 15, 27, 35, 160, DateTimeKind.Utc).AddTicks(2342));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 33,
                column: "BirthdayDate",
                value: new DateTime(1977, 4, 24, 15, 27, 35, 160, DateTimeKind.Utc).AddTicks(2342));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 34,
                column: "BirthdayDate",
                value: new DateTime(1973, 4, 24, 15, 27, 35, 160, DateTimeKind.Utc).AddTicks(2343));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 35,
                column: "BirthdayDate",
                value: new DateTime(1990, 4, 24, 15, 27, 35, 160, DateTimeKind.Utc).AddTicks(2344));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 36,
                column: "BirthdayDate",
                value: new DateTime(1964, 4, 24, 15, 27, 35, 160, DateTimeKind.Utc).AddTicks(2345));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 37,
                column: "BirthdayDate",
                value: new DateTime(1975, 4, 24, 15, 27, 35, 160, DateTimeKind.Utc).AddTicks(2345));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 38,
                column: "BirthdayDate",
                value: new DateTime(1982, 4, 24, 15, 27, 35, 160, DateTimeKind.Utc).AddTicks(2346));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 39,
                column: "BirthdayDate",
                value: new DateTime(1992, 4, 24, 15, 27, 35, 160, DateTimeKind.Utc).AddTicks(2347));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 40,
                column: "BirthdayDate",
                value: new DateTime(1998, 4, 24, 15, 27, 35, 160, DateTimeKind.Utc).AddTicks(2348));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 41,
                column: "BirthdayDate",
                value: new DateTime(1974, 4, 24, 15, 27, 35, 160, DateTimeKind.Utc).AddTicks(2348));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 42,
                column: "BirthdayDate",
                value: new DateTime(1974, 4, 24, 15, 27, 35, 160, DateTimeKind.Utc).AddTicks(2349));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 43,
                column: "BirthdayDate",
                value: new DateTime(1961, 4, 24, 15, 27, 35, 160, DateTimeKind.Utc).AddTicks(2350));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 44,
                column: "BirthdayDate",
                value: new DateTime(1967, 4, 24, 15, 27, 35, 160, DateTimeKind.Utc).AddTicks(2350));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 45,
                column: "BirthdayDate",
                value: new DateTime(1981, 4, 24, 15, 27, 35, 160, DateTimeKind.Utc).AddTicks(2351));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 46,
                column: "BirthdayDate",
                value: new DateTime(1967, 4, 24, 15, 27, 35, 160, DateTimeKind.Utc).AddTicks(2352));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 47,
                column: "BirthdayDate",
                value: new DateTime(1989, 4, 24, 15, 27, 35, 160, DateTimeKind.Utc).AddTicks(2352));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 48,
                column: "BirthdayDate",
                value: new DateTime(1985, 4, 24, 15, 27, 35, 160, DateTimeKind.Utc).AddTicks(2353));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 49,
                column: "BirthdayDate",
                value: new DateTime(1966, 4, 24, 15, 27, 35, 160, DateTimeKind.Utc).AddTicks(2354));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 50,
                column: "BirthdayDate",
                value: new DateTime(1998, 4, 24, 15, 27, 35, 160, DateTimeKind.Utc).AddTicks(2355));
        }
    }
}
