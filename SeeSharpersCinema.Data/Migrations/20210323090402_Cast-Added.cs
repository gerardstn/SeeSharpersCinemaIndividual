using Microsoft.EntityFrameworkCore.Migrations;

namespace SeeSharpersCinema.Data.Migrations
{
    public partial class CastAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Cast",
                table: "Movie",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Cinema",
                keyColumn: "Id",
                keyValue: 1L,
                column: "TotalRooms",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 1L,
                column: "Cast",
                value: "Sam Neill, Susan Sarandon, Anson Boon");

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 2L,
                column: "Cast",
                value: "Tony Chiu-Wai Leung, Maggie Cheung, Ping Lam Siu");

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 3L,
                column: "Cast",
                value: "Gijs Blom, Jamie Flatters, Susan Radder");

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 4L,
                column: "Cast",
                value: "Bernardo De Paula, Thom Hoffman, Lola Raie");

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 5L,
                column: "Cast",
                value: "David Byrne, Jacqueline Acevedo, Gustavo Di Dalva");

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 6L,
                column: "Cast",
                value: "Andra Day, Trevante Rhodes, Garrett Hedlund");

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 7L,
                column: "Cast",
                value: "Nicolas Cage, Emma Stone, Ryan Reynolds");

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 8L,
                column: "Cast",
                value: "Nicolas Cage, Emma Stone, Ryan Reynolds");

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 9L,
                column: "Cast",
                value: "Noée Abita, Jérémie Renier, Marie Denarnaud");

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 10L,
                column: "Cast",
                value: "Dustin Hoffman, Toni Servillo, Valentina Bellè");

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 11L,
                column: "Cast",
                value: "Charlotte Vega, Adain Bradley, Bill Sage");

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 12L,
                column: "Cast",
                value: "Adam Devine, Rachel Bloom, Ken Jeong");

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 13L,
                column: "Cast",
                value: "Bob Odenkirk, Aleksey Serebryakov, Connie Nielsen");

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 14L,
                column: "Cast",
                value: "Anthony Hopkins, Olivia Colman, Mark Gatiss");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cast",
                table: "Movie");

            migrationBuilder.UpdateData(
                table: "Cinema",
                keyColumn: "Id",
                keyValue: 1L,
                column: "TotalRooms",
                value: 5);
        }
    }
}
