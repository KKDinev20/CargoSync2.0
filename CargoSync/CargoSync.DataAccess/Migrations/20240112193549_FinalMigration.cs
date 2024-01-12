using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CargoSync.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class FinalMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DeliveryID",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "DeliveryID",
                table: "Revenue");

            migrationBuilder.RenameColumn(
                name: "UserID",
                table: "Users",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "RevenueID",
                table: "Revenue",
                newName: "RevenueId");

            migrationBuilder.RenameColumn(
                name: "DeliveryID",
                table: "Deliveries",
                newName: "DeliveryId");

            migrationBuilder.RenameColumn(
                name: "DeliveryID",
                table: "Cargos",
                newName: "DeliveryId");

            migrationBuilder.RenameColumn(
                name: "CargoID",
                table: "Cargos",
                newName: "CargoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Users",
                newName: "UserID");

            migrationBuilder.RenameColumn(
                name: "RevenueId",
                table: "Revenue",
                newName: "RevenueID");

            migrationBuilder.RenameColumn(
                name: "DeliveryId",
                table: "Deliveries",
                newName: "DeliveryID");

            migrationBuilder.RenameColumn(
                name: "DeliveryId",
                table: "Cargos",
                newName: "DeliveryID");

            migrationBuilder.RenameColumn(
                name: "CargoId",
                table: "Cargos",
                newName: "CargoID");

            migrationBuilder.AddColumn<int>(
                name: "DeliveryID",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DeliveryID",
                table: "Revenue",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
