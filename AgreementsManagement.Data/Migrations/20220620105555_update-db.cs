using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AgreementsManagement.Data.Migrations
{
    public partial class updatedb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "EffectiveDate",
                table: "Agreements",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 20, 17, 55, 55, 354, DateTimeKind.Local).AddTicks(4404),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 17, 9, 47, 28, 876, DateTimeKind.Local).AddTicks(510));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Agreements",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 20, 17, 55, 55, 354, DateTimeKind.Local).AddTicks(4700),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 17, 9, 47, 28, 876, DateTimeKind.Local).AddTicks(768));

            migrationBuilder.InsertData(
                table: "Agreements",
                columns: new[] { "Id", "AgreementName", "AgreementType", "CreatedDate", "DistributorName", "EffectiveDate", "ExpirationDate", "QuoteNumber", "Status" },
                values: new object[,]
                {
                    { 35, "DEMO NESTLE MRO NAT09", "SPA", new DateTime(2021, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Werner", new DateTime(2020, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "00029CON8", "Published" },
                    { 36, "HP PACK AIR INC 78", "SPA", new DateTime(2022, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Werner", new DateTime(2021, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "0277CS246", "Pending" },
                    { 37, "HP NESTLE MRO NAT23", "SPA", new DateTime(2022, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Werner", new DateTime(2022, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "0277CSL26", "Invalid" },
                    { 38, "HP PACK AIR INC 99", "SPA", new DateTime(2022, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Werner", new DateTime(2018, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "0277CSL26", "Invalid" },
                    { 39, "HP NESTLE MRO NAT33", "SPA", new DateTime(2021, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Werner", new DateTime(2022, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0277CSL26", "Pending" },
                    { 40, "HP PACK AIR INC 86", "SPA", new DateTime(2021, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Werner", new DateTime(2021, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "0277CS422", "Published" },
                    { 41, "HP PACK AIR INC", "SPA", new DateTime(2022, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Werner", new DateTime(2022, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "02776A3", "Peding" },
                    { 42, "DEMO NESTLE MRO NATSU", "SPA", new DateTime(2022, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Werner", new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "00029CONM", "Invalid" },
                    { 43, "HP PACK AIR INC 21", "SPA", new DateTime(2022, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Werner", new DateTime(2022, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "0277CSL26", "Pending" },
                    { 44, "HP PACK AIR INC 67", "SPA", new DateTime(2020, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Werner", new DateTime(2019, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "02776A7", "Published" },
                    { 45, "DEMO NESTLE MRO NAT09", "SPA", new DateTime(2021, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Werner", new DateTime(2020, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "00029CON8", "Published" },
                    { 46, "HP PACK AIR INC 78", "SPA", new DateTime(2022, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Werner", new DateTime(2021, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "0277CS246", "Published" },
                    { 47, "HP NESTLE MRO NAT23", "SPA", new DateTime(2022, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Werner", new DateTime(2022, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "0277CSL26", "Pending" },
                    { 48, "HP PACK AIR INC 99", "SPA", new DateTime(2022, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Werner", new DateTime(2018, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "0277CSL26", "Invalid" },
                    { 49, "HP NESTLE MRO NAT33", "SPA", new DateTime(2021, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Werner", new DateTime(2022, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0277CSL26", "Invalid" },
                    { 50, "HP PACK AIR INC 86", "SPA", new DateTime(2021, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Werner", new DateTime(2021, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "0277CS422", "Invalid" },
                    { 51, "HP PACK AIR INC", "SPA", new DateTime(2022, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Werner", new DateTime(2022, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "02776A3", "Invalid" },
                    { 52, "DEMO NESTLE MRO NATSU", "SPA", new DateTime(2022, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Werner", new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "00029CONM", "Published" },
                    { 53, "HP PACK AIR INC 21", "SPA", new DateTime(2022, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Werner", new DateTime(2022, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "0277CSL26", "Invalid" },
                    { 54, "HP PACK AIR INC 67", "SPA", new DateTime(2020, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Werner", new DateTime(2019, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "02776A7", "Pending" },
                    { 55, "DEMO NESTLE MRO NAT09", "SPA", new DateTime(2021, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Werner", new DateTime(2020, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "00029CON8", "Published" },
                    { 56, "HP PACK AIR INC 78", "SPA", new DateTime(2022, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Werner", new DateTime(2021, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "0277CS246", "Published" },
                    { 57, "HP NESTLE MRO NAT23", "SPA", new DateTime(2022, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Werner", new DateTime(2022, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "0277CSL26", "Pending" },
                    { 58, "HP PACK AIR INC 99", "SPA", new DateTime(2022, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Werner", new DateTime(2018, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "0277CSL26", "Invalid" },
                    { 59, "HP NESTLE MRO NAT33", "SPA", new DateTime(2021, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Werner", new DateTime(2022, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0277CSL26", "Published" },
                    { 60, "HP PACK AIR INC 86", "SPA", new DateTime(2021, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Werner", new DateTime(2021, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "0277CS422", "Published" },
                    { 61, "HP PACK AIR INC", "SPA", new DateTime(2022, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Werner", new DateTime(2022, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "02776A3", "Peding" },
                    { 62, "DEMO NESTLE MRO NATSU", "SPA", new DateTime(2022, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Werner", new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "00029CONM", "Invalid" },
                    { 63, "HP PACK AIR INC 21", "SPA", new DateTime(2022, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Werner", new DateTime(2022, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "0277CSL26", "Pending" },
                    { 64, "HP PACK AIR INC 67", "SPA", new DateTime(2020, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Werner", new DateTime(2019, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "02776A7", "Published" },
                    { 65, "DEMO NESTLE MRO NAT09", "SPA", new DateTime(2021, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Werner", new DateTime(2020, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "00029CON8", "Published" },
                    { 66, "HP PACK AIR INC 78", "SPA", new DateTime(2022, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Werner", new DateTime(2021, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "0277CS246", "Published" },
                    { 67, "HP NESTLE MRO NAT23", "SPA", new DateTime(2022, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Werner", new DateTime(2022, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "0277CSL26", "Pending" },
                    { 68, "HP PACK AIR INC 99", "SPA", new DateTime(2022, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Werner", new DateTime(2018, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "0277CSL26", "Invalid" },
                    { 69, "HP NESTLE MRO NAT33", "SPA", new DateTime(2021, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Werner", new DateTime(2022, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0277CSL26", "Invalid" },
                    { 70, "HP PACK AIR INC 86", "SPA", new DateTime(2021, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Werner", new DateTime(2021, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "0277CS422", "Invalid" },
                    { 71, "HP PACK AIR INC", "SPA", new DateTime(2022, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Werner", new DateTime(2022, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "02776A3", "Invalid" },
                    { 72, "DEMO NESTLE MRO NATSU", "SPA", new DateTime(2022, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Werner", new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "00029CONM", "Published" },
                    { 73, "HP PACK AIR INC 21", "SPA", new DateTime(2022, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Werner", new DateTime(2022, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "0277CSL26", "Invalid" },
                    { 74, "HP PACK AIR INC 67", "SPA", new DateTime(2020, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Werner", new DateTime(2019, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "02776A7", "Pending" },
                    { 75, "DEMO NESTLE MRO NAT09", "SPA", new DateTime(2021, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Werner", new DateTime(2020, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "00029CON8", "Published" },
                    { 76, "HP PACK AIR INC 78", "SPA", new DateTime(2022, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Werner", new DateTime(2021, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "0277CS246", "Published" }
                });

            migrationBuilder.InsertData(
                table: "Agreements",
                columns: new[] { "Id", "AgreementName", "AgreementType", "CreatedDate", "DistributorName", "EffectiveDate", "ExpirationDate", "QuoteNumber", "Status" },
                values: new object[,]
                {
                    { 77, "HP NESTLE MRO NAT23", "SPA", new DateTime(2022, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Werner", new DateTime(2022, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "0277CSL26", "Pending" },
                    { 78, "HP PACK AIR INC 99", "SPA", new DateTime(2022, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Werner", new DateTime(2018, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "0277CSL26", "Invalid" },
                    { 79, "HP NESTLE MRO NAT33", "SPA", new DateTime(2021, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Werner", new DateTime(2022, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0277CSL26", "Published" },
                    { 80, "HP PACK AIR INC 86", "SPA", new DateTime(2021, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Werner", new DateTime(2021, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "0277CS422", "Published" },
                    { 81, "HP PACK AIR INC", "SPA", new DateTime(2022, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Werner", new DateTime(2022, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "02776A3", "Peding" },
                    { 82, "DEMO NESTLE MRO NATSU", "SPA", new DateTime(2022, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Werner", new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "00029CONM", "Invalid" },
                    { 83, "HP PACK AIR INC 21", "SPA", new DateTime(2022, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Werner", new DateTime(2022, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "0277CSL26", "Pending" },
                    { 84, "HP PACK AIR INC 67", "SPA", new DateTime(2020, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Werner", new DateTime(2019, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "02776A7", "Published" },
                    { 85, "DEMO NESTLE MRO NAT09", "SPA", new DateTime(2021, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Werner", new DateTime(2020, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "00029CON8", "Published" },
                    { 86, "HP PACK AIR INC 78", "SPA", new DateTime(2022, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Werner", new DateTime(2021, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "0277CS246", "Published" },
                    { 87, "HP NESTLE MRO NAT23", "SPA", new DateTime(2022, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Werner", new DateTime(2022, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "0277CSL26", "Pending" },
                    { 88, "HP PACK AIR INC 99", "SPA", new DateTime(2022, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Werner", new DateTime(2018, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "0277CSL26", "Invalid" },
                    { 89, "HP NESTLE MRO NAT33", "SPA", new DateTime(2021, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Werner", new DateTime(2022, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0277CSL26", "Invalid" },
                    { 90, "HP PACK AIR INC 86", "SPA", new DateTime(2021, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Werner", new DateTime(2021, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "0277CS422", "Invalid" },
                    { 91, "HP PACK AIR INC", "SPA", new DateTime(2022, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Werner", new DateTime(2022, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "02776A3", "Invalid" },
                    { 92, "DEMO NESTLE MRO NATSU", "SPA", new DateTime(2022, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Werner", new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "00029CONM", "Published" },
                    { 93, "HP PACK AIR INC 21", "SPA", new DateTime(2022, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Werner", new DateTime(2022, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "0277CSL26", "Invalid" },
                    { 94, "HP PACK AIR INC 67", "SPA", new DateTime(2020, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Werner", new DateTime(2019, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "02776A7", "Pending" },
                    { 95, "DEMO NESTLE MRO NAT09", "SPA", new DateTime(2021, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Werner", new DateTime(2020, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "00029CON8", "Published" },
                    { 96, "HP PACK AIR INC 78", "SPA", new DateTime(2022, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Werner", new DateTime(2021, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "0277CS246", "Published" },
                    { 97, "HP NESTLE MRO NAT23", "SPA", new DateTime(2022, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Werner", new DateTime(2022, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "0277CSL26", "Pending" },
                    { 98, "HP PACK AIR INC 99", "SPA", new DateTime(2022, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Werner", new DateTime(2018, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "0277CSL26", "Invalid" },
                    { 99, "HP NESTLE MRO NAT33", "SPA", new DateTime(2021, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Werner", new DateTime(2022, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0277CSL26", "Published" },
                    { 100, "HP PACK AIR INC", "SPA", new DateTime(2022, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Werner", new DateTime(2022, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "02776A3", "Invalid" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.AlterColumn<DateTime>(
                name: "EffectiveDate",
                table: "Agreements",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 17, 9, 47, 28, 876, DateTimeKind.Local).AddTicks(510),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 20, 17, 55, 55, 354, DateTimeKind.Local).AddTicks(4404));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Agreements",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 17, 9, 47, 28, 876, DateTimeKind.Local).AddTicks(768),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 20, 17, 55, 55, 354, DateTimeKind.Local).AddTicks(4700));
        }
    }
}
