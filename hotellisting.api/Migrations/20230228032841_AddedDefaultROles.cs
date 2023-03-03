using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace hotellisting.api.Migrations
{
    /// <inheritdoc />
    public partial class AddedDefaultROles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "431244e7-e809-4d8a-be6f-57fc1817ae74", "6cf92c30-b731-44a2-8adf-2d8bb1f27749", "User", "USER" },
                    { "faeb5753-0bbe-4f06-aaa8-f6ebcdf51570", "b2b15abe-8b63-403d-adcd-4377cc24812a", "Administrator", "ADMINISTRATOR" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "431244e7-e809-4d8a-be6f-57fc1817ae74");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "faeb5753-0bbe-4f06-aaa8-f6ebcdf51570");
        }
    }
}
