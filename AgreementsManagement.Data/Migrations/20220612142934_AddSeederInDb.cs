using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AgreementsManagement.Data.Migrations
{
    public partial class AddSeederInDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "EffectiveDate",
                table: "Agreements",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 12, 21, 29, 34, 546, DateTimeKind.Local).AddTicks(70),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 12, 21, 28, 0, 409, DateTimeKind.Local).AddTicks(6741));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Agreements",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 12, 21, 29, 34, 546, DateTimeKind.Local).AddTicks(231),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 12, 21, 28, 0, 409, DateTimeKind.Local).AddTicks(6939));

            migrationBuilder.InsertData(
                table: "Agreements",
                columns: new[] { "Id", "AgreementName", "AgreementType", "CreatedDate", "DaysUntilExpiration", "DistributorName", "EffectiveDate", "ExpirationDate", "QuoteNumber" },
                values: new object[] { 1, "HP PACK AIR INC", "SPA", new DateTime(2022, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 331, "Werner", new DateTime(2022, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "02776A3" });

            migrationBuilder.InsertData(
                table: "Agreements",
                columns: new[] { "Id", "AgreementName", "AgreementType", "CreatedDate", "DaysUntilExpiration", "DistributorName", "EffectiveDate", "ExpirationDate", "QuoteNumber", "Status" },
                values: new object[,]
                {
                    { 2, "DEMO NESTLE MRO NATSU", "SPA", new DateTime(2022, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), -186, "Werner", new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "00029CONM", 1 },
                    { 3, "HP PACK AIR INC 21", "SPA", new DateTime(2022, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 311, "Werner", new DateTime(2022, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "0277CSL26", 2 }
                });

            migrationBuilder.InsertData(
                table: "Agreements",
                columns: new[] { "Id", "AgreementName", "AgreementType", "CreatedDate", "DaysUntilExpiration", "DistributorName", "EffectiveDate", "ExpirationDate", "QuoteNumber" },
                values: new object[,]
                {
                    { 4, "HP PACK AIR INC 67", "SPA", new DateTime(2020, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 323, "Werner", new DateTime(2019, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "02776A7" },
                    { 5, "DEMO NESTLE MRO NAT09", "SPA", new DateTime(2021, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 86, "Werner", new DateTime(2020, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "00029CON8" }
                });

            migrationBuilder.InsertData(
                table: "Agreements",
                columns: new[] { "Id", "AgreementName", "AgreementType", "CreatedDate", "DaysUntilExpiration", "DistributorName", "EffectiveDate", "ExpirationDate", "QuoteNumber", "Status" },
                values: new object[,]
                {
                    { 6, "HP PACK AIR INC 78", "SPA", new DateTime(2022, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 42, "Werner", new DateTime(2021, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "0277CS246", 1 },
                    { 7, "HP NESTLE MRO NAT23", "SPA", new DateTime(2022, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 57, "Werner", new DateTime(2022, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "0277CSL26", 2 },
                    { 8, "HP PACK AIR INC 99", "SPA", new DateTime(2022, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 39, "Werner", new DateTime(2018, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "0277CSL26", 2 },
                    { 9, "HP NESTLE MRO NAT33", "SPA", new DateTime(2021, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 231, "Werner", new DateTime(2022, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0277CSL26", 2 },
                    { 10, "HP PACK AIR INC 86", "SPA", new DateTime(2021, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 55, "Werner", new DateTime(2021, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "0277CS422", 1 }
                });

            migrationBuilder.InsertData(
                table: "Agreements",
                columns: new[] { "Id", "AgreementName", "AgreementType", "CreatedDate", "DaysUntilExpiration", "DistributorName", "EffectiveDate", "ExpirationDate", "QuoteNumber" },
                values: new object[] { 11, "HP PACK AIR INC", "SPA", new DateTime(2022, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 331, "Werner", new DateTime(2022, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "02776A3" });

            migrationBuilder.InsertData(
                table: "Agreements",
                columns: new[] { "Id", "AgreementName", "AgreementType", "CreatedDate", "DaysUntilExpiration", "DistributorName", "EffectiveDate", "ExpirationDate", "QuoteNumber", "Status" },
                values: new object[,]
                {
                    { 12, "DEMO NESTLE MRO NATSU", "SPA", new DateTime(2022, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), -186, "Werner", new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "00029CONM", 1 },
                    { 13, "HP PACK AIR INC 21", "SPA", new DateTime(2022, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 311, "Werner", new DateTime(2022, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "0277CSL26", 2 }
                });

            migrationBuilder.InsertData(
                table: "Agreements",
                columns: new[] { "Id", "AgreementName", "AgreementType", "CreatedDate", "DaysUntilExpiration", "DistributorName", "EffectiveDate", "ExpirationDate", "QuoteNumber" },
                values: new object[,]
                {
                    { 14, "HP PACK AIR INC 67", "SPA", new DateTime(2020, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 323, "Werner", new DateTime(2019, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "02776A7" },
                    { 15, "DEMO NESTLE MRO NAT09", "SPA", new DateTime(2021, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 86, "Werner", new DateTime(2020, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "00029CON8" }
                });

            migrationBuilder.InsertData(
                table: "Agreements",
                columns: new[] { "Id", "AgreementName", "AgreementType", "CreatedDate", "DaysUntilExpiration", "DistributorName", "EffectiveDate", "ExpirationDate", "QuoteNumber", "Status" },
                values: new object[,]
                {
                    { 16, "HP PACK AIR INC 78", "SPA", new DateTime(2022, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 42, "Werner", new DateTime(2021, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "0277CS246", 1 },
                    { 17, "HP NESTLE MRO NAT23", "SPA", new DateTime(2022, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 57, "Werner", new DateTime(2022, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "0277CSL26", 2 },
                    { 18, "HP PACK AIR INC 99", "SPA", new DateTime(2022, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 39, "Werner", new DateTime(2018, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "0277CSL26", 2 },
                    { 19, "HP NESTLE MRO NAT33", "SPA", new DateTime(2021, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 231, "Werner", new DateTime(2022, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0277CSL26", 2 },
                    { 20, "HP PACK AIR INC 86", "SPA", new DateTime(2021, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 55, "Werner", new DateTime(2021, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "0277CS422", 1 }
                });

            migrationBuilder.InsertData(
                table: "Agreements",
                columns: new[] { "Id", "AgreementName", "AgreementType", "CreatedDate", "DaysUntilExpiration", "DistributorName", "EffectiveDate", "ExpirationDate", "QuoteNumber" },
                values: new object[] { 21, "HP PACK AIR INC", "SPA", new DateTime(2022, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 331, "Werner", new DateTime(2022, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "02776A3" });

            migrationBuilder.InsertData(
                table: "Agreements",
                columns: new[] { "Id", "AgreementName", "AgreementType", "CreatedDate", "DaysUntilExpiration", "DistributorName", "EffectiveDate", "ExpirationDate", "QuoteNumber", "Status" },
                values: new object[,]
                {
                    { 22, "DEMO NESTLE MRO NATSU", "SPA", new DateTime(2022, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), -186, "Werner", new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "00029CONM", 1 },
                    { 23, "HP PACK AIR INC 21", "SPA", new DateTime(2022, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 311, "Werner", new DateTime(2022, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "0277CSL26", 2 }
                });

            migrationBuilder.InsertData(
                table: "Agreements",
                columns: new[] { "Id", "AgreementName", "AgreementType", "CreatedDate", "DaysUntilExpiration", "DistributorName", "EffectiveDate", "ExpirationDate", "QuoteNumber" },
                values: new object[,]
                {
                    { 24, "HP PACK AIR INC 67", "SPA", new DateTime(2020, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 323, "Werner", new DateTime(2019, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "02776A7" },
                    { 25, "DEMO NESTLE MRO NAT09", "SPA", new DateTime(2021, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 86, "Werner", new DateTime(2020, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "00029CON8" }
                });

            migrationBuilder.InsertData(
                table: "Agreements",
                columns: new[] { "Id", "AgreementName", "AgreementType", "CreatedDate", "DaysUntilExpiration", "DistributorName", "EffectiveDate", "ExpirationDate", "QuoteNumber", "Status" },
                values: new object[,]
                {
                    { 26, "HP PACK AIR INC 78", "SPA", new DateTime(2022, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 42, "Werner", new DateTime(2021, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "0277CS246", 1 },
                    { 27, "HP NESTLE MRO NAT23", "SPA", new DateTime(2022, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 57, "Werner", new DateTime(2022, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "0277CSL26", 2 },
                    { 28, "HP PACK AIR INC 99", "SPA", new DateTime(2022, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 39, "Werner", new DateTime(2018, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "0277CSL26", 2 },
                    { 29, "HP NESTLE MRO NAT33", "SPA", new DateTime(2021, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 231, "Werner", new DateTime(2022, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0277CSL26", 2 },
                    { 30, "HP PACK AIR INC 86", "SPA", new DateTime(2021, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 55, "Werner", new DateTime(2021, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "0277CS422", 1 }
                });

            migrationBuilder.InsertData(
                table: "Agreements",
                columns: new[] { "Id", "AgreementName", "AgreementType", "CreatedDate", "DaysUntilExpiration", "DistributorName", "EffectiveDate", "ExpirationDate", "QuoteNumber" },
                values: new object[] { 31, "HP PACK AIR INC", "SPA", new DateTime(2022, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 331, "Werner", new DateTime(2022, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "02776A3" });

            migrationBuilder.InsertData(
                table: "Agreements",
                columns: new[] { "Id", "AgreementName", "AgreementType", "CreatedDate", "DaysUntilExpiration", "DistributorName", "EffectiveDate", "ExpirationDate", "QuoteNumber", "Status" },
                values: new object[,]
                {
                    { 32, "DEMO NESTLE MRO NATSU", "SPA", new DateTime(2022, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), -186, "Werner", new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "00029CONM", 1 },
                    { 33, "HP PACK AIR INC 21", "SPA", new DateTime(2022, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 311, "Werner", new DateTime(2022, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "0277CSL26", 2 }
                });

            migrationBuilder.InsertData(
                table: "Agreements",
                columns: new[] { "Id", "AgreementName", "AgreementType", "CreatedDate", "DaysUntilExpiration", "DistributorName", "EffectiveDate", "ExpirationDate", "QuoteNumber" },
                values: new object[] { 34, "HP PACK AIR INC 67", "SPA", new DateTime(2020, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 323, "Werner", new DateTime(2019, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "02776A7" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.AlterColumn<DateTime>(
                name: "EffectiveDate",
                table: "Agreements",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 12, 21, 28, 0, 409, DateTimeKind.Local).AddTicks(6741),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 12, 21, 29, 34, 546, DateTimeKind.Local).AddTicks(70));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Agreements",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 12, 21, 28, 0, 409, DateTimeKind.Local).AddTicks(6939),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 12, 21, 29, 34, 546, DateTimeKind.Local).AddTicks(231));
        }
    }
}
