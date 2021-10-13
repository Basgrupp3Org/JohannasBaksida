using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JohannasBaksida.Migrations
{
    public partial class try4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Balance_BalanceId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_BalanceId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "BalanceId",
                table: "AspNetUsers");

            migrationBuilder.CreateTable(
                name: "BalanceJohannasBaksidaUser",
                columns: table => new
                {
                    BalanceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UsersId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BalanceJohannasBaksidaUser", x => new { x.BalanceId, x.UsersId });
                    table.ForeignKey(
                        name: "FK_BalanceJohannasBaksidaUser_AspNetUsers_UsersId",
                        column: x => x.UsersId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BalanceJohannasBaksidaUser_Balance_BalanceId",
                        column: x => x.BalanceId,
                        principalTable: "Balance",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BalanceJohannasBaksidaUser_UsersId",
                table: "BalanceJohannasBaksidaUser",
                column: "UsersId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BalanceJohannasBaksidaUser");

            migrationBuilder.AddColumn<Guid>(
                name: "BalanceId",
                table: "AspNetUsers",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_BalanceId",
                table: "AspNetUsers",
                column: "BalanceId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Balance_BalanceId",
                table: "AspNetUsers",
                column: "BalanceId",
                principalTable: "Balance",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
