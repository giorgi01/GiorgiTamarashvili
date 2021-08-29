using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PersonManagement.Migrations
{
    public partial class third : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "FirstName", "Age", "BirthDate", "City", "Gender", "Id", "LastName", "PersonIdentifier" },
                values: new object[] { "Giorgi", 12, new DateTime(2021, 8, 13, 21, 33, 52, 696, DateTimeKind.Local).AddTicks(7465), null, false, 1, "Kashiashvili", "0100201014" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "FirstName",
                keyValue: "Giorgi");
        }
    }
}
