using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement1.Server.Data.Migrations
{
    public partial class AddColourSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Colours",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[] { 1, "System", new DateTime(2022, 11, 28, 22, 8, 46, 289, DateTimeKind.Local).AddTicks(3556), new DateTime(2022, 11, 28, 22, 8, 46, 290, DateTimeKind.Local).AddTicks(1977), "Black", "System" });

            migrationBuilder.InsertData(
                table: "Colours",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[] { 2, "System", new DateTime(2022, 11, 28, 22, 8, 46, 290, DateTimeKind.Local).AddTicks(2445), new DateTime(2022, 11, 28, 22, 8, 46, 290, DateTimeKind.Local).AddTicks(2448), "Blue", "System" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
