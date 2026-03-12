using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataLayer.Migrations
{
    /// <inheritdoc />
    public partial class Update_CustomerInfo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Discription",
                table: "Customers",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "DistanceKm",
                table: "Customers",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImgUrl",
                table: "Customers",
                type: "nvarchar(300)",
                maxLength: 300,
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "MoneySpent",
                table: "Customers",
                type: "decimal(8,2)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NumberOfCountryVisited",
                table: "Customers",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discription",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "DistanceKm",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "ImgUrl",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "MoneySpent",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "NumberOfCountryVisited",
                table: "Customers");
        }
    }
}
