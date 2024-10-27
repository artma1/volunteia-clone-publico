using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Volunteia.Migrations
{
    /// <inheritdoc />
    public partial class M06UpdateFotoColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<byte[]>(
            name: "Foto",
            table: "UserActions",
            type: "varbinary(max)",
            nullable: true,
            oldClrType: typeof(string),
            oldType: "nvarchar(max)",
            oldNullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
           name: "Foto",
           table: "UserActions",
           type: "nvarchar(max)",
           nullable: true,
           oldClrType: typeof(byte[]),
           oldType: "varbinary(max)",
           oldNullable: true);

        }
    }
}
