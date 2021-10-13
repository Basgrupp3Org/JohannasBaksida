using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JohannasBaksida.Migrations
{
    public partial class budget : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Budget_AspNetUsers_UserId",
                table: "Budget");

            migrationBuilder.DropTable(
                name: "BudgetCategory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Budget",
                table: "Budget");

            migrationBuilder.RenameTable(
                name: "Budget",
                newName: "Budgets");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Budgets",
                newName: "JohannasBaksidaUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Budget_UserId",
                table: "Budgets",
                newName: "IX_Budgets_JohannasBaksidaUserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Budgets",
                table: "Budgets",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Budgets_AspNetUsers_JohannasBaksidaUserId",
                table: "Budgets",
                column: "JohannasBaksidaUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Budgets_AspNetUsers_JohannasBaksidaUserId",
                table: "Budgets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Budgets",
                table: "Budgets");

            migrationBuilder.RenameTable(
                name: "Budgets",
                newName: "Budget");

            migrationBuilder.RenameColumn(
                name: "JohannasBaksidaUserId",
                table: "Budget",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Budgets_JohannasBaksidaUserId",
                table: "Budget",
                newName: "IX_Budget_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Budget",
                table: "Budget",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "BudgetCategory",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BudgetId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    FixedCostsCategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    VariableCostsCategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
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
                    table.ForeignKey(
                        name: "FK_BudgetCategory_Budget_BudgetId",
                        column: x => x.BudgetId,
                        principalTable: "Budget",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BudgetCategory_FixedCostsCategories_FixedCostsCategoryId",
                        column: x => x.FixedCostsCategoryId,
                        principalTable: "FixedCostsCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BudgetCategory_VariableCostsCategories_VariableCostsCategoryId",
                        column: x => x.VariableCostsCategoryId,
                        principalTable: "VariableCostsCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BudgetCategory_BudgetId",
                table: "BudgetCategory",
                column: "BudgetId");

            migrationBuilder.CreateIndex(
                name: "IX_BudgetCategory_FixedCostsCategoryId",
                table: "BudgetCategory",
                column: "FixedCostsCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_BudgetCategory_UserId",
                table: "BudgetCategory",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_BudgetCategory_VariableCostsCategoryId",
                table: "BudgetCategory",
                column: "VariableCostsCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Budget_AspNetUsers_UserId",
                table: "Budget",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
