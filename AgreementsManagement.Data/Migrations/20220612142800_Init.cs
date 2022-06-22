using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AgreementsManagement.Data.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Agreements",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    QuoteNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AgreementName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AgreementType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DistributorName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EffectiveDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2022, 6, 12, 21, 28, 0, 409, DateTimeKind.Local).AddTicks(6741)),
                    ExpirationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2022, 6, 12, 21, 28, 0, 409, DateTimeKind.Local).AddTicks(6939)),
                    DaysUntilExpiration = table.Column<int>(type: "int", nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agreements", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Agreements");
        }
    }
}
