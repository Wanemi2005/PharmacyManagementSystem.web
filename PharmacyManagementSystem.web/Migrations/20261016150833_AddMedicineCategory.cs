using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace PharmacyManagementSystem.web.Migrations
{
    /// <inheritdoc />
    public partial class AddMedicineCategory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Barcode",
                table: "Medicines",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Medicines",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "GenericName",
                table: "Medicines",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "PurchasePrice",
                table: "Medicines",
                type: "numeric",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "RequiredPrescription",
                table: "Medicines",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "SellingPrice",
                table: "Medicines",
                type: "numeric",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.CreateTable(
                name: "MedicineCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicineCategories", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Medicines_CategoryId",
                table: "Medicines",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Medicines_MedicineCategories_CategoryId",
                table: "Medicines",
                column: "CategoryId",
                principalTable: "MedicineCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Medicines_MedicineCategories_CategoryId",
                table: "Medicines");

            migrationBuilder.DropTable(
                name: "MedicineCategories");

            migrationBuilder.DropIndex(
                name: "IX_Medicines_CategoryId",
                table: "Medicines");

            migrationBuilder.DropColumn(
                name: "Barcode",
                table: "Medicines");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Medicines");

            migrationBuilder.DropColumn(
                name: "GenericName",
                table: "Medicines");

            migrationBuilder.DropColumn(
                name: "PurchasePrice",
                table: "Medicines");

            migrationBuilder.DropColumn(
                name: "RequiredPrescription",
                table: "Medicines");

            migrationBuilder.DropColumn(
                name: "SellingPrice",
                table: "Medicines");
        }
    }
}
