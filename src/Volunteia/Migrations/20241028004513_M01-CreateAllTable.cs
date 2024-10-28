using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Volunteia.Migrations
{
    /// <inheritdoc />
    public partial class M01CreateAllTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    NumberOfActions = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    CPForCNPJ = table.Column<string>(type: "nvarchar(18)", maxLength: 18, nullable: false),
                    ShortBio = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    IsRestricted = table.Column<bool>(type: "bit", nullable: false),
                    IsBenefactor = table.Column<bool>(type: "bit", nullable: false),
                    IsPrivate = table.Column<bool>(type: "bit", nullable: false),
                    UserStatus = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserActions",
                columns: table => new
                {
                    ActionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Patrocinador = table.Column<bool>(type: "bit", nullable: false),
                    ActionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ActionBio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ODS = table.Column<int>(type: "int", nullable: false),
                    ActionStatus = table.Column<int>(type: "int", nullable: false),
                    VolunteersTotal = table.Column<int>(type: "int", nullable: false),
                    NumberOfPeopleHelped = table.Column<int>(type: "int", nullable: false),
                    Rate = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserActions", x => x.ActionId);
                    table.ForeignKey(
                        name: "FK_UserActions_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserActions_UserId",
                table: "UserActions",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserActions");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
