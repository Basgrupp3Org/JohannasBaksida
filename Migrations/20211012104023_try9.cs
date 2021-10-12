using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JohannasBaksida.Migrations
{
    public partial class try9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Budget_BudgetCategory_BudgetCategoryId",
                table: "Budget");

            migrationBuilder.DropForeignKey(
                name: "FK_FixedCostsCategories_BudgetCategory_BudgetCategoryId",
                table: "FixedCostsCategories");

            migrationBuilder.DropForeignKey(
                name: "FK_Purchase_VariableCostsCategories_VariableCostsCategoriesId",
                table: "Purchase");

            migrationBuilder.DropForeignKey(
                name: "FK_VariableCostsCategories_BudgetCategory_BudgetCategoryId",
                table: "VariableCostsCategories");

            migrationBuilder.DropIndex(
                name: "IX_VariableCostsCategories_BudgetCategoryId",
                table: "VariableCostsCategories");

            migrationBuilder.DropIndex(
                name: "IX_FixedCostsCategories_BudgetCategoryId",
                table: "FixedCostsCategories");

            migrationBuilder.DropIndex(
                name: "IX_Budget_BudgetCategoryId",
                table: "Budget");

            migrationBuilder.DropColumn(
                name: "BudgetCategoryId",
                table: "VariableCostsCategories");

            migrationBuilder.DropColumn(
                name: "BudgetCategoryId",
                table: "FixedCostsCategories");

            migrationBuilder.DropColumn(
                name: "BudgetCategoryId",
                table: "Budget");

            migrationBuilder.RenameColumn(
                name: "VariableCostsCategoriesId",
                table: "Purchase",
                newName: "VariableCostsCategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Purchase_VariableCostsCategoriesId",
                table: "Purchase",
                newName: "IX_Purchase_VariableCostsCategoryId");

            migrationBuilder.AddColumn<Guid>(
                name: "BudgetId",
                table: "BudgetCategory",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "FixedCostsCategoryId",
                table: "BudgetCategory",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "VariableCostsCategoryId",
                table: "BudgetCategory",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_BudgetCategory_BudgetId",
                table: "BudgetCategory",
                column: "BudgetId");

            migrationBuilder.CreateIndex(
                name: "IX_BudgetCategory_FixedCostsCategoryId",
                table: "BudgetCategory",
                column: "FixedCostsCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_BudgetCategory_VariableCostsCategoryId",
                table: "BudgetCategory",
                column: "VariableCostsCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_BudgetCategory_Budget_BudgetId",
                table: "BudgetCategory",
                column: "BudgetId",
                principalTable: "Budget",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BudgetCategory_FixedCostsCategories_FixedCostsCategoryId",
                table: "BudgetCategory",
                column: "FixedCostsCategoryId",
                principalTable: "FixedCostsCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BudgetCategory_VariableCostsCategories_VariableCostsCategoryId",
                table: "BudgetCategory",
                column: "VariableCostsCategoryId",
                principalTable: "VariableCostsCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Purchase_VariableCostsCategories_VariableCostsCategoryId",
                table: "Purchase",
                column: "VariableCostsCategoryId",
                principalTable: "VariableCostsCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BudgetCategory_Budget_BudgetId",
                table: "BudgetCategory");

            migrationBuilder.DropForeignKey(
                name: "FK_BudgetCategory_FixedCostsCategories_FixedCostsCategoryId",
                table: "BudgetCategory");

            migrationBuilder.DropForeignKey(
                name: "FK_BudgetCategory_VariableCostsCategories_VariableCostsCategoryId",
                table: "BudgetCategory");

            migrationBuilder.DropForeignKey(
                name: "FK_Purchase_VariableCostsCategories_VariableCostsCategoryId",
                table: "Purchase");

            migrationBuilder.DropIndex(
                name: "IX_BudgetCategory_BudgetId",
                table: "BudgetCategory");

            migrationBuilder.DropIndex(
                name: "IX_BudgetCategory_FixedCostsCategoryId",
                table: "BudgetCategory");

            migrationBuilder.DropIndex(
                name: "IX_BudgetCategory_VariableCostsCategoryId",
                table: "BudgetCategory");

            migrationBuilder.DropColumn(
                name: "BudgetId",
                table: "BudgetCategory");

            migrationBuilder.DropColumn(
                name: "FixedCostsCategoryId",
                table: "BudgetCategory");

            migrationBuilder.DropColumn(
                name: "VariableCostsCategoryId",
                table: "BudgetCategory");

            migrationBuilder.RenameColumn(
                name: "VariableCostsCategoryId",
                table: "Purchase",
                newName: "VariableCostsCategoriesId");

            migrationBuilder.RenameIndex(
                name: "IX_Purchase_VariableCostsCategoryId",
                table: "Purchase",
                newName: "IX_Purchase_VariableCostsCategoriesId");

            migrationBuilder.AddColumn<Guid>(
                name: "BudgetCategoryId",
                table: "VariableCostsCategories",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "BudgetCategoryId",
                table: "FixedCostsCategories",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "BudgetCategoryId",
                table: "Budget",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_VariableCostsCategories_BudgetCategoryId",
                table: "VariableCostsCategories",
                column: "BudgetCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_FixedCostsCategories_BudgetCategoryId",
                table: "FixedCostsCategories",
                column: "BudgetCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Budget_BudgetCategoryId",
                table: "Budget",
                column: "BudgetCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Budget_BudgetCategory_BudgetCategoryId",
                table: "Budget",
                column: "BudgetCategoryId",
                principalTable: "BudgetCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FixedCostsCategories_BudgetCategory_BudgetCategoryId",
                table: "FixedCostsCategories",
                column: "BudgetCategoryId",
                principalTable: "BudgetCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Purchase_VariableCostsCategories_VariableCostsCategoriesId",
                table: "Purchase",
                column: "VariableCostsCategoriesId",
                principalTable: "VariableCostsCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_VariableCostsCategories_BudgetCategory_BudgetCategoryId",
                table: "VariableCostsCategories",
                column: "BudgetCategoryId",
                principalTable: "BudgetCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
