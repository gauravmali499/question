using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Exam.Migrations
{
    /// <inheritdoc />
    public partial class updated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_bookings_seats_SeatId",
                table: "bookings");

            migrationBuilder.DropIndex(
                name: "IX_bookings_SeatId",
                table: "bookings");

            migrationBuilder.DropColumn(
                name: "SeatId",
                table: "bookings");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SeatId",
                table: "bookings",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_bookings_SeatId",
                table: "bookings",
                column: "SeatId");

            migrationBuilder.AddForeignKey(
                name: "FK_bookings_seats_SeatId",
                table: "bookings",
                column: "SeatId",
                principalTable: "seats",
                principalColumn: "Id");
        }
    }
}
