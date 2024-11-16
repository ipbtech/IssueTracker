using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TaskManager.DAL.Impl.Migrations
{
    /// <inheritdoc />
    public partial class SeedFakeUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedDateTimeUTC", "DisplayName", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UpdatedDateTimeUTC", "UserName" },
                values: new object[,]
                {
                    { 1, 0, "eb08f2a4-59ff-4205-9dc2-6815f39bc101", new DateTime(2024, 11, 16, 14, 6, 30, 304, DateTimeKind.Utc).AddTicks(7572), "Matthew Auer", null, false, false, null, null, "DOMINGO_UPTON73", "AQAAAAIAAYagAAAAEHXOWOJhHXJEQJaNmdDDlOEi5vaawS7KU875MvlWJjpTMVO0A37LAyCOD8ABC02kfA==", null, false, "e61f79da-6187-4485-bf9e-46dde7978bf1", false, new DateTime(2024, 11, 16, 14, 6, 30, 304, DateTimeKind.Utc).AddTicks(7829), "Domingo_Upton73" },
                    { 2, 0, "84712b13-2708-4b79-a2dd-81cd9a24718d", new DateTime(2024, 11, 16, 14, 6, 30, 304, DateTimeKind.Utc).AddTicks(9255), "Kelly Dickens", null, false, false, null, null, "LOUIS_DIETRICH", "AQAAAAIAAYagAAAAEMCROh+LNxV/vmw+W+ocPYvv85Y4e1JxE3NGQNCJlDf+OZ+Z5sCXsr/xsXvhWwoRSQ==", null, false, "9c6ae5bb-5ac9-4938-9214-5e9f3d7d518c", false, new DateTime(2024, 11, 16, 14, 6, 30, 304, DateTimeKind.Utc).AddTicks(9261), "Louis_Dietrich" },
                    { 3, 0, "aa006451-c006-4a5a-b686-0d92c85ae16f", new DateTime(2024, 11, 16, 14, 6, 30, 304, DateTimeKind.Utc).AddTicks(9615), "Michael Weimann", null, false, false, null, null, "ERIK_BLOCK25", "AQAAAAIAAYagAAAAEPvbrKZpdFcuwqADuWEDcxVFG/gZJxkfq2Myp2eBhiuKGgdIhKY8w8rQ0AZP+V9XAA==", null, false, "e5dd4f50-0772-446a-9100-f49dc5c3f9b9", false, new DateTime(2024, 11, 16, 14, 6, 30, 304, DateTimeKind.Utc).AddTicks(9621), "Erik_Block25" },
                    { 4, 0, "a5a7e2ef-5872-4902-9dbd-ed19e0143910", new DateTime(2024, 11, 16, 14, 6, 30, 304, DateTimeKind.Utc).AddTicks(9915), "Oliver Pfannerstill", null, false, false, null, null, "EUGENE.BAILEY75", "AQAAAAIAAYagAAAAENmkYLa2G9FHmLGiy6s5E5dLamrId39oC51B1v1CPsVne0RjjCxQWQiRUxoye1dKTQ==", null, false, "afcceae2-8254-49d1-848c-56b41444d3a6", false, new DateTime(2024, 11, 16, 14, 6, 30, 304, DateTimeKind.Utc).AddTicks(9941), "Eugene.Bailey75" },
                    { 5, 0, "2454eebb-f244-4d35-9a23-694e04752d88", new DateTime(2024, 11, 16, 14, 6, 30, 305, DateTimeKind.Utc).AddTicks(224), "Nicolas Rosenbaum", null, false, false, null, null, "SANTIAGO59", "AQAAAAIAAYagAAAAEAWY3DBsoE5x9Jg8NYQXpGuruaQrdKJW3EbfKS1347DUSH5qknetrJmRnghupzxUNg==", null, false, "cd22dee1-9d73-46eb-b343-295fdf11b8f9", false, new DateTime(2024, 11, 16, 14, 6, 30, 305, DateTimeKind.Utc).AddTicks(228), "Santiago59" },
                    { 6, 0, "9e733ed4-fbea-4801-9a6d-80304dbf1fc7", new DateTime(2024, 11, 16, 14, 6, 30, 305, DateTimeKind.Utc).AddTicks(829), "Tony Jaskolski", null, false, false, null, null, "GREGORY91", "AQAAAAIAAYagAAAAEKOd/9WNMzEhGdImg+LZ1XjGlSvZ96y0pCtnEbhF3HJZvawZz33MHuI2tDYTl2HfUw==", null, false, "da4f0da4-8e86-4938-b8ee-6287c384c114", false, new DateTime(2024, 11, 16, 14, 6, 30, 305, DateTimeKind.Utc).AddTicks(834), "Gregory91" },
                    { 7, 0, "d88630b7-b2d2-427f-b5fa-e2d26d5e31b5", new DateTime(2024, 11, 16, 14, 6, 30, 305, DateTimeKind.Utc).AddTicks(1092), "Guillermo Bruen", null, false, false, null, null, "ISRAEL.WATERS19", "AQAAAAIAAYagAAAAEKqXJJIcFFSfjKT3yBRmdXvZrG9qy81+b+N6DJrdFhzCdckwX4lS6fqMWXUENuc+hQ==", null, false, "e6eb00ef-0858-43f0-8ae3-604a0a036576", false, new DateTime(2024, 11, 16, 14, 6, 30, 305, DateTimeKind.Utc).AddTicks(1097), "Israel.Waters19" }
                });

            migrationBuilder.InsertData(
                table: "Statuses",
                columns: new[] { "Id", "CreatedDateTimeUTC", "Name", "UpdatedDateTimeUTC" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 11, 16, 14, 6, 31, 358, DateTimeKind.Utc).AddTicks(282), "Создана", new DateTime(2024, 11, 16, 14, 6, 31, 358, DateTimeKind.Utc).AddTicks(304) },
                    { 2, new DateTime(2024, 11, 16, 14, 6, 31, 358, DateTimeKind.Utc).AddTicks(345), "В работе", new DateTime(2024, 11, 16, 14, 6, 31, 358, DateTimeKind.Utc).AddTicks(346) },
                    { 3, new DateTime(2024, 11, 16, 14, 6, 31, 358, DateTimeKind.Utc).AddTicks(350), "Пауза", new DateTime(2024, 11, 16, 14, 6, 31, 358, DateTimeKind.Utc).AddTicks(350) },
                    { 4, new DateTime(2024, 11, 16, 14, 6, 31, 358, DateTimeKind.Utc).AddTicks(356), "Завершена", new DateTime(2024, 11, 16, 14, 6, 31, 358, DateTimeKind.Utc).AddTicks(357) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
