using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JohannasBaksida.Migrations
{
    public partial class try5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BalanceJohannasBaksidaUser");

            migrationBuilder.AddColumn<string>(
                name: "UsersId",
                table: "Balance",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Balance_UsersId",
                table: "Balance",
                column: "UsersId");

            migrationBuilder.AddForeignKey(
                name: "FK_Balance_AspNetUsers_UsersId",
                table: "Balance",
                column: "UsersId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Balance_AspNetUsers_UsersId",
                table: "Balance");

            migrationBuilder.DropIndex(
                name: "IX_Balance_UsersId",
                table: "Balance");

            migrationBuilder.DropColumn(
                name: "UsersId",
                table: "Balance");

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
    }
}
