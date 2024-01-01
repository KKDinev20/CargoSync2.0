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

            migrationBuilder.RenameColumn(
                name: "CargoId",
                table: "Cargos",
                newName: "CargoID");

            migrationBuilder.RenameColumn(
                name: "Destination",
                table: "Cargos",
                newName: "Description");

            migrationBuilder.AlterColumn<int>(
                name: "CargoID",
                table: "Cargos",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "DeliveryID",
                table: "Cargos",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

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

            migrationBuilder.RenameColumn(
                name: "CargoID",
                table: "Cargos",
                newName: "CargoId");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Cargos",
                newName: "Destination");

            migrationBuilder.AlterColumn<int>(
                name: "DeliveryID",
                table: "Cargos",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "CargoId",
                table: "Cargos",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cargos",
                table: "Cargos",
                column: "DeliveryID");
        }
    }
}
