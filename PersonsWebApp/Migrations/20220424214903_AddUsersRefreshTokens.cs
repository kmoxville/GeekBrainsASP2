using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PersonsWebApp.Migrations
{
    public partial class AddUsersRefreshTokens : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RefreshTokens",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserEntityId = table.Column<int>(type: "int", nullable: false),
                    Token = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefreshTokens", x => new { x.UserEntityId, x.Id });
                    table.ForeignKey(
                        name: "FK_RefreshTokens_Users_UserEntityId",
                        column: x => x.UserEntityId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 4,
                column: "BirthdayDate",
                value: new DateTime(1999, 4, 24, 21, 49, 3, 515, DateTimeKind.Utc).AddTicks(4610));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 10,
                column: "BirthdayDate",
                value: new DateTime(1963, 4, 24, 21, 49, 3, 515, DateTimeKind.Utc).AddTicks(4617));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 11,
                column: "BirthdayDate",
                value: new DateTime(1957, 4, 24, 21, 49, 3, 515, DateTimeKind.Utc).AddTicks(4617));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 12,
                column: "BirthdayDate",
                value: new DateTime(1970, 4, 24, 21, 49, 3, 515, DateTimeKind.Utc).AddTicks(4618));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 13,
                column: "BirthdayDate",
                value: new DateTime(1964, 4, 24, 21, 49, 3, 515, DateTimeKind.Utc).AddTicks(4619));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 14,
                column: "BirthdayDate",
                value: new DateTime(1993, 4, 24, 21, 49, 3, 515, DateTimeKind.Utc).AddTicks(4620));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 15,
                column: "BirthdayDate",
                value: new DateTime(1963, 4, 24, 21, 49, 3, 515, DateTimeKind.Utc).AddTicks(4621));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 16,
                column: "BirthdayDate",
                value: new DateTime(1968, 4, 24, 21, 49, 3, 515, DateTimeKind.Utc).AddTicks(4622));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 17,
                column: "BirthdayDate",
                value: new DateTime(1995, 4, 24, 21, 49, 3, 515, DateTimeKind.Utc).AddTicks(4623));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 18,
                column: "BirthdayDate",
                value: new DateTime(1997, 4, 24, 21, 49, 3, 515, DateTimeKind.Utc).AddTicks(4624));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 19,
                column: "BirthdayDate",
                value: new DateTime(1961, 4, 24, 21, 49, 3, 515, DateTimeKind.Utc).AddTicks(4624));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 20,
                column: "BirthdayDate",
                value: new DateTime(1961, 4, 24, 21, 49, 3, 515, DateTimeKind.Utc).AddTicks(4625));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 21,
                column: "BirthdayDate",
                value: new DateTime(1979, 4, 24, 21, 49, 3, 515, DateTimeKind.Utc).AddTicks(4626));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 22,
                column: "BirthdayDate",
                value: new DateTime(1974, 4, 24, 21, 49, 3, 515, DateTimeKind.Utc).AddTicks(4626));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 23,
                column: "BirthdayDate",
                value: new DateTime(1962, 4, 24, 21, 49, 3, 515, DateTimeKind.Utc).AddTicks(4627));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 24,
                column: "BirthdayDate",
                value: new DateTime(1993, 4, 24, 21, 49, 3, 515, DateTimeKind.Utc).AddTicks(4629));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 25,
                column: "BirthdayDate",
                value: new DateTime(1996, 4, 24, 21, 49, 3, 515, DateTimeKind.Utc).AddTicks(4629));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 26,
                column: "BirthdayDate",
                value: new DateTime(1974, 4, 24, 21, 49, 3, 515, DateTimeKind.Utc).AddTicks(4630));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 27,
                column: "BirthdayDate",
                value: new DateTime(1988, 4, 24, 21, 49, 3, 515, DateTimeKind.Utc).AddTicks(4631));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 28,
                column: "BirthdayDate",
                value: new DateTime(1987, 4, 24, 21, 49, 3, 515, DateTimeKind.Utc).AddTicks(4632));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 29,
                column: "BirthdayDate",
                value: new DateTime(1959, 4, 24, 21, 49, 3, 515, DateTimeKind.Utc).AddTicks(4633));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 30,
                column: "BirthdayDate",
                value: new DateTime(1983, 4, 24, 21, 49, 3, 515, DateTimeKind.Utc).AddTicks(4634));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 31,
                column: "BirthdayDate",
                value: new DateTime(1992, 4, 24, 21, 49, 3, 515, DateTimeKind.Utc).AddTicks(4635));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 32,
                column: "BirthdayDate",
                value: new DateTime(1969, 4, 24, 21, 49, 3, 515, DateTimeKind.Utc).AddTicks(4637));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 33,
                column: "BirthdayDate",
                value: new DateTime(1977, 4, 24, 21, 49, 3, 515, DateTimeKind.Utc).AddTicks(4637));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 34,
                column: "BirthdayDate",
                value: new DateTime(1973, 4, 24, 21, 49, 3, 515, DateTimeKind.Utc).AddTicks(4638));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 35,
                column: "BirthdayDate",
                value: new DateTime(1990, 4, 24, 21, 49, 3, 515, DateTimeKind.Utc).AddTicks(4639));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 36,
                column: "BirthdayDate",
                value: new DateTime(1964, 4, 24, 21, 49, 3, 515, DateTimeKind.Utc).AddTicks(4640));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 37,
                column: "BirthdayDate",
                value: new DateTime(1975, 4, 24, 21, 49, 3, 515, DateTimeKind.Utc).AddTicks(4641));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 38,
                column: "BirthdayDate",
                value: new DateTime(1982, 4, 24, 21, 49, 3, 515, DateTimeKind.Utc).AddTicks(4642));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 39,
                column: "BirthdayDate",
                value: new DateTime(1992, 4, 24, 21, 49, 3, 515, DateTimeKind.Utc).AddTicks(4642));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 40,
                column: "BirthdayDate",
                value: new DateTime(1998, 4, 24, 21, 49, 3, 515, DateTimeKind.Utc).AddTicks(4644));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 41,
                column: "BirthdayDate",
                value: new DateTime(1974, 4, 24, 21, 49, 3, 515, DateTimeKind.Utc).AddTicks(4645));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 42,
                column: "BirthdayDate",
                value: new DateTime(1974, 4, 24, 21, 49, 3, 515, DateTimeKind.Utc).AddTicks(4645));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 43,
                column: "BirthdayDate",
                value: new DateTime(1961, 4, 24, 21, 49, 3, 515, DateTimeKind.Utc).AddTicks(4646));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 44,
                column: "BirthdayDate",
                value: new DateTime(1967, 4, 24, 21, 49, 3, 515, DateTimeKind.Utc).AddTicks(4647));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 45,
                column: "BirthdayDate",
                value: new DateTime(1981, 4, 24, 21, 49, 3, 515, DateTimeKind.Utc).AddTicks(4648));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 46,
                column: "BirthdayDate",
                value: new DateTime(1967, 4, 24, 21, 49, 3, 515, DateTimeKind.Utc).AddTicks(4649));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 47,
                column: "BirthdayDate",
                value: new DateTime(1989, 4, 24, 21, 49, 3, 515, DateTimeKind.Utc).AddTicks(4649));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 48,
                column: "BirthdayDate",
                value: new DateTime(1985, 4, 24, 21, 49, 3, 515, DateTimeKind.Utc).AddTicks(4654));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 49,
                column: "BirthdayDate",
                value: new DateTime(1966, 4, 24, 21, 49, 3, 515, DateTimeKind.Utc).AddTicks(4654));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 50,
                column: "BirthdayDate",
                value: new DateTime(1998, 4, 24, 21, 49, 3, 515, DateTimeKind.Utc).AddTicks(4655));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DeleteDate", "IsDeleted", "Password", "Role", "Username" },
                values: new object[] { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "pwd", "admin", "root" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RefreshTokens");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

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
    }
}
