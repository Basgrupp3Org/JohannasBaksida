using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JohannasBaksida.Migrations
{
    public partial class try8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.CreateTable(
                name: "BudgetCategory",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BudgetCategory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BudgetCategory_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_BudgetCategory_UserId",
                table: "BudgetCategory",
                column: "UserId");

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
                name: "FK_VariableCostsCategories_BudgetCategory_BudgetCategoryId",
                table: "VariableCostsCategories",
                column: "BudgetCategoryId",
                principalTable: "BudgetCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Budget_BudgetCategory_BudgetCategoryId",
                table: "Budget");

            migrationBuilder.DropForeignKey(
                name: "FK_FixedCostsCategories_BudgetCategory_BudgetCategoryId",
                table: "FixedCostsCategories");

            migrationBuilder.DropForeignKey(
                name: "FK_VariableCostsCategories_BudgetCategory_BudgetCategoryId",
                table: "VariableCostsCategories");

            migrationBuilder.DropTable(
                name: "BudgetCategory");

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
        }
    }
}
