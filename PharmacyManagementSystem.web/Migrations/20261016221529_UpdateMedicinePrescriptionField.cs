using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PharmacyManagementSystem.web.Migrations
{
    /// <inheritdoc />
    public partial class UpdateMedicinePrescriptionField : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RequiredPrescription",
                table: "Medicines");

            migrationBuilder.AddColumn<bool>(
                name: "RequiresPrescription",
                table: "Medicines",
                type: "boolean",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RequiresPrescription",
                table: "Medicines");

            migrationBuilder.AddColumn<string>(
                name: "RequiredPrescription",
                table: "Medicines",
                type: "text",
                nullable: false,
                defaultValue: "");
        }
    }
}
