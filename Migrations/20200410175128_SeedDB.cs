using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ostosAppi_api.Migrations
{
    public partial class SeedDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingItem_ShoppingList_ShoppingListId",
                table: "ShoppingItem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ShoppingItem",
                table: "ShoppingItem");

            migrationBuilder.DropIndex(
                name: "IX_ShoppingItem_ShoppingListId",
                table: "ShoppingItem");

            migrationBuilder.AlterColumn<int>(
                name: "ShoppingListId",
                table: "ShoppingItem",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ShoppingItem",
                table: "ShoppingItem",
                columns: new[] { "ShoppingListId", "Id" });

            migrationBuilder.InsertData(
                table: "ShoppingList",
                columns: new[] { "Id", "Created", "CreatedBy", "IsDone", "Name", "Store", "Updated", "UpdatedBy" },
                values: new object[] { 1, new DateTime(2020, 4, 10, 20, 51, 28, 562, DateTimeKind.Local).AddTicks(7475), "DBInit", false, "Ostokset1", "Prisma", new DateTime(2020, 4, 10, 20, 51, 28, 564, DateTimeKind.Local).AddTicks(8497), "DBInit" });

            migrationBuilder.InsertData(
                table: "ShoppingItem",
                columns: new[] { "ShoppingListId", "Id", "Amount", "AmountUnit", "IsCollected", "Name", "Price" },
                values: new object[] { 1, 2, 5.0, "kpl", false, "Banaani", 0.0 });

            migrationBuilder.InsertData(
                table: "ShoppingItem",
                columns: new[] { "ShoppingListId", "Id", "Amount", "AmountUnit", "IsCollected", "Name", "Price" },
                values: new object[] { 1, 3, 1.0, "kpl", false, "Rahka", 0.0 });

            migrationBuilder.InsertData(
                table: "ShoppingItem",
                columns: new[] { "ShoppingListId", "Id", "Amount", "AmountUnit", "IsCollected", "Name", "Price" },
                values: new object[] { 1, 4, 700.0, "g", false, "Jauheliha", 0.0 });

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingItem_ShoppingList_ShoppingListId",
                table: "ShoppingItem",
                column: "ShoppingListId",
                principalTable: "ShoppingList",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingItem_ShoppingList_ShoppingListId",
                table: "ShoppingItem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ShoppingItem",
                table: "ShoppingItem");

            migrationBuilder.DeleteData(
                table: "ShoppingItem",
                keyColumns: new[] { "ShoppingListId", "Id" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "ShoppingItem",
                keyColumns: new[] { "ShoppingListId", "Id" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "ShoppingItem",
                keyColumns: new[] { "ShoppingListId", "Id" },
                keyValues: new object[] { 1, 4 });

            migrationBuilder.DeleteData(
                table: "ShoppingList",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.AlterColumn<int>(
                name: "ShoppingListId",
                table: "ShoppingItem",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddPrimaryKey(
                name: "PK_ShoppingItem",
                table: "ShoppingItem",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingItem_ShoppingListId",
                table: "ShoppingItem",
                column: "ShoppingListId");

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingItem_ShoppingList_ShoppingListId",
                table: "ShoppingItem",
                column: "ShoppingListId",
                principalTable: "ShoppingList",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
