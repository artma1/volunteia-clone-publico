using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Volunteia.Migrations
{
    /// <inheritdoc />
    public partial class M02UpdateTableAction : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Tipo",
                table: "Action",
                newName: "ODS");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ODS",
                table: "Action",
                newName: "Tipo");
        }
    }
}
