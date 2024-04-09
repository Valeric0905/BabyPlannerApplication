using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BloodTypeWeb.Migrations
{
    /// <inheritdoc />
    public partial class AddApplicationUserProperties : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(50)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PregnancyTerm",
                table: "AspNetUsers",
                type: "nvarchar(50)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "PregnancyTerm",
                table: "AspNetUsers");
        }
    }
}
