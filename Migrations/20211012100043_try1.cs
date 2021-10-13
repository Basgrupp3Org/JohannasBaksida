using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JohannasBaksida.Migrations
{
    public partial class try1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "BalanceId",
                table: "AspNetUsers",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Balance",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Sum = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Balance", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Budget",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Income = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Housing = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Vehicle = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Unbudgeted = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    JohannasBaksidaUserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Budget", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Budget_AspNetUsers_JohannasBaksidaUserId",
                        column: x => x.JohannasBaksidaUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FixedCostsCategories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sum = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    JohannasBaksidaUserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FixedCostsCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FixedCostsCategories_AspNetUsers_JohannasBaksidaUserId",
                        column: x => x.JohannasBaksidaUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BalanceChanged",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OldSum = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NewSum = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BalanceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    JohannasBaksidaUserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BalanceChanged", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BalanceChanged_AspNetUsers_JohannasBaksidaUserId",
                        column: x => x.JohannasBaksidaUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BalanceChanged_Balance_BalanceId",
                        column: x => x.BalanceId,
                        principalTable: "Balance",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "VariableCostsCategories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ToSpend = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Spent = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BudgetId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    JohannasBaksidaUserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VariableCostsCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VariableCostsCategories_AspNetUsers_JohannasBaksidaUserId",
                        column: x => x.JohannasBaksidaUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_VariableCostsCategories_Budget_BudgetId",
                        column: x => x.BudgetId,
                        principalTable: "Budget",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Purchase",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    VariableCostsCategoriesId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Purchase", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Purchase_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Purchase_VariableCostsCategories_VariableCostsCategoriesId",
                        column: x => x.VariableCostsCategoriesId,
                        principalTable: "VariableCostsCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_BalanceId",
                table: "AspNetUsers",
                column: "BalanceId");

            migrationBuilder.CreateIndex(
                name: "IX_BalanceChanged_BalanceId",
                table: "BalanceChanged",
                column: "BalanceId");

            migrationBuilder.CreateIndex(
                name: "IX_BalanceChanged_JohannasBaksidaUserId",
                table: "BalanceChanged",
                column: "JohannasBaksidaUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Budget_JohannasBaksidaUserId",
                table: "Budget",
                column: "JohannasBaksidaUserId");

            migrationBuilder.CreateIndex(
                name: "IX_FixedCostsCategories_JohannasBaksidaUserId",
                table: "FixedCostsCategories",
                column: "JohannasBaksidaUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Purchase_UserId",
                table: "Purchase",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Purchase_VariableCostsCategoriesId",
                table: "Purchase",
                column: "VariableCostsCategoriesId");

            migrationBuilder.CreateIndex(
                name: "IX_VariableCostsCategories_BudgetId",
                table: "VariableCostsCategories",
                column: "BudgetId");

            migrationBuilder.CreateIndex(
                name: "IX_VariableCostsCategories_JohannasBaksidaUserId",
                table: "VariableCostsCategories",
                column: "JohannasBaksidaUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Balance_BalanceId",
                table: "AspNetUsers",
                column: "BalanceId",
                principalTable: "Balance",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Balance_BalanceId",
                table: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "BalanceChanged");

            migrationBuilder.DropTable(
                name: "FixedCostsCategories");

            migrationBuilder.DropTable(
                name: "Purchase");

            migrationBuilder.DropTable(
                name: "Balance");

            migrationBuilder.DropTable(
                name: "VariableCostsCategories");

            migrationBuilder.DropTable(
                name: "Budget");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_BalanceId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "BalanceId",
                table: "AspNetUsers");
        }
    }
}
