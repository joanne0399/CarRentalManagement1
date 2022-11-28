using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement1.Server.Data.Migrations
{
    public partial class AddIdentityUserData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "43392ded-7431-4453-a75f-c44ccb85ffc6", "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", "722185cf-d447-48f5-b942-32f6d019bf0f", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "d4bd9ba5-7300-4478-8726-1c26d428ed90", "admin@localhost.com", false, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN", "AQAAAAEAACcQAAAAEEQdfVGWVjMoz8vejJeYDyGtjrT0uiCk8OmD94htaSYbb1MTzUob5ppJm+wu6yZJRw==", null, false, "116f0fc9-d9c8-4de0-b870-473fd76117c9", false, "Admin" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 28, 22, 33, 52, 384, DateTimeKind.Local).AddTicks(5683), new DateTime(2022, 11, 28, 22, 33, 52, 385, DateTimeKind.Local).AddTicks(4151) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 28, 22, 33, 52, 385, DateTimeKind.Local).AddTicks(4653), new DateTime(2022, 11, 28, 22, 33, 52, 385, DateTimeKind.Local).AddTicks(4656) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 28, 22, 33, 52, 386, DateTimeKind.Local).AddTicks(2448), new DateTime(2022, 11, 28, 22, 33, 52, 386, DateTimeKind.Local).AddTicks(2455) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 28, 22, 33, 52, 386, DateTimeKind.Local).AddTicks(2457), new DateTime(2022, 11, 28, 22, 33, 52, 386, DateTimeKind.Local).AddTicks(2458) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 28, 22, 33, 52, 386, DateTimeKind.Local).AddTicks(4819), new DateTime(2022, 11, 28, 22, 33, 52, 386, DateTimeKind.Local).AddTicks(4823) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 28, 22, 33, 52, 386, DateTimeKind.Local).AddTicks(4825), new DateTime(2022, 11, 28, 22, 33, 52, 386, DateTimeKind.Local).AddTicks(4826) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 28, 22, 33, 52, 386, DateTimeKind.Local).AddTicks(4827), new DateTime(2022, 11, 28, 22, 33, 52, 386, DateTimeKind.Local).AddTicks(4828) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 28, 22, 33, 52, 386, DateTimeKind.Local).AddTicks(4829), new DateTime(2022, 11, 28, 22, 33, 52, 386, DateTimeKind.Local).AddTicks(4829) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");

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

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 28, 22, 17, 9, 597, DateTimeKind.Local).AddTicks(3873), new DateTime(2022, 11, 28, 22, 17, 9, 597, DateTimeKind.Local).AddTicks(3881) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 28, 22, 17, 9, 597, DateTimeKind.Local).AddTicks(3884), new DateTime(2022, 11, 28, 22, 17, 9, 597, DateTimeKind.Local).AddTicks(3885) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 28, 22, 17, 9, 597, DateTimeKind.Local).AddTicks(6121), new DateTime(2022, 11, 28, 22, 17, 9, 597, DateTimeKind.Local).AddTicks(6127) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 28, 22, 17, 9, 597, DateTimeKind.Local).AddTicks(6129), new DateTime(2022, 11, 28, 22, 17, 9, 597, DateTimeKind.Local).AddTicks(6130) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 28, 22, 17, 9, 597, DateTimeKind.Local).AddTicks(6131), new DateTime(2022, 11, 28, 22, 17, 9, 597, DateTimeKind.Local).AddTicks(6132) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 28, 22, 17, 9, 597, DateTimeKind.Local).AddTicks(6133), new DateTime(2022, 11, 28, 22, 17, 9, 597, DateTimeKind.Local).AddTicks(6134) });
        }
    }
}
