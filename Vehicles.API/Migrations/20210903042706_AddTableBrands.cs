using Microsoft.EntityFrameworkCore.Migrations;

namespace Vehicles.API.Migrations
{
    public partial class AddTableBrands : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_VehicleType",
                table: "VehicleType");

            migrationBuilder.RenameTable(
                name: "VehicleType",
                newName: "VehicleTypes");

            migrationBuilder.RenameIndex(
                name: "IX_VehicleType_Description",
                table: "VehicleTypes",
                newName: "IX_VehicleTypes_Description");

            migrationBuilder.AddPrimaryKey(
                name: "PK_VehicleTypes",
                table: "VehicleTypes",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Brand",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brand", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Brand");

            migrationBuilder.DropPrimaryKey(
                name: "PK_VehicleTypes",
                table: "VehicleTypes");

            migrationBuilder.RenameTable(
                name: "VehicleTypes",
                newName: "VehicleType");

            migrationBuilder.RenameIndex(
                name: "IX_VehicleTypes_Description",
                table: "VehicleType",
                newName: "IX_VehicleType_Description");

            migrationBuilder.AddPrimaryKey(
                name: "PK_VehicleType",
                table: "VehicleType",
                column: "Id");
        }
    }
}
