using Microsoft.EntityFrameworkCore.Migrations;

namespace JohannasBaksida.Migrations
{
    public partial class secondMig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SavingGoal_AspNetUsers_JohannasBaksidaUserId",
                table: "SavingGoal");

            migrationBuilder.RenameColumn(
                name: "JohannasBaksidaUserId",
                table: "SavingGoal",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_SavingGoal_JohannasBaksidaUserId",
                table: "SavingGoal",
                newName: "IX_SavingGoal_UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_SavingGoal_AspNetUsers_UserId",
                table: "SavingGoal",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SavingGoal_AspNetUsers_UserId",
                table: "SavingGoal");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "SavingGoal",
                newName: "JohannasBaksidaUserId");

            migrationBuilder.RenameIndex(
                name: "IX_SavingGoal_UserId",
                table: "SavingGoal",
                newName: "IX_SavingGoal_JohannasBaksidaUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_SavingGoal_AspNetUsers_JohannasBaksidaUserId",
                table: "SavingGoal",
                column: "JohannasBaksidaUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
