using Microsoft.EntityFrameworkCore.Migrations;

namespace SeeSharpersCinema.Data.Migrations
{
    public partial class addingcouponid : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ticket_Movie_MovieId",
                table: "Ticket");

            migrationBuilder.DropForeignKey(
                name: "FK_Ticket_TimeSlot_TimeSlotId",
                table: "Ticket");

            migrationBuilder.DropColumn(
                name: "Coupon",
                table: "Ticket");

            migrationBuilder.AlterColumn<long>(
                name: "TimeSlotId",
                table: "Ticket",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "MovieId",
                table: "Ticket",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CouponId",
                table: "Ticket",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<long>(
                name: "CouponId1",
                table: "Ticket",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_CouponId1",
                table: "Ticket",
                column: "CouponId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Ticket_Coupon_CouponId1",
                table: "Ticket",
                column: "CouponId1",
                principalTable: "Coupon",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Ticket_Movie_MovieId",
                table: "Ticket",
                column: "MovieId",
                principalTable: "Movie",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ticket_TimeSlot_TimeSlotId",
                table: "Ticket",
                column: "TimeSlotId",
                principalTable: "TimeSlot",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ticket_Coupon_CouponId1",
                table: "Ticket");

            migrationBuilder.DropForeignKey(
                name: "FK_Ticket_Movie_MovieId",
                table: "Ticket");

            migrationBuilder.DropForeignKey(
                name: "FK_Ticket_TimeSlot_TimeSlotId",
                table: "Ticket");

            migrationBuilder.DropIndex(
                name: "IX_Ticket_CouponId1",
                table: "Ticket");

            migrationBuilder.DropColumn(
                name: "CouponId",
                table: "Ticket");

            migrationBuilder.DropColumn(
                name: "CouponId1",
                table: "Ticket");

            migrationBuilder.AlterColumn<long>(
                name: "TimeSlotId",
                table: "Ticket",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<long>(
                name: "MovieId",
                table: "Ticket",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AddColumn<string>(
                name: "Coupon",
                table: "Ticket",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Ticket_Movie_MovieId",
                table: "Ticket",
                column: "MovieId",
                principalTable: "Movie",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Ticket_TimeSlot_TimeSlotId",
                table: "Ticket",
                column: "TimeSlotId",
                principalTable: "TimeSlot",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
