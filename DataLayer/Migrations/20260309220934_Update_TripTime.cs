using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataLayer.Migrations
{
    /// <inheritdoc />
    public partial class Update_TripTime : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddForeignKey(
       name: "FK_Trips_TripTimes_TripTimeID",
       table: "Trips",
       column: "TripTimeID",
       principalTable: "TripTimes",
       principalColumn: "TripTimeID",
       onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
        name: "FK_Trips_TripTimes_TripTimeID",
        table: "Trips");
        }
    }
}
