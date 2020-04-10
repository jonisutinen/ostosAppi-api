using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ostosAppi_api.Migrations
{
    public partial class SeedDB2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ShoppingList",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 4, 10, 21, 16, 16, 271, DateTimeKind.Local).AddTicks(9000), new DateTime(2020, 4, 10, 21, 16, 16, 273, DateTimeKind.Local).AddTicks(9340) });

            migrationBuilder.InsertData(
                table: "ShoppingList",
                columns: new[] { "Id", "Created", "CreatedBy", "IsDone", "Name", "Store", "Updated", "UpdatedBy" },
                values: new object[] { 2, new DateTime(2020, 4, 10, 21, 16, 16, 274, DateTimeKind.Local).AddTicks(189), "DBInit", false, "Ostokset2", "City-market", new DateTime(2020, 4, 10, 21, 16, 16, 274, DateTimeKind.Local).AddTicks(210), "DBInit" });

            migrationBuilder.InsertData(
                table: "ShoppingItem",
                columns: new[] { "ShoppingListId", "Id", "Amount", "AmountUnit", "IsCollected", "Name", "Price" },
                values: new object[] { 2, 5, 1.5, "kg", false, "Naudan sisäpaisti", 0.0 });

            migrationBuilder.InsertData(
                table: "ShoppingItem",
                columns: new[] { "ShoppingListId", "Id", "Amount", "AmountUnit", "IsCollected", "Name", "Price" },
                values: new object[] { 2, 6, 1.0, "kpl", false, "Timjami", 0.0 });

            migrationBuilder.InsertData(
                table: "ShoppingItem",
                columns: new[] { "ShoppingListId", "Id", "Amount", "AmountUnit", "IsCollected", "Name", "Price" },
                values: new object[] { 2, 7, 2.0, "kpl", false, "Sitruuna", 0.0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ShoppingItem",
                keyColumns: new[] { "ShoppingListId", "Id" },
                keyValues: new object[] { 2, 5 });

            migrationBuilder.DeleteData(
                table: "ShoppingItem",
                keyColumns: new[] { "ShoppingListId", "Id" },
                keyValues: new object[] { 2, 6 });

            migrationBuilder.DeleteData(
                table: "ShoppingItem",
                keyColumns: new[] { "ShoppingListId", "Id" },
                keyValues: new object[] { 2, 7 });

            migrationBuilder.DeleteData(
                table: "ShoppingList",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "ShoppingList",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 4, 10, 20, 51, 28, 562, DateTimeKind.Local).AddTicks(7475), new DateTime(2020, 4, 10, 20, 51, 28, 564, DateTimeKind.Local).AddTicks(8497) });
        }
    }
}
