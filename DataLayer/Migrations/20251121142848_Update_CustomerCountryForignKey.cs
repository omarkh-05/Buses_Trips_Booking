using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataLayer.Migrations
{
    /// <inheritdoc />
    public partial class Update_CustomerCountryForignKey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Countries_CountryId",
                table: "Customers");

            migrationBuilder.DropForeignKey(
                name: "FK_Customers_CustomersCountries_CustomersCountriesCountryID",
                table: "Customers");

            migrationBuilder.DropIndex(
                name: "IX_Customers_CustomersCountriesCountryID",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "CustomersCountriesCountryID",
                table: "Customers");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_CustomersCountries_CountryId",
                table: "Customers",
                column: "CountryId",
                principalTable: "CustomersCountries",
                principalColumn: "CountryID",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_CustomersCountries_CountryId",
                table: "Customers");

            migrationBuilder.AddColumn<short>(
                name: "CustomersCountriesCountryID",
                table: "Customers",
                type: "smallint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Customers_CustomersCountriesCountryID",
                table: "Customers",
                column: "CustomersCountriesCountryID");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Countries_CountryId",
                table: "Customers",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "CountryID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_CustomersCountries_CustomersCountriesCountryID",
                table: "Customers",
                column: "CustomersCountriesCountryID",
                principalTable: "CustomersCountries",
                principalColumn: "CountryID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
