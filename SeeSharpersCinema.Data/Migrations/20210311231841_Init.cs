using Microsoft.EntityFrameworkCore.Migrations;

namespace SeeSharpersCinema.Data.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "PlayList",
                columns: new[] { "Id", "MovieId", "TimeSlotId" },
                values: new object[,]
                {
                    { 15L, 1L, 15L },
                    { 38L, 10L, 38L },
                    { 39L, 11L, 39L },
                    { 40L, 12L, 40L },
                    { 41L, 13L, 41L },
                    { 42L, 14L, 42L },
                    { 43L, 1L, 43L },
                    { 44L, 2L, 44L },
                    { 45L, 3L, 45L },
                    { 46L, 4L, 46L },
                    { 47L, 5L, 47L },
                    { 48L, 6L, 48L },
                    { 49L, 7L, 49L },
                    { 50L, 8L, 50L },
                    { 51L, 9L, 51L },
                    { 52L, 10L, 52L },
                    { 53L, 11L, 53L },
                    { 54L, 12L, 54L },
                    { 37L, 9L, 37L },
                    { 36L, 8L, 36L },
                    { 35L, 7L, 35L },
                    { 34L, 6L, 34L },
                    { 16L, 2L, 16L },
                    { 17L, 3L, 17L },
                    { 18L, 4L, 18L },
                    { 19L, 5L, 19L },
                    { 20L, 6L, 20L },
                    { 21L, 7L, 21L },
                    { 22L, 8L, 22L },
                    { 23L, 9L, 23L },
                    { 55L, 13L, 55L },
                    { 24L, 10L, 24L },
                    { 26L, 12L, 26L },
                    { 27L, 13L, 27L },
                    { 28L, 14L, 28L },
                    { 29L, 1L, 29L },
                    { 30L, 2L, 30L },
                    { 31L, 3L, 31L },
                    { 32L, 4L, 32L },
                    { 33L, 5L, 33L },
                    { 25L, 11L, 25L },
                    { 56L, 14L, 56L }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PlayList",
                keyColumn: "Id",
                keyValue: 15L);

            migrationBuilder.DeleteData(
                table: "PlayList",
                keyColumn: "Id",
                keyValue: 16L);

            migrationBuilder.DeleteData(
                table: "PlayList",
                keyColumn: "Id",
                keyValue: 17L);

            migrationBuilder.DeleteData(
                table: "PlayList",
                keyColumn: "Id",
                keyValue: 18L);

            migrationBuilder.DeleteData(
                table: "PlayList",
                keyColumn: "Id",
                keyValue: 19L);

            migrationBuilder.DeleteData(
                table: "PlayList",
                keyColumn: "Id",
                keyValue: 20L);

            migrationBuilder.DeleteData(
                table: "PlayList",
                keyColumn: "Id",
                keyValue: 21L);

            migrationBuilder.DeleteData(
                table: "PlayList",
                keyColumn: "Id",
                keyValue: 22L);

            migrationBuilder.DeleteData(
                table: "PlayList",
                keyColumn: "Id",
                keyValue: 23L);

            migrationBuilder.DeleteData(
                table: "PlayList",
                keyColumn: "Id",
                keyValue: 24L);

            migrationBuilder.DeleteData(
                table: "PlayList",
                keyColumn: "Id",
                keyValue: 25L);

            migrationBuilder.DeleteData(
                table: "PlayList",
                keyColumn: "Id",
                keyValue: 26L);

            migrationBuilder.DeleteData(
                table: "PlayList",
                keyColumn: "Id",
                keyValue: 27L);

            migrationBuilder.DeleteData(
                table: "PlayList",
                keyColumn: "Id",
                keyValue: 28L);

            migrationBuilder.DeleteData(
                table: "PlayList",
                keyColumn: "Id",
                keyValue: 29L);

            migrationBuilder.DeleteData(
                table: "PlayList",
                keyColumn: "Id",
                keyValue: 30L);

            migrationBuilder.DeleteData(
                table: "PlayList",
                keyColumn: "Id",
                keyValue: 31L);

            migrationBuilder.DeleteData(
                table: "PlayList",
                keyColumn: "Id",
                keyValue: 32L);

            migrationBuilder.DeleteData(
                table: "PlayList",
                keyColumn: "Id",
                keyValue: 33L);

            migrationBuilder.DeleteData(
                table: "PlayList",
                keyColumn: "Id",
                keyValue: 34L);

            migrationBuilder.DeleteData(
                table: "PlayList",
                keyColumn: "Id",
                keyValue: 35L);

            migrationBuilder.DeleteData(
                table: "PlayList",
                keyColumn: "Id",
                keyValue: 36L);

            migrationBuilder.DeleteData(
                table: "PlayList",
                keyColumn: "Id",
                keyValue: 37L);

            migrationBuilder.DeleteData(
                table: "PlayList",
                keyColumn: "Id",
                keyValue: 38L);

            migrationBuilder.DeleteData(
                table: "PlayList",
                keyColumn: "Id",
                keyValue: 39L);

            migrationBuilder.DeleteData(
                table: "PlayList",
                keyColumn: "Id",
                keyValue: 40L);

            migrationBuilder.DeleteData(
                table: "PlayList",
                keyColumn: "Id",
                keyValue: 41L);

            migrationBuilder.DeleteData(
                table: "PlayList",
                keyColumn: "Id",
                keyValue: 42L);

            migrationBuilder.DeleteData(
                table: "PlayList",
                keyColumn: "Id",
                keyValue: 43L);

            migrationBuilder.DeleteData(
                table: "PlayList",
                keyColumn: "Id",
                keyValue: 44L);

            migrationBuilder.DeleteData(
                table: "PlayList",
                keyColumn: "Id",
                keyValue: 45L);

            migrationBuilder.DeleteData(
                table: "PlayList",
                keyColumn: "Id",
                keyValue: 46L);

            migrationBuilder.DeleteData(
                table: "PlayList",
                keyColumn: "Id",
                keyValue: 47L);

            migrationBuilder.DeleteData(
                table: "PlayList",
                keyColumn: "Id",
                keyValue: 48L);

            migrationBuilder.DeleteData(
                table: "PlayList",
                keyColumn: "Id",
                keyValue: 49L);

            migrationBuilder.DeleteData(
                table: "PlayList",
                keyColumn: "Id",
                keyValue: 50L);

            migrationBuilder.DeleteData(
                table: "PlayList",
                keyColumn: "Id",
                keyValue: 51L);

            migrationBuilder.DeleteData(
                table: "PlayList",
                keyColumn: "Id",
                keyValue: 52L);

            migrationBuilder.DeleteData(
                table: "PlayList",
                keyColumn: "Id",
                keyValue: 53L);

            migrationBuilder.DeleteData(
                table: "PlayList",
                keyColumn: "Id",
                keyValue: 54L);

            migrationBuilder.DeleteData(
                table: "PlayList",
                keyColumn: "Id",
                keyValue: 55L);

            migrationBuilder.DeleteData(
                table: "PlayList",
                keyColumn: "Id",
                keyValue: 56L);
        }
    }
}
