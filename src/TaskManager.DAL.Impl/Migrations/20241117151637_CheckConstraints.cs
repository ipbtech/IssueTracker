using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskManager.DAL.Impl.Migrations
{
    /// <inheritdoc />
    public partial class CheckConstraints : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Tasks",
                type: "TEXT",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDateTimeUTC", "PasswordHash", "SecurityStamp", "UpdatedDateTimeUTC" },
                values: new object[] { "a3133450-7dd7-4eb6-a1d5-14bc1b9ee6df", new DateTime(2024, 11, 17, 15, 16, 33, 705, DateTimeKind.Utc).AddTicks(6646), "AQAAAAIAAYagAAAAELe0M8XfHe/INR1ItVfAsaLSQplgKcvD+8+r0FVZ/i4gxdb2/mL0s9mLCxcUQHeb0g==", "a491f602-9e16-4bb6-80f5-9765bf9e9ead", new DateTime(2024, 11, 17, 15, 16, 33, 705, DateTimeKind.Utc).AddTicks(6986) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedDateTimeUTC", "PasswordHash", "SecurityStamp", "UpdatedDateTimeUTC" },
                values: new object[] { "a4629b81-717c-4b8a-badd-b219f07e6dda", new DateTime(2024, 11, 17, 15, 16, 33, 705, DateTimeKind.Utc).AddTicks(8298), "AQAAAAIAAYagAAAAEGAh+DQlL2NVCJDrHDCMddyu8yWREzvKVmYIPBNyF4H/nJ6VEr+WwokPfurHxtYUXQ==", "3d15c623-dce8-4ee0-b339-7f4c0e8ccce4", new DateTime(2024, 11, 17, 15, 16, 33, 705, DateTimeKind.Utc).AddTicks(8308) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "CreatedDateTimeUTC", "PasswordHash", "SecurityStamp", "UpdatedDateTimeUTC" },
                values: new object[] { "89c4b5ce-833c-4a93-836d-40717024b0dc", new DateTime(2024, 11, 17, 15, 16, 33, 705, DateTimeKind.Utc).AddTicks(8950), "AQAAAAIAAYagAAAAEAsKs33KdMEFSYuBkMhj+QW3eo+FwJRkrO/pS+h6D+GPGqPBv7vsHMjGHajDCAFxNQ==", "b54a717a-2717-4f7f-9beb-85472bad888f", new DateTime(2024, 11, 17, 15, 16, 33, 705, DateTimeKind.Utc).AddTicks(8958) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "CreatedDateTimeUTC", "PasswordHash", "SecurityStamp", "UpdatedDateTimeUTC" },
                values: new object[] { "b03ac825-4ae7-42dd-8469-60057882c0c4", new DateTime(2024, 11, 17, 15, 16, 33, 705, DateTimeKind.Utc).AddTicks(9272), "AQAAAAIAAYagAAAAENFMUDBkLKCeyZhTLF4yzIFe+xavRZAiIX2Su4IG21a/DFqhxwQGXm/Gq+9Zpiohhw==", "4268ebd9-9981-4cdd-93e0-680b17db6f07", new DateTime(2024, 11, 17, 15, 16, 33, 705, DateTimeKind.Utc).AddTicks(9280) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "CreatedDateTimeUTC", "PasswordHash", "SecurityStamp", "UpdatedDateTimeUTC" },
                values: new object[] { "82887e54-f0b8-440a-b8a1-99ac3ecb3b91", new DateTime(2024, 11, 17, 15, 16, 33, 705, DateTimeKind.Utc).AddTicks(9617), "AQAAAAIAAYagAAAAEKW/m56GK//0sK9h4lzS6SXcFVNIOteBq9TPhOzTDgSBuvMGxhcVNeoLA7VSaHP26w==", "28955ef2-fc83-49cc-b275-2868d094bb82", new DateTime(2024, 11, 17, 15, 16, 33, 705, DateTimeKind.Utc).AddTicks(9622) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ConcurrencyStamp", "CreatedDateTimeUTC", "PasswordHash", "SecurityStamp", "UpdatedDateTimeUTC" },
                values: new object[] { "4e0c80a6-abca-4059-a7a1-315fc2888b92", new DateTime(2024, 11, 17, 15, 16, 33, 706, DateTimeKind.Utc).AddTicks(175), "AQAAAAIAAYagAAAAEL/UJ+BqEqOI0Rz+wkRFp/VUds1bSTJm7yI0bWAoWSgPanF4e4Hn/2bsVQOrOVTVfA==", "e36bd531-0051-4650-968d-0f257feef233", new DateTime(2024, 11, 17, 15, 16, 33, 706, DateTimeKind.Utc).AddTicks(183) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ConcurrencyStamp", "CreatedDateTimeUTC", "PasswordHash", "SecurityStamp", "UpdatedDateTimeUTC" },
                values: new object[] { "6b5935b0-d602-413f-8177-998287e2a09c", new DateTime(2024, 11, 17, 15, 16, 33, 706, DateTimeKind.Utc).AddTicks(500), "AQAAAAIAAYagAAAAEEn5pLbAQgjy1OGL1j15vAAE30wGcrvuMlBmV/7vW/xrxMu1ZheX0uXyCfqr8u9MBQ==", "2082de3b-3708-4342-8955-03ae303711d3", new DateTime(2024, 11, 17, 15, 16, 33, 706, DateTimeKind.Utc).AddTicks(507) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 15, 0, 35, 49, 135, DateTimeKind.Utc).AddTicks(4101), new DateTime(2024, 11, 14, 4, 44, 52, 187, DateTimeKind.Utc).AddTicks(1083) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 13, 12, 17, 47, 631, DateTimeKind.Utc).AddTicks(1016), new DateTime(2024, 11, 16, 6, 51, 42, 956, DateTimeKind.Utc).AddTicks(8904) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 11, 16, 33, 2, 528, DateTimeKind.Utc).AddTicks(3293), new DateTime(2024, 11, 13, 11, 23, 26, 544, DateTimeKind.Utc).AddTicks(2684) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 12, 12, 31, 57, 273, DateTimeKind.Utc).AddTicks(1322), new DateTime(2024, 11, 13, 22, 18, 40, 438, DateTimeKind.Utc).AddTicks(1113) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 15, 1, 23, 26, 110, DateTimeKind.Utc).AddTicks(1270), new DateTime(2024, 11, 12, 18, 3, 52, 66, DateTimeKind.Utc).AddTicks(1660) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 15, 15, 42, 32, 575, DateTimeKind.Utc).AddTicks(3904), new DateTime(2024, 11, 15, 3, 46, 59, 171, DateTimeKind.Utc).AddTicks(700) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 12, 18, 6, 48, 994, DateTimeKind.Utc).AddTicks(6067), new DateTime(2024, 11, 16, 22, 27, 29, 20, DateTimeKind.Utc).AddTicks(6669) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 16, 4, 33, 25, 456, DateTimeKind.Utc).AddTicks(2167), new DateTime(2024, 11, 15, 1, 51, 52, 41, DateTimeKind.Utc).AddTicks(3607) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 16, 1, 34, 38, 820, DateTimeKind.Utc).AddTicks(5185), new DateTime(2024, 11, 13, 16, 47, 0, 542, DateTimeKind.Utc).AddTicks(8162) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 16, 3, 24, 45, 35, DateTimeKind.Utc).AddTicks(3805), new DateTime(2024, 11, 11, 21, 57, 2, 355, DateTimeKind.Utc).AddTicks(7042) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 16, 21, 46, 37, 448, DateTimeKind.Utc).AddTicks(6792), new DateTime(2024, 11, 12, 6, 38, 12, 971, DateTimeKind.Utc).AddTicks(57) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 15, 11, 38, 26, 569, DateTimeKind.Utc).AddTicks(1460), new DateTime(2024, 11, 16, 4, 12, 19, 202, DateTimeKind.Utc).AddTicks(3940) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 13, 10, 25, 56, 888, DateTimeKind.Utc).AddTicks(4088), new DateTime(2024, 11, 14, 10, 49, 3, 377, DateTimeKind.Utc).AddTicks(1698) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 12, 22, 22, 23, 218, DateTimeKind.Utc).AddTicks(1609), new DateTime(2024, 11, 14, 3, 33, 2, 877, DateTimeKind.Utc).AddTicks(3200) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 13, 3, 34, 51, 513, DateTimeKind.Utc).AddTicks(7075), new DateTime(2024, 11, 14, 20, 53, 16, 277, DateTimeKind.Utc).AddTicks(219) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 17, 8, 2, 34, 941, DateTimeKind.Utc).AddTicks(5706), new DateTime(2024, 11, 16, 0, 48, 26, 3, DateTimeKind.Utc).AddTicks(5916) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 13, 11, 8, 51, 217, DateTimeKind.Utc).AddTicks(5113), new DateTime(2024, 11, 17, 8, 16, 30, 340, DateTimeKind.Utc).AddTicks(9088) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 14, 13, 11, 5, 899, DateTimeKind.Utc).AddTicks(8377), new DateTime(2024, 11, 15, 8, 50, 25, 601, DateTimeKind.Utc).AddTicks(7656) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 14, 19, 47, 25, 518, DateTimeKind.Utc).AddTicks(2382), new DateTime(2024, 11, 15, 18, 56, 37, 373, DateTimeKind.Utc).AddTicks(2354) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 12, 21, 3, 43, 660, DateTimeKind.Utc).AddTicks(8788), new DateTime(2024, 11, 17, 2, 16, 23, 752, DateTimeKind.Utc).AddTicks(931) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 13, 12, 49, 59, 320, DateTimeKind.Utc).AddTicks(9555), new DateTime(2024, 11, 15, 20, 36, 20, 969, DateTimeKind.Utc).AddTicks(4789) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 15, 23, 2, 27, 536, DateTimeKind.Utc).AddTicks(1629), new DateTime(2024, 11, 12, 9, 1, 23, 924, DateTimeKind.Utc).AddTicks(1617) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 11, 22, 0, 20, 2, DateTimeKind.Utc).AddTicks(5143), new DateTime(2024, 11, 16, 5, 25, 13, 382, DateTimeKind.Utc).AddTicks(5066) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 14, 10, 6, 7, 162, DateTimeKind.Utc).AddTicks(4022), new DateTime(2024, 11, 11, 21, 2, 22, 910, DateTimeKind.Utc).AddTicks(8264) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 11, 22, 12, 43, 474, DateTimeKind.Utc).AddTicks(2133), new DateTime(2024, 11, 17, 7, 52, 52, 195, DateTimeKind.Utc).AddTicks(5473) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 13, 0, 18, 23, 497, DateTimeKind.Utc).AddTicks(3680), new DateTime(2024, 11, 14, 6, 49, 13, 317, DateTimeKind.Utc).AddTicks(7642) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 14, 14, 43, 22, 911, DateTimeKind.Utc).AddTicks(7776), new DateTime(2024, 11, 13, 2, 33, 16, 205, DateTimeKind.Utc).AddTicks(5345) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 12, 6, 13, 24, 806, DateTimeKind.Utc).AddTicks(3302), new DateTime(2024, 11, 13, 20, 11, 56, 8, DateTimeKind.Utc).AddTicks(3795) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 15, 19, 59, 43, 694, DateTimeKind.Utc).AddTicks(6971), new DateTime(2024, 11, 12, 18, 42, 5, 399, DateTimeKind.Utc).AddTicks(7464) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 12, 9, 56, 8, 764, DateTimeKind.Utc).AddTicks(7317), new DateTime(2024, 11, 15, 6, 25, 24, 200, DateTimeKind.Utc).AddTicks(4822) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 12, 0, 27, 59, 357, DateTimeKind.Utc).AddTicks(9122), new DateTime(2024, 11, 15, 2, 42, 39, 680, DateTimeKind.Utc).AddTicks(6559) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 14, 3, 6, 37, 588, DateTimeKind.Utc).AddTicks(430), new DateTime(2024, 11, 15, 18, 58, 51, 648, DateTimeKind.Utc).AddTicks(6825) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 11, 19, 13, 14, 234, DateTimeKind.Utc).AddTicks(4745), new DateTime(2024, 11, 16, 2, 9, 1, 761, DateTimeKind.Utc).AddTicks(7745) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 15, 2, 3, 43, 40, DateTimeKind.Utc).AddTicks(4465), new DateTime(2024, 11, 16, 20, 27, 7, 587, DateTimeKind.Utc).AddTicks(3170) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 16, 4, 58, 32, 301, DateTimeKind.Utc).AddTicks(4508), new DateTime(2024, 11, 17, 9, 17, 17, 92, DateTimeKind.Utc).AddTicks(2880) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 14, 23, 44, 32, 277, DateTimeKind.Utc).AddTicks(609), new DateTime(2024, 11, 14, 6, 16, 16, 487, DateTimeKind.Utc).AddTicks(8275) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 15, 14, 35, 59, 193, DateTimeKind.Utc).AddTicks(3535), new DateTime(2024, 11, 14, 3, 24, 0, 149, DateTimeKind.Utc).AddTicks(3054) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 17, 12, 58, 4, 787, DateTimeKind.Utc).AddTicks(6337), new DateTime(2024, 11, 15, 8, 58, 6, 488, DateTimeKind.Utc).AddTicks(5355) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 14, 0, 23, 39, 110, DateTimeKind.Utc).AddTicks(1846), new DateTime(2024, 11, 13, 1, 59, 31, 38, DateTimeKind.Utc).AddTicks(2349) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 16, 19, 7, 12, 91, DateTimeKind.Utc).AddTicks(8624), new DateTime(2024, 11, 15, 0, 4, 30, 990, DateTimeKind.Utc).AddTicks(9700) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 13, 10, 21, 19, 843, DateTimeKind.Utc).AddTicks(7367), new DateTime(2024, 11, 16, 15, 34, 47, 84, DateTimeKind.Utc).AddTicks(2957) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 15, 12, 36, 56, 783, DateTimeKind.Utc).AddTicks(5837), new DateTime(2024, 11, 12, 15, 58, 50, 580, DateTimeKind.Utc).AddTicks(6497) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 13, 11, 7, 15, 472, DateTimeKind.Utc).AddTicks(2290), new DateTime(2024, 11, 17, 5, 24, 47, 257, DateTimeKind.Utc).AddTicks(6255) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 15, 8, 2, 29, 799, DateTimeKind.Utc).AddTicks(8454), new DateTime(2024, 11, 15, 18, 21, 42, 343, DateTimeKind.Utc).AddTicks(663) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 16, 11, 22, 2, 629, DateTimeKind.Utc).AddTicks(1237), new DateTime(2024, 11, 14, 11, 58, 39, 932, DateTimeKind.Utc).AddTicks(6782) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 12, 4, 56, 24, 384, DateTimeKind.Utc).AddTicks(8390), new DateTime(2024, 11, 12, 14, 46, 22, 884, DateTimeKind.Utc).AddTicks(4660) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 15, 3, 44, 23, 515, DateTimeKind.Utc).AddTicks(3091), new DateTime(2024, 11, 15, 2, 48, 15, 745, DateTimeKind.Utc).AddTicks(5255) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 12, 21, 8, 46, 832, DateTimeKind.Utc).AddTicks(6535), new DateTime(2024, 11, 16, 12, 54, 6, 881, DateTimeKind.Utc).AddTicks(6980) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 13, 15, 54, 20, 830, DateTimeKind.Utc).AddTicks(9572), new DateTime(2024, 11, 16, 21, 25, 15, 991, DateTimeKind.Utc).AddTicks(7096) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 14, 15, 35, 29, 26, DateTimeKind.Utc).AddTicks(3989), new DateTime(2024, 11, 13, 16, 8, 22, 717, DateTimeKind.Utc).AddTicks(8482) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 12, 16, 8, 19, 388, DateTimeKind.Utc).AddTicks(8601), new DateTime(2024, 11, 14, 13, 45, 32, 671, DateTimeKind.Utc).AddTicks(2120) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 15, 18, 18, 14, 601, DateTimeKind.Utc).AddTicks(3372), new DateTime(2024, 11, 13, 9, 53, 53, 24, DateTimeKind.Utc).AddTicks(5676) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 14, 21, 8, 22, 325, DateTimeKind.Utc).AddTicks(6890), new DateTime(2024, 11, 15, 3, 43, 22, 158, DateTimeKind.Utc).AddTicks(454) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 17, 0, 15, 39, 148, DateTimeKind.Utc).AddTicks(9858), new DateTime(2024, 11, 13, 1, 49, 9, 295, DateTimeKind.Utc).AddTicks(9086) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 14, 17, 0, 10, 590, DateTimeKind.Utc).AddTicks(7851), new DateTime(2024, 11, 16, 20, 29, 13, 929, DateTimeKind.Utc).AddTicks(732) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 17, 11, 25, 24, 180, DateTimeKind.Utc).AddTicks(9091), new DateTime(2024, 11, 16, 19, 56, 21, 782, DateTimeKind.Utc).AddTicks(6909) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 13, 22, 18, 35, 33, DateTimeKind.Utc).AddTicks(1691), new DateTime(2024, 11, 15, 11, 37, 50, 11, DateTimeKind.Utc).AddTicks(9076) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 15, 0, 37, 0, 457, DateTimeKind.Utc).AddTicks(5483), new DateTime(2024, 11, 17, 4, 7, 29, 180, DateTimeKind.Utc).AddTicks(5273) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 11, 20, 24, 28, 215, DateTimeKind.Utc).AddTicks(30), new DateTime(2024, 11, 16, 9, 36, 50, 689, DateTimeKind.Utc).AddTicks(4007) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 17, 5, 29, 28, 788, DateTimeKind.Utc).AddTicks(407), new DateTime(2024, 11, 17, 4, 42, 28, 872, DateTimeKind.Utc).AddTicks(1353) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 13, 23, 46, 49, 436, DateTimeKind.Utc).AddTicks(8612), new DateTime(2024, 11, 12, 16, 41, 5, 377, DateTimeKind.Utc).AddTicks(4949) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 15, 20, 56, 14, 935, DateTimeKind.Utc).AddTicks(2147), new DateTime(2024, 11, 14, 8, 34, 59, 327, DateTimeKind.Utc).AddTicks(8314) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 14, 10, 47, 24, 854, DateTimeKind.Utc).AddTicks(1520), new DateTime(2024, 11, 15, 4, 45, 58, 653, DateTimeKind.Utc).AddTicks(821) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 11, 16, 27, 44, 247, DateTimeKind.Utc).AddTicks(2825), new DateTime(2024, 11, 12, 12, 25, 19, 478, DateTimeKind.Utc).AddTicks(3311) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 13, 12, 26, 12, 950, DateTimeKind.Utc).AddTicks(1368), new DateTime(2024, 11, 13, 2, 26, 42, 297, DateTimeKind.Utc).AddTicks(4308) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 12, 12, 4, 19, 45, DateTimeKind.Utc).AddTicks(7148), new DateTime(2024, 11, 13, 10, 24, 37, 452, DateTimeKind.Utc).AddTicks(464) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 14, 5, 35, 20, 585, DateTimeKind.Utc).AddTicks(4381), new DateTime(2024, 11, 12, 4, 33, 36, 11, DateTimeKind.Utc).AddTicks(2848) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 14, 22, 34, 21, 107, DateTimeKind.Utc).AddTicks(7434), new DateTime(2024, 11, 12, 3, 4, 28, 545, DateTimeKind.Utc).AddTicks(8533) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 11, 17, 21, 39, 732, DateTimeKind.Utc).AddTicks(3182), new DateTime(2024, 11, 12, 3, 56, 4, 757, DateTimeKind.Utc).AddTicks(7355) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 12, 12, 32, 28, 34, DateTimeKind.Utc).AddTicks(5437), new DateTime(2024, 11, 16, 4, 22, 53, 582, DateTimeKind.Utc).AddTicks(2324) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 11, 21, 13, 32, 251, DateTimeKind.Utc).AddTicks(5583), new DateTime(2024, 11, 12, 7, 23, 44, 43, DateTimeKind.Utc).AddTicks(948) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 14, 13, 1, 48, 202, DateTimeKind.Utc).AddTicks(7250), new DateTime(2024, 11, 15, 20, 1, 7, 642, DateTimeKind.Utc).AddTicks(5747) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 16, 7, 36, 44, 142, DateTimeKind.Utc).AddTicks(6401), new DateTime(2024, 11, 15, 20, 46, 49, 461, DateTimeKind.Utc).AddTicks(6763) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 16, 5, 13, 2, 635, DateTimeKind.Utc).AddTicks(3436), new DateTime(2024, 11, 15, 15, 48, 17, 218, DateTimeKind.Utc).AddTicks(457) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 13, 6, 31, 45, 269, DateTimeKind.Utc).AddTicks(1902), new DateTime(2024, 11, 11, 19, 0, 26, 375, DateTimeKind.Utc).AddTicks(651) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 12, 16, 53, 8, 602, DateTimeKind.Utc).AddTicks(8617), new DateTime(2024, 11, 16, 18, 47, 31, 948, DateTimeKind.Utc).AddTicks(4595) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 13, 15, 21, 57, 355, DateTimeKind.Utc).AddTicks(812), new DateTime(2024, 11, 14, 19, 23, 47, 753, DateTimeKind.Utc).AddTicks(5920) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 12, 0, 43, 18, 194, DateTimeKind.Utc).AddTicks(6451), new DateTime(2024, 11, 14, 21, 43, 22, 989, DateTimeKind.Utc).AddTicks(3449) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 12, 5, 54, 48, 905, DateTimeKind.Utc).AddTicks(6423), new DateTime(2024, 11, 15, 2, 5, 37, 101, DateTimeKind.Utc).AddTicks(7728) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 17, 6, 36, 17, 663, DateTimeKind.Utc).AddTicks(7634), new DateTime(2024, 11, 16, 11, 0, 11, 688, DateTimeKind.Utc).AddTicks(2477) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 15, 21, 48, 11, 218, DateTimeKind.Utc).AddTicks(4889), new DateTime(2024, 11, 15, 2, 28, 31, 351, DateTimeKind.Utc).AddTicks(3245) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 14, 2, 19, 32, 847, DateTimeKind.Utc).AddTicks(9002), new DateTime(2024, 11, 14, 1, 20, 13, 36, DateTimeKind.Utc).AddTicks(1885) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 12, 4, 27, 57, 191, DateTimeKind.Utc).AddTicks(531), new DateTime(2024, 11, 13, 7, 10, 9, 57, DateTimeKind.Utc).AddTicks(3635) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 13, 5, 32, 13, 397, DateTimeKind.Utc).AddTicks(907), new DateTime(2024, 11, 17, 5, 25, 19, 913, DateTimeKind.Utc).AddTicks(8390) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 12, 15, 11, 14, 661, DateTimeKind.Utc).AddTicks(7673), new DateTime(2024, 11, 15, 8, 27, 13, 269, DateTimeKind.Utc).AddTicks(4057) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 14, 20, 55, 42, 125, DateTimeKind.Utc).AddTicks(457), new DateTime(2024, 11, 16, 23, 17, 23, 170, DateTimeKind.Utc).AddTicks(7131) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 16, 19, 49, 10, 915, DateTimeKind.Utc).AddTicks(5407), new DateTime(2024, 11, 12, 22, 50, 48, 306, DateTimeKind.Utc).AddTicks(4490) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 12, 23, 15, 56, 869, DateTimeKind.Utc).AddTicks(2729), new DateTime(2024, 11, 17, 12, 40, 34, 568, DateTimeKind.Utc).AddTicks(1682) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDateTimeUTC", "Name", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 17, 15, 16, 35, 510, DateTimeKind.Utc).AddTicks(5539), "Created", new DateTime(2024, 11, 17, 15, 16, 35, 510, DateTimeKind.Utc).AddTicks(5562) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDateTimeUTC", "Name", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 17, 15, 16, 35, 510, DateTimeKind.Utc).AddTicks(5611), "In progress", new DateTime(2024, 11, 17, 15, 16, 35, 510, DateTimeKind.Utc).AddTicks(5614) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDateTimeUTC", "Name", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 17, 15, 16, 35, 510, DateTimeKind.Utc).AddTicks(5621), "Pause", new DateTime(2024, 11, 17, 15, 16, 35, 510, DateTimeKind.Utc).AddTicks(5623) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDateTimeUTC", "Name", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 17, 15, 16, 35, 510, DateTimeKind.Utc).AddTicks(5627), "Done", new DateTime(2024, 11, 17, 15, 16, 35, 510, DateTimeKind.Utc).AddTicks(5629) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDateTimeUTC", "PlannedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 13, 19, 26, 57, 868, DateTimeKind.Utc).AddTicks(6684), new DateTime(2024, 11, 15, 22, 58, 16, 462, DateTimeKind.Utc).AddTicks(2511), new DateTime(2024, 11, 12, 17, 50, 37, 514, DateTimeKind.Utc).AddTicks(1585) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDateTimeUTC", "PlannedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 16, 1, 34, 24, 384, DateTimeKind.Utc).AddTicks(6868), new DateTime(2024, 11, 15, 22, 7, 10, 60, DateTimeKind.Utc).AddTicks(6651), new DateTime(2024, 11, 12, 0, 1, 30, 904, DateTimeKind.Utc).AddTicks(9628) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ClosedDateTimeUTC", "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 14, 21, 52, 39, 358, DateTimeKind.Utc).AddTicks(8140), new DateTime(2024, 11, 12, 13, 39, 33, 27, DateTimeKind.Utc).AddTicks(9028), new DateTime(2024, 11, 16, 9, 33, 29, 805, DateTimeKind.Utc).AddTicks(569) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ClosedDateTimeUTC", "CreatedDateTimeUTC", "PlannedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 16, 22, 30, 46, 213, DateTimeKind.Utc).AddTicks(1805), new DateTime(2024, 11, 15, 19, 24, 32, 471, DateTimeKind.Utc).AddTicks(5665), new DateTime(2024, 11, 15, 19, 38, 3, 155, DateTimeKind.Utc).AddTicks(37), new DateTime(2024, 11, 11, 3, 56, 1, 987, DateTimeKind.Utc).AddTicks(2371) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ClosedDateTimeUTC", "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 16, 3, 19, 48, 905, DateTimeKind.Utc).AddTicks(6352), new DateTime(2024, 11, 12, 22, 26, 33, 342, DateTimeKind.Utc).AddTicks(2426), new DateTime(2024, 11, 17, 1, 34, 17, 929, DateTimeKind.Utc).AddTicks(3894) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ClosedDateTimeUTC", "CreatedDateTimeUTC", "PlannedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 15, 15, 21, 55, 368, DateTimeKind.Utc).AddTicks(5479), new DateTime(2024, 11, 15, 11, 10, 49, 333, DateTimeKind.Utc).AddTicks(1380), new DateTime(2024, 11, 17, 6, 49, 20, 338, DateTimeKind.Utc).AddTicks(4098), new DateTime(2024, 11, 12, 5, 54, 0, 552, DateTimeKind.Utc).AddTicks(9118) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDateTimeUTC", "PlannedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 13, 21, 55, 31, 523, DateTimeKind.Utc).AddTicks(4300), new DateTime(2024, 11, 15, 13, 34, 46, 975, DateTimeKind.Utc).AddTicks(5004), new DateTime(2024, 11, 11, 22, 0, 20, 416, DateTimeKind.Utc).AddTicks(7752) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ClosedDateTimeUTC", "CreatedDateTimeUTC", "PlannedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 16, 18, 48, 49, 105, DateTimeKind.Utc).AddTicks(987), new DateTime(2024, 11, 14, 11, 1, 21, 926, DateTimeKind.Utc).AddTicks(9292), new DateTime(2024, 11, 16, 6, 51, 49, 779, DateTimeKind.Utc).AddTicks(9401), new DateTime(2024, 11, 13, 18, 7, 30, 757, DateTimeKind.Utc).AddTicks(4380) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDateTimeUTC", "PlannedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 12, 21, 54, 34, 891, DateTimeKind.Utc).AddTicks(6720), new DateTime(2024, 11, 14, 16, 33, 43, 614, DateTimeKind.Utc).AddTicks(7551), new DateTime(2024, 11, 15, 7, 1, 54, 354, DateTimeKind.Utc).AddTicks(6440) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ClosedDateTimeUTC", "CreatedDateTimeUTC", "PlannedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 16, 3, 44, 59, 356, DateTimeKind.Utc).AddTicks(191), new DateTime(2024, 11, 15, 12, 57, 14, 983, DateTimeKind.Utc).AddTicks(5450), new DateTime(2024, 11, 17, 4, 2, 7, 698, DateTimeKind.Utc).AddTicks(3814), new DateTime(2024, 11, 14, 2, 32, 37, 192, DateTimeKind.Utc).AddTicks(7648) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ClosedDateTimeUTC", "CreatedDateTimeUTC", "PlannedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 16, 2, 53, 8, 826, DateTimeKind.Utc).AddTicks(849), new DateTime(2024, 11, 17, 14, 33, 20, 300, DateTimeKind.Utc).AddTicks(9855), new DateTime(2024, 11, 15, 4, 36, 12, 509, DateTimeKind.Utc).AddTicks(3059), new DateTime(2024, 11, 12, 16, 32, 48, 901, DateTimeKind.Utc).AddTicks(8981) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ClosedDateTimeUTC", "CreatedDateTimeUTC", "PlannedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 16, 15, 19, 7, 663, DateTimeKind.Utc).AddTicks(1938), new DateTime(2024, 11, 12, 4, 34, 39, 33, DateTimeKind.Utc).AddTicks(3242), new DateTime(2024, 11, 17, 11, 59, 6, 943, DateTimeKind.Utc).AddTicks(8126), new DateTime(2024, 11, 17, 3, 12, 42, 34, DateTimeKind.Utc).AddTicks(2041) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDateTimeUTC", "PlannedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 13, 2, 21, 41, 630, DateTimeKind.Utc).AddTicks(1744), new DateTime(2024, 11, 16, 14, 43, 24, 757, DateTimeKind.Utc).AddTicks(5501), new DateTime(2024, 11, 14, 19, 17, 25, 761, DateTimeKind.Utc).AddTicks(9211) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ClosedDateTimeUTC", "CreatedDateTimeUTC", "PlannedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 15, 11, 12, 25, 16, DateTimeKind.Utc).AddTicks(5547), new DateTime(2024, 11, 11, 11, 43, 24, 230, DateTimeKind.Utc).AddTicks(5283), new DateTime(2024, 11, 16, 9, 28, 49, 377, DateTimeKind.Utc).AddTicks(6862), new DateTime(2024, 11, 14, 10, 7, 19, 65, DateTimeKind.Utc).AddTicks(3381) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ClosedDateTimeUTC", "CreatedDateTimeUTC", "PlannedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 17, 2, 17, 58, 376, DateTimeKind.Utc).AddTicks(3610), new DateTime(2024, 11, 12, 19, 37, 20, 578, DateTimeKind.Utc).AddTicks(6653), new DateTime(2024, 11, 15, 12, 17, 58, 201, DateTimeKind.Utc).AddTicks(4729), new DateTime(2024, 11, 15, 4, 30, 24, 785, DateTimeKind.Utc).AddTicks(4040) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ClosedDateTimeUTC", "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 15, 22, 54, 20, 813, DateTimeKind.Utc).AddTicks(1655), new DateTime(2024, 11, 10, 18, 19, 38, 383, DateTimeKind.Utc).AddTicks(3051), new DateTime(2024, 11, 11, 12, 42, 33, 264, DateTimeKind.Utc).AddTicks(3933) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ClosedDateTimeUTC", "CreatedDateTimeUTC", "PlannedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 15, 9, 13, 7, 813, DateTimeKind.Utc).AddTicks(5070), new DateTime(2024, 11, 14, 10, 10, 10, 482, DateTimeKind.Utc).AddTicks(2880), new DateTime(2024, 11, 16, 20, 40, 33, 581, DateTimeKind.Utc).AddTicks(8023), new DateTime(2024, 11, 15, 18, 4, 5, 558, DateTimeKind.Utc).AddTicks(7674) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "ClosedDateTimeUTC", "CreatedDateTimeUTC", "PlannedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 15, 12, 54, 22, 928, DateTimeKind.Utc).AddTicks(555), new DateTime(2024, 11, 15, 2, 4, 6, 807, DateTimeKind.Utc).AddTicks(3331), new DateTime(2024, 11, 15, 22, 59, 15, 409, DateTimeKind.Utc).AddTicks(1940), new DateTime(2024, 11, 14, 4, 52, 34, 575, DateTimeKind.Utc).AddTicks(1253) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "ClosedDateTimeUTC", "CreatedDateTimeUTC", "PlannedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 14, 23, 58, 35, 369, DateTimeKind.Utc).AddTicks(4664), new DateTime(2024, 11, 16, 10, 38, 27, 337, DateTimeKind.Utc).AddTicks(3437), new DateTime(2024, 11, 15, 12, 54, 35, 522, DateTimeKind.Utc).AddTicks(8592), new DateTime(2024, 11, 11, 15, 42, 42, 66, DateTimeKind.Utc).AddTicks(9445) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "ClosedDateTimeUTC", "CreatedDateTimeUTC", "PlannedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 17, 10, 7, 50, 619, DateTimeKind.Utc).AddTicks(1187), new DateTime(2024, 11, 10, 18, 5, 39, 25, DateTimeKind.Utc).AddTicks(2079), new DateTime(2024, 11, 17, 1, 33, 24, 493, DateTimeKind.Utc).AddTicks(9485), new DateTime(2024, 11, 11, 0, 58, 26, 235, DateTimeKind.Utc).AddTicks(9635) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "ClosedDateTimeUTC", "CreatedDateTimeUTC", "PlannedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 15, 9, 8, 37, 199, DateTimeKind.Utc).AddTicks(2003), new DateTime(2024, 11, 14, 15, 54, 50, 436, DateTimeKind.Utc).AddTicks(7522), new DateTime(2024, 11, 16, 7, 58, 12, 945, DateTimeKind.Utc).AddTicks(9105), new DateTime(2024, 11, 14, 17, 54, 22, 502, DateTimeKind.Utc).AddTicks(999) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "ClosedDateTimeUTC", "CreatedDateTimeUTC", "PlannedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 15, 4, 36, 54, 246, DateTimeKind.Utc).AddTicks(7769), new DateTime(2024, 11, 13, 1, 59, 16, 930, DateTimeKind.Utc).AddTicks(6964), new DateTime(2024, 11, 17, 1, 52, 6, 902, DateTimeKind.Utc).AddTicks(128), new DateTime(2024, 11, 14, 9, 6, 2, 721, DateTimeKind.Utc).AddTicks(9371) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "ClosedDateTimeUTC", "CreatedDateTimeUTC", "PlannedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 15, 18, 20, 25, 54, DateTimeKind.Utc).AddTicks(4220), new DateTime(2024, 11, 12, 11, 11, 16, 9, DateTimeKind.Utc).AddTicks(8835), new DateTime(2024, 11, 14, 16, 29, 48, 424, DateTimeKind.Utc).AddTicks(1936), new DateTime(2024, 11, 15, 8, 47, 40, 749, DateTimeKind.Utc).AddTicks(6702) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "ClosedDateTimeUTC", "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 14, 17, 27, 57, 680, DateTimeKind.Utc).AddTicks(6548), new DateTime(2024, 11, 12, 22, 18, 31, 590, DateTimeKind.Utc).AddTicks(4), new DateTime(2024, 11, 13, 11, 15, 30, 243, DateTimeKind.Utc).AddTicks(5790) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "ClosedDateTimeUTC", "CreatedDateTimeUTC", "PlannedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 15, 22, 59, 17, 245, DateTimeKind.Utc).AddTicks(6412), new DateTime(2024, 11, 16, 2, 18, 40, 542, DateTimeKind.Utc).AddTicks(4530), new DateTime(2024, 11, 15, 2, 1, 32, 234, DateTimeKind.Utc).AddTicks(6562), new DateTime(2024, 11, 10, 20, 53, 15, 859, DateTimeKind.Utc).AddTicks(6132) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "ClosedDateTimeUTC", "CreatedDateTimeUTC", "PlannedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 14, 22, 14, 14, 542, DateTimeKind.Utc).AddTicks(7427), new DateTime(2024, 11, 15, 8, 39, 36, 442, DateTimeKind.Utc).AddTicks(6368), new DateTime(2024, 11, 17, 13, 27, 24, 908, DateTimeKind.Utc).AddTicks(1470), new DateTime(2024, 11, 11, 12, 58, 46, 154, DateTimeKind.Utc).AddTicks(2392) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "ClosedDateTimeUTC", "CreatedDateTimeUTC", "PlannedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 15, 5, 7, 52, 508, DateTimeKind.Utc).AddTicks(3985), new DateTime(2024, 11, 15, 12, 51, 40, 242, DateTimeKind.Utc).AddTicks(7244), new DateTime(2024, 11, 16, 11, 3, 50, 225, DateTimeKind.Utc).AddTicks(7170), new DateTime(2024, 11, 14, 8, 17, 40, 272, DateTimeKind.Utc).AddTicks(4649) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "ClosedDateTimeUTC", "CreatedDateTimeUTC", "PlannedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 15, 8, 3, 54, 193, DateTimeKind.Utc).AddTicks(2498), new DateTime(2024, 11, 13, 5, 57, 49, 343, DateTimeKind.Utc).AddTicks(3083), new DateTime(2024, 11, 15, 23, 16, 0, 765, DateTimeKind.Utc).AddTicks(4776), new DateTime(2024, 11, 11, 22, 45, 23, 227, DateTimeKind.Utc).AddTicks(1810) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "ClosedDateTimeUTC", "CreatedDateTimeUTC", "PlannedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 16, 2, 44, 36, 618, DateTimeKind.Utc).AddTicks(8832), new DateTime(2024, 11, 11, 6, 26, 8, 913, DateTimeKind.Utc).AddTicks(4354), new DateTime(2024, 11, 16, 19, 54, 37, 207, DateTimeKind.Utc).AddTicks(1801), new DateTime(2024, 11, 14, 12, 45, 26, 99, DateTimeKind.Utc).AddTicks(1241) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "ClosedDateTimeUTC", "CreatedDateTimeUTC", "PlannedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 16, 10, 43, 24, 489, DateTimeKind.Utc).AddTicks(5186), new DateTime(2024, 11, 15, 4, 28, 15, 108, DateTimeKind.Utc).AddTicks(8803), new DateTime(2024, 11, 15, 4, 46, 39, 62, DateTimeKind.Utc).AddTicks(8677), new DateTime(2024, 11, 11, 18, 16, 50, 452, DateTimeKind.Utc).AddTicks(414) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "ClosedDateTimeUTC", "CreatedDateTimeUTC", "PlannedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 17, 2, 49, 10, 652, DateTimeKind.Utc).AddTicks(6137), new DateTime(2024, 11, 14, 8, 6, 7, 834, DateTimeKind.Utc).AddTicks(5618), new DateTime(2024, 11, 16, 2, 45, 38, 138, DateTimeKind.Utc).AddTicks(9024), new DateTime(2024, 11, 11, 0, 22, 52, 946, DateTimeKind.Utc).AddTicks(4471) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 16, 18, 14, 45, 713, DateTimeKind.Utc).AddTicks(650), new DateTime(2024, 11, 15, 22, 34, 55, 276, DateTimeKind.Utc).AddTicks(9690) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 10, 17, 41, 27, 547, DateTimeKind.Utc).AddTicks(1623), new DateTime(2024, 11, 14, 2, 26, 55, 225, DateTimeKind.Utc).AddTicks(3776) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "ClosedDateTimeUTC", "CreatedDateTimeUTC", "PlannedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 17, 11, 3, 58, 78, DateTimeKind.Utc).AddTicks(2501), new DateTime(2024, 11, 14, 12, 25, 35, 996, DateTimeKind.Utc).AddTicks(6826), new DateTime(2024, 11, 15, 19, 0, 58, 834, DateTimeKind.Utc).AddTicks(9952), new DateTime(2024, 11, 12, 1, 56, 41, 439, DateTimeKind.Utc).AddTicks(2817) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDateTimeUTC", "PlannedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 17, 13, 47, 35, 911, DateTimeKind.Utc).AddTicks(9058), new DateTime(2024, 11, 14, 23, 0, 35, 19, DateTimeKind.Utc).AddTicks(9522), new DateTime(2024, 11, 16, 20, 29, 27, 108, DateTimeKind.Utc).AddTicks(1152) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "ClosedDateTimeUTC", "CreatedDateTimeUTC", "PlannedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 15, 10, 1, 21, 364, DateTimeKind.Utc).AddTicks(5210), new DateTime(2024, 11, 13, 12, 12, 57, 270, DateTimeKind.Utc).AddTicks(1138), new DateTime(2024, 11, 17, 5, 45, 17, 896, DateTimeKind.Utc).AddTicks(486), new DateTime(2024, 11, 16, 8, 18, 18, 885, DateTimeKind.Utc).AddTicks(7997) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "ClosedDateTimeUTC", "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 15, 23, 47, 15, 753, DateTimeKind.Utc).AddTicks(1065), new DateTime(2024, 11, 14, 0, 4, 33, 425, DateTimeKind.Utc).AddTicks(6077), new DateTime(2024, 11, 10, 15, 23, 37, 641, DateTimeKind.Utc).AddTicks(748) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "ClosedDateTimeUTC", "CreatedDateTimeUTC", "PlannedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 16, 6, 54, 12, 634, DateTimeKind.Utc).AddTicks(5702), new DateTime(2024, 11, 12, 9, 35, 19, 815, DateTimeKind.Utc).AddTicks(6095), new DateTime(2024, 11, 15, 23, 59, 0, 491, DateTimeKind.Utc).AddTicks(9551), new DateTime(2024, 11, 11, 20, 0, 27, 839, DateTimeKind.Utc).AddTicks(6632) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "ClosedDateTimeUTC", "CreatedDateTimeUTC", "PlannedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 16, 23, 21, 42, 771, DateTimeKind.Utc).AddTicks(2581), new DateTime(2024, 11, 14, 2, 21, 45, 365, DateTimeKind.Utc).AddTicks(9749), new DateTime(2024, 11, 17, 4, 2, 44, 975, DateTimeKind.Utc).AddTicks(391), new DateTime(2024, 11, 16, 12, 44, 38, 516, DateTimeKind.Utc).AddTicks(6498) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDateTimeUTC", "PlannedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 16, 19, 37, 55, 331, DateTimeKind.Utc).AddTicks(2664), new DateTime(2024, 11, 16, 17, 0, 19, 166, DateTimeKind.Utc).AddTicks(5858), new DateTime(2024, 11, 13, 1, 7, 6, 448, DateTimeKind.Utc).AddTicks(8092) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "ClosedDateTimeUTC", "CreatedDateTimeUTC", "PlannedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 16, 16, 17, 57, 395, DateTimeKind.Utc).AddTicks(2071), new DateTime(2024, 11, 14, 18, 6, 36, 293, DateTimeKind.Utc).AddTicks(7438), new DateTime(2024, 11, 15, 6, 29, 26, 796, DateTimeKind.Utc).AddTicks(2955), new DateTime(2024, 11, 12, 23, 32, 5, 135, DateTimeKind.Utc).AddTicks(1641) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 11, 1, 20, 30, 312, DateTimeKind.Utc).AddTicks(6326), new DateTime(2024, 11, 15, 13, 25, 28, 772, DateTimeKind.Utc).AddTicks(4727) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "ClosedDateTimeUTC", "CreatedDateTimeUTC", "PlannedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 14, 18, 43, 31, 990, DateTimeKind.Utc).AddTicks(4402), new DateTime(2024, 11, 14, 9, 47, 8, 19, DateTimeKind.Utc).AddTicks(3845), new DateTime(2024, 11, 15, 15, 5, 24, 806, DateTimeKind.Utc).AddTicks(7053), new DateTime(2024, 11, 17, 0, 39, 13, 874, DateTimeKind.Utc).AddTicks(3673) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "ClosedDateTimeUTC", "CreatedDateTimeUTC", "PlannedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 14, 22, 2, 21, 713, DateTimeKind.Utc).AddTicks(740), new DateTime(2024, 11, 12, 9, 35, 18, 21, DateTimeKind.Utc).AddTicks(5141), new DateTime(2024, 11, 15, 2, 47, 46, 799, DateTimeKind.Utc).AddTicks(7988), new DateTime(2024, 11, 11, 2, 19, 31, 454, DateTimeKind.Utc).AddTicks(6947) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "ClosedDateTimeUTC", "CreatedDateTimeUTC", "PlannedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 16, 23, 19, 51, 427, DateTimeKind.Utc).AddTicks(6716), new DateTime(2024, 11, 15, 23, 1, 4, 367, DateTimeKind.Utc).AddTicks(9586), new DateTime(2024, 11, 16, 14, 14, 42, 47, DateTimeKind.Utc).AddTicks(9250), new DateTime(2024, 11, 14, 12, 59, 54, 878, DateTimeKind.Utc).AddTicks(5739) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 12, 18, 15, 20, 676, DateTimeKind.Utc).AddTicks(8556), new DateTime(2024, 11, 16, 12, 35, 57, 346, DateTimeKind.Utc).AddTicks(1014) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "ClosedDateTimeUTC", "CreatedDateTimeUTC", "PlannedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 15, 9, 0, 52, 85, DateTimeKind.Utc).AddTicks(7877), new DateTime(2024, 11, 12, 10, 34, 6, 976, DateTimeKind.Utc).AddTicks(6625), new DateTime(2024, 11, 15, 2, 27, 0, 420, DateTimeKind.Utc).AddTicks(1145), new DateTime(2024, 11, 11, 11, 17, 9, 574, DateTimeKind.Utc).AddTicks(3254) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDateTimeUTC", "PlannedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 12, 10, 22, 30, 720, DateTimeKind.Utc).AddTicks(9411), new DateTime(2024, 11, 15, 5, 6, 51, 430, DateTimeKind.Utc).AddTicks(232), new DateTime(2024, 11, 13, 11, 3, 45, 960, DateTimeKind.Utc).AddTicks(9889) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "ClosedDateTimeUTC", "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 16, 18, 39, 1, 259, DateTimeKind.Utc).AddTicks(9719), new DateTime(2024, 11, 17, 0, 3, 1, 154, DateTimeKind.Utc).AddTicks(2529), new DateTime(2024, 11, 15, 23, 25, 44, 581, DateTimeKind.Utc).AddTicks(7943) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "ClosedDateTimeUTC", "CreatedDateTimeUTC", "PlannedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 17, 3, 24, 29, 284, DateTimeKind.Utc).AddTicks(4040), new DateTime(2024, 11, 13, 7, 4, 33, 173, DateTimeKind.Utc).AddTicks(1982), new DateTime(2024, 11, 15, 7, 45, 50, 474, DateTimeKind.Utc).AddTicks(5143), new DateTime(2024, 11, 11, 20, 39, 28, 865, DateTimeKind.Utc).AddTicks(812) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "ClosedDateTimeUTC", "CreatedDateTimeUTC", "PlannedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 14, 16, 13, 15, 854, DateTimeKind.Utc).AddTicks(4209), new DateTime(2024, 11, 17, 11, 40, 29, 687, DateTimeKind.Utc).AddTicks(147), new DateTime(2024, 11, 15, 16, 52, 4, 715, DateTimeKind.Utc).AddTicks(8625), new DateTime(2024, 11, 10, 21, 56, 50, 828, DateTimeKind.Utc).AddTicks(677) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 11, 22, 56, 20, 558, DateTimeKind.Utc).AddTicks(7171), new DateTime(2024, 11, 14, 2, 50, 13, 95, DateTimeKind.Utc).AddTicks(1254) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "ClosedDateTimeUTC", "CreatedDateTimeUTC", "PlannedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 14, 16, 33, 36, 908, DateTimeKind.Utc).AddTicks(8793), new DateTime(2024, 11, 13, 7, 42, 45, 851, DateTimeKind.Utc).AddTicks(4071), new DateTime(2024, 11, 16, 4, 53, 50, 769, DateTimeKind.Utc).AddTicks(2267), new DateTime(2024, 11, 11, 10, 56, 14, 430, DateTimeKind.Utc).AddTicks(8149) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDateTimeUTC", "PlannedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 17, 11, 24, 52, 134, DateTimeKind.Utc).AddTicks(6433), new DateTime(2024, 11, 16, 0, 19, 0, 473, DateTimeKind.Utc).AddTicks(7612), new DateTime(2024, 11, 16, 8, 27, 37, 193, DateTimeKind.Utc).AddTicks(3311) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDateTimeUTC", "PlannedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 13, 17, 4, 48, 644, DateTimeKind.Utc).AddTicks(8709), new DateTime(2024, 11, 16, 22, 59, 58, 654, DateTimeKind.Utc).AddTicks(1853), new DateTime(2024, 11, 15, 2, 54, 44, 614, DateTimeKind.Utc).AddTicks(2766) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "ClosedDateTimeUTC", "CreatedDateTimeUTC", "PlannedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 15, 9, 30, 8, 553, DateTimeKind.Utc).AddTicks(6059), new DateTime(2024, 11, 16, 18, 17, 45, 124, DateTimeKind.Utc).AddTicks(2153), new DateTime(2024, 11, 16, 17, 19, 15, 441, DateTimeKind.Utc).AddTicks(3459), new DateTime(2024, 11, 14, 18, 34, 24, 237, DateTimeKind.Utc).AddTicks(5675) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "ClosedDateTimeUTC", "CreatedDateTimeUTC", "PlannedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 14, 20, 39, 34, 221, DateTimeKind.Utc).AddTicks(1423), new DateTime(2024, 11, 16, 19, 45, 26, 698, DateTimeKind.Utc).AddTicks(5389), new DateTime(2024, 11, 17, 13, 41, 6, 49, DateTimeKind.Utc).AddTicks(542), new DateTime(2024, 11, 11, 11, 53, 26, 431, DateTimeKind.Utc).AddTicks(4583) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "ClosedDateTimeUTC", "CreatedDateTimeUTC", "PlannedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 15, 18, 54, 34, 227, DateTimeKind.Utc).AddTicks(859), new DateTime(2024, 11, 11, 9, 59, 31, 458, DateTimeKind.Utc).AddTicks(433), new DateTime(2024, 11, 17, 0, 30, 32, 375, DateTimeKind.Utc).AddTicks(8965), new DateTime(2024, 11, 12, 16, 45, 9, 347, DateTimeKind.Utc).AddTicks(6125) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "ClosedDateTimeUTC", "CreatedDateTimeUTC", "PlannedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 15, 23, 46, 15, 887, DateTimeKind.Utc).AddTicks(3599), new DateTime(2024, 11, 12, 0, 48, 54, 570, DateTimeKind.Utc).AddTicks(2092), new DateTime(2024, 11, 15, 11, 59, 6, 987, DateTimeKind.Utc).AddTicks(6059), new DateTime(2024, 11, 13, 12, 49, 46, 513, DateTimeKind.Utc).AddTicks(7840) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 13, 23, 29, 36, 193, DateTimeKind.Utc).AddTicks(2363), new DateTime(2024, 11, 15, 6, 37, 23, 800, DateTimeKind.Utc).AddTicks(4376) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "ClosedDateTimeUTC", "CreatedDateTimeUTC", "PlannedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 15, 2, 52, 9, 509, DateTimeKind.Utc).AddTicks(5179), new DateTime(2024, 11, 16, 19, 41, 43, 272, DateTimeKind.Utc).AddTicks(5982), new DateTime(2024, 11, 16, 18, 37, 53, 6, DateTimeKind.Utc).AddTicks(725), new DateTime(2024, 11, 15, 8, 53, 59, 102, DateTimeKind.Utc).AddTicks(9370) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDateTimeUTC", "PlannedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 11, 21, 37, 36, 640, DateTimeKind.Utc).AddTicks(6461), new DateTime(2024, 11, 17, 5, 58, 49, 146, DateTimeKind.Utc).AddTicks(4711), new DateTime(2024, 11, 17, 5, 46, 58, 595, DateTimeKind.Utc).AddTicks(202) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 13, 18, 26, 58, 615, DateTimeKind.Utc).AddTicks(6962), new DateTime(2024, 11, 17, 10, 55, 55, 774, DateTimeKind.Utc).AddTicks(638) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "ClosedDateTimeUTC", "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 15, 15, 30, 14, 399, DateTimeKind.Utc).AddTicks(7106), new DateTime(2024, 11, 13, 4, 42, 54, 952, DateTimeKind.Utc).AddTicks(1782), new DateTime(2024, 11, 15, 19, 41, 34, 700, DateTimeKind.Utc).AddTicks(9811) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "ClosedDateTimeUTC", "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 17, 0, 10, 55, 234, DateTimeKind.Utc).AddTicks(8192), new DateTime(2024, 11, 16, 12, 14, 46, 65, DateTimeKind.Utc).AddTicks(3683), new DateTime(2024, 11, 13, 6, 37, 54, 521, DateTimeKind.Utc).AddTicks(2776) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedDateTimeUTC", "PlannedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 16, 11, 2, 58, 297, DateTimeKind.Utc).AddTicks(286), new DateTime(2024, 11, 16, 12, 23, 2, 431, DateTimeKind.Utc).AddTicks(1484), new DateTime(2024, 11, 15, 3, 31, 1, 162, DateTimeKind.Utc).AddTicks(5902) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "ClosedDateTimeUTC", "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 16, 13, 36, 10, 975, DateTimeKind.Utc).AddTicks(3605), new DateTime(2024, 11, 15, 14, 32, 7, 577, DateTimeKind.Utc).AddTicks(3492), new DateTime(2024, 11, 12, 22, 25, 55, 981, DateTimeKind.Utc).AddTicks(27) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 14, 2, 17, 7, 311, DateTimeKind.Utc).AddTicks(1675), new DateTime(2024, 11, 13, 8, 10, 32, 446, DateTimeKind.Utc).AddTicks(4532) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 16, 21, 40, 7, 2, DateTimeKind.Utc).AddTicks(9194), new DateTime(2024, 11, 11, 19, 48, 7, 182, DateTimeKind.Utc).AddTicks(6379) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "ClosedDateTimeUTC", "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 16, 23, 38, 45, 315, DateTimeKind.Utc).AddTicks(7892), new DateTime(2024, 11, 13, 1, 34, 24, 790, DateTimeKind.Utc).AddTicks(2388), new DateTime(2024, 11, 13, 23, 16, 35, 748, DateTimeKind.Utc).AddTicks(7078) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "ClosedDateTimeUTC", "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 14, 21, 34, 31, 986, DateTimeKind.Utc).AddTicks(6229), new DateTime(2024, 11, 16, 14, 53, 47, 419, DateTimeKind.Utc).AddTicks(3791), new DateTime(2024, 11, 17, 13, 46, 55, 659, DateTimeKind.Utc).AddTicks(41) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "ClosedDateTimeUTC", "CreatedDateTimeUTC", "PlannedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 16, 23, 36, 2, 606, DateTimeKind.Utc).AddTicks(7915), new DateTime(2024, 11, 16, 4, 59, 36, 745, DateTimeKind.Utc).AddTicks(8295), new DateTime(2024, 11, 15, 4, 6, 49, 4, DateTimeKind.Utc).AddTicks(2166), new DateTime(2024, 11, 15, 17, 2, 43, 599, DateTimeKind.Utc).AddTicks(3554) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "ClosedDateTimeUTC", "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 17, 8, 34, 13, 56, DateTimeKind.Utc).AddTicks(6561), new DateTime(2024, 11, 14, 0, 39, 56, 219, DateTimeKind.Utc).AddTicks(2787), new DateTime(2024, 11, 13, 0, 46, 57, 417, DateTimeKind.Utc).AddTicks(768) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "ClosedDateTimeUTC", "CreatedDateTimeUTC", "PlannedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 15, 7, 6, 6, 211, DateTimeKind.Utc).AddTicks(8919), new DateTime(2024, 11, 16, 15, 55, 52, 870, DateTimeKind.Utc).AddTicks(5499), new DateTime(2024, 11, 16, 2, 57, 29, 930, DateTimeKind.Utc).AddTicks(5329), new DateTime(2024, 11, 14, 3, 13, 44, 311, DateTimeKind.Utc).AddTicks(4435) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 11, 12, 27, 5, 289, DateTimeKind.Utc).AddTicks(6293), new DateTime(2024, 11, 14, 3, 37, 19, 276, DateTimeKind.Utc).AddTicks(1074) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "ClosedDateTimeUTC", "CreatedDateTimeUTC", "PlannedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 15, 9, 6, 4, 312, DateTimeKind.Utc).AddTicks(5290), new DateTime(2024, 11, 15, 4, 37, 33, 349, DateTimeKind.Utc).AddTicks(9745), new DateTime(2024, 11, 16, 14, 2, 57, 872, DateTimeKind.Utc).AddTicks(4867), new DateTime(2024, 11, 11, 19, 2, 58, 240, DateTimeKind.Utc).AddTicks(7978) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "ClosedDateTimeUTC", "CreatedDateTimeUTC", "PlannedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 16, 22, 31, 0, 551, DateTimeKind.Utc).AddTicks(873), new DateTime(2024, 11, 11, 11, 21, 41, 349, DateTimeKind.Utc).AddTicks(1360), new DateTime(2024, 11, 16, 8, 5, 22, 995, DateTimeKind.Utc).AddTicks(8434), new DateTime(2024, 11, 12, 3, 17, 20, 15, DateTimeKind.Utc).AddTicks(7871) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Tasks",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDateTimeUTC", "PasswordHash", "SecurityStamp", "UpdatedDateTimeUTC" },
                values: new object[] { "cc01ea3a-59b0-467d-b32c-032ca4e3c1df", new DateTime(2024, 11, 16, 18, 20, 54, 519, DateTimeKind.Utc).AddTicks(5560), "AQAAAAIAAYagAAAAEHYu5Ka5UKKD3OhcrOGV/mYFVUKd7g13hI8Y2/A3+LNaY3zNJqqCcujoyUpLgbuRtQ==", "f62a21ad-97ad-49ce-82b6-c3da8efe3e88", new DateTime(2024, 11, 16, 18, 20, 54, 519, DateTimeKind.Utc).AddTicks(5877) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedDateTimeUTC", "PasswordHash", "SecurityStamp", "UpdatedDateTimeUTC" },
                values: new object[] { "616ca070-9a1c-4854-a2fc-850ba76e7d4d", new DateTime(2024, 11, 16, 18, 20, 54, 519, DateTimeKind.Utc).AddTicks(7874), "AQAAAAIAAYagAAAAELej/q5KrCL0hz/1KXY9FrXNvyn1eXq5VEHzjo5tGu2cyOf1XJrvAqZJshtdV2Trew==", "3c023bb6-abcd-41b7-8fe1-9e1327ac1702", new DateTime(2024, 11, 16, 18, 20, 54, 519, DateTimeKind.Utc).AddTicks(7888) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "CreatedDateTimeUTC", "PasswordHash", "SecurityStamp", "UpdatedDateTimeUTC" },
                values: new object[] { "861c8a82-6b8d-480f-b553-16128793e4d9", new DateTime(2024, 11, 16, 18, 20, 54, 519, DateTimeKind.Utc).AddTicks(8393), "AQAAAAIAAYagAAAAEHf+oonTDxWa1Wvi5EmMGf3nhN7SS+JxAW0O/cnZQKe0TbFu5RQ4ZiOuW6CUm3x34A==", "79acfaa0-9eb0-4cc0-b256-731d191e3cd6", new DateTime(2024, 11, 16, 18, 20, 54, 519, DateTimeKind.Utc).AddTicks(8400) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "CreatedDateTimeUTC", "PasswordHash", "SecurityStamp", "UpdatedDateTimeUTC" },
                values: new object[] { "a469e678-f6e6-443a-adb8-c7410dfa0639", new DateTime(2024, 11, 16, 18, 20, 54, 519, DateTimeKind.Utc).AddTicks(8693), "AQAAAAIAAYagAAAAEEQj7JwyAsyPPR/cbDc7P17uATNDI+2ewltPayC6ZOjRlF6wj7nnMD8/HWNYB05TZA==", "ea14d62e-c4d0-4a0f-a25f-abb9059822e3", new DateTime(2024, 11, 16, 18, 20, 54, 519, DateTimeKind.Utc).AddTicks(8702) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "CreatedDateTimeUTC", "PasswordHash", "SecurityStamp", "UpdatedDateTimeUTC" },
                values: new object[] { "d1577d72-56c2-402f-9c47-08b1d283c318", new DateTime(2024, 11, 16, 18, 20, 54, 519, DateTimeKind.Utc).AddTicks(9033), "AQAAAAIAAYagAAAAEFy9rvGqhlq/UOxQ88qxlEYitjpG0W2dBIfg1O5vib9rPghWhTbNLdh26+KZ8hx8lg==", "222f2423-f744-460f-a0bc-ad275c12b194", new DateTime(2024, 11, 16, 18, 20, 54, 519, DateTimeKind.Utc).AddTicks(9039) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ConcurrencyStamp", "CreatedDateTimeUTC", "PasswordHash", "SecurityStamp", "UpdatedDateTimeUTC" },
                values: new object[] { "7809d188-db16-4eee-8cef-f48f570f0c5e", new DateTime(2024, 11, 16, 18, 20, 54, 519, DateTimeKind.Utc).AddTicks(9593), "AQAAAAIAAYagAAAAEKWcosSFa7r9cIonTsD0m7RUbqdsBbnhtBzjF2KQooC6Si2zYj3pQzND7wXzmQsm5A==", "b742a28e-2697-47c3-95e0-ba9ac0aa414f", new DateTime(2024, 11, 16, 18, 20, 54, 519, DateTimeKind.Utc).AddTicks(9598) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ConcurrencyStamp", "CreatedDateTimeUTC", "PasswordHash", "SecurityStamp", "UpdatedDateTimeUTC" },
                values: new object[] { "962377cb-bb3d-4d97-b101-2c6db9e53691", new DateTime(2024, 11, 16, 18, 20, 54, 519, DateTimeKind.Utc).AddTicks(9852), "AQAAAAIAAYagAAAAEPzzG3spr1ROdxbJBd7xDLwWfdgT12Xyu5FXTu98z7uIzhJoYHscMiANfUS4EXdkXw==", "d876db20-61d0-43db-9b6f-2fd50988e172", new DateTime(2024, 11, 16, 18, 20, 54, 519, DateTimeKind.Utc).AddTicks(9856) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 14, 3, 40, 10, 14, DateTimeKind.Utc).AddTicks(1369), new DateTime(2024, 11, 13, 7, 49, 13, 65, DateTimeKind.Utc).AddTicks(8405) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 12, 15, 22, 8, 509, DateTimeKind.Utc).AddTicks(8279), new DateTime(2024, 11, 15, 9, 56, 3, 835, DateTimeKind.Utc).AddTicks(6168) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 10, 19, 37, 23, 407, DateTimeKind.Utc).AddTicks(598), new DateTime(2024, 11, 12, 14, 27, 47, 422, DateTimeKind.Utc).AddTicks(9989) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 11, 15, 36, 18, 151, DateTimeKind.Utc).AddTicks(8817), new DateTime(2024, 11, 13, 1, 23, 1, 316, DateTimeKind.Utc).AddTicks(8608) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 14, 4, 27, 46, 988, DateTimeKind.Utc).AddTicks(8570), new DateTime(2024, 11, 11, 21, 8, 12, 944, DateTimeKind.Utc).AddTicks(8964) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 14, 18, 46, 53, 454, DateTimeKind.Utc).AddTicks(1712), new DateTime(2024, 11, 14, 6, 51, 20, 49, DateTimeKind.Utc).AddTicks(8520) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 11, 21, 11, 9, 873, DateTimeKind.Utc).AddTicks(4211), new DateTime(2024, 11, 16, 1, 31, 49, 899, DateTimeKind.Utc).AddTicks(4817) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 15, 7, 37, 46, 335, DateTimeKind.Utc).AddTicks(506), new DateTime(2024, 11, 14, 4, 56, 12, 920, DateTimeKind.Utc).AddTicks(1958) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 15, 4, 38, 59, 699, DateTimeKind.Utc).AddTicks(3831), new DateTime(2024, 11, 12, 19, 51, 21, 421, DateTimeKind.Utc).AddTicks(6817) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 15, 6, 29, 5, 914, DateTimeKind.Utc).AddTicks(2550), new DateTime(2024, 11, 11, 1, 1, 23, 234, DateTimeKind.Utc).AddTicks(5790) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 16, 0, 50, 58, 327, DateTimeKind.Utc).AddTicks(5635), new DateTime(2024, 11, 11, 9, 42, 33, 849, DateTimeKind.Utc).AddTicks(8903) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 14, 14, 42, 47, 448, DateTimeKind.Utc).AddTicks(426), new DateTime(2024, 11, 15, 7, 16, 40, 81, DateTimeKind.Utc).AddTicks(2909) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 12, 13, 30, 17, 767, DateTimeKind.Utc).AddTicks(2872), new DateTime(2024, 11, 13, 13, 53, 24, 256, DateTimeKind.Utc).AddTicks(483) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 12, 1, 26, 44, 97, DateTimeKind.Utc).AddTicks(624), new DateTime(2024, 11, 13, 6, 37, 23, 756, DateTimeKind.Utc).AddTicks(2217) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 12, 6, 39, 12, 392, DateTimeKind.Utc).AddTicks(6239), new DateTime(2024, 11, 13, 23, 57, 37, 155, DateTimeKind.Utc).AddTicks(9383) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 16, 11, 6, 55, 820, DateTimeKind.Utc).AddTicks(4579), new DateTime(2024, 11, 15, 3, 52, 46, 882, DateTimeKind.Utc).AddTicks(4784) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 12, 14, 13, 12, 96, DateTimeKind.Utc).AddTicks(3538), new DateTime(2024, 11, 16, 11, 20, 51, 219, DateTimeKind.Utc).AddTicks(7506) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 13, 16, 15, 26, 778, DateTimeKind.Utc).AddTicks(6337), new DateTime(2024, 11, 14, 11, 54, 46, 480, DateTimeKind.Utc).AddTicks(5610) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 13, 22, 51, 46, 397, DateTimeKind.Utc).AddTicks(88), new DateTime(2024, 11, 14, 22, 0, 58, 252, DateTimeKind.Utc).AddTicks(57) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 12, 0, 8, 4, 539, DateTimeKind.Utc).AddTicks(6220), new DateTime(2024, 11, 16, 5, 20, 44, 630, DateTimeKind.Utc).AddTicks(8358) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 12, 15, 54, 20, 199, DateTimeKind.Utc).AddTicks(6653), new DateTime(2024, 11, 14, 23, 40, 41, 848, DateTimeKind.Utc).AddTicks(1875) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 15, 2, 6, 48, 414, DateTimeKind.Utc).AddTicks(8397), new DateTime(2024, 11, 11, 12, 5, 44, 802, DateTimeKind.Utc).AddTicks(8379) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 11, 1, 4, 40, 881, DateTimeKind.Utc).AddTicks(1523), new DateTime(2024, 11, 15, 8, 29, 34, 261, DateTimeKind.Utc).AddTicks(1440) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 13, 13, 10, 28, 41, DateTimeKind.Utc).AddTicks(152), new DateTime(2024, 11, 11, 0, 6, 43, 789, DateTimeKind.Utc).AddTicks(4382) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 11, 1, 17, 4, 352, DateTimeKind.Utc).AddTicks(7987), new DateTime(2024, 11, 16, 10, 57, 13, 74, DateTimeKind.Utc).AddTicks(1312) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 12, 3, 22, 44, 375, DateTimeKind.Utc).AddTicks(9082), new DateTime(2024, 11, 13, 9, 53, 34, 196, DateTimeKind.Utc).AddTicks(3036) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 13, 17, 47, 43, 790, DateTimeKind.Utc).AddTicks(2971), new DateTime(2024, 11, 12, 5, 37, 37, 84, DateTimeKind.Utc).AddTicks(537) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 11, 9, 17, 45, 684, DateTimeKind.Utc).AddTicks(8166), new DateTime(2024, 11, 12, 23, 16, 16, 886, DateTimeKind.Utc).AddTicks(8655) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 14, 23, 4, 4, 573, DateTimeKind.Utc).AddTicks(1692), new DateTime(2024, 11, 11, 21, 46, 26, 278, DateTimeKind.Utc).AddTicks(2179) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 11, 13, 0, 29, 643, DateTimeKind.Utc).AddTicks(1709), new DateTime(2024, 11, 14, 9, 29, 45, 78, DateTimeKind.Utc).AddTicks(9211) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 11, 3, 32, 20, 236, DateTimeKind.Utc).AddTicks(3284), new DateTime(2024, 11, 14, 5, 47, 0, 559, DateTimeKind.Utc).AddTicks(717) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 13, 6, 10, 58, 466, DateTimeKind.Utc).AddTicks(4350), new DateTime(2024, 11, 14, 22, 3, 12, 527, DateTimeKind.Utc).AddTicks(742) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 10, 22, 17, 35, 112, DateTimeKind.Utc).AddTicks(8363), new DateTime(2024, 11, 15, 5, 13, 22, 640, DateTimeKind.Utc).AddTicks(1363) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 14, 5, 8, 3, 918, DateTimeKind.Utc).AddTicks(7705), new DateTime(2024, 11, 15, 23, 31, 28, 465, DateTimeKind.Utc).AddTicks(6403) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 15, 8, 2, 53, 179, DateTimeKind.Utc).AddTicks(7381), new DateTime(2024, 11, 16, 12, 21, 37, 970, DateTimeKind.Utc).AddTicks(5747) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 14, 2, 48, 53, 155, DateTimeKind.Utc).AddTicks(3299), new DateTime(2024, 11, 13, 9, 20, 37, 366, DateTimeKind.Utc).AddTicks(969) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 14, 17, 40, 20, 71, DateTimeKind.Utc).AddTicks(6066), new DateTime(2024, 11, 13, 6, 28, 21, 27, DateTimeKind.Utc).AddTicks(5581) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 16, 16, 2, 25, 665, DateTimeKind.Utc).AddTicks(8125), new DateTime(2024, 11, 14, 12, 2, 27, 366, DateTimeKind.Utc).AddTicks(6763) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 13, 3, 27, 59, 988, DateTimeKind.Utc).AddTicks(2800), new DateTime(2024, 11, 12, 5, 3, 51, 916, DateTimeKind.Utc).AddTicks(3290) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 15, 22, 11, 32, 969, DateTimeKind.Utc).AddTicks(9148), new DateTime(2024, 11, 14, 3, 8, 51, 869, DateTimeKind.Utc).AddTicks(215) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 12, 13, 25, 40, 721, DateTimeKind.Utc).AddTicks(7040), new DateTime(2024, 11, 15, 18, 39, 7, 962, DateTimeKind.Utc).AddTicks(2498) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 14, 15, 41, 17, 661, DateTimeKind.Utc).AddTicks(5135), new DateTime(2024, 11, 11, 19, 3, 11, 458, DateTimeKind.Utc).AddTicks(5787) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 12, 14, 11, 36, 350, DateTimeKind.Utc).AddTicks(1296), new DateTime(2024, 11, 16, 8, 29, 8, 135, DateTimeKind.Utc).AddTicks(5252) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 14, 11, 6, 50, 677, DateTimeKind.Utc).AddTicks(7127), new DateTime(2024, 11, 14, 21, 26, 3, 220, DateTimeKind.Utc).AddTicks(9336) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 15, 14, 26, 23, 506, DateTimeKind.Utc).AddTicks(9704), new DateTime(2024, 11, 13, 15, 3, 0, 810, DateTimeKind.Utc).AddTicks(5245) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 11, 8, 0, 45, 262, DateTimeKind.Utc).AddTicks(6461), new DateTime(2024, 11, 11, 17, 50, 43, 762, DateTimeKind.Utc).AddTicks(2722) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 14, 6, 48, 44, 393, DateTimeKind.Utc).AddTicks(910), new DateTime(2024, 11, 14, 5, 52, 36, 623, DateTimeKind.Utc).AddTicks(3072) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 12, 0, 13, 7, 710, DateTimeKind.Utc).AddTicks(4314), new DateTime(2024, 11, 15, 15, 58, 27, 759, DateTimeKind.Utc).AddTicks(4759) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 12, 18, 58, 41, 708, DateTimeKind.Utc).AddTicks(7358), new DateTime(2024, 11, 16, 0, 29, 36, 869, DateTimeKind.Utc).AddTicks(4881) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 13, 18, 39, 49, 904, DateTimeKind.Utc).AddTicks(1986), new DateTime(2024, 11, 12, 19, 12, 43, 595, DateTimeKind.Utc).AddTicks(6483) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 11, 19, 12, 40, 266, DateTimeKind.Utc).AddTicks(6543), new DateTime(2024, 11, 13, 16, 49, 53, 549, DateTimeKind.Utc).AddTicks(64) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 14, 21, 22, 35, 479, DateTimeKind.Utc).AddTicks(1322), new DateTime(2024, 11, 12, 12, 58, 13, 902, DateTimeKind.Utc).AddTicks(3627) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 14, 0, 12, 43, 203, DateTimeKind.Utc).AddTicks(4994), new DateTime(2024, 11, 14, 6, 47, 43, 35, DateTimeKind.Utc).AddTicks(8562) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 16, 3, 20, 0, 26, DateTimeKind.Utc).AddTicks(7919), new DateTime(2024, 11, 12, 4, 53, 30, 173, DateTimeKind.Utc).AddTicks(7146) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 13, 20, 4, 31, 468, DateTimeKind.Utc).AddTicks(5989), new DateTime(2024, 11, 15, 23, 33, 34, 806, DateTimeKind.Utc).AddTicks(8871) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 16, 14, 29, 45, 58, DateTimeKind.Utc).AddTicks(7311), new DateTime(2024, 11, 15, 23, 0, 42, 660, DateTimeKind.Utc).AddTicks(5131) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 13, 1, 22, 55, 910, DateTimeKind.Utc).AddTicks(9936), new DateTime(2024, 11, 14, 14, 42, 10, 889, DateTimeKind.Utc).AddTicks(7324) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 14, 3, 41, 21, 335, DateTimeKind.Utc).AddTicks(3936), new DateTime(2024, 11, 16, 7, 11, 50, 58, DateTimeKind.Utc).AddTicks(3727) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 10, 23, 28, 49, 92, DateTimeKind.Utc).AddTicks(8586), new DateTime(2024, 11, 15, 12, 41, 11, 567, DateTimeKind.Utc).AddTicks(2567) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 16, 8, 33, 49, 665, DateTimeKind.Utc).AddTicks(9204), new DateTime(2024, 11, 16, 7, 46, 49, 750, DateTimeKind.Utc).AddTicks(152) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 13, 2, 51, 10, 314, DateTimeKind.Utc).AddTicks(7588), new DateTime(2024, 11, 11, 19, 45, 26, 255, DateTimeKind.Utc).AddTicks(3929) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 15, 0, 0, 35, 813, DateTimeKind.Utc).AddTicks(1192), new DateTime(2024, 11, 13, 11, 39, 20, 205, DateTimeKind.Utc).AddTicks(7360) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 13, 13, 51, 45, 732, DateTimeKind.Utc).AddTicks(576), new DateTime(2024, 11, 14, 7, 50, 19, 530, DateTimeKind.Utc).AddTicks(9876) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 10, 19, 32, 5, 125, DateTimeKind.Utc).AddTicks(2069), new DateTime(2024, 11, 11, 15, 29, 40, 356, DateTimeKind.Utc).AddTicks(2556) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 12, 15, 30, 33, 828, DateTimeKind.Utc).AddTicks(617), new DateTime(2024, 11, 12, 5, 31, 3, 175, DateTimeKind.Utc).AddTicks(3559) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 11, 15, 8, 39, 923, DateTimeKind.Utc).AddTicks(6472), new DateTime(2024, 11, 12, 13, 28, 58, 329, DateTimeKind.Utc).AddTicks(9790) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 13, 8, 39, 41, 463, DateTimeKind.Utc).AddTicks(3720), new DateTime(2024, 11, 11, 7, 37, 56, 889, DateTimeKind.Utc).AddTicks(2188) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 14, 1, 38, 41, 985, DateTimeKind.Utc).AddTicks(6748), new DateTime(2024, 11, 11, 6, 8, 49, 423, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 10, 20, 26, 0, 610, DateTimeKind.Utc).AddTicks(2713), new DateTime(2024, 11, 11, 7, 0, 25, 635, DateTimeKind.Utc).AddTicks(6887) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 11, 15, 36, 48, 912, DateTimeKind.Utc).AddTicks(5066), new DateTime(2024, 11, 15, 7, 27, 14, 460, DateTimeKind.Utc).AddTicks(1958) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 11, 0, 17, 53, 129, DateTimeKind.Utc).AddTicks(5291), new DateTime(2024, 11, 11, 10, 28, 4, 921, DateTimeKind.Utc).AddTicks(656) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 13, 16, 6, 9, 80, DateTimeKind.Utc).AddTicks(7226), new DateTime(2024, 11, 14, 23, 5, 28, 520, DateTimeKind.Utc).AddTicks(5724) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 15, 10, 41, 5, 20, DateTimeKind.Utc).AddTicks(7349), new DateTime(2024, 11, 14, 23, 51, 10, 339, DateTimeKind.Utc).AddTicks(7714) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 15, 8, 17, 23, 513, DateTimeKind.Utc).AddTicks(4511), new DateTime(2024, 11, 14, 18, 52, 38, 96, DateTimeKind.Utc).AddTicks(1534) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 12, 9, 36, 6, 147, DateTimeKind.Utc).AddTicks(2978), new DateTime(2024, 11, 10, 22, 4, 47, 253, DateTimeKind.Utc).AddTicks(1729) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 11, 19, 57, 29, 480, DateTimeKind.Utc).AddTicks(9859), new DateTime(2024, 11, 15, 21, 51, 52, 826, DateTimeKind.Utc).AddTicks(5839) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 12, 18, 26, 18, 233, DateTimeKind.Utc).AddTicks(2185), new DateTime(2024, 11, 13, 22, 28, 8, 631, DateTimeKind.Utc).AddTicks(7295) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 11, 3, 47, 39, 72, DateTimeKind.Utc).AddTicks(7909), new DateTime(2024, 11, 14, 0, 47, 43, 867, DateTimeKind.Utc).AddTicks(4910) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 11, 8, 59, 9, 783, DateTimeKind.Utc).AddTicks(7914), new DateTime(2024, 11, 14, 5, 9, 57, 979, DateTimeKind.Utc).AddTicks(9220) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 16, 9, 40, 38, 541, DateTimeKind.Utc).AddTicks(9211), new DateTime(2024, 11, 15, 14, 4, 32, 566, DateTimeKind.Utc).AddTicks(4056) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 15, 0, 52, 32, 96, DateTimeKind.Utc).AddTicks(6529), new DateTime(2024, 11, 14, 5, 32, 52, 229, DateTimeKind.Utc).AddTicks(4884) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 13, 5, 23, 53, 726, DateTimeKind.Utc).AddTicks(713), new DateTime(2024, 11, 13, 4, 24, 33, 914, DateTimeKind.Utc).AddTicks(3602) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 11, 7, 32, 18, 69, DateTimeKind.Utc).AddTicks(2322), new DateTime(2024, 11, 12, 10, 14, 29, 935, DateTimeKind.Utc).AddTicks(5430) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 12, 8, 36, 34, 275, DateTimeKind.Utc).AddTicks(3026), new DateTime(2024, 11, 16, 8, 29, 40, 792, DateTimeKind.Utc).AddTicks(511) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 11, 18, 15, 35, 539, DateTimeKind.Utc).AddTicks(9815), new DateTime(2024, 11, 14, 11, 31, 34, 147, DateTimeKind.Utc).AddTicks(6202) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 14, 0, 0, 3, 3, DateTimeKind.Utc).AddTicks(2815), new DateTime(2024, 11, 16, 2, 21, 44, 48, DateTimeKind.Utc).AddTicks(9493) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 15, 22, 53, 31, 793, DateTimeKind.Utc).AddTicks(7853), new DateTime(2024, 11, 12, 1, 55, 9, 184, DateTimeKind.Utc).AddTicks(6940) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 12, 2, 20, 17, 747, DateTimeKind.Utc).AddTicks(5234), new DateTime(2024, 11, 16, 15, 44, 55, 446, DateTimeKind.Utc).AddTicks(4189) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDateTimeUTC", "Name", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 16, 18, 20, 56, 385, DateTimeKind.Utc).AddTicks(8429), "Создана", new DateTime(2024, 11, 16, 18, 20, 56, 385, DateTimeKind.Utc).AddTicks(8461) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDateTimeUTC", "Name", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 16, 18, 20, 56, 385, DateTimeKind.Utc).AddTicks(8502), "В работе", new DateTime(2024, 11, 16, 18, 20, 56, 385, DateTimeKind.Utc).AddTicks(8506) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDateTimeUTC", "Name", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 16, 18, 20, 56, 385, DateTimeKind.Utc).AddTicks(8732), "Пауза", new DateTime(2024, 11, 16, 18, 20, 56, 385, DateTimeKind.Utc).AddTicks(8734) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDateTimeUTC", "Name", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 16, 18, 20, 56, 385, DateTimeKind.Utc).AddTicks(8740), "Завершена", new DateTime(2024, 11, 16, 18, 20, 56, 385, DateTimeKind.Utc).AddTicks(8741) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDateTimeUTC", "PlannedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 12, 22, 31, 18, 752, DateTimeKind.Utc).AddTicks(7877), new DateTime(2024, 11, 15, 2, 2, 37, 346, DateTimeKind.Utc).AddTicks(4488), new DateTime(2024, 11, 11, 20, 54, 58, 398, DateTimeKind.Utc).AddTicks(2847) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDateTimeUTC", "PlannedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 15, 4, 38, 45, 269, DateTimeKind.Utc).AddTicks(1407), new DateTime(2024, 11, 15, 1, 11, 30, 945, DateTimeKind.Utc).AddTicks(1234), new DateTime(2024, 11, 11, 3, 5, 51, 789, DateTimeKind.Utc).AddTicks(4177) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ClosedDateTimeUTC", "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 14, 0, 57, 0, 243, DateTimeKind.Utc).AddTicks(3340), new DateTime(2024, 11, 11, 16, 43, 53, 912, DateTimeKind.Utc).AddTicks(4177), new DateTime(2024, 11, 15, 12, 37, 50, 689, DateTimeKind.Utc).AddTicks(5735) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ClosedDateTimeUTC", "CreatedDateTimeUTC", "PlannedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 16, 1, 35, 7, 97, DateTimeKind.Utc).AddTicks(8087), new DateTime(2024, 11, 14, 22, 28, 53, 356, DateTimeKind.Utc).AddTicks(1916), new DateTime(2024, 11, 14, 22, 42, 24, 39, DateTimeKind.Utc).AddTicks(6350), new DateTime(2024, 11, 10, 7, 0, 22, 871, DateTimeKind.Utc).AddTicks(8642) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ClosedDateTimeUTC", "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 15, 6, 24, 9, 790, DateTimeKind.Utc).AddTicks(3679), new DateTime(2024, 11, 12, 1, 30, 54, 226, DateTimeKind.Utc).AddTicks(9723), new DateTime(2024, 11, 16, 4, 38, 38, 814, DateTimeKind.Utc).AddTicks(1209) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ClosedDateTimeUTC", "CreatedDateTimeUTC", "PlannedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 14, 18, 26, 16, 253, DateTimeKind.Utc).AddTicks(3864), new DateTime(2024, 11, 14, 14, 15, 10, 217, DateTimeKind.Utc).AddTicks(9740), new DateTime(2024, 11, 16, 9, 53, 41, 223, DateTimeKind.Utc).AddTicks(2508), new DateTime(2024, 11, 11, 8, 58, 21, 437, DateTimeKind.Utc).AddTicks(7494) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDateTimeUTC", "PlannedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 13, 0, 59, 52, 408, DateTimeKind.Utc).AddTicks(3657), new DateTime(2024, 11, 14, 16, 39, 7, 860, DateTimeKind.Utc).AddTicks(4406), new DateTime(2024, 11, 11, 1, 4, 41, 301, DateTimeKind.Utc).AddTicks(7128) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ClosedDateTimeUTC", "CreatedDateTimeUTC", "PlannedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 15, 21, 53, 9, 990, DateTimeKind.Utc).AddTicks(1378), new DateTime(2024, 11, 13, 14, 5, 42, 811, DateTimeKind.Utc).AddTicks(9620), new DateTime(2024, 11, 15, 9, 56, 10, 664, DateTimeKind.Utc).AddTicks(9817), new DateTime(2024, 11, 12, 21, 11, 51, 642, DateTimeKind.Utc).AddTicks(4725) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDateTimeUTC", "PlannedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 12, 0, 58, 55, 776, DateTimeKind.Utc).AddTicks(8338), new DateTime(2024, 11, 13, 19, 38, 4, 499, DateTimeKind.Utc).AddTicks(9228), new DateTime(2024, 11, 14, 10, 6, 15, 239, DateTimeKind.Utc).AddTicks(8085) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ClosedDateTimeUTC", "CreatedDateTimeUTC", "PlannedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 15, 6, 49, 20, 241, DateTimeKind.Utc).AddTicks(2598), new DateTime(2024, 11, 14, 16, 1, 35, 868, DateTimeKind.Utc).AddTicks(7823), new DateTime(2024, 11, 16, 7, 6, 28, 583, DateTimeKind.Utc).AddTicks(6238), new DateTime(2024, 11, 13, 5, 36, 58, 78, DateTimeKind.Utc).AddTicks(42) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ClosedDateTimeUTC", "CreatedDateTimeUTC", "PlannedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 15, 5, 57, 29, 711, DateTimeKind.Utc).AddTicks(4140), new DateTime(2024, 11, 16, 17, 37, 41, 186, DateTimeKind.Utc).AddTicks(3125), new DateTime(2024, 11, 14, 7, 40, 33, 394, DateTimeKind.Utc).AddTicks(6368), new DateTime(2024, 11, 11, 19, 37, 9, 787, DateTimeKind.Utc).AddTicks(2264) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ClosedDateTimeUTC", "CreatedDateTimeUTC", "PlannedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 15, 18, 23, 28, 548, DateTimeKind.Utc).AddTicks(6013), new DateTime(2024, 11, 11, 7, 38, 59, 918, DateTimeKind.Utc).AddTicks(7289), new DateTime(2024, 11, 16, 15, 3, 27, 829, DateTimeKind.Utc).AddTicks(2219), new DateTime(2024, 11, 16, 6, 17, 2, 919, DateTimeKind.Utc).AddTicks(6104) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDateTimeUTC", "PlannedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 12, 5, 26, 2, 515, DateTimeKind.Utc).AddTicks(6461), new DateTime(2024, 11, 15, 17, 47, 45, 643, DateTimeKind.Utc).AddTicks(255), new DateTime(2024, 11, 13, 22, 21, 46, 647, DateTimeKind.Utc).AddTicks(3942) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ClosedDateTimeUTC", "CreatedDateTimeUTC", "PlannedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 14, 14, 16, 45, 902, DateTimeKind.Utc).AddTicks(1207), new DateTime(2024, 11, 10, 14, 47, 45, 116, DateTimeKind.Utc).AddTicks(920), new DateTime(2024, 11, 15, 12, 33, 10, 263, DateTimeKind.Utc).AddTicks(2546), new DateTime(2024, 11, 13, 13, 11, 39, 950, DateTimeKind.Utc).AddTicks(9032) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ClosedDateTimeUTC", "CreatedDateTimeUTC", "PlannedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 16, 5, 22, 19, 262, DateTimeKind.Utc).AddTicks(444), new DateTime(2024, 11, 11, 22, 41, 41, 464, DateTimeKind.Utc).AddTicks(3443), new DateTime(2024, 11, 14, 15, 22, 19, 87, DateTimeKind.Utc).AddTicks(1637), new DateTime(2024, 11, 14, 7, 34, 45, 671, DateTimeKind.Utc).AddTicks(853) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ClosedDateTimeUTC", "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 15, 1, 58, 41, 698, DateTimeKind.Utc).AddTicks(9129), new DateTime(2024, 11, 9, 21, 23, 59, 269, DateTimeKind.Utc).AddTicks(503), new DateTime(2024, 11, 10, 15, 46, 54, 150, DateTimeKind.Utc).AddTicks(1398) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ClosedDateTimeUTC", "CreatedDateTimeUTC", "PlannedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 14, 12, 17, 28, 699, DateTimeKind.Utc).AddTicks(3708), new DateTime(2024, 11, 13, 13, 14, 31, 368, DateTimeKind.Utc).AddTicks(1493), new DateTime(2024, 11, 15, 23, 44, 54, 467, DateTimeKind.Utc).AddTicks(6682), new DateTime(2024, 11, 14, 21, 8, 26, 444, DateTimeKind.Utc).AddTicks(6304) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "ClosedDateTimeUTC", "CreatedDateTimeUTC", "PlannedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 14, 15, 58, 43, 813, DateTimeKind.Utc).AddTicks(9850), new DateTime(2024, 11, 14, 5, 8, 27, 693, DateTimeKind.Utc).AddTicks(2598), new DateTime(2024, 11, 15, 2, 3, 36, 295, DateTimeKind.Utc).AddTicks(1253), new DateTime(2024, 11, 13, 7, 56, 55, 461, DateTimeKind.Utc).AddTicks(538) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "ClosedDateTimeUTC", "CreatedDateTimeUTC", "PlannedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 14, 3, 2, 56, 255, DateTimeKind.Utc).AddTicks(4538), new DateTime(2024, 11, 15, 13, 42, 48, 223, DateTimeKind.Utc).AddTicks(3283), new DateTime(2024, 11, 14, 15, 58, 56, 408, DateTimeKind.Utc).AddTicks(8489), new DateTime(2024, 11, 10, 18, 47, 2, 952, DateTimeKind.Utc).AddTicks(9308) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "ClosedDateTimeUTC", "CreatedDateTimeUTC", "PlannedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 16, 13, 12, 11, 505, DateTimeKind.Utc).AddTicks(1355), new DateTime(2024, 11, 9, 21, 9, 59, 911, DateTimeKind.Utc).AddTicks(2237), new DateTime(2024, 11, 16, 4, 37, 45, 379, DateTimeKind.Utc).AddTicks(9656), new DateTime(2024, 11, 10, 4, 2, 47, 121, DateTimeKind.Utc).AddTicks(9799) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "ClosedDateTimeUTC", "CreatedDateTimeUTC", "PlannedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 14, 12, 12, 58, 85, DateTimeKind.Utc).AddTicks(2236), new DateTime(2024, 11, 13, 18, 59, 11, 322, DateTimeKind.Utc).AddTicks(7751), new DateTime(2024, 11, 15, 11, 2, 33, 831, DateTimeKind.Utc).AddTicks(9344), new DateTime(2024, 11, 13, 20, 58, 43, 388, DateTimeKind.Utc).AddTicks(1229) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "ClosedDateTimeUTC", "CreatedDateTimeUTC", "PlannedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 14, 7, 41, 15, 132, DateTimeKind.Utc).AddTicks(8487), new DateTime(2024, 11, 12, 5, 3, 37, 816, DateTimeKind.Utc).AddTicks(7450), new DateTime(2024, 11, 16, 4, 56, 27, 788, DateTimeKind.Utc).AddTicks(870), new DateTime(2024, 11, 13, 12, 10, 23, 607, DateTimeKind.Utc).AddTicks(9865) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "ClosedDateTimeUTC", "CreatedDateTimeUTC", "PlannedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 14, 21, 24, 45, 940, DateTimeKind.Utc).AddTicks(5190), new DateTime(2024, 11, 11, 14, 15, 36, 895, DateTimeKind.Utc).AddTicks(9798), new DateTime(2024, 11, 13, 19, 34, 9, 310, DateTimeKind.Utc).AddTicks(2911), new DateTime(2024, 11, 14, 11, 52, 1, 635, DateTimeKind.Utc).AddTicks(7670) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "ClosedDateTimeUTC", "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 13, 20, 32, 18, 566, DateTimeKind.Utc).AddTicks(7540), new DateTime(2024, 11, 12, 1, 22, 52, 476, DateTimeKind.Utc).AddTicks(991), new DateTime(2024, 11, 12, 14, 19, 51, 129, DateTimeKind.Utc).AddTicks(6778) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "ClosedDateTimeUTC", "CreatedDateTimeUTC", "PlannedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 15, 2, 3, 38, 131, DateTimeKind.Utc).AddTicks(7641), new DateTime(2024, 11, 15, 5, 23, 1, 428, DateTimeKind.Utc).AddTicks(5751), new DateTime(2024, 11, 14, 5, 5, 53, 120, DateTimeKind.Utc).AddTicks(7795), new DateTime(2024, 11, 9, 23, 57, 36, 745, DateTimeKind.Utc).AddTicks(7357) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "ClosedDateTimeUTC", "CreatedDateTimeUTC", "PlannedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 14, 1, 18, 35, 428, DateTimeKind.Utc).AddTicks(8831), new DateTime(2024, 11, 14, 11, 43, 57, 328, DateTimeKind.Utc).AddTicks(7769), new DateTime(2024, 11, 16, 16, 31, 45, 794, DateTimeKind.Utc).AddTicks(2877), new DateTime(2024, 11, 10, 16, 3, 7, 40, DateTimeKind.Utc).AddTicks(3795) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "ClosedDateTimeUTC", "CreatedDateTimeUTC", "PlannedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 14, 8, 12, 13, 394, DateTimeKind.Utc).AddTicks(5456), new DateTime(2024, 11, 14, 15, 56, 1, 128, DateTimeKind.Utc).AddTicks(8711), new DateTime(2024, 11, 15, 14, 8, 11, 111, DateTimeKind.Utc).AddTicks(8643), new DateTime(2024, 11, 13, 11, 22, 1, 158, DateTimeKind.Utc).AddTicks(6116) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "ClosedDateTimeUTC", "CreatedDateTimeUTC", "PlannedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 14, 11, 8, 15, 79, DateTimeKind.Utc).AddTicks(4313), new DateTime(2024, 11, 12, 9, 2, 10, 229, DateTimeKind.Utc).AddTicks(4894), new DateTime(2024, 11, 15, 2, 20, 21, 651, DateTimeKind.Utc).AddTicks(6597), new DateTime(2024, 11, 11, 1, 49, 44, 113, DateTimeKind.Utc).AddTicks(3622) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "ClosedDateTimeUTC", "CreatedDateTimeUTC", "PlannedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 15, 5, 48, 57, 505, DateTimeKind.Utc).AddTicks(757), new DateTime(2024, 11, 10, 9, 30, 29, 799, DateTimeKind.Utc).AddTicks(6271), new DateTime(2024, 11, 15, 22, 58, 58, 93, DateTimeKind.Utc).AddTicks(3729), new DateTime(2024, 11, 13, 15, 49, 46, 985, DateTimeKind.Utc).AddTicks(3162) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "ClosedDateTimeUTC", "CreatedDateTimeUTC", "PlannedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 15, 13, 47, 45, 375, DateTimeKind.Utc).AddTicks(6876), new DateTime(2024, 11, 14, 7, 32, 35, 995, DateTimeKind.Utc).AddTicks(503), new DateTime(2024, 11, 14, 7, 50, 59, 949, DateTimeKind.Utc).AddTicks(357), new DateTime(2024, 11, 10, 21, 21, 11, 338, DateTimeKind.Utc).AddTicks(2107) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "ClosedDateTimeUTC", "CreatedDateTimeUTC", "PlannedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 16, 5, 53, 31, 538, DateTimeKind.Utc).AddTicks(7430), new DateTime(2024, 11, 13, 11, 10, 28, 720, DateTimeKind.Utc).AddTicks(6925), new DateTime(2024, 11, 15, 5, 49, 59, 25, DateTimeKind.Utc).AddTicks(311), new DateTime(2024, 11, 10, 3, 27, 13, 832, DateTimeKind.Utc).AddTicks(5764) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 15, 21, 19, 6, 599, DateTimeKind.Utc).AddTicks(1705), new DateTime(2024, 11, 15, 1, 39, 16, 163, DateTimeKind.Utc).AddTicks(738) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 9, 20, 45, 48, 433, DateTimeKind.Utc).AddTicks(2587), new DateTime(2024, 11, 13, 5, 31, 16, 111, DateTimeKind.Utc).AddTicks(4729) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "ClosedDateTimeUTC", "CreatedDateTimeUTC", "PlannedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 16, 14, 8, 18, 964, DateTimeKind.Utc).AddTicks(2728), new DateTime(2024, 11, 13, 15, 29, 56, 882, DateTimeKind.Utc).AddTicks(7066), new DateTime(2024, 11, 14, 22, 5, 19, 721, DateTimeKind.Utc).AddTicks(167), new DateTime(2024, 11, 11, 5, 1, 2, 325, DateTimeKind.Utc).AddTicks(3047) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDateTimeUTC", "PlannedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 16, 16, 51, 56, 797, DateTimeKind.Utc).AddTicks(8937), new DateTime(2024, 11, 14, 2, 4, 55, 905, DateTimeKind.Utc).AddTicks(9390), new DateTime(2024, 11, 15, 23, 33, 47, 994, DateTimeKind.Utc).AddTicks(1028) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "ClosedDateTimeUTC", "CreatedDateTimeUTC", "PlannedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 14, 13, 5, 42, 250, DateTimeKind.Utc).AddTicks(4724), new DateTime(2024, 11, 12, 15, 17, 18, 156, DateTimeKind.Utc).AddTicks(659), new DateTime(2024, 11, 16, 8, 49, 38, 781, DateTimeKind.Utc).AddTicks(9992), new DateTime(2024, 11, 15, 11, 22, 39, 771, DateTimeKind.Utc).AddTicks(7512) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "ClosedDateTimeUTC", "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 15, 2, 51, 36, 639, DateTimeKind.Utc).AddTicks(123), new DateTime(2024, 11, 13, 3, 8, 54, 311, DateTimeKind.Utc).AddTicks(5146), new DateTime(2024, 11, 9, 18, 27, 58, 526, DateTimeKind.Utc).AddTicks(9812) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "ClosedDateTimeUTC", "CreatedDateTimeUTC", "PlannedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 15, 9, 58, 33, 520, DateTimeKind.Utc).AddTicks(4495), new DateTime(2024, 11, 11, 12, 39, 40, 701, DateTimeKind.Utc).AddTicks(4900), new DateTime(2024, 11, 15, 3, 3, 21, 377, DateTimeKind.Utc).AddTicks(8339), new DateTime(2024, 11, 10, 23, 4, 48, 725, DateTimeKind.Utc).AddTicks(5427) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "ClosedDateTimeUTC", "CreatedDateTimeUTC", "PlannedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 16, 2, 26, 3, 657, DateTimeKind.Utc).AddTicks(1024), new DateTime(2024, 11, 13, 5, 26, 6, 251, DateTimeKind.Utc).AddTicks(8200), new DateTime(2024, 11, 16, 7, 7, 5, 860, DateTimeKind.Utc).AddTicks(8830), new DateTime(2024, 11, 15, 15, 48, 59, 402, DateTimeKind.Utc).AddTicks(4946) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDateTimeUTC", "PlannedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 15, 22, 42, 16, 217, DateTimeKind.Utc).AddTicks(928), new DateTime(2024, 11, 15, 20, 4, 40, 52, DateTimeKind.Utc).AddTicks(4115), new DateTime(2024, 11, 12, 4, 11, 27, 334, DateTimeKind.Utc).AddTicks(6356) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "ClosedDateTimeUTC", "CreatedDateTimeUTC", "PlannedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 15, 19, 22, 18, 281, DateTimeKind.Utc).AddTicks(80), new DateTime(2024, 11, 13, 21, 10, 57, 179, DateTimeKind.Utc).AddTicks(5456), new DateTime(2024, 11, 14, 9, 33, 47, 682, DateTimeKind.Utc).AddTicks(956), new DateTime(2024, 11, 12, 2, 36, 26, 20, DateTimeKind.Utc).AddTicks(9654) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 10, 4, 24, 51, 198, DateTimeKind.Utc).AddTicks(3794), new DateTime(2024, 11, 14, 16, 29, 49, 658, DateTimeKind.Utc).AddTicks(2189) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "ClosedDateTimeUTC", "CreatedDateTimeUTC", "PlannedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 13, 21, 47, 52, 876, DateTimeKind.Utc).AddTicks(1831), new DateTime(2024, 11, 13, 12, 51, 28, 905, DateTimeKind.Utc).AddTicks(1283), new DateTime(2024, 11, 14, 18, 9, 45, 692, DateTimeKind.Utc).AddTicks(4474), new DateTime(2024, 11, 16, 3, 43, 34, 760, DateTimeKind.Utc).AddTicks(1106) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "ClosedDateTimeUTC", "CreatedDateTimeUTC", "PlannedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 14, 1, 6, 42, 598, DateTimeKind.Utc).AddTicks(7826), new DateTime(2024, 11, 11, 12, 39, 38, 907, DateTimeKind.Utc).AddTicks(2238), new DateTime(2024, 11, 14, 5, 52, 7, 685, DateTimeKind.Utc).AddTicks(5071), new DateTime(2024, 11, 10, 5, 23, 52, 340, DateTimeKind.Utc).AddTicks(4035) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "ClosedDateTimeUTC", "CreatedDateTimeUTC", "PlannedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 16, 2, 24, 12, 313, DateTimeKind.Utc).AddTicks(3318), new DateTime(2024, 11, 15, 2, 5, 25, 253, DateTimeKind.Utc).AddTicks(6199), new DateTime(2024, 11, 15, 17, 19, 2, 933, DateTimeKind.Utc).AddTicks(5843), new DateTime(2024, 11, 13, 16, 4, 15, 764, DateTimeKind.Utc).AddTicks(2343) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 11, 21, 19, 41, 562, DateTimeKind.Utc).AddTicks(4873), new DateTime(2024, 11, 15, 15, 40, 18, 231, DateTimeKind.Utc).AddTicks(7323) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "ClosedDateTimeUTC", "CreatedDateTimeUTC", "PlannedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 14, 12, 5, 12, 971, DateTimeKind.Utc).AddTicks(3849), new DateTime(2024, 11, 11, 13, 38, 27, 862, DateTimeKind.Utc).AddTicks(2604), new DateTime(2024, 11, 14, 5, 31, 21, 305, DateTimeKind.Utc).AddTicks(7109), new DateTime(2024, 11, 10, 14, 21, 30, 459, DateTimeKind.Utc).AddTicks(9228) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDateTimeUTC", "PlannedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 11, 13, 26, 51, 606, DateTimeKind.Utc).AddTicks(5053), new DateTime(2024, 11, 14, 8, 11, 12, 315, DateTimeKind.Utc).AddTicks(5859), new DateTime(2024, 11, 12, 14, 8, 6, 846, DateTimeKind.Utc).AddTicks(5524) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "ClosedDateTimeUTC", "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 15, 21, 43, 22, 145, DateTimeKind.Utc).AddTicks(4997), new DateTime(2024, 11, 16, 3, 7, 22, 39, DateTimeKind.Utc).AddTicks(7813), new DateTime(2024, 11, 15, 2, 30, 5, 467, DateTimeKind.Utc).AddTicks(3224) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "ClosedDateTimeUTC", "CreatedDateTimeUTC", "PlannedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 16, 6, 28, 50, 169, DateTimeKind.Utc).AddTicks(8998), new DateTime(2024, 11, 12, 10, 8, 54, 58, DateTimeKind.Utc).AddTicks(6946), new DateTime(2024, 11, 14, 10, 50, 11, 360, DateTimeKind.Utc).AddTicks(94), new DateTime(2024, 11, 10, 23, 43, 49, 750, DateTimeKind.Utc).AddTicks(5772) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "ClosedDateTimeUTC", "CreatedDateTimeUTC", "PlannedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 13, 19, 17, 36, 739, DateTimeKind.Utc).AddTicks(8785), new DateTime(2024, 11, 16, 14, 44, 50, 572, DateTimeKind.Utc).AddTicks(4733), new DateTime(2024, 11, 14, 19, 56, 25, 601, DateTimeKind.Utc).AddTicks(3195), new DateTime(2024, 11, 10, 1, 1, 11, 713, DateTimeKind.Utc).AddTicks(5258) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 11, 2, 0, 41, 444, DateTimeKind.Utc).AddTicks(1207), new DateTime(2024, 11, 13, 5, 54, 33, 980, DateTimeKind.Utc).AddTicks(5282) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "ClosedDateTimeUTC", "CreatedDateTimeUTC", "PlannedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 13, 19, 37, 57, 794, DateTimeKind.Utc).AddTicks(2806), new DateTime(2024, 11, 12, 10, 47, 6, 736, DateTimeKind.Utc).AddTicks(8094), new DateTime(2024, 11, 15, 7, 58, 11, 654, DateTimeKind.Utc).AddTicks(6274), new DateTime(2024, 11, 10, 14, 0, 35, 316, DateTimeKind.Utc).AddTicks(2166) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDateTimeUTC", "PlannedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 16, 14, 29, 13, 20, DateTimeKind.Utc).AddTicks(117), new DateTime(2024, 11, 15, 3, 23, 21, 359, DateTimeKind.Utc).AddTicks(1277), new DateTime(2024, 11, 15, 11, 31, 58, 78, DateTimeKind.Utc).AddTicks(6985) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDateTimeUTC", "PlannedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 12, 20, 9, 9, 530, DateTimeKind.Utc).AddTicks(1980), new DateTime(2024, 11, 16, 2, 4, 19, 539, DateTimeKind.Utc).AddTicks(5107), new DateTime(2024, 11, 14, 5, 59, 5, 499, DateTimeKind.Utc).AddTicks(6025) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "ClosedDateTimeUTC", "CreatedDateTimeUTC", "PlannedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 14, 12, 34, 29, 438, DateTimeKind.Utc).AddTicks(9070), new DateTime(2024, 11, 15, 21, 22, 6, 9, DateTimeKind.Utc).AddTicks(5177), new DateTime(2024, 11, 15, 20, 23, 36, 326, DateTimeKind.Utc).AddTicks(6463), new DateTime(2024, 11, 13, 21, 38, 45, 122, DateTimeKind.Utc).AddTicks(8692) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "ClosedDateTimeUTC", "CreatedDateTimeUTC", "PlannedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 13, 23, 43, 55, 106, DateTimeKind.Utc).AddTicks(4153), new DateTime(2024, 11, 15, 22, 49, 47, 583, DateTimeKind.Utc).AddTicks(8125), new DateTime(2024, 11, 16, 16, 45, 26, 934, DateTimeKind.Utc).AddTicks(3257), new DateTime(2024, 11, 10, 14, 57, 47, 316, DateTimeKind.Utc).AddTicks(7316) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "ClosedDateTimeUTC", "CreatedDateTimeUTC", "PlannedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 14, 21, 58, 55, 112, DateTimeKind.Utc).AddTicks(3026), new DateTime(2024, 11, 10, 13, 3, 52, 343, DateTimeKind.Utc).AddTicks(2613), new DateTime(2024, 11, 16, 3, 34, 53, 261, DateTimeKind.Utc).AddTicks(1125), new DateTime(2024, 11, 11, 19, 49, 30, 232, DateTimeKind.Utc).AddTicks(8295) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "ClosedDateTimeUTC", "CreatedDateTimeUTC", "PlannedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 15, 2, 50, 36, 772, DateTimeKind.Utc).AddTicks(5500), new DateTime(2024, 11, 11, 3, 53, 15, 455, DateTimeKind.Utc).AddTicks(4002), new DateTime(2024, 11, 14, 15, 3, 27, 872, DateTimeKind.Utc).AddTicks(7952), new DateTime(2024, 11, 12, 15, 54, 7, 398, DateTimeKind.Utc).AddTicks(9744) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 13, 2, 33, 57, 78, DateTimeKind.Utc).AddTicks(3787), new DateTime(2024, 11, 14, 9, 41, 44, 685, DateTimeKind.Utc).AddTicks(5792) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "ClosedDateTimeUTC", "CreatedDateTimeUTC", "PlannedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 14, 5, 56, 30, 394, DateTimeKind.Utc).AddTicks(6205), new DateTime(2024, 11, 15, 22, 46, 4, 157, DateTimeKind.Utc).AddTicks(7019), new DateTime(2024, 11, 15, 21, 42, 13, 891, DateTimeKind.Utc).AddTicks(1743), new DateTime(2024, 11, 14, 11, 58, 19, 988, DateTimeKind.Utc).AddTicks(402) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDateTimeUTC", "PlannedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 11, 0, 41, 57, 525, DateTimeKind.Utc).AddTicks(7150), new DateTime(2024, 11, 16, 9, 3, 10, 31, DateTimeKind.Utc).AddTicks(5385), new DateTime(2024, 11, 16, 8, 51, 19, 480, DateTimeKind.Utc).AddTicks(886) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 12, 21, 31, 19, 500, DateTimeKind.Utc).AddTicks(7327), new DateTime(2024, 11, 16, 14, 0, 16, 659, DateTimeKind.Utc).AddTicks(991) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "ClosedDateTimeUTC", "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 14, 18, 34, 35, 284, DateTimeKind.Utc).AddTicks(7227), new DateTime(2024, 11, 12, 7, 47, 15, 837, DateTimeKind.Utc).AddTicks(1913), new DateTime(2024, 11, 14, 22, 45, 55, 585, DateTimeKind.Utc).AddTicks(9939) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "ClosedDateTimeUTC", "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 16, 3, 15, 16, 119, DateTimeKind.Utc).AddTicks(8135), new DateTime(2024, 11, 15, 15, 19, 6, 950, DateTimeKind.Utc).AddTicks(3629), new DateTime(2024, 11, 12, 9, 42, 15, 406, DateTimeKind.Utc).AddTicks(2720) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedDateTimeUTC", "PlannedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 15, 14, 7, 19, 181, DateTimeKind.Utc).AddTicks(9906), new DateTime(2024, 11, 15, 15, 27, 23, 316, DateTimeKind.Utc).AddTicks(1085), new DateTime(2024, 11, 14, 6, 35, 22, 47, DateTimeKind.Utc).AddTicks(5515) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "ClosedDateTimeUTC", "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 15, 16, 40, 31, 860, DateTimeKind.Utc).AddTicks(2826), new DateTime(2024, 11, 14, 17, 36, 28, 462, DateTimeKind.Utc).AddTicks(2720), new DateTime(2024, 11, 12, 1, 30, 16, 865, DateTimeKind.Utc).AddTicks(9252) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 13, 5, 21, 28, 196, DateTimeKind.Utc).AddTicks(595), new DateTime(2024, 11, 12, 11, 14, 53, 331, DateTimeKind.Utc).AddTicks(3450) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 16, 0, 44, 27, 887, DateTimeKind.Utc).AddTicks(7837), new DateTime(2024, 11, 10, 22, 52, 28, 67, DateTimeKind.Utc).AddTicks(5017) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "ClosedDateTimeUTC", "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 16, 2, 43, 6, 200, DateTimeKind.Utc).AddTicks(6170), new DateTime(2024, 11, 12, 4, 38, 45, 675, DateTimeKind.Utc).AddTicks(675), new DateTime(2024, 11, 13, 2, 20, 56, 633, DateTimeKind.Utc).AddTicks(5359) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "ClosedDateTimeUTC", "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 14, 0, 38, 52, 871, DateTimeKind.Utc).AddTicks(4073), new DateTime(2024, 11, 15, 17, 58, 8, 304, DateTimeKind.Utc).AddTicks(1657), new DateTime(2024, 11, 16, 16, 51, 16, 543, DateTimeKind.Utc).AddTicks(7892) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "ClosedDateTimeUTC", "CreatedDateTimeUTC", "PlannedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 16, 2, 40, 23, 491, DateTimeKind.Utc).AddTicks(5172), new DateTime(2024, 11, 15, 8, 3, 57, 630, DateTimeKind.Utc).AddTicks(5570), new DateTime(2024, 11, 14, 7, 11, 9, 888, DateTimeKind.Utc).AddTicks(9412), new DateTime(2024, 11, 14, 20, 7, 4, 484, DateTimeKind.Utc).AddTicks(815) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "ClosedDateTimeUTC", "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 16, 11, 38, 33, 941, DateTimeKind.Utc).AddTicks(3467), new DateTime(2024, 11, 13, 3, 44, 17, 103, DateTimeKind.Utc).AddTicks(9698), new DateTime(2024, 11, 12, 3, 51, 18, 301, DateTimeKind.Utc).AddTicks(7674) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "ClosedDateTimeUTC", "CreatedDateTimeUTC", "PlannedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 14, 10, 10, 27, 96, DateTimeKind.Utc).AddTicks(5793), new DateTime(2024, 11, 15, 19, 0, 13, 755, DateTimeKind.Utc).AddTicks(2373), new DateTime(2024, 11, 15, 6, 1, 50, 815, DateTimeKind.Utc).AddTicks(2208), new DateTime(2024, 11, 13, 6, 18, 5, 196, DateTimeKind.Utc).AddTicks(1314) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 10, 15, 31, 26, 174, DateTimeKind.Utc).AddTicks(3250), new DateTime(2024, 11, 13, 6, 41, 40, 160, DateTimeKind.Utc).AddTicks(8044) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "ClosedDateTimeUTC", "CreatedDateTimeUTC", "PlannedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 14, 12, 10, 25, 197, DateTimeKind.Utc).AddTicks(2442), new DateTime(2024, 11, 14, 7, 41, 54, 234, DateTimeKind.Utc).AddTicks(6887), new DateTime(2024, 11, 15, 17, 7, 18, 757, DateTimeKind.Utc).AddTicks(2026), new DateTime(2024, 11, 10, 22, 7, 19, 125, DateTimeKind.Utc).AddTicks(5127) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "ClosedDateTimeUTC", "CreatedDateTimeUTC", "PlannedDateTimeUTC", "UpdatedDateTimeUTC" },
                values: new object[] { new DateTime(2024, 11, 16, 1, 35, 21, 435, DateTimeKind.Utc).AddTicks(8132), new DateTime(2024, 11, 10, 14, 26, 2, 233, DateTimeKind.Utc).AddTicks(8611), new DateTime(2024, 11, 15, 11, 9, 43, 880, DateTimeKind.Utc).AddTicks(5699), new DateTime(2024, 11, 11, 6, 21, 40, 900, DateTimeKind.Utc).AddTicks(5128) });
        }
    }
}
