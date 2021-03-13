using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SeeSharpersCinema.Data.Migrations
{
    public partial class newTimeSlots : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "SlotEnd", "SlotStart" },
                values: new object[] { new DateTime(2021, 3, 10, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 10, 21, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "SlotEnd", "SlotStart" },
                values: new object[] { new DateTime(2021, 3, 11, 20, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 11, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "SlotEnd", "SlotStart" },
                values: new object[] { new DateTime(2021, 3, 12, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 12, 21, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "SlotEnd", "SlotStart" },
                values: new object[] { new DateTime(2021, 3, 13, 20, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 13, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "SlotEnd", "SlotStart" },
                values: new object[] { new DateTime(2021, 3, 14, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 14, 21, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "SlotEnd", "SlotStart" },
                values: new object[] { new DateTime(2021, 3, 15, 20, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 15, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "SlotEnd", "SlotStart" },
                values: new object[] { new DateTime(2021, 3, 16, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 16, 21, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "SlotEnd", "SlotStart" },
                values: new object[] { new DateTime(2021, 3, 17, 20, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 17, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "SlotEnd", "SlotStart" },
                values: new object[] { new DateTime(2021, 3, 18, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 18, 21, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "SlotEnd", "SlotStart" },
                values: new object[] { new DateTime(2021, 3, 19, 20, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 19, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "SlotEnd", "SlotStart" },
                values: new object[] { new DateTime(2021, 3, 20, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 20, 21, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "SlotEnd", "SlotStart" },
                values: new object[] { new DateTime(2021, 3, 21, 20, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 21, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "SlotEnd", "SlotStart" },
                values: new object[] { new DateTime(2021, 3, 22, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 22, 21, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "SlotEnd", "SlotStart" },
                values: new object[] { new DateTime(2021, 3, 9, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 9, 21, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "SlotEnd", "SlotStart" },
                values: new object[] { new DateTime(2021, 3, 9, 20, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 9, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "SlotEnd", "SlotStart" },
                values: new object[] { new DateTime(2021, 3, 9, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 9, 21, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "SlotEnd", "SlotStart" },
                values: new object[] { new DateTime(2021, 3, 9, 20, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 9, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "SlotEnd", "SlotStart" },
                values: new object[] { new DateTime(2021, 3, 9, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 9, 21, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "SlotEnd", "SlotStart" },
                values: new object[] { new DateTime(2021, 3, 9, 20, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 9, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "SlotEnd", "SlotStart" },
                values: new object[] { new DateTime(2021, 3, 9, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 9, 21, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "SlotEnd", "SlotStart" },
                values: new object[] { new DateTime(2021, 3, 9, 20, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 9, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "SlotEnd", "SlotStart" },
                values: new object[] { new DateTime(2021, 3, 9, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 9, 21, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "SlotEnd", "SlotStart" },
                values: new object[] { new DateTime(2021, 3, 9, 20, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 9, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "SlotEnd", "SlotStart" },
                values: new object[] { new DateTime(2021, 3, 9, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 9, 21, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "SlotEnd", "SlotStart" },
                values: new object[] { new DateTime(2021, 3, 9, 20, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 9, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "SlotEnd", "SlotStart" },
                values: new object[] { new DateTime(2021, 3, 9, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 9, 21, 0, 0, 0, DateTimeKind.Unspecified) });
        }
    }
}
