using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JohannasBaksida.Migrations
{
    public partial class commentpurchase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Purchase_AspNetUsers_UserId",
                table: "Purchase");

            migrationBuilder.DropForeignKey(
                name: "FK_Purchase_VariableCostsCategories_VariableCostsCategoryId",
                table: "Purchase");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Purchase",
                table: "Purchase");

            migrationBuilder.DropColumn(
                name: "Date",
                table: "Purchase");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Purchase");

            migrationBuilder.RenameTable(
                name: "Purchase",
                newName: "Purchases");

            migrationBuilder.RenameColumn(
                name: "VariableCostsCategoryId",
                table: "Purchases",
                newName: "VariableCostsCategoriesId");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Purchases",
                newName: "JohannasBaksidaUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Purchase_VariableCostsCategoryId",
                table: "Purchases",
                newName: "IX_Purchases_VariableCostsCategoriesId");

            migrationBuilder.RenameIndex(
                name: "IX_Purchase_UserId",
                table: "Purchases",
                newName: "IX_Purchases_JohannasBaksidaUserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Purchases",
                table: "Purchases",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Purchases_AspNetUsers_JohannasBaksidaUserId",
                table: "Purchases",
                column: "JohannasBaksidaUserId",
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Purchases_AspNetUsers_JohannasBaksidaUserId",
                table: "Purchases");

            migrationBuilder.DropForeignKey(
                name: "FK_Purchases_VariableCostsCategories_VariableCostsCategoriesId",
                table: "Purchases");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Purchases",
                table: "Purchases");

            migrationBuilder.RenameTable(
                name: "Purchases",
                newName: "Purchase");

            migrationBuilder.RenameColumn(
                name: "VariableCostsCategoriesId",
                table: "Purchase",
                newName: "VariableCostsCategoryId");

            migrationBuilder.RenameColumn(
                name: "JohannasBaksidaUserId",
                table: "Purchase",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Purchases_VariableCostsCategoriesId",
                table: "Purchase",
                newName: "IX_Purchase_VariableCostsCategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Purchases_JohannasBaksidaUserId",
                table: "Purchase",
                newName: "IX_Purchase_UserId");

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "Purchase",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Purchase",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Purchase",
                table: "Purchase",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Purchase_AspNetUsers_UserId",
                table: "Purchase",
                column: "UserId",
                principalTable: "AspNetUsers",
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
    }
}
