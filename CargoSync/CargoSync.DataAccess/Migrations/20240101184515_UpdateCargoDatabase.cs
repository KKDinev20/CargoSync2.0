using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CargoSync.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class UpdateCargoDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Cargos",
                table: "Cargos");

            migrationBuilder.DropColumn(
                name: "CargoID",
                table: "Cargos");

            migrationBuilder.AddColumn<int>(
                name: "CargoID",
                table: "Cargos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cargos",
                table: "Cargos",
                column: "CargoID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Cargos",
                table: "Cargos");

            migrationBuilder.DropColumn(
                name: "CargoID",
                table: "Cargos");

            migrationBuilder.AddColumn<int>(
                name: "CargoID",
                table: "Cargos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cargos",
                table: "Cargos",
                column: "DeliveryID");
        }
    }
}
