using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JohannasBaksida.Migrations
{
    public partial class fixedcostandvariablecostchanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FixedCostsCategories_AspNetUsers_UserId",
                table: "FixedCostsCategories");

            migrationBuilder.DropForeignKey(
                name: "FK_Purchases_VariableCostsCategories_VariableCostsCategoriesId",
                table: "Purchases");

            migrationBuilder.DropForeignKey(
                name: "FK_VariableCostsCategories_AspNetUsers_UserId",
                table: "VariableCostsCategories");

            migrationBuilder.DropForeignKey(
                name: "FK_VariableCostsCategories_Budget_BudgetId",
                table: "VariableCostsCategories");

            migrationBuilder.DropIndex(
                name: "IX_VariableCostsCategories_BudgetId",
                table: "VariableCostsCategories");

            migrationBuilder.DropIndex(
                name: "IX_Purchases_VariableCostsCategoriesId",
                table: "Purchases");

            migrationBuilder.DropColumn(
                name: "BudgetId",
                table: "VariableCostsCategories");

            migrationBuilder.DropColumn(
                name: "VariableCostsCategoriesId",
                table: "Purchases");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddColumn<Guid>(
                name: "BudgetId",
                table: "VariableCostsCategories",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "VariableCostsCategoriesId",
                table: "Purchases",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_VariableCostsCategories_BudgetId",
                table: "VariableCostsCategories",
                column: "BudgetId");

            migrationBuilder.CreateIndex(
                name: "IX_Purchases_VariableCostsCategoriesId",
                table: "Purchases",
                column: "VariableCostsCategoriesId");

            migrationBuilder.AddForeignKey(
                name: "FK_FixedCostsCategories_AspNetUsers_UserId",
                table: "FixedCostsCategories",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Purchases_VariableCostsCategories_VariableCostsCategoriesId",
                table: "Purchases",
                column: "VariableCostsCategoriesId",
                principalTable: "VariableCostsCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_VariableCostsCategories_AspNetUsers_UserId",
                table: "VariableCostsCategories",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_VariableCostsCategories_Budget_BudgetId",
                table: "VariableCostsCategories",
                column: "BudgetId",
                principalTable: "Budget",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
