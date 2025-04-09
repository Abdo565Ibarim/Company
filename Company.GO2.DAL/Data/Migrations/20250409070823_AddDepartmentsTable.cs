using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Company.GO2.DAL.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddDepartmentsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Depratment",
                table: "Depratment");

            migrationBuilder.RenameTable(
                name: "Depratment",
                newName: "Depratments");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Depratments",
                table: "Depratments",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Depratments",
                table: "Depratments");

            migrationBuilder.RenameTable(
                name: "Depratments",
                newName: "Depratment");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Depratment",
                table: "Depratment",
                column: "Id");
        }
    }
}
