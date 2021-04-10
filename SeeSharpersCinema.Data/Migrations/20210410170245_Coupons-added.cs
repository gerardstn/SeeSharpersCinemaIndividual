using Microsoft.EntityFrameworkCore.Migrations;

namespace SeeSharpersCinema.Data.Migrations
{
    public partial class Couponsadded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ticket_Room_RoomId",
                table: "Ticket");

            migrationBuilder.DropIndex(
                name: "IX_Ticket_RoomId",
                table: "Ticket");

            migrationBuilder.DropColumn(
                name: "Week",
                table: "TimeSlot");

            migrationBuilder.DropColumn(
                name: "RoomId",
                table: "Ticket");

            migrationBuilder.RenameColumn(
                name: "TicketID",
                table: "Ticket",
                newName: "Id");

            migrationBuilder.AddColumn<string>(
                name: "Cashier",
                table: "Ticket",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Coupon",
                table: "Ticket",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Price",
                table: "Ticket",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.CreateTable(
                name: "Coupon",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coupon", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Coupon",
                columns: new[] { "Id", "Code", "IsActive", "Type" },
                values: new object[,]
                {
                    { 1L, "qdzffpKWzeUQWnxyhhtYdZbAFhbXVzXnsfNoPzBBodkQErfXGt", true, "TienRitten" },
                    { 18L, "zbTSiSeabZqRHYbiQqGMPaDkmpMdWRgJqsBjdAjWyzQMfcyiWd", true, "NationaleBios" },
                    { 17L, "iUtmgyNDrhjzVNJeqAYNVJhcPqkZLiLsGJLUbGnCsadqzNmQxK", true, "NationaleBios" },
                    { 16L, "LzFXNjFxqLvhfdbHKjdnoFJsyGWFhJdahjwmPZcYkVyCUvniWL", true, "NationaleBios" },
                    { 15L, "jUxrtLBGXhtnzieKPUrQXjdYbAgYQNBLEtASyjYRddDNStdLta", true, "MaDiWoDo" },
                    { 14L, "ncTVbNNhUHVoWFESMprVBFGLZgUVykgYSSocopexaAYGiiVXWt", true, "MaDiWoDo" },
                    { 13L, "tzSXUxyNguYRuJobmPWHTXhWjSbDDhiJhrYJMsCTnNxUiukauo", true, "MaDiWoDo" },
                    { 12L, "QMPwpeuboNqLsHpQMTKuNmzfYZKVWXEnpzyPpbfsAcqMNpYbVM", true, "MaDiWoDo" },
                    { 11L, "rWFZDavFTAKLUpgduKgnZbJYhJmeNuJYqKacymjXtcAreTpGXt", true, "MaDiWoDo" },
                    { 10L, "hRvwLhAqauNbpFFRbMGQhRouTiVXftZrAVfaLqTTtwCAaAnTWg", true, "TienRitten" },
                    { 9L, "kpUjDNtdFewzWnvhmYQNUKUTLNajvRnjhTCedqHbmFCaMriyXk", true, "TienRitten" },
                    { 8L, "kjtbnqKvSEoFXsrLCpSDMEKzNEPAfwbVtgnPfBxrZpJzxqZjgv", true, "TienRitten" },
                    { 7L, "cizvkSGfRbSvjSwwKNGBaGFBNHJfZooKzWXnDBwqWNoeJswZCz", true, "TienRitten" },
                    { 6L, "UhkakywsFfRVJRJVevmYujSkjbSPbrrkmxJFQyEWiUEHDiRtfa", true, "TienRitten" },
                    { 5L, "TRHivQPvgHECuYdpyxsdMXFQMzhvEpwPYsVcbsrUXkhwoCqRNg", true, "TienRitten" },
                    { 4L, "ceeMYxuUNEsktQkepPUTMPJuApFQZtndqrjbuGUohWzHYETxdf", true, "TienRitten" },
                    { 3L, "UvfqHbadzNnbgUbCzACgazabSiVzasuhrDHvfKkuHxSQHybroJ", true, "TienRitten" },
                    { 2L, "iuqtjGFbvPtAGtuYPzRuCpGrLjXzfMkMiNFsZFDwTcduAzQeAp", true, "TienRitten" },
                    { 19L, "ieUiKLSUmFBJEAmwWaDpvDjejMiaJUjyQbNvYcTvmMVSvJXkvJ", true, "NationaleBios" },
                    { 20L, "emhKrFgnnYELTheDFnsXZQwYkQmNagSzkBeEgZrdTxmmFqUDPv", true, "NationaleBios" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Coupon");

            migrationBuilder.DropColumn(
                name: "Cashier",
                table: "Ticket");

            migrationBuilder.DropColumn(
                name: "Coupon",
                table: "Ticket");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Ticket");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Ticket",
                newName: "TicketID");

            migrationBuilder.AddColumn<int>(
                name: "Week",
                table: "TimeSlot",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<long>(
                name: "RoomId",
                table: "Ticket",
                type: "bigint",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 1L,
                column: "Week",
                value: 12);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 2L,
                column: "Week",
                value: 12);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 3L,
                column: "Week",
                value: 12);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 4L,
                column: "Week",
                value: 12);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 5L,
                column: "Week",
                value: 12);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 6L,
                column: "Week",
                value: 12);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 7L,
                column: "Week",
                value: 12);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 8L,
                column: "Week",
                value: 12);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 9L,
                column: "Week",
                value: 12);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 10L,
                column: "Week",
                value: 12);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 11L,
                column: "Week",
                value: 12);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 12L,
                column: "Week",
                value: 12);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 13L,
                column: "Week",
                value: 12);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 14L,
                column: "Week",
                value: 12);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 15L,
                column: "Week",
                value: 12);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 16L,
                column: "Week",
                value: 12);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 17L,
                column: "Week",
                value: 12);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 18L,
                column: "Week",
                value: 12);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 19L,
                column: "Week",
                value: 12);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 20L,
                column: "Week",
                value: 12);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 21L,
                column: "Week",
                value: 12);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 22L,
                column: "Week",
                value: 12);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 23L,
                column: "Week",
                value: 12);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 24L,
                column: "Week",
                value: 12);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 25L,
                column: "Week",
                value: 12);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 26L,
                column: "Week",
                value: 12);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 27L,
                column: "Week",
                value: 12);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 28L,
                column: "Week",
                value: 12);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 29L,
                column: "Week",
                value: 12);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 30L,
                column: "Week",
                value: 12);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 31L,
                column: "Week",
                value: 12);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 32L,
                column: "Week",
                value: 12);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 33L,
                column: "Week",
                value: 12);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 34L,
                column: "Week",
                value: 12);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 35L,
                column: "Week",
                value: 12);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 36L,
                column: "Week",
                value: 12);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 37L,
                column: "Week",
                value: 12);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 38L,
                column: "Week",
                value: 12);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 39L,
                column: "Week",
                value: 12);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 40L,
                column: "Week",
                value: 12);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 41L,
                column: "Week",
                value: 12);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 42L,
                column: "Week",
                value: 12);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 43L,
                column: "Week",
                value: 12);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 44L,
                column: "Week",
                value: 12);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 45L,
                column: "Week",
                value: 12);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 46L,
                column: "Week",
                value: 12);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 47L,
                column: "Week",
                value: 12);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 48L,
                column: "Week",
                value: 13);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 49L,
                column: "Week",
                value: 13);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 50L,
                column: "Week",
                value: 13);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 51L,
                column: "Week",
                value: 13);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 52L,
                column: "Week",
                value: 13);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 53L,
                column: "Week",
                value: 13);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 54L,
                column: "Week",
                value: 13);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 55L,
                column: "Week",
                value: 13);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 56L,
                column: "Week",
                value: 13);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 57L,
                column: "Week",
                value: 13);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 58L,
                column: "Week",
                value: 13);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 59L,
                column: "Week",
                value: 13);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 60L,
                column: "Week",
                value: 13);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 61L,
                column: "Week",
                value: 13);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 62L,
                column: "Week",
                value: 13);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 63L,
                column: "Week",
                value: 13);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 64L,
                column: "Week",
                value: 13);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 65L,
                column: "Week",
                value: 13);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 66L,
                column: "Week",
                value: 13);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 67L,
                column: "Week",
                value: 13);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 68L,
                column: "Week",
                value: 13);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 69L,
                column: "Week",
                value: 13);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 70L,
                column: "Week",
                value: 13);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 71L,
                column: "Week",
                value: 13);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 72L,
                column: "Week",
                value: 13);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 73L,
                column: "Week",
                value: 13);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 74L,
                column: "Week",
                value: 13);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 75L,
                column: "Week",
                value: 13);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 76L,
                column: "Week",
                value: 13);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 77L,
                column: "Week",
                value: 13);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 78L,
                column: "Week",
                value: 13);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 79L,
                column: "Week",
                value: 13);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 80L,
                column: "Week",
                value: 13);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 81L,
                column: "Week",
                value: 14);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 82L,
                column: "Week",
                value: 14);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 83L,
                column: "Week",
                value: 14);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 84L,
                column: "Week",
                value: 14);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 85L,
                column: "Week",
                value: 14);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 86L,
                column: "Week",
                value: 14);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 87L,
                column: "Week",
                value: 14);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 88L,
                column: "Week",
                value: 14);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 89L,
                column: "Week",
                value: 14);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 90L,
                column: "Week",
                value: 14);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 91L,
                column: "Week",
                value: 14);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 92L,
                column: "Week",
                value: 14);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 93L,
                column: "Week",
                value: 14);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 94L,
                column: "Week",
                value: 14);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 95L,
                column: "Week",
                value: 14);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 96L,
                column: "Week",
                value: 14);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 97L,
                column: "Week",
                value: 14);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 98L,
                column: "Week",
                value: 14);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 99L,
                column: "Week",
                value: 14);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 100L,
                column: "Week",
                value: 14);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 101L,
                column: "Week",
                value: 14);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 102L,
                column: "Week",
                value: 14);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 103L,
                column: "Week",
                value: 14);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 104L,
                column: "Week",
                value: 14);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 105L,
                column: "Week",
                value: 14);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 106L,
                column: "Week",
                value: 14);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 107L,
                column: "Week",
                value: 14);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 108L,
                column: "Week",
                value: 14);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 109L,
                column: "Week",
                value: 14);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 110L,
                column: "Week",
                value: 14);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 112L,
                column: "Week",
                value: 14);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 113L,
                column: "Week",
                value: 14);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 114L,
                column: "Week",
                value: 14);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 115L,
                column: "Week",
                value: 14);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 116L,
                column: "Week",
                value: 14);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 117L,
                column: "Week",
                value: 14);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 118L,
                column: "Week",
                value: 14);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 119L,
                column: "Week",
                value: 14);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 120L,
                column: "Week",
                value: 14);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 121L,
                column: "Week",
                value: 14);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 122L,
                column: "Week",
                value: 14);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 123L,
                column: "Week",
                value: 14);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 124L,
                column: "Week",
                value: 14);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 125L,
                column: "Week",
                value: 14);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 126L,
                column: "Week",
                value: 14);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 127L,
                column: "Week",
                value: 14);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 128L,
                column: "Week",
                value: 14);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 129L,
                column: "Week",
                value: 14);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 130L,
                column: "Week",
                value: 14);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 131L,
                column: "Week",
                value: 14);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 132L,
                column: "Week",
                value: 14);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 133L,
                column: "Week",
                value: 14);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 134L,
                column: "Week",
                value: 14);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 135L,
                column: "Week",
                value: 14);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 136L,
                column: "Week",
                value: 14);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 137L,
                column: "Week",
                value: 14);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 138L,
                column: "Week",
                value: 14);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 139L,
                column: "Week",
                value: 14);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 140L,
                column: "Week",
                value: 14);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 141L,
                column: "Week",
                value: 14);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 142L,
                column: "Week",
                value: 14);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 143L,
                column: "Week",
                value: 14);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 144L,
                column: "Week",
                value: 15);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 145L,
                column: "Week",
                value: 15);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 146L,
                column: "Week",
                value: 15);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 147L,
                column: "Week",
                value: 15);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 148L,
                column: "Week",
                value: 15);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 149L,
                column: "Week",
                value: 15);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 150L,
                column: "Week",
                value: 15);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 151L,
                column: "Week",
                value: 15);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 152L,
                column: "Week",
                value: 15);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 153L,
                column: "Week",
                value: 15);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 154L,
                column: "Week",
                value: 15);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 155L,
                column: "Week",
                value: 15);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 156L,
                column: "Week",
                value: 15);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 157L,
                column: "Week",
                value: 15);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 158L,
                column: "Week",
                value: 15);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 159L,
                column: "Week",
                value: 15);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 160L,
                column: "Week",
                value: 15);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 161L,
                column: "Week",
                value: 15);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 162L,
                column: "Week",
                value: 15);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 163L,
                column: "Week",
                value: 15);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 164L,
                column: "Week",
                value: 15);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 165L,
                column: "Week",
                value: 15);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 166L,
                column: "Week",
                value: 15);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 167L,
                column: "Week",
                value: 15);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 168L,
                column: "Week",
                value: 15);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 169L,
                column: "Week",
                value: 15);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 170L,
                column: "Week",
                value: 15);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 171L,
                column: "Week",
                value: 15);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 172L,
                column: "Week",
                value: 15);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 173L,
                column: "Week",
                value: 15);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 174L,
                column: "Week",
                value: 15);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 175L,
                column: "Week",
                value: 15);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 176L,
                column: "Week",
                value: 15);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 177L,
                column: "Week",
                value: 15);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 178L,
                column: "Week",
                value: 15);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 179L,
                column: "Week",
                value: 15);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 180L,
                column: "Week",
                value: 15);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 181L,
                column: "Week",
                value: 15);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 182L,
                column: "Week",
                value: 15);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 183L,
                column: "Week",
                value: 15);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 184L,
                column: "Week",
                value: 15);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 185L,
                column: "Week",
                value: 15);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 186L,
                column: "Week",
                value: 15);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 187L,
                column: "Week",
                value: 15);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 188L,
                column: "Week",
                value: 15);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 189L,
                column: "Week",
                value: 15);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 190L,
                column: "Week",
                value: 15);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 191L,
                column: "Week",
                value: 15);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 192L,
                column: "Week",
                value: 15);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 193L,
                column: "Week",
                value: 15);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 194L,
                column: "Week",
                value: 15);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 195L,
                column: "Week",
                value: 15);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 196L,
                column: "Week",
                value: 15);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 197L,
                column: "Week",
                value: 15);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 198L,
                column: "Week",
                value: 15);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 199L,
                column: "Week",
                value: 15);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 200L,
                column: "Week",
                value: 15);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 201L,
                column: "Week",
                value: 15);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 202L,
                column: "Week",
                value: 15);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 203L,
                column: "Week",
                value: 15);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 204L,
                column: "Week",
                value: 15);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 205L,
                column: "Week",
                value: 15);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 206L,
                column: "Week",
                value: 15);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 207L,
                column: "Week",
                value: 15);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 208L,
                column: "Week",
                value: 15);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 209L,
                column: "Week",
                value: 15);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 210L,
                column: "Week",
                value: 15);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 211L,
                column: "Week",
                value: 15);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 212L,
                column: "Week",
                value: 15);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 213L,
                column: "Week",
                value: 15);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 214L,
                column: "Week",
                value: 15);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 215L,
                column: "Week",
                value: 15);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 216L,
                column: "Week",
                value: 15);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 217L,
                column: "Week",
                value: 15);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 218L,
                column: "Week",
                value: 15);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 219L,
                column: "Week",
                value: 15);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 220L,
                column: "Week",
                value: 15);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 221L,
                column: "Week",
                value: 15);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 222L,
                column: "Week",
                value: 15);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 223L,
                column: "Week",
                value: 15);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 224L,
                column: "Week",
                value: 15);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 225L,
                column: "Week",
                value: 15);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 226L,
                column: "Week",
                value: 15);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 227L,
                column: "Week",
                value: 15);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 228L,
                column: "Week",
                value: 16);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 229L,
                column: "Week",
                value: 16);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 230L,
                column: "Week",
                value: 16);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 231L,
                column: "Week",
                value: 16);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 232L,
                column: "Week",
                value: 16);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 233L,
                column: "Week",
                value: 16);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 234L,
                column: "Week",
                value: 16);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 235L,
                column: "Week",
                value: 16);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 236L,
                column: "Week",
                value: 16);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 237L,
                column: "Week",
                value: 16);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 238L,
                column: "Week",
                value: 16);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 239L,
                column: "Week",
                value: 16);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 240L,
                column: "Week",
                value: 16);

            migrationBuilder.UpdateData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 241L,
                column: "Week",
                value: 16);

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_RoomId",
                table: "Ticket",
                column: "RoomId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ticket_Room_RoomId",
                table: "Ticket",
                column: "RoomId",
                principalTable: "Room",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
