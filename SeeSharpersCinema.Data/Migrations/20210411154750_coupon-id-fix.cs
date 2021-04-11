using Microsoft.EntityFrameworkCore.Migrations;

namespace SeeSharpersCinema.Data.Migrations
{
    public partial class couponidfix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ticket_Coupon_CouponId1",
                table: "Ticket");

            migrationBuilder.DropIndex(
                name: "IX_Ticket_CouponId1",
                table: "Ticket");

            migrationBuilder.DropColumn(
                name: "CouponId1",
                table: "Ticket");

            migrationBuilder.AlterColumn<long>(
                name: "CouponId",
                table: "Ticket",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_CouponId",
                table: "Ticket",
                column: "CouponId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ticket_Coupon_CouponId",
                table: "Ticket",
                column: "CouponId",
                principalTable: "Coupon",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ticket_Coupon_CouponId",
                table: "Ticket");

            migrationBuilder.DropIndex(
                name: "IX_Ticket_CouponId",
                table: "Ticket");

            migrationBuilder.AlterColumn<int>(
                name: "CouponId",
                table: "Ticket",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

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
        }
    }
}
