﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Volunteia.Migrations
{
    /// <inheritdoc />
    public partial class teste5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserActions_Users_UserId",
                table: "UserActions");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "UserActions",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_UserActions_Users_UserId",
                table: "UserActions",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserActions_Users_UserId",
                table: "UserActions");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "UserActions",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_UserActions_Users_UserId",
                table: "UserActions",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
