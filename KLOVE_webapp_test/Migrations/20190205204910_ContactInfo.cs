using Microsoft.EntityFrameworkCore.Migrations;

namespace KLOVE_webapp_test.Migrations
{
    public partial class ContactInfo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Employee",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EmailAddress",
                table: "Employee",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PostalCode",
                table: "Employee",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PrimaryPhoneNumber",
                table: "Employee",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SecondaryPhoneNumber",
                table: "Employee",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "Employee",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Street",
                table: "Employee",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "City",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "EmailAddress",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "PostalCode",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "PrimaryPhoneNumber",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "SecondaryPhoneNumber",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "State",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "Street",
                table: "Employee");
        }
    }
}
