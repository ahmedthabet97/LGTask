using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskDB.Migrations
{
    public partial class init3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CategoryPropertiesValues_Categories_CategoryId",
                table: "CategoryPropertiesValues");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoryPropertiesValues_Devices_DeviceId",
                table: "CategoryPropertiesValues");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoryPropertiesValues_Propertiess_propertyId",
                table: "CategoryPropertiesValues");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CategoryPropertiesValues",
                table: "CategoryPropertiesValues");

            migrationBuilder.RenameTable(
                name: "CategoryPropertiesValues",
                newName: "PropertiesValues");

            migrationBuilder.RenameIndex(
                name: "IX_CategoryPropertiesValues_DeviceId",
                table: "PropertiesValues",
                newName: "IX_PropertiesValues_DeviceId");

            migrationBuilder.RenameIndex(
                name: "IX_CategoryPropertiesValues_CategoryId",
                table: "PropertiesValues",
                newName: "IX_PropertiesValues_CategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PropertiesValues",
                table: "PropertiesValues",
                columns: new[] { "propertyId", "CategoryId", "DeviceId" });

            migrationBuilder.AddForeignKey(
                name: "FK_PropertiesValues_Categories_CategoryId",
                table: "PropertiesValues",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_PropertiesValues_Devices_DeviceId",
                table: "PropertiesValues",
                column: "DeviceId",
                principalTable: "Devices",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PropertiesValues_Propertiess_propertyId",
                table: "PropertiesValues",
                column: "propertyId",
                principalTable: "Propertiess",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PropertiesValues_Categories_CategoryId",
                table: "PropertiesValues");

            migrationBuilder.DropForeignKey(
                name: "FK_PropertiesValues_Devices_DeviceId",
                table: "PropertiesValues");

            migrationBuilder.DropForeignKey(
                name: "FK_PropertiesValues_Propertiess_propertyId",
                table: "PropertiesValues");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PropertiesValues",
                table: "PropertiesValues");

            migrationBuilder.RenameTable(
                name: "PropertiesValues",
                newName: "CategoryPropertiesValues");

            migrationBuilder.RenameIndex(
                name: "IX_PropertiesValues_DeviceId",
                table: "CategoryPropertiesValues",
                newName: "IX_CategoryPropertiesValues_DeviceId");

            migrationBuilder.RenameIndex(
                name: "IX_PropertiesValues_CategoryId",
                table: "CategoryPropertiesValues",
                newName: "IX_CategoryPropertiesValues_CategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CategoryPropertiesValues",
                table: "CategoryPropertiesValues",
                columns: new[] { "propertyId", "CategoryId", "DeviceId" });

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryPropertiesValues_Categories_CategoryId",
                table: "CategoryPropertiesValues",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryPropertiesValues_Devices_DeviceId",
                table: "CategoryPropertiesValues",
                column: "DeviceId",
                principalTable: "Devices",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryPropertiesValues_Propertiess_propertyId",
                table: "CategoryPropertiesValues",
                column: "propertyId",
                principalTable: "Propertiess",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
