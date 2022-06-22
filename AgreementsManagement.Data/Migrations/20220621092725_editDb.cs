using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AgreementsManagement.Data.Migrations
{
    public partial class editDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "EffectiveDate",
                table: "Agreements",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 21, 16, 27, 25, 676, DateTimeKind.Local).AddTicks(1329),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 20, 17, 55, 55, 354, DateTimeKind.Local).AddTicks(4404));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Agreements",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 21, 16, 27, 25, 676, DateTimeKind.Local).AddTicks(1601),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 20, 17, 55, 55, 354, DateTimeKind.Local).AddTicks(4700));

            migrationBuilder.CreateTable(
                name: "Account",
                columns: table => new
                {
                    userName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fullName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Account", x => x.userName);
                });

            migrationBuilder.InsertData(
                table: "Account",
                columns: new[] { "userName", "email", "fullName", "password" },
                values: new object[] { "Admin", "abc@gmail.com", "Nguyen Minh Trung", "123" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Account");

            migrationBuilder.AlterColumn<DateTime>(
                name: "EffectiveDate",
                table: "Agreements",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 20, 17, 55, 55, 354, DateTimeKind.Local).AddTicks(4404),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 21, 16, 27, 25, 676, DateTimeKind.Local).AddTicks(1329));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Agreements",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 20, 17, 55, 55, 354, DateTimeKind.Local).AddTicks(4700),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 21, 16, 27, 25, 676, DateTimeKind.Local).AddTicks(1601));
        }
    }
}
