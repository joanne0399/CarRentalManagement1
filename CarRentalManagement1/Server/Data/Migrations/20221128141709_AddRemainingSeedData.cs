using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement1.Server.Data.Migrations
{
    public partial class AddRemainingSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 28, 22, 17, 9, 595, DateTimeKind.Local).AddTicks(6629), new DateTime(2022, 11, 28, 22, 17, 9, 596, DateTimeKind.Local).AddTicks(5425) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 28, 22, 17, 9, 596, DateTimeKind.Local).AddTicks(5955), new DateTime(2022, 11, 28, 22, 17, 9, 596, DateTimeKind.Local).AddTicks(5958) });

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2022, 11, 28, 22, 17, 9, 597, DateTimeKind.Local).AddTicks(3873), new DateTime(2022, 11, 28, 22, 17, 9, 597, DateTimeKind.Local).AddTicks(3881), "BMW", "System" },
                    { 2, "System", new DateTime(2022, 11, 28, 22, 17, 9, 597, DateTimeKind.Local).AddTicks(3884), new DateTime(2022, 11, 28, 22, 17, 9, 597, DateTimeKind.Local).AddTicks(3885), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2022, 11, 28, 22, 17, 9, 597, DateTimeKind.Local).AddTicks(6121), new DateTime(2022, 11, 28, 22, 17, 9, 597, DateTimeKind.Local).AddTicks(6127), "3 Series", "System" },
                    { 2, "System", new DateTime(2022, 11, 28, 22, 17, 9, 597, DateTimeKind.Local).AddTicks(6129), new DateTime(2022, 11, 28, 22, 17, 9, 597, DateTimeKind.Local).AddTicks(6130), "X5", "System" },
                    { 3, "System", new DateTime(2022, 11, 28, 22, 17, 9, 597, DateTimeKind.Local).AddTicks(6131), new DateTime(2022, 11, 28, 22, 17, 9, 597, DateTimeKind.Local).AddTicks(6132), "Prius", "System" },
                    { 4, "System", new DateTime(2022, 11, 28, 22, 17, 9, 597, DateTimeKind.Local).AddTicks(6133), new DateTime(2022, 11, 28, 22, 17, 9, 597, DateTimeKind.Local).AddTicks(6134), "Rav4", "System" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 28, 22, 8, 46, 289, DateTimeKind.Local).AddTicks(3556), new DateTime(2022, 11, 28, 22, 8, 46, 290, DateTimeKind.Local).AddTicks(1977) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 28, 22, 8, 46, 290, DateTimeKind.Local).AddTicks(2445), new DateTime(2022, 11, 28, 22, 8, 46, 290, DateTimeKind.Local).AddTicks(2448) });
        }
    }
}
