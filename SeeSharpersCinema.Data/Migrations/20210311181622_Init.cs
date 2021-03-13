using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SeeSharpersCinema.Data.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cinema",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalRooms = table.Column<int>(type: "int", nullable: false),
                    TotalCapacity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cinema", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Movie",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PosterUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Duration = table.Column<int>(type: "int", nullable: false),
                    Language = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Technique = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ViewIndication = table.Column<int>(type: "int", nullable: false),
                    Genre = table.Column<int>(type: "int", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Director = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movie", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Room",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Capacity = table.Column<int>(type: "int", nullable: false),
                    CinemaId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Room", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Room_Cinema_CinemaId",
                        column: x => x.CinemaId,
                        principalTable: "Cinema",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TimeSlot",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Week = table.Column<int>(type: "int", nullable: false),
                    SlotStart = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SlotEnd = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RoomId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TimeSlot", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TimeSlot_Room_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Room",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PlayList",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TimeSlotId = table.Column<long>(type: "bigint", nullable: false),
                    MovieId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayList", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PlayList_Movie_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movie",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlayList_TimeSlot_TimeSlotId",
                        column: x => x.TimeSlotId,
                        principalTable: "TimeSlot",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Cinema",
                columns: new[] { "Id", "Address", "City", "Name", "Phone", "TotalCapacity", "TotalRooms" },
                values: new object[] { 1L, "Gedempte Zuiderdiep 78", "Groningen", "Pathé", "0885152050", 1500, 5 });

            migrationBuilder.InsertData(
                table: "Movie",
                columns: new[] { "Id", "Country", "Description", "Director", "Duration", "Genre", "Language", "PosterUrl", "Technique", "Title", "ViewIndication", "Year" },
                values: new object[,]
                {
                    { 1L, "USA", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc elementum rutrum magna at sagittis. Curabitur viverra hendrerit enim, at gravida elit venenatis vel. Pellentesque aliquam maximus suscipit. Pellentesque et dolor elit. Duis rhoncus interdum quam, maximus pharetra tortor auctor sed. Ut congue molestie nisl ut aliquam.", "Roger Michell", 98, 6, "Original", "https://media.pathe.nl/thumb/360x508/gfx_content/other/api/filmdepot/v1/movie/download/32660_128633_ps_sd-high.jpg", "2D", "Blackbird", 5, 2021 },
                    { 2L, "USA", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc elementum rutrum magna at sagittis. Curabitur viverra hendrerit enim, at gravida elit venenatis vel. Pellentesque aliquam maximus suscipit. Pellentesque et dolor elit. Duis rhoncus interdum quam, maximus pharetra tortor auctor sed. Ut congue molestie nisl ut aliquam.", "Kar-Wai Wong", 98, 6, "Original", "https://media.pathe.nl/thumb/360x508/gfx_content/other/api/filmdepot/v1/movie/download/33783_134425_ps_sd-high.jpg", "2D", "In the mood for love", 0, 2020 },
                    { 3L, "NL", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc elementum rutrum magna at sagittis. Curabitur viverra hendrerit enim, at gravida elit venenatis vel. Pellentesque aliquam maximus suscipit. Pellentesque et dolor elit. Duis rhoncus interdum quam, maximus pharetra tortor auctor sed. Ut congue molestie nisl ut aliquam.", "Matthijs van Heijningen Jr.", 124, 6, "Nederlands", "https://media.pathe.nl/thumb/360x508/gfx_content/PathePartners/movie-25169-SlagOmDeScheldeDe_Poster_DEF.jpg", "2D", "De slag om de schelde", 5, 2021 },
                    { 4L, "USA", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc elementum rutrum magna at sagittis. Curabitur viverra hendrerit enim, at gravida elit venenatis vel. Pellentesque aliquam maximus suscipit. Pellentesque et dolor elit. Duis rhoncus interdum quam, maximus pharetra tortor auctor sed. Ut congue molestie nisl ut aliquam.", "Kar-Wai Wong", 84, 10, "Nederlands", "https://media.pathe.nl/thumb/360x508/gfx_content/other/api/filmdepot/v1/movie/download/23672_133688_ps_sd-high.jpg", "3D", "Ainbo: Heldin van de amazone", 0, 2020 },
                    { 5L, "USA", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc elementum rutrum magna at sagittis. Curabitur viverra hendrerit enim, at gravida elit venenatis vel. Pellentesque aliquam maximus suscipit. Pellentesque et dolor elit. Duis rhoncus interdum quam, maximus pharetra tortor auctor sed. Ut congue molestie nisl ut aliquam.", "Spike Lee", 105, 16, "Original", "https://media.pathe.nl/thumb/360x508//gfx_content/other/api/filmdepot/v1/movie/download/33816_134505_ps_sd-high.jpg", "2D", "David Byrne's amerikan utopia", 0, 2021 },
                    { 6L, "USA", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc elementum rutrum magna at sagittis. Curabitur viverra hendrerit enim, at gravida elit venenatis vel. Pellentesque aliquam maximus suscipit. Pellentesque et dolor elit. Duis rhoncus interdum quam, maximus pharetra tortor auctor sed. Ut congue molestie nisl ut aliquam.", "Lee Daniels", 130, 6, "Original", "https://media.pathe.nl/thumb/360x508/gfx_content/other/api/filmdepot/v1/movie/download/33645_134768_ps_sd-high.jpg", "2D", "The united stats vs. billie holiday", 4, 2021 },
                    { 7L, "USA", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc elementum rutrum magna at sagittis. Curabitur viverra hendrerit enim, at gravida elit venenatis vel. Pellentesque aliquam maximus suscipit. Pellentesque et dolor elit. Duis rhoncus interdum quam, maximus pharetra tortor auctor sed. Ut congue molestie nisl ut aliquam.", "Joel Crawford", 95, 9, "Original", "https://media.pathe.nl/thumb/360x508/gfx_content/other/api/filmdepot/v1/movie/download/23557_133608_ps_sd-high.jpg", "3D", "The croods: a new age (OV)", 1, 2020 },
                    { 8L, "USA", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc elementum rutrum magna at sagittis. Curabitur viverra hendrerit enim, at gravida elit venenatis vel. Pellentesque aliquam maximus suscipit. Pellentesque et dolor elit. Duis rhoncus interdum quam, maximus pharetra tortor auctor sed. Ut congue molestie nisl ut aliquam.", "Joel Crawford", 95, 10, "Nederlands", "https://media.pathe.nl/thumb/360x508/gfx_content/other/api/filmdepot/v1/movie/download/23557_133608_ps_sd-high.jpg", "3D", "De croods 2: een nieuw begin (NL)", 1, 2020 },
                    { 9L, "USA", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc elementum rutrum magna at sagittis. Curabitur viverra hendrerit enim, at gravida elit venenatis vel. Pellentesque aliquam maximus suscipit. Pellentesque et dolor elit. Duis rhoncus interdum quam, maximus pharetra tortor auctor sed. Ut congue molestie nisl ut aliquam.", "Charlène Favier", 92, 6, "Original", "https://media.pathe.nl/thumb/360x508/gfx_content/Slalom.jpg", "2D", "Slalom", 2, 2020 },
                    { 10L, "USA", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc elementum rutrum magna at sagittis. Curabitur viverra hendrerit enim, at gravida elit venenatis vel. Pellentesque aliquam maximus suscipit. Pellentesque et dolor elit. Duis rhoncus interdum quam, maximus pharetra tortor auctor sed. Ut congue molestie nisl ut aliquam.", "Donato Carrisi", 130, 8, "Original", "https://media.pathe.nl/thumb/360x508/gfx_content/other/api/filmdepot/v1/movie/download/33764_133801_ps_sd-high.jpg", "2D", "Into the labyrinth", 2, 2021 },
                    { 11L, "USA", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc elementum rutrum magna at sagittis. Curabitur viverra hendrerit enim, at gravida elit venenatis vel. Pellentesque aliquam maximus suscipit. Pellentesque et dolor elit. Duis rhoncus interdum quam, maximus pharetra tortor auctor sed. Ut congue molestie nisl ut aliquam.", "Mike P. Nelson", 110, 2, "Original", "https://media.pathe.nl/thumb/360x508/gfx_content/other/api/filmdepot/v1/movie/download/33804_134756_ps_sd-high.jpg", "2D", "Wrong turn", 5, 2020 },
                    { 12L, "USA", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc elementum rutrum magna at sagittis. Curabitur viverra hendrerit enim, at gravida elit venenatis vel. Pellentesque aliquam maximus suscipit. Pellentesque et dolor elit. Duis rhoncus interdum quam, maximus pharetra tortor auctor sed. Ut congue molestie nisl ut aliquam.", "David Silverman", 84, 10, "Nederlands", "https://media.pathe.nl/thumb/360x508/gfx_content/other/api/filmdepot/v1/movie/download/33774_133282_ps_sd-high.jpg", "2D", "De Flummels", 1, 2021 },
                    { 13L, "USA", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc elementum rutrum magna at sagittis. Curabitur viverra hendrerit enim, at gravida elit venenatis vel. Pellentesque aliquam maximus suscipit. Pellentesque et dolor elit. Duis rhoncus interdum quam, maximus pharetra tortor auctor sed. Ut congue molestie nisl ut aliquam.", "Ilya Naishuller", 92, 5, "Original", "https://media.pathe.nl/thumb/360x508/gfx_content/other/api/filmdepot/v1/movie/download/23923_133307_ps_sd-high.jpg", "2D", "Nobody", 5, 2021 },
                    { 14L, "USA", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc elementum rutrum magna at sagittis. Curabitur viverra hendrerit enim, at gravida elit venenatis vel. Pellentesque aliquam maximus suscipit. Pellentesque et dolor elit. Duis rhoncus interdum quam, maximus pharetra tortor auctor sed. Ut congue molestie nisl ut aliquam.", "Florian Zeller", 97, 6, "Original", "https://media.pathe.nl/thumb/360x508/gfx_content/other/api/filmdepot/v1/movie/download/33495_134471_ps_sd-high.jpg", "2D", "The Father", 2, 2020 }
                });

            migrationBuilder.InsertData(
                table: "Room",
                columns: new[] { "Id", "Capacity", "CinemaId" },
                values: new object[,]
                {
                    { 1L, 300, 1L },
                    { 2L, 300, 1L },
                    { 3L, 300, 1L },
                    { 4L, 300, 1L },
                    { 5L, 300, 1L },
                    { 6L, 300, 1L },
                    { 7L, 300, 1L }
                });

            migrationBuilder.InsertData(
                table: "TimeSlot",
                columns: new[] { "Id", "RoomId", "SlotEnd", "SlotStart", "Week" },
                values: new object[,]
                {
                    { 1L, 1L, new DateTime(2021, 3, 9, 20, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 9, 19, 0, 0, 0, DateTimeKind.Unspecified), 9 },
                    { 2L, 1L, new DateTime(2021, 3, 9, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 9, 21, 0, 0, 0, DateTimeKind.Unspecified), 9 },
                    { 3L, 2L, new DateTime(2021, 3, 9, 20, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 9, 19, 0, 0, 0, DateTimeKind.Unspecified), 9 },
                    { 4L, 2L, new DateTime(2021, 3, 9, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 9, 21, 0, 0, 0, DateTimeKind.Unspecified), 9 },
                    { 5L, 3L, new DateTime(2021, 3, 9, 20, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 9, 19, 0, 0, 0, DateTimeKind.Unspecified), 9 },
                    { 6L, 3L, new DateTime(2021, 3, 9, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 9, 21, 0, 0, 0, DateTimeKind.Unspecified), 9 },
                    { 7L, 4L, new DateTime(2021, 3, 9, 20, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 9, 19, 0, 0, 0, DateTimeKind.Unspecified), 9 },
                    { 8L, 4L, new DateTime(2021, 3, 9, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 9, 21, 0, 0, 0, DateTimeKind.Unspecified), 9 },
                    { 9L, 5L, new DateTime(2021, 3, 9, 20, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 9, 19, 0, 0, 0, DateTimeKind.Unspecified), 9 },
                    { 10L, 5L, new DateTime(2021, 3, 9, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 9, 21, 0, 0, 0, DateTimeKind.Unspecified), 9 },
                    { 11L, 6L, new DateTime(2021, 3, 9, 20, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 9, 19, 0, 0, 0, DateTimeKind.Unspecified), 9 },
                    { 12L, 6L, new DateTime(2021, 3, 9, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 9, 21, 0, 0, 0, DateTimeKind.Unspecified), 9 },
                    { 13L, 7L, new DateTime(2021, 3, 9, 20, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 9, 19, 0, 0, 0, DateTimeKind.Unspecified), 9 },
                    { 14L, 7L, new DateTime(2021, 3, 9, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 9, 21, 0, 0, 0, DateTimeKind.Unspecified), 9 }
                });

            migrationBuilder.InsertData(
                table: "PlayList",
                columns: new[] { "Id", "MovieId", "TimeSlotId" },
                values: new object[,]
                {
                    { 1L, 1L, 1L },
                    { 2L, 2L, 2L },
                    { 3L, 3L, 3L },
                    { 4L, 4L, 4L },
                    { 5L, 5L, 5L },
                    { 6L, 6L, 6L },
                    { 7L, 7L, 7L },
                    { 8L, 8L, 8L },
                    { 9L, 9L, 9L },
                    { 10L, 10L, 10L },
                    { 11L, 11L, 11L },
                    { 12L, 12L, 12L },
                    { 13L, 13L, 13L },
                    { 14L, 14L, 14L }
                });

            migrationBuilder.CreateIndex(
                name: "IX_PlayList_MovieId",
                table: "PlayList",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayList_TimeSlotId",
                table: "PlayList",
                column: "TimeSlotId");

            migrationBuilder.CreateIndex(
                name: "IX_Room_CinemaId",
                table: "Room",
                column: "CinemaId");

            migrationBuilder.CreateIndex(
                name: "IX_TimeSlot_RoomId",
                table: "TimeSlot",
                column: "RoomId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PlayList");

            migrationBuilder.DropTable(
                name: "Movie");

            migrationBuilder.DropTable(
                name: "TimeSlot");

            migrationBuilder.DropTable(
                name: "Room");

            migrationBuilder.DropTable(
                name: "Cinema");
        }
    }
}
