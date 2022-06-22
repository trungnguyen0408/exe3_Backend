using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AgreementsManagement.Data.Migrations
{
    public partial class updateDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DaysUntilExpiration",
                table: "Agreements");

            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "Agreements",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "EffectiveDate",
                table: "Agreements",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 17, 9, 47, 28, 876, DateTimeKind.Local).AddTicks(510),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 12, 21, 29, 34, 546, DateTimeKind.Local).AddTicks(70));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Agreements",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 17, 9, 47, 28, 876, DateTimeKind.Local).AddTicks(768),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 12, 21, 29, 34, 546, DateTimeKind.Local).AddTicks(231));

            migrationBuilder.UpdateData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 1,
                column: "Status",
                value: "Pending");

            migrationBuilder.UpdateData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 2,
                column: "Status",
                value: "Pending");

            migrationBuilder.UpdateData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 3,
                column: "Status",
                value: "Invalid");

            migrationBuilder.UpdateData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 4,
                column: "Status",
                value: "Published");

            migrationBuilder.UpdateData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 5,
                column: "Status",
                value: "Published");

            migrationBuilder.UpdateData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 6,
                column: "Status",
                value: "Pending");

            migrationBuilder.UpdateData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 7,
                column: "Status",
                value: "Invalid");

            migrationBuilder.UpdateData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 8,
                column: "Status",
                value: "Invalid");

            migrationBuilder.UpdateData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 9,
                column: "Status",
                value: "Pending");

            migrationBuilder.UpdateData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 10,
                column: "Status",
                value: "Published");

            migrationBuilder.UpdateData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 11,
                column: "Status",
                value: "Peding");

            migrationBuilder.UpdateData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 12,
                column: "Status",
                value: "Invalid");

            migrationBuilder.UpdateData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 13,
                column: "Status",
                value: "Pending");

            migrationBuilder.UpdateData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 14,
                column: "Status",
                value: "Published");

            migrationBuilder.UpdateData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 15,
                column: "Status",
                value: "Published");

            migrationBuilder.UpdateData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 16,
                column: "Status",
                value: "Published");

            migrationBuilder.UpdateData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 17,
                column: "Status",
                value: "Pending");

            migrationBuilder.UpdateData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 18,
                column: "Status",
                value: "Invalid");

            migrationBuilder.UpdateData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 19,
                column: "Status",
                value: "Invalid");

            migrationBuilder.UpdateData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 20,
                column: "Status",
                value: "Invalid");

            migrationBuilder.UpdateData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 21,
                column: "Status",
                value: "Invalid");

            migrationBuilder.UpdateData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 22,
                column: "Status",
                value: "Published");

            migrationBuilder.UpdateData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 23,
                column: "Status",
                value: "Invalid");

            migrationBuilder.UpdateData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 24,
                column: "Status",
                value: "Pending");

            migrationBuilder.UpdateData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 25,
                column: "Status",
                value: "Published");

            migrationBuilder.UpdateData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 26,
                column: "Status",
                value: "Published");

            migrationBuilder.UpdateData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 27,
                column: "Status",
                value: "Pending");

            migrationBuilder.UpdateData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 28,
                column: "Status",
                value: "Invalid");

            migrationBuilder.UpdateData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 29,
                column: "Status",
                value: "Published");

            migrationBuilder.UpdateData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 30,
                column: "Status",
                value: "Pending");

            migrationBuilder.UpdateData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 31,
                column: "Status",
                value: "Pending");

            migrationBuilder.UpdateData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 32,
                column: "Status",
                value: "Invalid");

            migrationBuilder.UpdateData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 33,
                column: "Status",
                value: "Published");

            migrationBuilder.UpdateData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 34,
                column: "Status",
                value: "Published");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Status",
                table: "Agreements",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "EffectiveDate",
                table: "Agreements",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 12, 21, 29, 34, 546, DateTimeKind.Local).AddTicks(70),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 17, 9, 47, 28, 876, DateTimeKind.Local).AddTicks(510));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Agreements",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 12, 21, 29, 34, 546, DateTimeKind.Local).AddTicks(231),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 17, 9, 47, 28, 876, DateTimeKind.Local).AddTicks(768));

            migrationBuilder.AddColumn<int>(
                name: "DaysUntilExpiration",
                table: "Agreements",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DaysUntilExpiration", "Status" },
                values: new object[] { 331, 0 });

            migrationBuilder.UpdateData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DaysUntilExpiration", "Status" },
                values: new object[] { -186, 1 });

            migrationBuilder.UpdateData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DaysUntilExpiration", "Status" },
                values: new object[] { 311, 2 });

            migrationBuilder.UpdateData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DaysUntilExpiration", "Status" },
                values: new object[] { 323, 0 });

            migrationBuilder.UpdateData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DaysUntilExpiration", "Status" },
                values: new object[] { 86, 0 });

            migrationBuilder.UpdateData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DaysUntilExpiration", "Status" },
                values: new object[] { 42, 1 });

            migrationBuilder.UpdateData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DaysUntilExpiration", "Status" },
                values: new object[] { 57, 2 });

            migrationBuilder.UpdateData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DaysUntilExpiration", "Status" },
                values: new object[] { 39, 2 });

            migrationBuilder.UpdateData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DaysUntilExpiration", "Status" },
                values: new object[] { 231, 2 });

            migrationBuilder.UpdateData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DaysUntilExpiration", "Status" },
                values: new object[] { 55, 1 });

            migrationBuilder.UpdateData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DaysUntilExpiration", "Status" },
                values: new object[] { 331, 0 });

            migrationBuilder.UpdateData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DaysUntilExpiration", "Status" },
                values: new object[] { -186, 1 });

            migrationBuilder.UpdateData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DaysUntilExpiration", "Status" },
                values: new object[] { 311, 2 });

            migrationBuilder.UpdateData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DaysUntilExpiration", "Status" },
                values: new object[] { 323, 0 });

            migrationBuilder.UpdateData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DaysUntilExpiration", "Status" },
                values: new object[] { 86, 0 });

            migrationBuilder.UpdateData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DaysUntilExpiration", "Status" },
                values: new object[] { 42, 1 });

            migrationBuilder.UpdateData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DaysUntilExpiration", "Status" },
                values: new object[] { 57, 2 });

            migrationBuilder.UpdateData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DaysUntilExpiration", "Status" },
                values: new object[] { 39, 2 });

            migrationBuilder.UpdateData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DaysUntilExpiration", "Status" },
                values: new object[] { 231, 2 });

            migrationBuilder.UpdateData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DaysUntilExpiration", "Status" },
                values: new object[] { 55, 1 });

            migrationBuilder.UpdateData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DaysUntilExpiration", "Status" },
                values: new object[] { 331, 0 });

            migrationBuilder.UpdateData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DaysUntilExpiration", "Status" },
                values: new object[] { -186, 1 });

            migrationBuilder.UpdateData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DaysUntilExpiration", "Status" },
                values: new object[] { 311, 2 });

            migrationBuilder.UpdateData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DaysUntilExpiration", "Status" },
                values: new object[] { 323, 0 });

            migrationBuilder.UpdateData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DaysUntilExpiration", "Status" },
                values: new object[] { 86, 0 });

            migrationBuilder.UpdateData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DaysUntilExpiration", "Status" },
                values: new object[] { 42, 1 });

            migrationBuilder.UpdateData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DaysUntilExpiration", "Status" },
                values: new object[] { 57, 2 });

            migrationBuilder.UpdateData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DaysUntilExpiration", "Status" },
                values: new object[] { 39, 2 });

            migrationBuilder.UpdateData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DaysUntilExpiration", "Status" },
                values: new object[] { 231, 2 });

            migrationBuilder.UpdateData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DaysUntilExpiration", "Status" },
                values: new object[] { 55, 1 });

            migrationBuilder.UpdateData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DaysUntilExpiration", "Status" },
                values: new object[] { 331, 0 });

            migrationBuilder.UpdateData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DaysUntilExpiration", "Status" },
                values: new object[] { -186, 1 });

            migrationBuilder.UpdateData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DaysUntilExpiration", "Status" },
                values: new object[] { 311, 2 });

            migrationBuilder.UpdateData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DaysUntilExpiration", "Status" },
                values: new object[] { 323, 0 });
        }
    }
}
