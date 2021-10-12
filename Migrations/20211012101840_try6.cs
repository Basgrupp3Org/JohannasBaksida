using Microsoft.EntityFrameworkCore.Migrations;

namespace JohannasBaksida.Migrations
{
    public partial class try6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Balance_AspNetUsers_UsersId",
                table: "Balance");

            migrationBuilder.DropForeignKey(
                name: "FK_BalanceChanged_AspNetUsers_JohannasBaksidaUserId",
                table: "BalanceChanged");

            migrationBuilder.DropForeignKey(
                name: "FK_Budget_AspNetUsers_JohannasBaksidaUserId",
                table: "Budget");

            migrationBuilder.DropForeignKey(
                name: "FK_FixedCostsCategories_AspNetUsers_JohannasBaksidaUserId",
                table: "FixedCostsCategories");

            migrationBuilder.DropForeignKey(
                name: "FK_VariableCostsCategories_AspNetUsers_JohannasBaksidaUserId",
                table: "VariableCostsCategories");

            migrationBuilder.RenameColumn(
                name: "JohannasBaksidaUserId",
                table: "VariableCostsCategories",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_VariableCostsCategories_JohannasBaksidaUserId",
                table: "VariableCostsCategories",
                newName: "IX_VariableCostsCategories_UserId");

            migrationBuilder.RenameColumn(
                name: "JohannasBaksidaUserId",
                table: "FixedCostsCategories",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_FixedCostsCategories_JohannasBaksidaUserId",
                table: "FixedCostsCategories",
                newName: "IX_FixedCostsCategories_UserId");

            migrationBuilder.RenameColumn(
                name: "JohannasBaksidaUserId",
                table: "Budget",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Budget_JohannasBaksidaUserId",
                table: "Budget",
                newName: "IX_Budget_UserId");

            migrationBuilder.RenameColumn(
                name: "JohannasBaksidaUserId",
                table: "BalanceChanged",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_BalanceChanged_JohannasBaksidaUserId",
                table: "BalanceChanged",
                newName: "IX_BalanceChanged_UserId");

            migrationBuilder.RenameColumn(
                name: "UsersId",
                table: "Balance",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Balance_UsersId",
                table: "Balance",
                newName: "IX_Balance_UserId");

            migrationBuilder.AddColumn<decimal>(
                name: "BalanceUser",
                table: "AspNetUsers",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddForeignKey(
                name: "FK_Balance_AspNetUsers_UserId",
                table: "Balance",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BalanceChanged_AspNetUsers_UserId",
                table: "BalanceChanged",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Budget_AspNetUsers_UserId",
                table: "Budget",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FixedCostsCategories_AspNetUsers_UserId",
                table: "FixedCostsCategories",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_VariableCostsCategories_AspNetUsers_UserId",
                table: "VariableCostsCategories",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Balance_AspNetUsers_UserId",
                table: "Balance");

            migrationBuilder.DropForeignKey(
                name: "FK_BalanceChanged_AspNetUsers_UserId",
                table: "BalanceChanged");

            migrationBuilder.DropForeignKey(
                name: "FK_Budget_AspNetUsers_UserId",
                table: "Budget");

            migrationBuilder.DropForeignKey(
                name: "FK_FixedCostsCategories_AspNetUsers_UserId",
                table: "FixedCostsCategories");

            migrationBuilder.DropForeignKey(
                name: "FK_VariableCostsCategories_AspNetUsers_UserId",
                table: "VariableCostsCategories");

            migrationBuilder.DropColumn(
                name: "BalanceUser",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "VariableCostsCategories",
                newName: "JohannasBaksidaUserId");

            migrationBuilder.RenameIndex(
                name: "IX_VariableCostsCategories_UserId",
                table: "VariableCostsCategories",
                newName: "IX_VariableCostsCategories_JohannasBaksidaUserId");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "FixedCostsCategories",
                newName: "JohannasBaksidaUserId");

            migrationBuilder.RenameIndex(
                name: "IX_FixedCostsCategories_UserId",
                table: "FixedCostsCategories",
                newName: "IX_FixedCostsCategories_JohannasBaksidaUserId");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Budget",
                newName: "JohannasBaksidaUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Budget_UserId",
                table: "Budget",
                newName: "IX_Budget_JohannasBaksidaUserId");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "BalanceChanged",
                newName: "JohannasBaksidaUserId");

            migrationBuilder.RenameIndex(
                name: "IX_BalanceChanged_UserId",
                table: "BalanceChanged",
                newName: "IX_BalanceChanged_JohannasBaksidaUserId");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Balance",
                newName: "UsersId");

            migrationBuilder.RenameIndex(
                name: "IX_Balance_UserId",
                table: "Balance",
                newName: "IX_Balance_UsersId");

            migrationBuilder.AddForeignKey(
                name: "FK_Balance_AspNetUsers_UsersId",
                table: "Balance",
                column: "UsersId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BalanceChanged_AspNetUsers_JohannasBaksidaUserId",
                table: "BalanceChanged",
                column: "JohannasBaksidaUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Budget_AspNetUsers_JohannasBaksidaUserId",
                table: "Budget",
                column: "JohannasBaksidaUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FixedCostsCategories_AspNetUsers_JohannasBaksidaUserId",
                table: "FixedCostsCategories",
                column: "JohannasBaksidaUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_VariableCostsCategories_AspNetUsers_JohannasBaksidaUserId",
                table: "VariableCostsCategories",
                column: "JohannasBaksidaUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
