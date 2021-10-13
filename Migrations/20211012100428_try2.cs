using Microsoft.EntityFrameworkCore.Migrations;

namespace JohannasBaksida.Migrations
{
    public partial class try2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BalanceChanged_AspNetUsers_JohannasBaksidaUserId",
                table: "BalanceChanged");

            migrationBuilder.RenameColumn(
                name: "JohannasBaksidaUserId",
                table: "BalanceChanged",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_BalanceChanged_JohannasBaksidaUserId",
                table: "BalanceChanged",
                newName: "IX_BalanceChanged_UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_BalanceChanged_AspNetUsers_UserId",
                table: "BalanceChanged",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BalanceChanged_AspNetUsers_UserId",
                table: "BalanceChanged");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "BalanceChanged",
                newName: "JohannasBaksidaUserId");

            migrationBuilder.RenameIndex(
                name: "IX_BalanceChanged_UserId",
                table: "BalanceChanged",
                newName: "IX_BalanceChanged_JohannasBaksidaUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_BalanceChanged_AspNetUsers_JohannasBaksidaUserId",
                table: "BalanceChanged",
                column: "JohannasBaksidaUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
