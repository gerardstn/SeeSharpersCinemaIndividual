using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SeeSharpersCinema.Migrations
{
    public partial class Second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TimeSlot",
                columns: new[] { "Id", "RoomId", "SlotEnd", "SlotStart", "Week" },
                values: new object[,]
                {
                    { 15L, 1L, new DateTime(2021, 3, 9, 20, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 10, 19, 0, 0, 0, DateTimeKind.Unspecified), 9 },
                    { 38L, 5L, new DateTime(2021, 3, 9, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 16, 21, 0, 0, 0, DateTimeKind.Unspecified), 10 },
                    { 39L, 6L, new DateTime(2021, 3, 9, 20, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 16, 19, 0, 0, 0, DateTimeKind.Unspecified), 10 },
                    { 40L, 6L, new DateTime(2021, 3, 9, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 16, 21, 0, 0, 0, DateTimeKind.Unspecified), 10 },
                    { 41L, 7L, new DateTime(2021, 3, 9, 20, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 17, 19, 0, 0, 0, DateTimeKind.Unspecified), 10 },
                    { 42L, 7L, new DateTime(2021, 3, 9, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 17, 21, 0, 0, 0, DateTimeKind.Unspecified), 10 },
                    { 43L, 1L, new DateTime(2021, 3, 9, 20, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 17, 19, 0, 0, 0, DateTimeKind.Unspecified), 10 },
                    { 44L, 1L, new DateTime(2021, 3, 9, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 18, 21, 0, 0, 0, DateTimeKind.Unspecified), 11 },
                    { 45L, 2L, new DateTime(2021, 3, 9, 20, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 18, 19, 0, 0, 0, DateTimeKind.Unspecified), 11 },
                    { 46L, 2L, new DateTime(2021, 3, 9, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 18, 21, 0, 0, 0, DateTimeKind.Unspecified), 11 },
                    { 47L, 3L, new DateTime(2021, 3, 9, 20, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 18, 19, 0, 0, 0, DateTimeKind.Unspecified), 11 },
                    { 48L, 3L, new DateTime(2021, 3, 9, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 18, 21, 0, 0, 0, DateTimeKind.Unspecified), 11 },
                    { 49L, 4L, new DateTime(2021, 3, 9, 20, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 19, 19, 0, 0, 0, DateTimeKind.Unspecified), 11 },
                    { 50L, 4L, new DateTime(2021, 3, 9, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), 11 },
                    { 51L, 5L, new DateTime(2021, 3, 9, 20, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 19, 19, 0, 0, 0, DateTimeKind.Unspecified), 11 },
                    { 52L, 5L, new DateTime(2021, 3, 9, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 20, 21, 0, 0, 0, DateTimeKind.Unspecified), 11 },
                    { 53L, 6L, new DateTime(2021, 3, 9, 20, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 20, 19, 0, 0, 0, DateTimeKind.Unspecified), 11 },
                    { 54L, 6L, new DateTime(2021, 3, 9, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 20, 21, 0, 0, 0, DateTimeKind.Unspecified), 11 },
                    { 37L, 5L, new DateTime(2021, 3, 9, 20, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 15, 19, 0, 0, 0, DateTimeKind.Unspecified), 10 },
                    { 36L, 4L, new DateTime(2021, 3, 9, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 15, 21, 0, 0, 0, DateTimeKind.Unspecified), 10 },
                    { 35L, 4L, new DateTime(2021, 3, 9, 20, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 15, 19, 0, 0, 0, DateTimeKind.Unspecified), 10 },
                    { 34L, 3L, new DateTime(2021, 3, 9, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 14, 21, 0, 0, 0, DateTimeKind.Unspecified), 10 },
                    { 16L, 1L, new DateTime(2021, 3, 9, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 10, 21, 0, 0, 0, DateTimeKind.Unspecified), 9 },
                    { 17L, 2L, new DateTime(2021, 3, 9, 20, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 10, 19, 0, 0, 0, DateTimeKind.Unspecified), 9 },
                    { 18L, 2L, new DateTime(2021, 3, 9, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 10, 21, 0, 0, 0, DateTimeKind.Unspecified), 9 },
                    { 19L, 3L, new DateTime(2021, 3, 9, 20, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 11, 19, 0, 0, 0, DateTimeKind.Unspecified), 10 },
                    { 20L, 3L, new DateTime(2021, 3, 9, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 11, 21, 0, 0, 0, DateTimeKind.Unspecified), 10 },
                    { 21L, 4L, new DateTime(2021, 3, 9, 20, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 11, 19, 0, 0, 0, DateTimeKind.Unspecified), 10 },
                    { 22L, 4L, new DateTime(2021, 3, 9, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 11, 21, 0, 0, 0, DateTimeKind.Unspecified), 10 },
                    { 23L, 5L, new DateTime(2021, 3, 9, 20, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 12, 19, 0, 0, 0, DateTimeKind.Unspecified), 10 },
                    { 55L, 7L, new DateTime(2021, 3, 9, 20, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 21, 19, 0, 0, 0, DateTimeKind.Unspecified), 11 },
                    { 24L, 5L, new DateTime(2021, 3, 9, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 12, 21, 0, 0, 0, DateTimeKind.Unspecified), 10 },
                    { 26L, 6L, new DateTime(2021, 3, 9, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 12, 21, 0, 0, 0, DateTimeKind.Unspecified), 10 },
                    { 27L, 7L, new DateTime(2021, 3, 9, 20, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 12, 19, 0, 0, 0, DateTimeKind.Unspecified), 10 },
                    { 28L, 7L, new DateTime(2021, 3, 9, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 12, 21, 0, 0, 0, DateTimeKind.Unspecified), 10 },
                    { 29L, 1L, new DateTime(2021, 3, 9, 20, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 13, 19, 0, 0, 0, DateTimeKind.Unspecified), 10 },
                    { 30L, 1L, new DateTime(2021, 3, 9, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 13, 21, 0, 0, 0, DateTimeKind.Unspecified), 10 },
                    { 31L, 2L, new DateTime(2021, 3, 9, 20, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 13, 19, 0, 0, 0, DateTimeKind.Unspecified), 10 },
                    { 32L, 2L, new DateTime(2021, 3, 9, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 14, 21, 0, 0, 0, DateTimeKind.Unspecified), 10 },
                    { 33L, 3L, new DateTime(2021, 3, 9, 20, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 14, 19, 0, 0, 0, DateTimeKind.Unspecified), 10 },
                    { 25L, 6L, new DateTime(2021, 3, 9, 20, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 12, 19, 0, 0, 0, DateTimeKind.Unspecified), 10 },
                    { 56L, 7L, new DateTime(2021, 3, 9, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 21, 21, 0, 0, 0, DateTimeKind.Unspecified), 11 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 15L);

            migrationBuilder.DeleteData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 16L);

            migrationBuilder.DeleteData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 17L);

            migrationBuilder.DeleteData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 18L);

            migrationBuilder.DeleteData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 19L);

            migrationBuilder.DeleteData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 20L);

            migrationBuilder.DeleteData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 21L);

            migrationBuilder.DeleteData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 22L);

            migrationBuilder.DeleteData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 23L);

            migrationBuilder.DeleteData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 24L);

            migrationBuilder.DeleteData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 25L);

            migrationBuilder.DeleteData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 26L);

            migrationBuilder.DeleteData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 27L);

            migrationBuilder.DeleteData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 28L);

            migrationBuilder.DeleteData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 29L);

            migrationBuilder.DeleteData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 30L);

            migrationBuilder.DeleteData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 31L);

            migrationBuilder.DeleteData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 32L);

            migrationBuilder.DeleteData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 33L);

            migrationBuilder.DeleteData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 34L);

            migrationBuilder.DeleteData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 35L);

            migrationBuilder.DeleteData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 36L);

            migrationBuilder.DeleteData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 37L);

            migrationBuilder.DeleteData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 38L);

            migrationBuilder.DeleteData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 39L);

            migrationBuilder.DeleteData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 40L);

            migrationBuilder.DeleteData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 41L);

            migrationBuilder.DeleteData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 42L);

            migrationBuilder.DeleteData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 43L);

            migrationBuilder.DeleteData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 44L);

            migrationBuilder.DeleteData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 45L);

            migrationBuilder.DeleteData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 46L);

            migrationBuilder.DeleteData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 47L);

            migrationBuilder.DeleteData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 48L);

            migrationBuilder.DeleteData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 49L);

            migrationBuilder.DeleteData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 50L);

            migrationBuilder.DeleteData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 51L);

            migrationBuilder.DeleteData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 52L);

            migrationBuilder.DeleteData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 53L);

            migrationBuilder.DeleteData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 54L);

            migrationBuilder.DeleteData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 55L);

            migrationBuilder.DeleteData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 56L);
        }
    }
}
